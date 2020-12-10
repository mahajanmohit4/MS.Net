using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace WorkingWithThreads1
{
    class Program
    {
        static void Main1(string[] args)
        {
            Thread tl = new Thread(new ThreadStart(Func1));
            Thread t2 = new Thread(Func2);
            // tl.Priority = ThreadPriority.Highest;
            // tl.IsBackground = true; => do not wait on read line
            // t2.IsBackground = true;
            tl.Start();
            t2.Start();

            // tl.Abort(); end the thread
            // tl.IsAlive;
            // tl.Join(); // wait for the r=thread to complete waiting call

            // tl.Name

            // if (tl.ThreadState == ThreadState.)
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("main : " + i);
                Thread.Sleep(1000);
            }
           
            Console.ReadLine();
        }
        static void Func1()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("first : "+i);
            }
        }
        static void Func2()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("second : " + i);
            }
        }
    }
}
namespace WorkingWithThreads2
{
    class Program
    {
        static void Main1(string[] args)
        {
            Thread tl = new Thread(new ParameterizedThreadStart(Func1));
            Thread t2 = new Thread(Func2);
            
            tl.Start("o1");
            t2.Start("o2");

            
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("main : " + i);
                Thread.Sleep(1000);
            }

            Console.ReadLine();
        }
        static void Func1(object o)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("first : " + i.ToString()+o.ToString());
            }
        }
        static void Func2(object o)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("second : " + i.ToString() + o.ToString());
            }
        }
    }
}

namespace WorkingWithThreads3
{
    class Program
    {
        class Employee
        {
            private int empNo;
            private string empName;
            public int EmpNo { get; set; }
            public string EmpName { get; set; }
        }
        static void Main1()
        {
            // Thread t1 = new Thread(new ParameterizedThreadStart(Func1));
            //Thread t2 = new Thread(new ParameterizedThreadStart(Func2));
            Thread t2 = new Thread(Func2);
            Employee emp = new Employee { EmpNo = 11, EmpName = "Mohit" };
           // t1.Start("0");
            t2.Start(emp);
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Main Thread " + i.ToString());
            }
            Console.ReadLine();
        }

        //TO DO : Pass 2 values to the func.
        //Hint : Create a class that has 2 properties and pass an object of the class
        static void Func1(Employee o)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("First Thread " + i+"  "+ o.EmpName+" "+o.EmpNo);
            }
        }
        static void Func2(object emp)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Second Thread " + i + "  " + ((Employee)emp).EmpName +" "+ ((Employee)emp).EmpNo);
            }
        }
    }
}

namespace WorkingWithThreads4
{
    class Program
    {
        class Employee
        {
            private int empNo;
            private string empName;
            public int EmpNo { get; set; }
            public string EmpName { get; set; }
        }
        static void Main()
        {
            //ThreadPool.QueueUserWorkItem(new WaitCallback(PoolFunc1), "aaa");
            //ThreadPool.QueueUserWorkItem(PoolFunc1, "aaa");
            //hreadPool.QueueUserWorkItem();

            // Thread t1 = new Thread(new ParameterizedThreadStart(Func1));
            //Thread t2 = new Thread(new ParameterizedThreadStart(Func2));
            Thread t2 = new Thread(Func2);
            Employee emp = new Employee { EmpNo = 11, EmpName = "Mohit" };
            // t1.Start("0");
            t2.Start(emp);
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Main Thread " + i.ToString());
            }
            Console.ReadLine();
        }

        //TO DO : Pass 2 values to the func.
        //Hint : Create a class that has 2 properties and pass an object of the class
        static void Func1(Employee o)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("First Thread " + i + "  " + o.EmpName + " " + o.EmpNo);
            }
        }
        static void Func2(object emp)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Second Thread " + i + "  " + ((Employee)emp).EmpName + " " + ((Employee)emp).EmpNo);
            }
        }
    }
}
