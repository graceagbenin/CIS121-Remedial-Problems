// Grace Ofure Agbenin
// 02/04/2025

using System.Diagnostics;

namespace DiscountedInventory
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Title = "Inventory";


            //Ask user for name 
            Console.Write("What is your name? ");
            string aName = Console.ReadLine();

            //set name
            string myName = "Ofure";

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

            // Define price 
            double price = 0;

            switch (number)
            {
                case 1:
                    price = 10;
                    break;
                case 2:
                    price = 15;
                    break;
                case 3:
                    price = 25;
                    break;
                case 4:
                    price = 1;
                    break;
                case 5:
                    price = 20;
                    break;
                case 6:
                    price = 200;
                    break;
                case 7:
                    price = 1;
                    break;
                default:
                    Console.WriteLine("Apologies. there is no more inventory ");
                    break;
            }
            if (aName == myName)
            {
                price /= 2;
            }
            Console.WriteLine($"The price is {price} Gold. ");

        }
    }
}
