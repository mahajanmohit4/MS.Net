using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceEx
{
    class Override
    {
        static void Main1(string[] args)
        {
             DerivedClass obj = new DerivedClass();
            // DerivedClass obj = new DerivedClass(11, 22);

            obj.show();
            obj.display();
            Console.ReadLine();
        }
        static void Main()
        {
            BaseClass o;
            o = new BaseClass();

            o.show(); // non virtual => early binding
            o.display(); // virutal => Late binding

            Console.WriteLine( "---------------");
            o = new DerivedClass();
            o.show(); // non virtual => early binding
            o.display(); // virutal => Late binding

            Console.WriteLine("---------------");
            
            o.show(); // non virtual => early binding
            o.display(); // virutal => Late binding

            Console.ReadLine();
        }
    }
    public class BaseClass
    {
        public int i;
        public BaseClass()
        {
            i = 10;
            Console.WriteLine("base class");
        }
        public BaseClass(int i)
        {
            Console.WriteLine("param base class");
            this.i = i;
        }
        public void show()
        {
            Console.WriteLine("base show");
        }
        public virtual void display()
        {
            Console.WriteLine("base display");
        }
    }
    public class DerivedClass : BaseClass
    {
        public int j;
        public DerivedClass()
        {
            j = 20;
            Console.WriteLine("derived class");
        }

        public DerivedClass(int i, int j) : base(i)
        {
            Console.WriteLine("param derived class");
            this.j = j;
        }
        // Hiding the method of base class
        public new void show()
        {
            Console.WriteLine("derived show");
        }
        //overiden from base class
        public override void display()
        {
           // base.display();
            Console.WriteLine("derived display");
        }
        public class SubDerivedClass : DerivedClass
        {
            public sealed override void display()
            {
                // base.display();
                Console.WriteLine("sub derived class display");
            }
        }

        public class SubSubDerivedClass : SubDerivedClass
        {
            public new  void display()
            {
                // base.display();
                Console.WriteLine("sub sub display");
            }
        }
    }
}
