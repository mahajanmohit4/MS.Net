using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDay
{
    class JaggedArrays
    {
        public static void Main()
        {
            int[][] arr = new int[2][];// Declare the array  

            arr[0] = new int[] { 11, 21, 56, 78 };// Initialize the array          
            arr[1] = new int[] { 42, 61, 37, 41, 59, 63 };

            // Traverse array elements  
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    System.Console.Write(arr[i][j] + " ");
                }
                System.Console.WriteLine();
            }

            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("2D Matrix");

            int[][] arr1 = new int[3][]{
            new int[] { 11, 21, 56, 78 },
            new int[] { 2, 5, 6, 7, 98, 5 },
            new int[] { 2, 5 }
            };

            // Traverse array elements  
            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = 0; j < arr1[i].Length; j++)
                {
                    System.Console.Write(arr1[i][j] + " ");
                }
                System.Console.WriteLine();
            }

        }
    }
}
