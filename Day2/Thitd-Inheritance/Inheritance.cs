using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thitd_Inheritance
{
    class Inheritance
    {
        static void Main()
        {
            A obj = new A();
            obj.Num1 = 11;
            Console.WriteLine(obj.Num1);
           // obj.show();
            Console.ReadLine();
        }
    }

    class A
    {
        private int num1;
        public int Num1
        {
            set { value = num1; }
            get { return num1; }
        }
        
    }

    class B : A
    {
        public void show()
        {
            Console.WriteLine(" CLASS B");
        }
    }
}
