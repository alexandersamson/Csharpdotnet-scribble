using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Alexander Samson";
            string name = "Mijn naam";
            int age = 31;

            //Console color change
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("App: {0}\nVersion: {1}\nAuthor: {2}", appName, appVersion, appAuthor);
            Console.ResetColor();

            Console.WriteLine("What is your name?");

            string nameInput = Console.ReadLine();

            Console.WriteLine("Hi {0}! Let's play a game.", nameInput);

            while (true)
            {
                //Set random number
                Random random = new Random();

                int correctNumber = random.Next(1, 10);

                //Guess var

                int guess = 0;
                Console.WriteLine("Guess the number");

                while (guess != correctNumber)
                {
                    string input = Console.ReadLine();

                    //Validate input
                    if (!int.TryParse(input, out guess))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Not a valid number!");
                        Console.ResetColor();
                        continue;
                    }

                    //Cast to int
                    guess = Int32.Parse(input);

                    if (guess != correctNumber)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Wrong! Try again");
                        Console.ResetColor();
                    }
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Correct! It was {0}!", correctNumber);
                Console.ResetColor();

                Console.WriteLine("Play again? [Y or N]");
                string answer = Console.ReadLine().ToUpper();

                if(answer == "Y")
                {
                    continue;
                } else
                {
                    break;
                }
            }
        }
    }
}
