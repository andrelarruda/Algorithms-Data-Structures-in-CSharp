using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Data_Structures.Data_Structures.Queue
{
    public class Queue
    {
        public int MaxSize { get; set; } // Sets the number of elements because this is an array
        public int[] QueueArray { get; set; } // Actual array we will store elements in
        public int Front { get; set; } // Index to keep track of front
        public int Rear { get; set; } // Index to keep track of rear
        public int NItems { get; set; } // This will keep track of length

        public Queue(int size) { 
            MaxSize = size;
            QueueArray = new int[size];
            Front = 0;
            Rear = -1;
            NItems = 0;
        }

        public void Enqueue(int item)
        {
            // Increment our pointer 
            Rear++;
            // Insert into where the rear was incremented
            QueueArray[Rear] = item;
            // Increment
            NItems++;
        }

        public int Dequeue()
        {
            int temp = QueueArray[Front];
            Front++;
            if(Front == MaxSize)
            {
                Front = 0;
            }
            NItems--;
            return temp;
        }

        public int Peek()
        {
            return QueueArray[Front];
        }


    }
}
