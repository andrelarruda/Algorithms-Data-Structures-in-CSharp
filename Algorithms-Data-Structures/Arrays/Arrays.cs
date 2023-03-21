using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Data_Structures.Arrays
{
    public static class Arrays
    {
        public static void InsertAtTheEnd()
        {
            // Array Insertions and Deletions
            // Arrays are very inefficient at insertions. Set values is different from insert values.

            int[] intArray = new int[6];
            int length = 0; // Make a variable to keep the length because .Length is based off capacity and does track the actual index

            // This adds data for us
            for (int i = 0; i < 3; i++)
            {
                intArray[length] = i;
                length++;
            }

            intArray[length] = 8;
            length++;

        }

        public static void InsertAtTheStart()
        {
            int[] intArray = new int[8];
            int length = 0;

            // Adding the initial values to the array
            for (int i = 0; i < 7; i++)
            {
                intArray[length] = i + 1;
                length++;
            }

            // Insert an element at the start of an array, is very tough.
            for (int j = 6; j >= 0; j--)
            {
                // Shift each element one position to the right
                intArray[j + 1] = intArray[j];
            }

            intArray[0] = 8;
            var test = intArray[0];

        } 

        public static void InsertAtAnyPosition()
        {
            // TODO: Implement this method.
            int[] intArray = new int[8];
            int length = 0;

            // Adding the initial values to the array
            for (int i = 0; i < 7; i++)
            {
                intArray[length] = i + 1;
                length++;
            }
            intArray.ToList().ForEach(num => Console.Write(num + " "));
            Console.WriteLine();

            int insertPosition = 3;
            int numberToInsert = 9;
            --length;
            for (int j = length; j >= insertPosition; j--)
            {
                intArray[j + 1] = intArray[j];
            }
            intArray[insertPosition] = numberToInsert;
            length++;
            intArray.ToList().ForEach(num => Console.Write(num + " "));
        }

        // The deletion works in the same way. Every time we need to delete some item from the array, we need to shift the rest of the numbers. This is really a harsh task.
    }
}
