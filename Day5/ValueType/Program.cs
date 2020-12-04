using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueType
{
    class Program
    {
        static void Main1(string[] args)
        {
            // MyPoint p;
            // p.x = 123;
            // p.y = 345;
            MyPoint p = new MyPoint(11,22);
            //Console.WriteLine((p.x);
            //Console.WriteLine(p.y);
            Console.WriteLine();
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            Display2(TimeOfDay.Afgernooon);
            Console.WriteLine();
            Console.ReadLine();
        }
        static void Display2(TimeOfDay t)
        {
            if (t == TimeOfDay.Afgernooon)
                Console.WriteLine("good afternoon");
            else if(t == TimeOfDay.Morning)
                Console.WriteLine("good morning");
        }

    }

    public enum TimeOfDay : int
    {
        Morning =100,
        Afgernooon=200,
        Evening,
        Night
    }
    public struct MyPoint
    {
        public MyPoint(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public int x, y;
    }


}
