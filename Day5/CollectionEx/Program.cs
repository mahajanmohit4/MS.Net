using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionEx
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList al1 = new ArrayList();
            al1.Add(111);
            al1.Add(222);
            al1.Add(333);

            ArrayList al = new ArrayList();

            al.Add("Mohit");
            al.Add("Deepak");
            al.Add("Rahul");

            al.Add(11);
            al.Add(22);

            Console.WriteLine(al.Count);

            al.Capacity = 10;
            al.Remove("Deepak");
            
            al.RemoveAt(0);
            al.Insert(0, "Hello");

            al.RemoveRange(1,2);

            al.InsertRange(1, al1);



            foreach (object o in al)
            {
                Console.WriteLine(o);
            }

            //Convert Array list to Array
            object[] arr = al.ToArray();

            //foreach (object oj in arr)
            //{
            //    Console.WriteLine(oj);
            //}
            al.Add("Hero");
            al.Add("Honda");

            object[] arr1 = new object[al.Count];
            al.CopyTo(arr1);

            Console.WriteLine("-------------------------");
            foreach (object oj in arr1)
            {
                Console.WriteLine(oj);
            }

            

            Console.WriteLine(al.IndexOf("Hello"));
            Console.WriteLine(al.BinarySearch(111));
            Console.WriteLine(al.LastIndexOf(arr1));
            Console.ReadLine();

        }
    }
}
