using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Manager");
            Manager mg = new Manager("Hello","MOhit",11,17000000);
            Console.WriteLine(mg.Name + "   " + mg.BasicSal);
            Console.WriteLine("Net sal : " + mg.calcNetSalary());
            

            Console.WriteLine("----------------------------------------");
            GeneralManager gmg = new GeneralManager("Hello", "Hello", "MOHIT", 12, 16000000);
            Console.WriteLine(gmg.Name + "   " + gmg.BasicSal);
            Console.WriteLine("Net sal : " + gmg.calcNetSalary());
            
            Console.WriteLine("----------------------------------------");
            CEO c = new CEO("MOHIT", 13, 20000000);
            Console.WriteLine(c.Name + "   " + c.BasicSal);
            Console.WriteLine("Net sal : " + c.calcNetSalary());
            Console.ReadLine();

        }
    }

    public abstract class Employee
    {
        private string name;
        private int empNO;
        public static int id;
        private short deptNo;
        private  decimal basicSal;
        public abstract decimal calcNetSalary();
        public string Name
        {
            get { return name; }
            set { if (value == null) Console.WriteLine("invalid name"); else name = value; }
        }
        public int EmpNo
        {
            get;           
        }

        public short DeptNo
        {
            get { return deptNo; }
            set { if (value > 0) deptNo = value; else Console.WriteLine("invalid dept id"); }
        }
        public abstract decimal BasicSal
        {
            get;
            set;
        }
        public Employee(string name, short deptNo, decimal basicSal)
        {
            id++;
            this.EmpNo = id;
            this.Name = name;
            this.DeptNo = deptNo;
            this.BasicSal = basicSal;
        }
    }
    public class Manager : Employee
    {
        private string designation;
        public string Designation
        {
            get { return designation; }
            set { if (value == null) Console.WriteLine("invalid name"); else designation = value; }
        }

        public override decimal BasicSal { get; set; }

        public Manager(string designation, string name, short deptNo, decimal basicSal):base(name,deptNo,basicSal)
        {
            this.Designation = designation;
        }
        public override decimal calcNetSalary()
        {
            double Diduction = 2000;
            decimal netSal = BasicSal - (decimal)Diduction;
            return netSal;
        }
    }

    public class GeneralManager : Manager
    {
        private string perks;
        public string Perks
        {
            get { return perks; }
            set { perks = value; }
        }
       
        public GeneralManager(string perks, string designation, string name, short deptNo, decimal basicSal):base(designation, name, deptNo, basicSal)
        {
            this.Perks = perks;
        }
        public override decimal calcNetSalary()
        {
            double Diduction = 2000;
            decimal netSal = BasicSal - (decimal)Diduction;
            return netSal;
        }
    }

    public class CEO : Employee
    {
        public CEO(string name, short deptNo, decimal basicSal): base(name, deptNo, basicSal)
        {

        }

        public override decimal BasicSal { get; set; }

        public sealed override decimal calcNetSalary()
        {
            double Diduction = 2000;
            decimal netSal = BasicSal - (decimal)Diduction;
            return netSal;
        }
    }
}
