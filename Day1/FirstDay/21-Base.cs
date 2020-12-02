using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDay
{
    class Base
    {
        public static void Main()
        {
            Dog d = new Dog();
            d.eat();
        }
    }
    public class Animal2
    {
        public virtual void eat()
        {
            Console.WriteLine("eating...");
        }
    }
    public class Dog : Animal2
    {
        public override void eat()
        {
            base.eat();
            Console.WriteLine("eating bread...");
        }

    }
}
