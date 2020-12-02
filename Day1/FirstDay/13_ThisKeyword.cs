using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDay
{
    class ThisKeyword
    {
        public static void Main(string[] args)
        {
            Employee2 e1 = new Employee2(101, "Sonoo", 890000f);
            Employee2 e2 = new Employee2(102, "Mahesh", 490000f);
            e1.display();
            e2.display();

        }
    }
    public class Employee2
    {
        public int id;
        public String name;
        public float salary;
        public Employee2(int id, String name, float salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }
        public void display()
        {
            Console.WriteLine(id + " " + name + " " + salary);
        }
    }
}
