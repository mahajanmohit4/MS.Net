using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverlading1
{
    class Program
    {
        static void Main1(string[] args)
        {
            Class1 o = new Class1 { i = 10 };
            o = o + 5;
            Console.WriteLine(o.i);
            Console.ReadLine();
        }

        public class Class1
        {
            public int i;
            public static Class1 operator +(Class1 o, int i)
            {
                Class1 retvals = new Class1();
                retvals.i = o.i + 5;
                return retvals;
            }
        }
    }
}

namespace OperatorOverlading
{
    class Program
    {
        static void Main1(string[] args)
        {
            Class1 o = new Class1 { i = 10 };
            Class1 o1 = new Class1 { i = 20 };
            Class1 o2 = new Class1 { i =30 };
            o = o1 + o2;
            o = ++o;
            Console.WriteLine(o.i);
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            Class2 o = new Class2(3,10);
            o[10] = 111;
            o[11] = 222;
            o[12] = 333;
            Console.WriteLine("First value = {0}", o[10]);
            Console.WriteLine("Second value = {0}", o[11]);
            Console.WriteLine("Third value = {0}", o[12]);
            
            Console.ReadLine();
        }
        public class Class2
        {
            int[] arr;
            int startPos;
            public Class2(int size, int startPos)
            {
                arr = new int[size];
                this.startPos = startPos;
            }
            public int this[int index]
            {
                get { return arr[index-startPos]; }
                set { arr[index-startPos] = value; }
            }
        }
        public class Class1
        {
            public int i;
            public static Class1 operator +(Class1 o1, Class1 o2)
            {
                Class1 retvals = new Class1();
                retvals.i = o1.i + o2.i;
                return retvals;
            }
            public static Class1 operator ++(Class1 o1)
            {
                Class1 retvals = new Class1();
                retvals.i = ++o1.i;
                return retvals;
            }
        }
    }
}
