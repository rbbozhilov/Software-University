using System;

namespace Password_Validator
{
    class Program
    {
        static bool DigitsMore(string text)
        {

            bool result = false;
            int counter = 0;

            for (int i = 0; i < text.Length; i++)
            {

                char currentLeter = text[i];

                if (currentLeter >= 48 && currentLeter <= 57)
                {
                    counter++;
                }
            }

            if (counter >= 2)
            {
                result = true;
            }


            return result;
        }

        static bool PassCharactersValid(string text)
        {

            bool result = false;

            if (text.Length >= 6 && text.Length <= 10)
            {

                result = true;
            }

            else
            {
                result = false;

            }



            return result;

        }


        static bool LetterDigitsValid(string text)
        {

            bool result = false;

            for (int i = 0; i < text.Length; i++)
            {
                char currentLetter = text[i];

                if (currentLetter >= 48 && currentLetter <= 122)
                {
                    result = true;
                }
                else
                {
                    result = false;
                    break;
                }
            }



            return result;
        }




        static void Main(string[] args)
        {

            string password = Console.ReadLine();


            if (DigitsMore(password) && LetterDigitsValid(password) && PassCharactersValid(password))
            {
                Console.WriteLine("Password is valid");
            }
            else
            {

                if (!PassCharactersValid(password))
                {
                    Console.WriteLine("Password must be between 6 and 10 characters ");
                }

                if (!LetterDigitsValid(password))
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                }

                if (!DigitsMore(password))
                {
                    Console.WriteLine("Password must have at least 2 digits");
                }

            }

        }
    }
}
