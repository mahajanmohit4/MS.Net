using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First
{
    class Program
    {
        static void Main1()
        {
            Class1 o = new Class1();
            //o.SetI(100);
            //Console.WriteLine(o.GetI());

            o.P1 = 10;
            Console.WriteLine(o.P1);
            // o.P1 = ++o.P1 - o.P1-- - --o.P1;
            // Console.WriteLine(o.P1);
           
            Console.WriteLine(o.P3);

            o.P5 = 123;
            Console.WriteLine(o.P5);

            Console.ReadLine();
        }
       
        static void Main()
        {
            Class1 o;
            o = new Class1();
            Console.WriteLine(o.P1);

            Class1 o2 = new Class1(10);
            Console.WriteLine(o2.P1);

            o = null;
            o2 = null;
            GC.Collect();
            Console.ReadLine();
        }

        public class Class1
        {
            #region Constructor
            public Class1()
            {
                Console.WriteLine("no param");
                P1 = 5;
            }

            public Class1(int P1)
            {
                this.P1 = P1;
                // p1 = a;
            }
            #endregion
            ~Class1()
            {
                Console.WriteLine("Desttructor called");
            }

            #region Property
            // public int i;
            private int i;
            public void SetI(int x)
            {
                if (x < 100)
                {
                    i = x;
                }
                else
                    Console.WriteLine("invalid value");
            }

            public int GetI()
            {
                return i;
            }

            // property
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
            private string p2;
            public string P2
            {
                set
                {
                    p2 = value;
                }
                get
                {
                    return p2;
                }
            }
            // readonly
            private string p3 = "Mohit";
            public string P3
            {
                get { return p3; }
            }
            // writeonly
            private string p4;
            public string P4
            {
                set { value = p3;  }
            }

            // auto properties
            public int P5 { get; set; }
            #endregion




        }
    }
}
