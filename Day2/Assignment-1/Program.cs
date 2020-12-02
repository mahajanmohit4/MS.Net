using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the name of the Employee : ");
            string empName = Console.ReadLine();
            Console.Write("Enter Basic salary of Employee : ");
            double basicSalary = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Dept No of Employee : ");
            short deptNo = Convert.ToSByte(Console.ReadLine());

            //Employee emp = new Employee();
            //emp.EmpName = empName;
            //emp.BasicSalary = basicSalary;

            //Employee emp1 = new Employee(empName, basicSalary);
            Employee emp1 = new Employee("Mohit", 12311.1, 11);
            Employee emp2 = new Employee("Mohit", 12311.11);
            Employee emp3 = new Employee("Mohit");
            //Employee emp4 = new Employee();

            //Console.WriteLine("Emp Number is : " + emp1.EmpNo);
            //Console.WriteLine("Emp Name is : " + emp1.EmpName);

            //Console.WriteLine("Emp Salary is : " + emp1.BasicSalary);
            //Console.WriteLine("Net Salary is : " + emp1.getNetSalary());
            Console.ReadLine();
        }
    }

    class Employee
    {
        private string empName;
        private static int empNo=0;
        private double basicSalary;
        private short deptNo;

        static Employee()
        {

            empNo++;
        }

        public Employee(string empName=0 , double basicSalary=0, short deptNo=0)
        {
            this.empName = empName;
            this.basicSalary = basicSalary;
            this.deptNo = deptNo;
        }
       

        public string EmpName
        {
            get { return empName; }
            set 
            {
                if (value == null)
                    Console.WriteLine("Invalid Name !!");
                else
                    empName = value;

            }
        }
        public int EmpNo
        {
            get { return empNo; }
        }

        public double BasicSalary
        {
            get { return basicSalary; }
            set
            {
                if (value > 1000 && value < 1000000)
                    basicSalary = value;
                else
                    Console.WriteLine("Invalid salary !!");
            }
        }
        public short DeptNo
        {
            get { return deptNo; }
            set
            {
                if (value > 0)
                    deptNo = value;
                else
                    Console.WriteLine("Invalid Depatment Number !!");
            }
        }

        public double getNetSalary()
        {
            double tax = 1000;
            double salary = basicSalary - tax;
            return salary;
        }

    }
}
