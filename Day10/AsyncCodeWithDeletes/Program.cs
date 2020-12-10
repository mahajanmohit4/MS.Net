using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace AsyncCodeWithDeletes1
{
    class Program
    {
        static void Main1()
        {
            Console.WriteLine("Before");
            Func<string, string> o = Display;
            o.BeginInvoke("aaa", CallBackFunc, o);

            Console.WriteLine("After");
            Console.ReadLine();
        }
        static string Display(string s)
        {
            System.Threading.Thread.Sleep(5000);
            Console.WriteLine("Display" + s);
            return s.ToUpper();
        }

        static void CallBackFunc(IAsyncResult ar)
        {
            Console.WriteLine("callback func called");
            Func<string,string> o = (Func<string, string>) ar.AsyncState;
            string retval = o.EndInvoke(ar);
        }
    }
}

namespace AsyncCodeWithDeletes2
{
    class Program
    {
        static void Main1()
        {
            Console.WriteLine("Before");
            Func<string, string> o = Display;
            o.BeginInvoke("aaa", CallBackFunc, o);

            Console.WriteLine("After");
            Console.ReadLine();
        }
        static string Display(string s)
        {
            System.Threading.Thread.Sleep(5000);
            Console.WriteLine("Display" + s);
            return s.ToUpper();
        }

        static void CallBackFunc(IAsyncResult ar)
        {
            AsyncResult result = (AsyncResult)ar;
            Console.WriteLine("callback func called");
            //Func<string, string> o = (Func<string, string>)ar.AsyncState;
            //string retval = o.EndInvoke(ar);
            Func<string, string> o = (Func<string, string>)result.AsyncDelegate;
            string retval = o.EndInvoke(ar);
            Console.WriteLine(retval);
        }
    }
}

namespace AsyncCodeWithDelegates3
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Before");
            Action o = Display;
            IAsyncResult ar=  o.BeginInvoke(null, null);
            Console.WriteLine("After");

            // while (!ar.IsCompleted) ;
            ar.AsyncWaitHandle.WaitOne();
            //Console.ReadLine();
        }
        static void Display()
        {
            System.Threading.Thread.Sleep(5000);
            Console.WriteLine("Display");
        }
    }
}



