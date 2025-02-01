// written by Grace Ofure
//1/30/2025

namespace FourSister
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Ask user for total egg count
            Console.Write("Enter total number of eggs collected today:");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int totalEggs))
            {
                int eggsPerSister = totalEggs / 4;
                int eggsForDuckbear = totalEggs % 4;


                Console.WriteLine("Each sister gets: " + eggsPerSister);
                Console.WriteLine("The duckbear gets: " + eggsForDuckbear);



            }
            else
            {
                Console.WriteLine("Not a valid number. Try again");
            }


        }
    }

}