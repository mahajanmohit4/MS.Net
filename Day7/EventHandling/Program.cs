using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandling1
{
    class Program
    {
        static void Main1(string[] args)
        {
            Class1 objClass1 = new Class1();
            
            objClass1.invalidP1 += objClass1_InvalidP1;
            objClass1.P1 = 1213;
            Console.ReadLine();
        }
        static void objClass1_InvalidP1()
        {
            Console.WriteLine("Invalid P1 event click");
        }
    }

    public delegate void InvalidP1EvenHandler();
    public class Class1
    {
        public event InvalidP1EvenHandler invalidP1;

        private int p1;
        public int P1
        {
            get
            {
                return p1;
            }
            set
            {
                if (value < 100)
                    p1 = value;
                else
                {
                    invalidP1();
                }
            }
        }
    }
   
}
namespace EventHandling2
{
    class Program
    {
        static void Main2(string[] args)
        {
            Class1 objClass1 = new Class1();

            objClass1.invalidP1 += objClass1_InvalidP1;

            objClass1.invalidP1 += Handler2;

            objClass1.P1 = 1213;
            Console.WriteLine("-------------------");
            objClass1.invalidP1 -= objClass1_InvalidP1;
            objClass1.P1 = 1213;

            Console.WriteLine("--------------------");
            objClass1.invalidP1 -= Handler2;
            objClass1.P1 = 1213;

            Console.ReadLine();
        }
        static void objClass1_InvalidP1()
        {
            Console.WriteLine("Invalid P1 event click");
        }
        static void Handler2()
        {
            Console.WriteLine("Invalid Hander Method");
        }
    }

    public delegate void InvalidP1EvenHandler();
    public class Class1
    {
        public event InvalidP1EvenHandler invalidP1;

        private int p1;
        public int P1
        {
            get
            {
                return p1;
            }
            set
            {
                if (value < 100)
                    p1 = value;
                else
                {
                    //if(invalidP1 != null)
                        invalidP1();
                }
            }
        }
    }

}
namespace EventHandling3
{
    class Program
    {
        static void Main1(string[] args)
        {
            Class1 objClass1 = new Class1();

           // objClass1.invalidP1 += objClass1_InvalidP1;

            

            objClass1.P1 = 1213;
           

            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            Class1 objClass1 = new Class1();
            objClass1.invalidP1 += ObjClass1_invalidP1;
            objClass1.P1 = 1213;


            Console.ReadLine();
        }

        private static void ObjClass1_invalidP1(int a)
        {
            Console.WriteLine("invalid p1");
        }
    }

    public delegate void InvalidP1EvenHandler(int a);
    public class Class1
    {
        public event InvalidP1EvenHandler invalidP1;

        private int p1;
        public int P1
        {
            get
            {
                return p1;
            }
            set
            {
                if (value < 100)
                    p1 = value;
                else
                {
                    //if(invalidP1 != null)
                    invalidP1(value);
                }
            }
        }
    }

}