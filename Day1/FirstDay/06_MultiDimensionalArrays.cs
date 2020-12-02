using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDay
{
    class MultiDimensionalArrays
    {
        public static void Main(string[] args)
        {
            int[,] arr = new int[3, 3];//declaration of 2D array  
            arr[0, 1] = 10;//initialization  
            arr[1, 2] = 20;
            arr[2, 0] = 30;

            //traversal  
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();//new line at each row  
            }

            Console.WriteLine("---------------------------------------");

            int[,] arr1 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };//declaration and initialization  

            //traversal  
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(arr1[i, j] + " ");
                }
                Console.WriteLine();//new line at each row  
            }

        }
    }
}
