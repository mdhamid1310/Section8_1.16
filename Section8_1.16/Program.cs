using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section8_1._16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            runApp();
            Console.ReadLine();
        }
        public static void runApp()
        {
            int[] array = { 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 };
            int target = 45;

            int index = BinarySearch(array, target);

            if (index != -1)
            {
                Console.WriteLine("Element " + target + " found at index " + index);
            }
            else
            {
                Console.WriteLine("Element " + target + " not found in the array");
            }
        }

        public static int BinarySearch(int[] array, int target)
        {
            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (array[mid] == target)
                {
                    return mid; // Element found, return its index
                }

                if (array[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return -1; // Element not found
        }
    }
}
