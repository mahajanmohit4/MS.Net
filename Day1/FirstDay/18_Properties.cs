using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDay
{
    class Properties
    {
        public static void Main(string[] args)
        {
            Employee4 e1 = new Employee4();
            e1.Name = "Sonoo Jaiswal";
            Console.WriteLine("Employee Name: " + e1.Name);

        }
    }
    public class Employee4
    {
        private string name;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                //name = value;
                name = value + " Hello World ";
            }
        }
    }
}
