// Written by Grace Ofure Agbenin
// 1/30/2025

namespace TriangleFarmer
{
    public class Program
    {
        public static void Main(string[] args)
        // code for area of triangle
        {  // Ask P-Thag for base and height
            Console.Write("Enter Triangle base:");
            double side1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Triangle Height:");
            double height = Convert.ToDouble(Console.ReadLine());

            double areaOfTriangle = (side1 * height) / 2.0;


            Console.WriteLine("Area of Triangle:" + areaOfTriangle);
        }
    }
}
