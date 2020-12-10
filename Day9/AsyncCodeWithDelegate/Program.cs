using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//callling a method asynchronously usintg delOb.beininvoke
namespace AsyncCodeWithDelegate1
{
    class Program
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("Before");
            Action o = Display;
            o.BeginInvoke(null,null);
           
            Console.WriteLine("After");
            Console.ReadLine();
        }
        static void Display()
        {
            System.Threading.Thread.Sleep(5000);
            Console.WriteLine("Display");
        }
    }
}
namespace AsyncCodeWithDelegate2
{
    class Program
    {
        static void Main2(string[] args)
        {
            Console.WriteLine("Before");
            Action<string> o = Display;
            o.BeginInvoke("asdf", null, null);

            Console.WriteLine("After");
            Console.ReadLine();
        }
        static void Display(string s)
        {
            System.Threading.Thread.Sleep(5000);
            Console.WriteLine("Display "+s);
        }
    }
}
namespace AsyncCodeWithDelegate3
{
    class Program
    {
        static void Main3(string[] args)
        {
            Console.WriteLine("Before");
            Func<string,string> o = Display;
            o.BeginInvoke("asdf", CallBackFun , null);

            Console.WriteLine("After");
            Console.ReadLine();
        }
        static string Display(string s)
        {
            System.Threading.Thread.Sleep(5000);
            Console.WriteLine("Display " + s);
            return s.ToUpper();
        }
        static void CallBackFun(IAsyncResult ar)
        {
            Console.WriteLine("Callback func called !! ");
        }
    }
}
namespace AsyncCodeWithDelegate
{
    class Program
    {
      //  static Func<string, string> o;
        static void Main1(string[] args)
        {
            Console.WriteLine("Before");
            Func<string, string> o = Display;
            o.BeginInvoke("asdf", delegate(IAsyncResult ar)
        {
                Console.WriteLine("Callback func called !! ");
                string reval = o.EndInvoke(ar);
                Console.WriteLine("Retval : "+reval);

            }, null);
           
            Console.WriteLine("After");
            Console.ReadLine();
        }
        static string Display(string s)
        {
            System.Threading.Thread.Sleep(5000);
            Console.WriteLine("Display " + s);
            return s.ToUpper();
        }
        static void CallBackFun(IAsyncResult ar)
        {
            Console.WriteLine("Callback func called !! ");
          
        }
    }
}
