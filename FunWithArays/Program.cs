using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithArays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Arrays *****");
            SimpleArrays();
            RectMultidimensionalArray();
            Console.ReadLine();
        }

        static void SimpleArrays()
        {
            Console.WriteLine("=> Simple Array Creation.");
            // Create an array of ints containing 3 elements indexed 0, 1, 2
            int[] myInts = new int[3];
            myInts[0] = 100;
            myInts[1] = 200;
            myInts[2] = 300;

            // Now print each value.
            foreach (int i in myInts)
                Console.WriteLine(i);

            Console.WriteLine();
        }

        static void RectMultidimensionalArray()
        {
            Console.WriteLine("=> Rectangular multidimensional array.");
            // A rectangular MD array.
            int[,] myMatrix = new int[51, 11];

            for (int i = 0; i < 51; i++)
                for (int j = 0; j < 11; j++)
                    myMatrix[i, j] = i * j;

            // Print (3*4) array.
            for (int i = 0; i < 51; i++)
            {
                for (int j = 0; j < 11; j++)
                {
                    Console.Write(myMatrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
