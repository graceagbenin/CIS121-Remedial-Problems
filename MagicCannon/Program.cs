// Written by Grace Ofure Agbenin
// 03/02/2025

namespace MagicCannon
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Turn the Crank: ");
            int Crankturns = int.Parse(Console.ReadLine());

            for(int turn = 1; turn <=100;  turn++)
            {
                // determine blast type
                string blastType;
                if(turn % 3 ==  0 && turn % 5 == 0)
                {
                    blastType = "Fire and Electric";
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                else if(turn % 3 == 0)
                {
                    blastType = "Fire";
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else if (turn % 5 == 0)
                {
                    blastType = "Electric";
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                else
                {
                    blastType = "Normal";
                    Console.ResetColor();
                }
                // Output the result
                Console.WriteLine($"Turn {turn}: {blastType}");
            }
            
          // Reset the color
          Console.ResetColor();

        }    
    }
}
