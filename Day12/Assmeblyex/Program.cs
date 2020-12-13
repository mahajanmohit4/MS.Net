using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assmeblyex
{
    class Program
    {
        public string Hello()
        {
            return "hello world";

        }
       public static void Main()
        {
            Program p = new Program();
            Console.WriteLine(p.Hello());
        }
    }
}
