// Written by Grace Ofure Agbenin
// 02/03/2025


namespace ReplicationDto
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //create an array for length 5
            int[] originalArray = new int[5];

            //Ask user for five numbers and insert in array
            Console.WriteLine("Enter 5 numbers for the original array: ");
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Enter number {i + 1}; ");
                originalArray[i] = int.Parse(Console.ReadLine());
            }

            //Create second array of length 5
            int[] replicatedArray = new int[5];

            // use loop to copy values
            for (int i = 0; i < 5; i++)
            {
                replicatedArray[i] = originalArray[i];
            }

            // Display result of both arrays
            Console.WriteLine("\nOriginal Array: ");
            foreach (int i in originalArray)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine("\nCopied Array: ");
            foreach (int i in replicatedArray)
            {
                Console.Write(i + " ");
            }

        }
    }
}

