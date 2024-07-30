﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string appName = "Guess The Number";
            string appVersion = "1.0.0";
            string appAuthor = "Anuththara Perera";

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);
            Console.ResetColor();

            Console.WriteLine("Your Name?");

            string nInput = Console.ReadLine();

            Console.WriteLine("Hello {0}! Hope you are good at guessing!", nInput);

            // The number user has to guess
            int correctNum = 4;

            int guess = 0;

            Console.WriteLine("Guess a number between 1 and 10");

            while (guess != correctNum) {
                string uInput = Console.ReadLine();

                if (!int.TryParse(uInput, out guess)) {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please enter a number!");
                    Console.ResetColor();

                    continue;
                }

                guess = Int32.Parse(uInput);

                if (guess != correctNum) {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Wrong Answer! Try Again");
                    Console.ResetColor();
                }
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Your guess is right! Congratulations!");
            Console.ResetColor();
        }
    }
}
