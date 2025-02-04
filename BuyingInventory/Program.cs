//written by Grace Ofure Agbenin
// 02/04/2025

namespace BuyingInventory
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Title = "Inventory";
            Console.WriteLine("1 - Rope ");
            Console.WriteLine("2 - Torches ");
            Console.WriteLine("3 - Climbing Equipments ");
            Console.WriteLine("4 - Clean Water ");
            Console.WriteLine("5 - Machete ");
            Console.WriteLine("6 - Canoe ");
            Console.WriteLine("7 - Food Supplies ");

            //Ask user for item number
            Console.Write("What number do you want to see the price of? ");
            int number = int.Parse(Console.ReadLine());

            
            switch (number)
            {
                case 1:
                    Console.WriteLine("10 Gold ");
                    break;
                case 2:
                    Console.WriteLine("15 Gold ");
                    break;
                case 3:
                    Console.WriteLine("25 Gold ");
                    break;
                case 4:
                    Console.WriteLine("1 Gold ");
                    break;
                case 5:
                    Console.WriteLine("20 Gold ");
                    break;
                case 6:
                    Console.WriteLine("200 Gold ");
                    break;
                case 7:
                    Console.WriteLine("1 Gold ");
                    break;
                default:
                    Console.WriteLine("Apologies. there is no more inventory ");
                    break;
            }

            
        }
    }
}
