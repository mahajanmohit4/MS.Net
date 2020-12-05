using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionEx
{
    class Program
    {
        static void Main1(string[] args)
        {
            //  Hashtable objDistionary = new Hashtable();
            SortedList objDistionary = new SortedList();
            objDistionary.Add(1, "asd");
            objDistionary.Add(2, "asds");
            objDistionary.Add(3, "asda");

            objDistionary[3] = "new value";
            objDistionary[4] = "new value generate";

            objDistionary.Remove(2);

            // objDistionary.Clear() // remove all
            // objDistionary.Contains(); //for key
            // objDistionary.ContainsKey //for key finding

            // objDistionary.Values //for value
            Console.WriteLine(objDistionary.GetByIndex(0));

            ArrayList objKeys =(ArrayList) objDistionary.GetKeyList();
            //objDistionary.IndexOfKey
            //objDistionary.IndexOfValue
            
            //try Dis method

            foreach (DictionaryEntry de in objDistionary)
            {
                Console.WriteLine(de.Key);
                Console.WriteLine(de.Value);
            }

            Console.ReadLine();
        }

        public static void Main2()
        {
            Stack objStack = new Stack();
            objStack.Push(100);
            objStack.Push(200);

            Console.WriteLine(objStack.Peek());
            Console.WriteLine(objStack.Pop());

            objStack.Push(100);
            objStack.Push(200);
            objStack.Push(300);

            

            Console.WriteLine("---------------------");

            foreach (object item in objStack)
            {
                Console.WriteLine(item);
            }


            Console.ReadLine();
            

        }

        static void Main12()
        {
            Queue objQ = new Queue();
            objQ.Enqueue(100);
            objQ.Enqueue(200);

            Console.WriteLine("deleted : "+ objQ.Dequeue());
            Console.WriteLine();

            foreach (object item in objQ)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }

        public static void Main3()
        {
            int i = 100;
            object o;
            o = i;
        }

        public static void Main4()
        {
            List<int> objList = new List<int>();
            objList.Add(10);

            foreach (int  x in objList)
            {
                Console.WriteLine(x);
            }
            Console.ReadLine();
        }

        public static void Main5()
        {
            SortedList<int, string> objDic = new SortedList<int, string>();
            objDic.Add(11, "asdf");
            objDic[12] = "aasdf";

            foreach (KeyValuePair<int,string> item in objDic)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);
            }
            Console.ReadLine();
        }
        public static void Main6()
        {
            List<Employee> objEmp = new List<Employee>();



            objEmp.Add(new Employee { EmpNO = 1, Name = "Mohit", DeptNo = 10, Basic = 120000 });
            objEmp.Add(new Employee { EmpNO = 1, Name = "Mohit", DeptNo = 10, Basic = 120000 });
            objEmp.Add(new Employee { EmpNO = 1, Name = "Mohit", DeptNo = 10, Basic = 120000 });

            foreach (object i in objEmp)
            {
                //((Employee)i).EmpNO;
            }

            Console.ReadLine();

        }
        public static void Main7()
        {
            SortedList<int, Employee> objemp = new SortedList<int, Employee>();
            objemp.Add(1, new Employee { EmpNO = 1, Name = "Mohit", DeptNo = 10, Basic = 120000 });

            foreach (KeyValuePair<int,Employee> item in objemp)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value.Name);
            }
        }
        public static void Main8()
        {
            Employees objemps = new Employees();
            Console.ReadLine();
        }

        public class Employees : List<Employee>
        {

        }
    }
    public class Employee
    {
        public int EmpNO { get; set; }
        public string Name { get; set; }
        public decimal Basic { get; set; }
        public short DeptNo { get; set; }
    }
}
