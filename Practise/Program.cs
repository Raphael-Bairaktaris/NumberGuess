using System;
using System.Linq;

namespace Practise
{
    class Practise
    {
        static void Main(string[] args)
        {
            // Ask user to think of a number between 0 and 100
            Console.WriteLine("I want you to think of a number between 0 and 100.");
            Console.ReadLine();

            // Define maximum number the user can guess
            int max = 100;

            // Keep track of the number guesses
            int guesses = 0;

            // The start guess from
            int guessMin = 0;

            // The start guess to (half of the max)
            int guessMax = max / 2;

            // While the guess isn't the same as the known maximum value
            while (guessMin != max)
            {
                // Increase guess amount (by 1)
                guesses++;

                // Ask the user if their number is between the guess range
                Console.WriteLine($"Is your number between {guessMin} and {guessMax}?");
                string response = Console.ReadLine();

                // If the user confirmed their number is within the current range...
                if (response?.ToLower().FirstOrDefault() == 'y' )
                {
                    // We know the number is between guessMin and guessMax
                    // So set the new maximum number
                    max = guessMax;

                    // Change the next guess range to be half of the new maximum range
                    guessMax = guessMax - (guessMax - guessMin) / 2;
                }
                // The number is greater than guessMax and less than or equal to max
                else
                {
                    // The new minimum is one above the old maximum
                    guessMin = guessMax + 1;

                    // Guess the bottom half of the new range
                    int remainingDifference = max - guessMax;

                    // Set the guess max to half way between the guessMin and max
                    // NOTE: Math.Ceiling will round up the remaining difference to 2, if the difference is 3
                    guessMax += (int)Math.Ceiling(remainingDifference / 2f);
                }

                // If we only have 2 numbers left, guess one of them
                if (guessMin + 1 == max)
                {
                    // Increase the guess amount by one
                    guesses++;

                    // Ask the user if their number is the lower number
                    Console.WriteLine($"Is your number {guessMin}?");
                    response = Console.ReadLine();

                    // If the user confirmed that their number is indeed the lower number...
                    if (response?.ToLower().FirstOrDefault() == 'y')
                    {
                        break;
                    }
                    else 
                    {
                        // That means that the number must be the highest of the two
                        guessMin = max;
                    }
                }
            }
            // Tell the user their number
            Console.WriteLine($"** Your number is {guessMin}! **");

            // Let the user know how many guesses it took
            Console.WriteLine($"Guessed in {guesses} guesses");
        }
    }
}
