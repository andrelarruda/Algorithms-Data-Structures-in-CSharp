using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Data_Structures.Data_Structures.Stacks
{
    public class Stack
    {
        public int MaxSize { get; set; } // Array stacks you need a maxsize to init array.
        public string[] StackArray { get; set; } // this holds our array
        public int Top { get; set; } // this keeps track of the top

        public Stack(int size)
        {
            // This holds constructor value
            MaxSize = size;
            // Creates array with size
            StackArray = new string[MaxSize];
            // We give top -1 because arrays is zero inde; If we don't it will skip the first element.
            Top = -1;
        }

        public void Push(string item)
        {
            if (!IsFull())
            {
                StackArray[++Top] = item;
            }
        }

        public string Pop()
        {
            //var deletedItem = StackArray[Top];
            //StackArray[Top--] = string.Empty;
            return StackArray[Top--];
        }

        public string Peek()
        {
            return StackArray[Top];
        }

        public bool IsEmpty()
        {
            return Top < 0;
        }

        public bool IsFull()
        {
            return Top == (MaxSize - 1);
        }

    }
}
