using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceEx
{
    class AbstractClass
    {
        public static void Main()
        {
            Class2 o = new Class2();

            o.show();
            o.display();
            Console.ReadLine();
        }
    }
    public abstract class AbstractClass1
    {

    }
    public class DerivedClass1 : AbstractClass1
    {

    }
    public abstract class AbstractClass2
    {
        public abstract void display();
        public abstract void show();
    }
    public  class Class2 : AbstractClass2
    {
        public override void display()
        {
            Console.WriteLine("display");
        }

        public override void show()
        {
            Console.WriteLine("show");
        }

      

        

    }
    public  class Class3 : Class2
    {
        public override void show()
        {
            Console.WriteLine("class3 show ");
        }
        
    }
}
