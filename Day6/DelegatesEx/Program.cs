using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesEx
{
    class Program
    {
        public delegate void Del1();
        public delegate int DelAdd(int a, int b);
        static void Main1(string[] args)
        {

            Del1 objDel;
            objDel = new Del1(Display);

            objDel();

            objDel += new Del1(Show);
            objDel();

            //Del1 objDel2 = new Del1(Show);

 //           objDel2();

            Console.ReadLine();
        }
        static void Main2(string[] args)
        {

            Del1 objDel;
            objDel = new Del1(Display);

            objDel();
            Console.WriteLine();
            objDel += new Del1(Show);
            objDel();

            Console.WriteLine();
            objDel -= new Del1(Show);
            objDel();

            Console.ReadLine();
        }
        static void Main3(string[] args)
        {

            Del1 objDel;
            objDel = new Del1(Display);

            objDel();
            Console.WriteLine();
            objDel += new Del1(Show);
            objDel();

            Console.WriteLine();
            objDel -= new Del1(Display);
            objDel();

            Console.WriteLine();
            objDel = Display;
            objDel();

            Console.ReadLine();
        }

        public static void  Main4()
        {
            Del1 objDel = (Del1)Delegate.Combine(new Del1(Display), new Del1(Show));
            objDel();

            Console.WriteLine();
            objDel = (Del1)Delegate.Remove(objDel, new Del1(Display));
        }
        public static void Main5()
        {
            DelAdd delAdd;
            delAdd = Add;
           
            Console.WriteLine(delAdd(11, 22));
            Console.ReadLine();
        }
        public static void Main()
        {
            Console.WriteLine(PassMethodToCallAsParameter(Add, 20, 20));
            Console.WriteLine(PassMethodToCallAsParameter(Sub, 20, 20));
            Console.WriteLine(PassMethodToCallAsParameter(Mul, 20, 20));

            Console.ReadLine();
        }

        static int Add(int a, int b)
        {
            return a + b;
        }
        static int Sub(int a, int b)
        {
            return a - b;
        }
        static int Mul(int a, int b)
        {
            return a * b;
        }
        static int PassMethodToCallAsParameter(DelAdd objDelAdd,int a, int b)
        {

            return objDelAdd(a, b);
        }
        static void Show()
        {
            Console.WriteLine("Show");
        }
        static void Display()
        {
            Console.WriteLine("display");
        }
    }
    public class Class2
    {
        public  int Add(int a, int b)
        {
            return a + b;
        }
    }
}
