using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TaskExampls
{
    class Program
    {
        static void Main()
        {

            Action objAction1 = Func1;
            Task t1 = new Task(objAction1);


            Task t3 = new Task(new Action(Func1));
            Task t4 = new Task(Func1);

            Action objAction2 = Func2;
            Task t2 = new Task(objAction2);

            t1.Start();
            t2.Start();

            Console.ReadLine();
        }
        static void Func1()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("first Func called from {0},{1}", Thread.CurrentThread.ManagedThreadId, i);
            }
        }
        static void Func2()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("second Func called from {0},{1}", Thread.CurrentThread.ManagedThreadId, i);
            }
        }
    }
}
