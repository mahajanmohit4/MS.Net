using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_StaticMember
{
    class StaticClass
    {

        public static void Main()
        {
            
            Console.WriteLine(Hello.square(11));
            Console.ReadLine();
        }
    }

    static class Hello
    {
        static int num1;

       
        static public int square(int num1)
        {
            // this.num1 = num1;
            return num1 * num1;
        }
    }
}
