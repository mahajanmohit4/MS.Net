using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDay
{
    class Aggrigation
    {
        public static void Main(string[] args)
        {
            Address1 a1 = new Address1("G-13, Sec-3", "Noida", "UP");
            Employee6 e1 = new Employee6(1, "Sonoo", a1);
            e1.display();
        }
    }

    public class Address1
    {
        public string addressLine, city, state;
        public Address1(string addressLine, string city, string state)
        {
            this.addressLine = addressLine;
            this.city = city;
            this.state = state;
        }
    }
    public class Employee6
    {
        public int id;
        public string name;
        public Address1 address;//Employee HAS-A Address  
        public Employee6(int id, string name, Address1 address)
        {
            this.id = id;
            this.name = name;
            this.address = address;
        }
        public void display()
        {
            Console.WriteLine(id + " " + name + " " +
              address.addressLine + " " + address.city + " " + address.state);
        }
    }
}
