using System;

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
            int guessFrom = 0;

            // The start guess to (half of the max)
            int guessTo = max / 2;

            // While the guess isn't the same as the known maximum value
            while (guessFrom != max)
            {
                // Increase guess amount (by 1)
                guesses++;

                // Ask the user if their number is between the guess range
                Console.WriteLine($"Is your number between {guessFrom} and {guessTo}");
                string response = Console.ReadLine();

                // If the user confirmed their number is within the current range...
                if (response?.ToLower().FirstOrDefault() == 'y' )
                {
                    // We know the number is between guessFrom and guessTo
                    // So set the new maximum number
                    max = guessFrom;


                }
                else
                {
                    

                }
            }
        }
    }
}
