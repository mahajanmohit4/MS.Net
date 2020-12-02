using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Assignment
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Assignment");
            Console.ReadLine();
        }
    }

    //class Employee1
    //{
    //    private string empName;
    //    private static int empNo = 0;
    //    private double basicSalary;
    //    private short deptNo;

    //    static Employee1()
    //    {

    //        empNo++;
    //    }

    //    //public Employee1(string empName = 0, double basicSalary = 0, short deptNo = 0)
    //    //{
    //    //    this.empName = empName;
    //    //    this.basicSalary = basicSalary;
    //    //    this.deptNo = deptNo;
    //    //}


    //    public string EmpName
    //    {
    //        get { return empName; }
    //        set
    //        {
    //            if (value == null)
    //                Console.WriteLine("Invalid Name !!");
    //            else
    //                empName = value;

    //        }
    //    }
    //    public int EmpNo
    //    {
    //        get { return empNo; }
    //    }

    //    public double BasicSalary
    //    {
    //        get { return basicSalary; }
    //        set
    //        {
    //            if (value > 1000 && value < 1000000)
    //                basicSalary = value;
    //            else
    //                Console.WriteLine("Invalid salary !!");
    //        }
    //    }
    //    public short DeptNo
    //    {
    //        get { return deptNo; }
    //        set
    //        {
    //            if (value > 0)
    //                deptNo = value;
    //            else
    //                Console.WriteLine("Invalid Depatment Number !!");
    //        }
    //    }

    //    public double getNetSalary()
    //    {
    //        double tax = 1000;
    //        double salary = basicSalary - tax;
    //        return salary;
    //    }

    }
}
