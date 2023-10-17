using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchAssist
{
    public class Program
    {
        static void Main(string[] args)
        {
            runApp();
        }
        static void runApp()

        {
            

            int[] sortedArray = { 5, 7, 12, 15, 28, 34, 47, 50, 62, 89 };
            Console.WriteLine("Sorted Array values: " + string.Join(", ", sortedArray));

            Console.Write("Enter a value to search for: ");
            int target = int.Parse(Console.ReadLine());

            int index = BinarySearch.BinarySearchValues(sortedArray, target);

            if (index != -1)
            {
                Console.WriteLine($"{target} found at index {index}.");
            }
            else
            {
                Console.WriteLine($"{target} not found in the array.");
            }

            Console.ReadLine();

        }
    }
}
