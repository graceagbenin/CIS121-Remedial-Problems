// written by Grace Ofure Agbenin
// 02/04/2025

using System.ComponentModel.Design;

namespace Watchtower
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Ask user for "x" value
            Console.Write("Enter a value for X: ");
            int x = int.Parse(Console.ReadLine());

            //Ask user for "y" value
            Console.Write("Enter a value for Y: ");
            int y = int.Parse(Console.ReadLine());

            //Determine enemy direction
            DetermineDirection(x, y);

        } 
        public static void DetermineDirection(int x, int y)
        {
            if (x == 0 && y == 0)
            {
                Console.WriteLine("The enemy is Here!!!!!!");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("The enemy is to the northwest ");
            }
            else if(x == 0 && y > 0)
            {
                Console.WriteLine("The enemy is to the north ");
            }
            else if (x >0 && y > 0)
            {
                Console.WriteLine("The enemy is to the northeast ");
            }
            else if (y == 0 && x < 0)
            {
                Console.WriteLine("The enemy is to the west ");
            }
            else if (y < 0 && x < 0)
            {
                Console.WriteLine("The enemy is to the southwest ");
            }
            else if (y < 0 && x == 0)
            {
                Console.WriteLine("The enemy is to the south ");
            }
            else if (y < 0 && x > 0)
            {
                Console.WriteLine("The enemy is to the southeast ");
            }



        }
        
    }   
}
