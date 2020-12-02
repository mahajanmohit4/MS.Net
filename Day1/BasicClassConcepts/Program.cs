using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace BasicClassConcepts
{
    class Program
    {
        static void oldMain()
        {

            Console.WriteLine("Hello World");
            System.Console.WriteLine("Hello Mohit");
            //n2.Class2;
            //n2.n3.class4

            DataSet ds = new DataSet();
        }
        static void Main(String[] args)
        {
            Class11 o;
            o = new Class11();
            o.Display();
            o.Display("mohit");

            Console.WriteLine(o.add(10, 20, 30, 40));
            Console.WriteLine(o.add(10, 20));
            Console.WriteLine(o.add(10, 20, 30));
            Console.WriteLine(o.add(10));

            Console.WriteLine(o.add(d: 40));
            Console.WriteLine(o.add(c: 30));
            Console.WriteLine(o.add(a: 40, b:20));

            n2.c3 obj = new n2.c3();
            obj.show();

            Demo1 d = new Demo1();
            d.showDemo1();

            Demo2 d2 = new Demo2();
            
            System.Console.ReadLine();
           
        }

        public class Class11
        {
            public void Display()
            {
                Console.WriteLine("class1");
            }
            public void Display(String s)
            {
                Console.WriteLine("Display" + s);
            }

            public int add(int a=0, int b=0,int c=0, int d=0)
            {
                return a + b + c + d;
            }
            public int add1(int a , int b , int c , int d )
            {
                return a + b + c + d;
            }
        }
        class Class2
        { }
    }
}

namespace n2
{
    class c3
    {
        public void show()
        {
            Console.WriteLine("class 3");
        }
    }
    class Class2
    {
        
    }
    namespace n3
    {
        class class4
        {

        }
    }
}
