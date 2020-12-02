using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDay
{
    class Destructor
    {
        public static void Main(string[] args)
        {
            Employee1 e1 = new Employee1();
            Employee1 e2 = new Employee1();
        }
    }
    public class Employee1
    {
        public Employee1()
        {
            Console.WriteLine("Constructor Invoked");
        }
        ~Employee1()
        {
            Console.WriteLine("Destructor Invoked");
        }
    }
}
