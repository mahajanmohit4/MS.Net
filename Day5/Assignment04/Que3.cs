using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment04
{
    class Que3
    {
        static void Main1()
        {
            Student s1 = new Student("Mohit", 11, 1000);
            Student s2 = new Student("Ritsh", 22, 900);
            Student s3 = new Student("Abhi", 33, 800);
            Student s4 = new Student("Harsh", 44, 800);
            Student s5 = new Student("Nakul", 55, 700);

            Student[] arr = { s1, s2, s3, s4, s5 };
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i].Name+"  "+ arr[i].RollNo+"  "+ arr[i].Marks);
            }
            Console.ReadLine();
        }


        public struct Student
        {
            private string name;
            private int rollNo;
            private decimal marks;
            private string naw;
            public string Name { get { return name; } set { if (value == null) Console.WriteLine("Invalid Name "); else name = value; } }
            public string Naw { get { return naw; } set { if (value == null) Console.WriteLine("Invalid Name "); else naw = value; } }
            public int RollNo { get { return rollNo; } set { if (value > 0) rollNo = value; else Console.WriteLine("Invalid RollNo"); } }

            public decimal Marks { get; set; }


            public Student(string Name1 = "asdf", int RollNo, decimal Marks)
            {
                this.name = "asd";
                this.rollNo = 11;
                this.marks = 1000;

                this.Name = Name1;
            }

            

           
        }
    }
    
}
