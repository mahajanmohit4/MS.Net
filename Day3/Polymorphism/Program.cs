using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello poly");

            BaseClass obj = new DerivedClass();
            obj.show(); // method hiding with new keyword
            obj.display(); // runtime polymorphism

            Console.ReadLine();
        }
        
        class BaseClass
        {
            public void show()
            {
                Console.WriteLine("show Base Class !!");
            }

            public virtual void display()
            {
                Console.WriteLine("display base Class");
            }
        }
        class DerivedClass : BaseClass
        {
            public new void show()
            {
                Console.WriteLine("show derived class");
            }
            public override void display()
            {
                Console.WriteLine("display derived class");
            }
        }
        class SubDerivedClass : DerivedClass
        {
            public new void show()
            {
                Console.WriteLine("show sub derived class ");
            }
            public sealed override void display()
            {
                Console.WriteLine("display sub derived class");
            }
        }
        class SubSubDerivedClass : SubDerivedClass
        {
            public new void display()
            {
                Console.WriteLine("display sub derived class");
            }
        }

    }
}
