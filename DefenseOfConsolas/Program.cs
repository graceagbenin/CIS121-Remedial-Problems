// Written by Grace Ofure Agbenin
// 1/31/2025

namespace DefenseOfConsolas
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //modify console window title
            Console.Title = "Defense of Consolas";

            // input target row and column
            Console.WriteLine("Enter Target Row:");
            int targetRow = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Target Column:");
            int targetColumn = int.Parse(Console.ReadLine());

            // calculate deployment locations
            int left = targetColumn - 1;
            int right = targetColumn + 1;
            int up = targetRow - 1;
            int down = targetColumn - 1;

            // Display deployment instructions 
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Deploy to:");
            Console.WriteLine($"({targetRow}, {left})");    
            Console.WriteLine($"({up}, {targetColumn})");   
            Console.WriteLine($"({targetRow}, {right})");   
            Console.WriteLine($"({down}, {targetColumn})");
            Console.ResetColor();

            //play Beep sound
            Console.Beep(440, 1000);
         
        }
    }
}
