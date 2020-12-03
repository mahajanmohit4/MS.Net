using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefAndValue
{
    class Program
    {
        static void Main1(string[] args)
        {
            Class1 o = new Class1();
            Class1 o2 = new Class1();
            o.i = 100;
            o2.i = 200;
            o = o2;
            o2.i = 300;
            Console.WriteLine(o.i);
            Console.WriteLine(o2.i);
            Console.ReadLine();
        }
        static void Main2(string[] args)
        {
            int o1, o2;
            o1 = 100;
            o2 = 200;
            o1=o2;
            o2 = 300;
            Console.WriteLine(o1);
            Console.WriteLine(o2);
            Console.ReadLine();
        }
        static void Main3(string[] args)
        {
            string o1, o2;
            o1 = "100";
            o2 = "200";
            o1 = o2;
            o2 = "300";
            Console.WriteLine(o1);
            Console.WriteLine(o2);
            Console.ReadLine();
        }
        static void Main4(string[] args)
        {
            int o1, o2;
            o1 = 1;
            o2 = 2;
            swap(ref o1,ref o2);
            Console.WriteLine(o1);
            Console.WriteLine(o2);
            Console.ReadLine();
        }
        static void Main5(string[] args)
        {
            int o1, o2;
            
            intit(out o1, out o2);
            swap(ref o1, ref o2);
            Console.WriteLine(o1);
            Console.WriteLine(o2);
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            Class1 o = new Class1();
            o.i = 100;
            doSomething3(ref o);
            Console.WriteLine(o.i);
            //Console.WriteLine(o2);
            Console.ReadLine();
        }
        static void doSomething(Class1 obj) 
        {
            obj.i = 200;
        }
        static void doSomething2(Class1 obj)
        {
            obj = new Class1();
            obj.i = 200;
        }
        static void doSomething3(ref Class1 obj)
        {
            obj = new Class1();
            obj.i = 200;
        }
        static void intit(out int i , out int j)
        {
            i = 100;
            j = 100;
        }
        static void swap(ref int i, ref int j)
        {
            int temp = i;
            i = j;
            j = temp;
        }
        public class Class1
        {
            public int i;
        }
    }
}
