using System;

namespace Operations_Between_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            string operation = Console.ReadLine();
            double result = 0;
            string even;
            switch (operation)
            {

                case "+":
                    {

                        result = number1 + number2;

                        if (result % 2 == 0)
                        {
                            even = "even";
                        }
                        else
                        {
                            even = "odd";
                        }



                        Console.WriteLine("{0} + {1} = {2} - {3}", number1, number2, result, even);

                        break;
                    }
                case "-":
                    {
                        result = number1 - number2;
                        if (result % 2 == 0)
                        {
                            even = "even";
                        }
                        else
                        {
                            even = "odd";
                        }



                        Console.WriteLine("{0} - {1} = {2} - {3}", number1, number2, result, even);
                        break;

                    }

                case "*":
                    {
                        result = number1 * number2;
                        if (result % 2 == 0)
                        {
                            even = "even";
                        }
                        else
                        {
                            even = "odd";
                        }



                        Console.WriteLine("{0} * {1} = {2} - {3}", number1, number2, result, even);

                        break;
                    }

                case "/":
                    {

                        if (number1 == 0 || number2 == 0)
                        {
                            int helper = 0;
                            if (number1 == 0)
                            {
                                helper = number2;
                            }
                            else
                            {
                                helper = number1;
                            }
                            Console.WriteLine("Cannot divide {0} by zero", helper);
                            return;
                        }

                        result = (double)number1 / number2;


                        Console.WriteLine("{0} / {1} = {2:F2}", number1, number2, result);

                        break;
                    }

                case "%":
                    {
                        if (number1 == 0 || number2 == 0)
                        {
                            int helper = 0;
                            if (number1 == 0)
                            {
                                helper = number2;
                            }
                            else
                            {
                                helper = number1;
                            }
                            Console.WriteLine("Cannot divide {0} by zero", helper);
                            return;
                        }

                        result = number1 % number2;

                        Console.WriteLine("{0} % {1} = {2}", number1, number2, result);

                        break;
                    }

            }

        }
    }
}
