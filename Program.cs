using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Program.cs
/// June 18, 2021
/// Written by Taylor Dauphinee
/// A program that determines if an input number is a prime number or a composite number
/// </summary>

namespace PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            // ask for input
            bool isInt;
            int number;
            do
            {
                Console.WriteLine("Input an integer: ");
                string inputNum = Console.ReadLine();

                isInt = Int32.TryParse(inputNum, out number);

                if (!isInt)
                {
                    Console.WriteLine(inputNum + " is not an integer.");
                }
            }
            while (!isInt);

            // check the divisible numbers
            int numFactors = 0;

            for (int i = 1; i <= Math.Ceiling((double)number / 2); i++)
            {
                if (number % i == 0)
                {
                    numFactors += 2;
                    if (numFactors > 2)
                    {
                        Console.WriteLine(number + " is a composite number.");
                        Console.WriteLine("Press any key to exit.");
                        Console.ReadKey(true);
                        return;
                    }
                }
            }
            Console.WriteLine(number + " is a prime number.");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey(true);
        }
    }
}
