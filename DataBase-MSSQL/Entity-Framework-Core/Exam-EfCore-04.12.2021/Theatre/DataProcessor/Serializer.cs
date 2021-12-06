namespace Theatre.DataProcessor
{
    using Newtonsoft.Json;
    using System;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Xml.Serialization;
    using Theatre.Data;
    using Theatre.DataProcessor.ExportDto;

    public class Serializer
    {
        public static string ExportTheatres(TheatreContext context, int numbersOfHalls)
        {
            var topTheatres = context
                                  .Theatres
                                  .ToArray()
                                  .Where(x => x.NumberOfHalls >= numbersOfHalls && x.Tickets.Count >= 20)
                                  .Select(x => new
                                  {
                                      Name = x.Name,
                                      Halls = x.NumberOfHalls,
                                      TotalIncome = (x.Tickets.Where(y => y.RowNumber >= 1 && y.RowNumber <= 5).Sum(z => z.Price)),
                                      Tickets = x.Tickets.Where(y => y.RowNumber >= 1 && y.RowNumber <= 5).Select(z => new
                                      {
                                          Price = z.Price,
                                          RowNumber = z.RowNumber
                                      }).OrderByDescending(t=> t.Price).ToArray()
                                  })
                                  .OrderByDescending(x=> x.Halls)
                                  .ThenBy(x=> x.Name)
                                  .ToArray();


            string json = JsonConvert.SerializeObject(topTheatres,Formatting.Indented);

            return json;

        }

        public static string ExportPlays(TheatreContext context, double rating)
        {

            StringBuilder builder = new StringBuilder();
            
            var nameSpace = new XmlSerializerNamespaces();
            nameSpace.Add(string.Empty, string.Empty);

            var xmlSerializer = new XmlSerializer(typeof(PlayDto[]), new XmlRootAttribute("Plays"));

            using StringWriter sw = new StringWriter(builder);

            var plays = context.Plays
                            .ToArray()
                            .Where(x => x.Rating <= rating)
                            .Select(x => new PlayDto
                            {
                                Title = x.Title,
                                Duration = x.Duration.ToString("c", CultureInfo.InvariantCulture),
                                Rating = x.Rating == 0 ? "Premier" : x.Rating.ToString(),
                                Genre = x.Genre.ToString(),
                                Actors = x.Casts
                                          .ToArray()
                                          .Where(y => y.IsMainCharacter == true)
                                          .Select(z => new ActorDto
                                          {
                                              FullName = z.FullName,
                                              MainCharacter = $"Plays main character in '{x.Title}'."
                                          })
                                          .OrderByDescending(z => z.FullName)
                                          .ToArray()

                            })
                            .OrderBy(x => x.Title)
                            .ThenByDescending(x => x.Genre)
                            .ToArray();

            xmlSerializer.Serialize(sw, plays, nameSpace);


            return builder.ToString().TrimEnd();
        }
    }
}
