using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDay
{
    public class Constructor
    {
        public Constructor()
        {
            Console.WriteLine("Default Constructor Invoked");
        }
        public static void Main(string[] args)
        {
            Constructor c1 = new Constructor();
            Constructor c2 = new Constructor();

            Console.WriteLine("-------------------------------");
            Employee e1 = new Employee(101, "Sonoo", 890000f);
            Employee e2 = new Employee(102, "Mahesh", 490000f);
            e1.display();
            e2.display();

        }
    }

    public class Employee
    {
        public int id;
        public String name;
        public float salary;
        public Employee(int i, String n, float s)
        {
            id = i;
            name = n;
            salary = s;
        }
        public void display()
        {
            Console.WriteLine(id + " " + name + " " + salary);
        }
    }
}
