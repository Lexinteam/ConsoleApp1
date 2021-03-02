using System;
using System.Dynamic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Calc calc1 = new Calc();

            calc1.ShowResult();

            Console.WriteLine("\nIs there anything else I can help you with? Y/N");

            if (Console.ReadKey().Key == ConsoleKey.Y)
            {
                Console.WriteLine("\nSorry, your trial period is over :(");
            }
            else
            {
                Console.WriteLine("\nHave a nice day!");
            }
        }

    }

    class Calc
    {
        public const double pi = 3.14159;
        private double squareLength;
        private double circleRadius;
        private double areaSquare;
        private double areaCircle;

            public Calc()
            {
                Random random = new Random();

                Console.WriteLine("Hello human! Provide me with valid data and I will calculate area for you");

                Console.WriteLine("Enter length of side of your sqare");

                for (int i = 0; i < 3; i++)
                {
                // how to restrict to 2 decimals here?
                    bool result = double.TryParse(Console.ReadLine(), out squareLength);
                    if (result == true)
                        break;
                    else
                    {
                        Console.WriteLine("incorrect length number");
                    // setting random each time. How to set only once?
                        squareLength = random.NextDouble() * (5 - 0.5) + 0.5;
                    }
                
                }

                Console.WriteLine("Enter radius of your circle");

                for (int i = 0; i < 3; i++)
                {

                    bool result = double.TryParse(Console.ReadLine(), out circleRadius);
                    if (result == true)
                        break;
                    else
                    {
                        Console.WriteLine("incorrect radius number");
                        circleRadius = random.NextDouble() * (5 - 0.5) + 0.5;
                    }

                }

            }


        public void ShowResult()
        {
            areaSquare = Math.Round(squareLength * squareLength, 2);
            string squareFitInCircle = squareLength * Math.Sqrt(2) <= 2 * circleRadius ? "can be inscribed in your circle" : "can not be inscribed in your circle";
            Console.WriteLine($"Area of you square is {areaSquare} and {squareFitInCircle}");
            
            areaCircle = Math.Round(pi * circleRadius * circleRadius, 2);
            string circleFitinSquare = 2 * circleRadius <= squareLength? "can be inscribed in your square" : "can not be inscribed in your square";
            Console.WriteLine($"Area of your circle is {areaCircle} and {circleFitinSquare}");

        }

    }
}

