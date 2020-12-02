using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDay
{
    class PassingArrayToFunction
    {
        static void printArray(int[] arr)
        {
            Console.WriteLine("Printing array elements:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        public static void Main(string[] args)
        {
            int[] arr1 = { 25, 10, 20, 15, 40, 50 };
            int[] arr2 = { 12, 23, 44, 11, 54 };
            printArray(arr1);//passing array to function  
            printArray(arr2);

            Console.WriteLine("------------------------------------");
            printMin(arr1);//passing array to function  
            printMin(arr2);

            Console.WriteLine("------------------------------------");
            printMax(arr1);//passing array to function  
            printMax(arr2);
            Console.ReadLine();

        }

        static void printMin(int[] arr)
        {
            int min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (min > arr[i])
                {
                    min = arr[i];
                }
            }
            Console.WriteLine("Minimum element is: " + min);
        }
        static void printMax(int[] arr)
        {
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                }
            }
            Console.WriteLine("Maximum element is: " + max);
        }
    }
}
