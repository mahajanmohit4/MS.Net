using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main1(string[] args)
        {
            // Internally inherited from System.Array
            int[] arr = new int[5];
            
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write("Enter element no {0} : ",i);
                
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            foreach(int x in arr)
            {
                Console.WriteLine("value is {0}",x);
            }

            Console.ReadLine();
        }

        static void Main2(string[] args)
        {
            // Internally inherited from System.Array
            int[] arr = new int[5];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Enter element no {0} : ", i);

                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Array.Clear(arr, 0, 5);
            // Array.Copy(arr, arr2, 5);
            // Array.ConstrainedCopy => all should copy or none
            // Array.CreateInstance(typeof(int), 0);

            //int pos = Array.IndexOf(arr, 3);
            // if postion is not found then pos is -1

            //int pos = Array.LastIndexOf(arr,10);

            // int pos = Array.BinarySearch(arr, 10);

            //Array.Reverse(arr); // reverse the array

            // Array.Sort(arr); 


            //Console.WriteLine(pos);
            foreach (int x in arr)
            {
                Console.WriteLine("value is {0}", x);
            }

            Console.ReadLine();
        }
        static void Main3(string[] args)
        {
            int[,] arr1 = new int[5,3];


            Console.WriteLine(arr1.Rank);
            Console.WriteLine(arr1.GetLength(0));
            Console.WriteLine(arr1.GetUpperBound(0));

            for(int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    Console.Write("Enter marks for Student number {0} and Subject {1})", i, j);
                    arr1[i,j] = Convert.ToInt32(Console.ReadLine());
                }
               
            }

            for (int i = 0; i < arr1.GetLength(0) ; i++)
            {
                for (int j = 0; j < arr1.GetLength(1) ; j++)
                {
                    Console.Write("Enter marks for Student number {0} and Subject {1})", i, j, arr1[i,j]);
                    // Console.WriteLine(arr1[i,j]);
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
      
    }
}
