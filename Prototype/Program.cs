// written by Grace Ofure Agbenin
// 02/03/2025

namespace Prototype
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Ask user for a number

            int targetNumber;
            do
            {
                Console.Write("Hey Captain! Enter a number between 0 and 100: ");
            } while (!int.TryParse(Console.ReadLine(), out targetNumber) || targetNumber < 0 || targetNumber > 100);

            // clear screen
            Console.Clear();

            // Ask hunter to guess the number
            int guess;
            do
            {
                Console.Write("Hey Hunter!, Guess the number ");
                guess = int.Parse(Console.ReadLine());

                if (guess > targetNumber)
                {
                    Console.WriteLine($"{guess} is too high, what is your next guess? ");
                }
                else if (guess < targetNumber)
                {
                    Console.WriteLine($"{guess} is too low, what is your next guess? ");
                }
            } while (guess != targetNumber);
            Console.WriteLine("You guessed the number!!!");




        }
    }
}

