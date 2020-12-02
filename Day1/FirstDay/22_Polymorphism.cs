using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDay
{
    class Polymorphism
    {
        public static void Main()
        {
            Shape s;
            s = new Shape();
            s.draw();
            s = new Rectangle1();
            s.draw();
            s = new Circle();
            s.draw();

        }
    }
    public class Shape
    {
        public virtual void draw()
        {
            Console.WriteLine("drawing...");
        }
    }
    public class Rectangle1 : Shape
    {
        public override void draw()
        {
            Console.WriteLine("drawing rectangle...");
        }

    }
    public class Circle : Shape
    {
        public override void draw()
        {
            Console.WriteLine("drawing circle...");
        }

    }
}
