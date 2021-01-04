using System;

namespace Deliverable2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Guess which will have more: heads or tails? ");

            var headsOrTailsGuess = Console.ReadLine();

            int Heads = 0;
            int Tails = 0;
            int tossResults;
            float correctCount = 0;

            float attempts;
            Random rnd = new Random();
            Console.Write("How many times shall we flip a coin? ");
            float numberOfFlips = float.Parse(Console.ReadLine());
            attempts = 1;
            Console.WriteLine("");

            do
            {
                tossResults = rnd.Next(0, 2);
                if (tossResults == 0)
                {
                    Console.WriteLine("heads");
                    Heads++;

                    if (headsOrTailsGuess == "heads")
                    {
                        correctCount++;
                    }

                }

                else if (tossResults == 1)
                {
                    Console.WriteLine("tails");
                    Tails++;

                    if (headsOrTailsGuess == "tails")
                    {
                        correctCount++;
                    }
                }
                    attempts++;

                } while (attempts <= numberOfFlips) ;
                Console.WriteLine("\nYour guess, {0}, came up {1} time(s).", headsOrTailsGuess, correctCount);

            float correctPercentage;
            correctPercentage = correctCount / numberOfFlips * 100;

                Console.WriteLine("That's {0}%.", correctPercentage);
                Console.ReadKey();
            }
        }
    }
