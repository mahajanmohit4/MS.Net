using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main1(string[] args)
        {
          //  MyOperations<int> i = new MyOperations<int>();
            int ii = 100;
            int j = 200;
            Console.WriteLine(ii + "  " + j);
            MyOperations<int>.Swap(ref ii, ref j);
            Console.WriteLine(ii + "  " + j);

            Console.ReadLine();
        }

        class MyOperations<T>
        {
            public static void Swap(ref T i, ref T j)
            {
                T temp;
                temp = i;
                i = j;
                j = temp;

            }
        }
        class IntOPerations
        {
            public static void Swap(ref int i, ref int j)
            {
                int temp;
                temp = i;
                i = j;
                j = temp;

            }
        }
        class ShortOPerations
        {
            public static void Swap(ref short i, ref short j)
            {
                short temp;
                temp = i;
                i = j;
                j = temp;

            }
        }
    }
}
