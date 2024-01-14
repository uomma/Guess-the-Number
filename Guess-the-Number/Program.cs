using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guess_the_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            bool PlayAgain = true;

            int min = 1;
            int max = 100;
            int guess;
            int number;
            int guesses;
            String response;

            while (PlayAgain)
            {
                guess = 0;
                guesses = 0;
                number = rnd.Next(min, max + 1);
                response = "";

                while (guess != number)
                {
                    Console.WriteLine("Guess a number between " + min + "-" + max);
                    guess = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("guess: " + guess);

                    if (guess > number)
                    {
                        Console.WriteLine(guess + "is to high");
                    }
                    else if (guess < number)
                    {
                        Console.WriteLine(guess + "is to low");
                    }
                    guesses++;
                }
                Console.WriteLine("number: " + number);
                Console.WriteLine("YOU WIN");
                Console.WriteLine("guesses: " + guesses);
                

                Console.WriteLine("vuoi giocare ancora?(Y/N):");
                response = Console.ReadLine();
                response = response.ToUpper();

                if (response == "Y")
                {
                    PlayAgain = true;
                }
                else
                {
                    PlayAgain = false;
                }
            }

            Console.WriteLine("grazie per aver giocato");

            Console.ReadKey();
        }
    }
}
