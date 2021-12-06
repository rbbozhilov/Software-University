namespace Theatre.DataProcessor
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Globalization;
    using System.IO;
    using System.Text;
    using System.Xml.Serialization;
    using Theatre.Data;
    using Theatre.Data.Models;
    using Theatre.Data.Models.Enums;
    using Theatre.DataProcessor.ImportDto;

    public class Deserializer
    {
        private const string ErrorMessage = "Invalid data!";

        private const string SuccessfulImportPlay
            = "Successfully imported {0} with genre {1} and a rating of {2}!";

        private const string SuccessfulImportActor
            = "Successfully imported actor {0} as a {1} character!";

        private const string SuccessfulImportTheatre
            = "Successfully imported theatre {0} with #{1} tickets!";

        public static string ImportPlays(TheatreContext context, string xmlString)
        {
            StringBuilder builder = new StringBuilder();

            var xmlRoot = new XmlRootAttribute("Plays");
            var xmlSerializer = new XmlSerializer(typeof(ImportXmlDto[]), xmlRoot);

            using StringReader sr = new StringReader(xmlString);

            ImportXmlDto[] playsProjectDto = (ImportXmlDto[])xmlSerializer.Deserialize(sr);
            List<Play> validDtos = new List<Play>();

            foreach (var play in playsProjectDto)
            {

                if (!IsValid(play))
                {
                    builder.AppendLine(ErrorMessage);
                    continue;
                }

                bool isTimeSpanValide = TimeSpan.TryParseExact(play.Duration, String.Format("c", CultureInfo.InvariantCulture), CultureInfo.InvariantCulture, TimeSpanStyles.None, out TimeSpan result);

                if (result == null || result.Hours < 1)
                {
                    builder.AppendLine(ErrorMessage);
                    continue;
                }

                string genre = play.Genre;

                if (genre == "Drama" || genre == "Comedy" || genre == "Romance" || genre == "Musical")
                {
                    Enum.TryParse(genre, out Genre currentGenre);

                    Play currentPlay = new Play()
                    {
                        Title = play.Title,
                        Duration = result,
                        Rating = play.Rating,
                        Genre = currentGenre,
                        Description = play.Description,
                        Screenwriter = play.Screenwriter
                    };

                    validDtos.Add(currentPlay);

                    builder.AppendLine(string.Format(SuccessfulImportPlay, play.Title, play.Genre, play.Rating));
                }

                else
                {
                    builder.AppendLine(ErrorMessage);
                    continue;
                }

            }

            context.Plays.AddRange(validDtos);
            context.SaveChanges();

            return builder.ToString().TrimEnd();
        }

        public static string ImportCasts(TheatreContext context, string xmlString)
        {
            StringBuilder builder = new StringBuilder();

            var xmlRoot = new XmlRootAttribute("Casts");
            var xmlSerializer = new XmlSerializer(typeof(ImportCastDto[]), xmlRoot);

            using StringReader sr = new StringReader(xmlString);

            ImportCastDto[] castsProjectDto = (ImportCastDto[])xmlSerializer.Deserialize(sr);
            List<Cast> validDtos = new List<Cast>();

            foreach (var cast in castsProjectDto)
            {

                if (!IsValid(cast))
                {
                    builder.AppendLine(ErrorMessage);
                    continue;
                }




                Cast currentCast = new Cast()
                {
                    FullName = cast.FullName,
                    IsMainCharacter = cast.IsMainCharacter,
                    PhoneNumber = cast.PhoneNumber,
                    PlayId = cast.PlayId
                };

                validDtos.Add(currentCast);

                builder.AppendLine(string.Format(SuccessfulImportActor, cast.FullName, cast.IsMainCharacter ? "main" : "lesser"));

            }

            context.Casts.AddRange(validDtos);
            context.SaveChanges();

            return builder.ToString().TrimEnd();
        }

        public static string ImportTtheatersTickets(TheatreContext context, string jsonString)
        {
            StringBuilder builder = new StringBuilder();

            ImportJsonDto[] jsonFile = JsonConvert.DeserializeObject<ImportJsonDto[]>(jsonString);

            var valideData = new HashSet<Theatre>();


            foreach (var theatre in jsonFile)
            {

                if (!IsValid(theatre))
                {
                    builder.AppendLine(ErrorMessage);
                    continue;
                }

                var currentTheatre = new Theatre() 
                { 
                    Name = theatre.Name,
                    NumberOfHalls = theatre.NumberOfHalls,
                    Director = theatre.Director
                };
              
                
                
                List<Ticket> valideTickets = new List<Ticket>();

                foreach (var ticket in theatre.Tickets)
                {
                    if (!IsValid(ticket))
                    {
                        builder.AppendLine(ErrorMessage);
                        continue;
                    }

                    Ticket valideTicket = new Ticket() 
                    { 

                        Price = ticket.Price,
                        RowNumber = ticket.RowNumber,
                        PlayId = ticket.PlayId

                    };

                    valideTickets.Add(valideTicket);
                   


                }

                currentTheatre.Tickets = valideTickets;

                valideData.Add(currentTheatre);
                builder.AppendLine(string.Format(SuccessfulImportTheatre, currentTheatre.Name, currentTheatre.Tickets.Count));
            }

            context.Theatres.AddRange(valideData);
            context.SaveChanges();
            return builder.ToString().TrimEnd();
        }


        private static bool IsValid(object obj)
        {
            var validator = new ValidationContext(obj);
            var validationRes = new List<ValidationResult>();

            var result = Validator.TryValidateObject(obj, validator, validationRes, true);
            return result;
        }
    }
}
