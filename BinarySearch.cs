using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchAssist
{
    public class BinarySearch
    {
       

        public static int BinarySearchValues(int[] sortedArray, int target)
        {
            int left = 0;
            int right = sortedArray.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (sortedArray[mid] == target)
                {
                    return mid; // Element found, return the index
                }

                if (sortedArray[mid] < target)
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
