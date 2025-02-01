// Written by Grace Ofure Agbenin
// 1/25/2025

using System.ComponentModel.Design;

namespace clockTower
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // input number
            Console.Write("Input a number:");
            int number = int.Parse(Console.ReadLine());

            // Determine if number is even or odd

            if (number % 2 == 0)
            {
                Console.WriteLine("Tick");
            }
            else
            {
                Console.WriteLine("Tock");
            }

          
        }
    }
}
