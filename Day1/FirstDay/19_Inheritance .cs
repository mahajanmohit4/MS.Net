using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDay
{
    class Inheritance
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Single Level Inheritance .............");
            Programmer p1 = new Programmer();

            Console.WriteLine("Salary: " + p1.salary);
            Console.WriteLine("Bonus: " + p1.bonus);

            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Muliple Level Inheritace .....................");

            BabyDog d1 = new BabyDog();
            d1.eat();
            d1.bark();
            d1.weep();

        }

        public class Employee5
        {
            public float salary = 40000;
        }
        public class Programmer : Employee5
        {
            public float bonus = 10000;
        }

        // Multi Level Inheritance
        public class Animal
        {
            public void eat() { Console.WriteLine("Eating..."); }
        }
        public class Dog : Animal
        {
            public void bark() { Console.WriteLine("Barking..."); }
        }
        public class BabyDog : Dog
        {
            public void weep() { Console.WriteLine("Weeping..."); }
        }
    }
}
