using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Data_Structures.Algorithms
{
    public static class Algorithms
    {

        public static void LinearSearch(int key)
        {
            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine(LinearSearchAlgorithm(array, key));
        }

        private static bool LinearSearchAlgorithm(int[] array, int key)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == key)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
