using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_StaticMember
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 o1 = new Class1();
            Class1 o2 = new Class1();
            o1.i = 100;
            o2.i = 200;
            Class1.s_i = 123;
            //Console.WriteLine(Class1.s_i);
            o1.Display();
            Class1.s_Display();

            Console.WriteLine("-------------------");

            Class1.s_P1 = 10;
            Console.WriteLine(Class1.s_P1);


            

            Console.ReadLine();
        }

        public class Class1
        {
            static Class1()
            {
                Console.WriteLine("static constructor !!");
                s_P1 = 11;
                s_i = 33;
            }
            public int i;
            //static variable - single copy for the class
            public static int s_i;

            // static method
            public void Display()
            {
                Console.WriteLine(i);
                Console.WriteLine(s_i);
                Console.WriteLine("display");
            }

            public static void s_Display()
            {
                Console.WriteLine("Static Display");
                //Console.WriteLine(i);
                Console.WriteLine(s_i);
            }

            private int p1;
            public int P1
            {
                set
                {
                    // passed value is avaiable as 'value'
                    if (value < 100)
                        p1 = value;
                    else
                        Console.WriteLine("Invalid ");
                }
                get
                {
                    return p1;
                }
            }

            private static int s_p1;
            public static int s_P1
            {
                set
                {
                    // passed value is avaiable as 'value'
                    if (value < 100)
                        s_p1 = value;
                    else
                        Console.WriteLine("Invalid ");
                }
                get
                {
                    return s_p1;
                }
            }

        }
    }

    public static class s_Class1
    {
        // can have only static members
        // cannot be instantiated
        //cannot be used as a base class

        public static int z;
        public static void show()
        {
            Console.WriteLine(z);
        }




    }
}
