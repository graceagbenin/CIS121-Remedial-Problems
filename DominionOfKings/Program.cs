// Written by Grace Ofure Agbenin
// 1/31/2025

namespace DominionOfKings
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Ask users to input current holdings
            Console.WriteLine("Enter the number of Provinces:");
            int provinces = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the number of Duchies:");
            int duchies = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the number of Estates:");
            int estates = int.Parse(Console.ReadLine());

            //Calculate total holdings
            int totalScore = (provinces * 6) + (duchies * 3) + (estates * 1);

            // print Result
            Console.WriteLine("Total Points is:" + totalScore);

        }
    }
}
