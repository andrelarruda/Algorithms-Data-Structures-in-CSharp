using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Data_Structures.ADT
{
    public  class PokemonClient
    {

        public static void IterateOverASequence()
        {
            // Abstract Data Types - All about Representation and Operation

            Pokemon pokemon = new Pokemon();

            string[] arr = new string[] { "pickachu", "charmander", "squirtle" };
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
