using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class ArrayPractice
    {
        static void Main1()
        {
            int[] arr1 = new int[5];
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine("Enter Element {0} : ",i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }

            foreach  (int no in arr1)
            {
                Console.WriteLine("Elements are :  {0}  ",no);
            }

            Console.ReadLine();
        }

        static void Main2()
        {
            int[,] arr1 = new int[4, 2];

            for (int i = 0; i < arr1.GetLength(0); i++)
            {
                for (int j = 0; j < arr1.GetLength(1); j++)
                {
                    Console.Write($"[{i} , {j}] : ");
                    arr1[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int i = 0; i < arr1.GetLength(0); i++)
            {
                for (int j = 0; j < arr1.GetLength(1); j++)
                {
                   // Console.Write("[{0} , {1}]", i, j);
                    Console.Write(arr1[i,j] + " " );
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }

        static void Main()
        {
            int[][] arr1 = new int[4][];
            arr1[0] = new int[2];
            arr1[1] = new int[3];
            arr1[2] = new int[2];
            arr1[3] = new int[4];

            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = 0; j < arr1[i].Length; j++)
                {
                    Console.Write($"[{i} , {j}] : ");
                    arr1[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = 0; j < arr1[i].Length; j++)
                {
                    // Console.Write("[{0} , {1}]", i, j);
                    Console.Write(arr1[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
