using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonMethodsAndLembdas1
{
    class Program
    {
        static void Main1(string[] args)
        {
            Action o1 = Display;
            o1();

            Action<string> o2 = Display;
            o2("Mohit");

            Action<string,int> o3 = Display;
            o3("Mohit",11);
            Console.ReadLine();
        }
        static void Main2(string[] args)
        {
            Func<int, int, int> f1 = Add;
            Console.WriteLine(f1(11,22));

            Func<string, short, int> f2 = DoSomting;
            Console.WriteLine(f2("MOhit", 22));
            Console.ReadLine();
        }
        static void Main3(string[] args)
        {
            Func<int, int, int> f1 = Add;
            Console.WriteLine(f1(11, 22));

            Func<string, short, int> f2 = DoSomting;
            Console.WriteLine(f2("MOhit", 22));

            Func<int, bool> f3 = IsEven;
            Console.WriteLine(f3(10));

            Predicate<int> f4 = IsEven;
            Console.WriteLine(f4(3));

            Console.ReadLine();
        }

        static void Main4(string[] args)
        {
            // Action o = delegate { Console.WriteLine("Annonymous mehtod Called"); }
            int i = 10;
            Action o = delegate ()
            {
                Console.WriteLine("Display");
                ++i;
            };

            o();
            Func<int ,int,int> o2 = delegate(int a, int b)
        {
                return a + b;
            };
            Console.WriteLine(i);
            Console.WriteLine(o2(10,20));

            Console.ReadLine();
        }
        static bool IsEven(int a)
        {
            return a % 2 == 0;
        }
        static int Add(int a, int b)
        {
            return a + b;
        }
        static int DoSomting(String a, short b)
        {
            return 1;
        }
        static void Display()
        {
            Console.WriteLine("Display");
        }
        static void Display(string s)
        {
            Console.WriteLine("Display "+s);
        }
        static void Display(string s,int a)
        {
            Console.WriteLine("Display " + s+a);
        }
    }
}
namespace Lambda
{
    class Program
    {
   

        static void Main(string[] args)
        {
            //shorter syntex of the ananomoous
            //x is the paramter of he function
            //=> is the lambda operator
            //x*2 is he return value
            Func<int, int> o = x => x * 2;
            Func<int, int, int> o2 = (a, b) => a + b;
           // Func<int, int, int> o2 = (a, b) => { return a + b; };

            Func<int, int, int, int> o3 = (a, b, c) =>
               {
                //multiple line of code
                return a + b + c;
               };

            Console.WriteLine(o2(10,20));
            Console.WriteLine(o(10));

            Console.ReadLine();
        }
        static int MakeDouble(int a)
        {
            return a * 2;
        }
        static bool IsEven(int a)
        {
            return a % 2 == 0;
        }
        static int Add(int a, int b)
        {
            return a + b;
        }
        static int DoSomting(String a, short b)
        {
            return 1;
        }
        static void Display()
        {
            Console.WriteLine("Display");
        }
        static void Display(string s)
        {
            Console.WriteLine("Display " + s);
        }
        static void Display(string s, int a)
        {
            Console.WriteLine("Display " + s + a);
        }
    }
}
