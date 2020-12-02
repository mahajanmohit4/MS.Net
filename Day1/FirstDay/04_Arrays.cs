using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDay
{
    class Arrays
    {
        public static void Main(string[] args)
        {
            int[] arr = new int[5];//creating array  
            arr[0] = 10;//initializing array  
            arr[2] = 20;
            arr[4] = 30;

            //traversing array  
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            Console.WriteLine("----------------------------------------");


            int[] arr1 = { 10, 20, 30, 40, 50 };//Declaration and Initialization of array  

            //traversing array  
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine(arr1[i]);
            }

            Console.WriteLine("----------------------------------------");
            int[] arr2 = { 10, 20, 30, 40, 50 };//creating and initializing array  

            //traversing array  
            foreach (int i in arr2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
