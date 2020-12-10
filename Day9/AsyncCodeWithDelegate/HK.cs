using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncCodeWithDelegate
{
    class HK
    {
        static void Main()
        {

            int[] arr = new int[] { 2, 1, 2, 3, 4, 5, 2, 9};
            Console.Write("[ ");
            for (int i = 0; i < arr.Length/2; i++)
            {
                
                if (i % 2 != 0)
                {
                    if (arr[i] > arr[i - 1]) Console.Write(arr[i]+", ");
                    else Console.Write("-,");
                }
                else Console.Write(arr[i]+", ");
            }

            for (int i = arr.Length/2; i < arr.Length; i++)
            {

                if (i % 2 == 0)
                {
                    if (arr[i] < arr[i - 1]) Console.Write(arr[i]);
                    else Console.Write("-");
                }
                else Console.Write(arr[i]);
                if (i < arr.Length - 1) Console.Write(", ");
            }
            Console.WriteLine("]");
            Console.WriteLine("--------------------");
            Console.Write("[");
            for (int i = 0; i < arr.Length ; i++)
            {

                if (i % 2 != 0)
                {
                    if (arr[i] < arr[i - 1]) Console.Write(arr[i]);
                    else Console.Write("-");
                }
                else Console.Write(arr[i]);

              
                if(i<arr.Length-1) Console.Write(", ");


            }
            Console.WriteLine("]");
           

            Console.ReadLine();
        }
    }
}
