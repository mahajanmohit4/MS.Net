using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqQuery
{
    class Program
    {
        static List<Employee> lstEmp = new List<Employee>();
        static List<Department> lstDept = new List<Department>();

        static void Main1(string[] args)
        {
            AddRec();
            var emps = from emp in lstEmp select emp;
            // IEnumerable<Employee> emps = from emp in lstEmp select emp;
            //  List<Employee> emps =(List<Employee>) from emp in lstEmp select emp;

            foreach (Employee emp in emps)
            {
                Console.WriteLine(emp.EmpNo+" "+emp.Name);
            }
            Console.ReadLine();
        }
        static void Main2(string[] args)
        {
            AddRec();
            var emps = from emp in lstEmp select emp.Name;
            // IEnumerable<Employee> emps = from emp in lstEmp select emp;
            //  List<Employee> emps =(List<Employee>) from emp in lstEmp select emp;

            foreach (string name in emps)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();
        }
        static void Main3(string[] args)
        {
            AddRec();
            var emps = from emp in lstEmp select emp;
            // IEnumerable<Employee> emps = from emp in lstEmp select emp;
            //  List<Employee> emps =(List<Employee>) from emp in lstEmp select emp;

            foreach (var emp in emps)
            {
                Console.WriteLine(emp);
            }
            Console.ReadLine();
        }
        static void Main4(string[] args)
        {
            AddRec();
            var emps = from emp in lstEmp select new { emp.Name, emp.Basic };
            // IEnumerable<Employee> emps = from emp in lstEmp select emp;
            //  List<Employee> emps =(List<Employee>) from emp in lstEmp select emp;

            foreach (var emp in emps)
            {
                Console.WriteLine(emp.Name+" "+emp.Basic);
            }
            Console.ReadLine();
        }
        static void Main5(string[] args)
        {
            AddRec();
            var emps = from emp in lstEmp 
                       where emp.Basic>1000 
                       select emp ;
           

            foreach (var emp in emps)
            {
                Console.WriteLine(emp.Basic);
            }
            Console.ReadLine();
        }
        static void Main6(string[] args)
        {
            AddRec();
            //var emps = from emp in lstEmp
            //           where emp.Basic > 1000 && emp.Basic < 1200
            //           select emp;

            //var emps = from emp in lstEmp
            //           where emp.Name.StartsWith("a")
            //           select emp;

            //var emps = from emp in lstEmp
            //           orderby emp.Name descending
            //           select emp;

            var emps = from emp in lstEmp
                       orderby emp.DeptNo, emp.Name descending
                       select emp;

            foreach (var emp in emps)
            {
                Console.WriteLine(emp.Name+" "+emp.Basic);
            }
            Console.ReadLine();
        }
        static void Main7(string[] args)
        {
            AddRec();
           

            var emps = from emp in lstEmp
                       join dept in lstDept
                            on emp.DeptNo equals dept.DeptNo                       
                       select new {dept.DeptName,emp.Name };

            foreach (var emp in emps)
            {
                Console.WriteLine(emp.Name);
            }
            Console.ReadLine();
        }
        static Employee GetEmployee(Employee obj)
        {
            return obj;
        }
        static void Main8(string[] args)
        {
            AddRec();


            //var emps = from emp in lstEmp                
            //           select emp;

            //passing function as a parameter to Select
            // var emps = lstEmp.Select(GetEmployee);

            // passing ann\on method as a parameter to select
            //var emps = lstEmp.Select(delegate(Employee obj)
            //{
            //    return obj;
            //});

            //using a lambda insted of anon method
            var emps = lstEmp.Select(emp => emp);

            foreach (var emp in emps)
            {
                Console.WriteLine(emp.Name);
            }
            Console.ReadLine();
        }
        static void Main9(string[] args)
        {
            AddRec();


            //using a lambda insted of anon method
            // var emps = lstEmp.Select(emp => emp);
            // var emps = lstEmp.Where(emp=>emp.Basic>1000);
            // var emps = lstEmp.Where(emp => emp.Basic > 1000).Select(emp => emp);
            
            //var emps = lstEmp.Where(emp => emp.Basic > 1000).Select(emp => emp.Name);
            var emps = lstEmp.Where(emp => emp.Basic > 1000).Select(emp => new { emp.Name,emp.Basic});

            var emps1 = lstEmp.Select(emp => emp).Where(emp => emp.Basic > 1000);
            var emps2 = lstEmp.Select(emp => emp.Name);


            foreach (var emp in emps)
            {
                Console.WriteLine(emp.Name+"  "+emp.Basic);
            }
            Console.ReadLine();
        }
        static void Main10(string[] args)
        {
            AddRec();



            //var emps1 = lstEmp.Select(emp => emp).Where(emp => emp.Basic > 1000);
            //var emps2 = lstEmp.Select(emp => emp.Name);

            // var emps = lstEmp.OrderBy(emp => emp.Name).Where(emp => emp.Basic > 1000);
            var emps = lstEmp.OrderBy(emp => emp.Name).OrderByDescending(emp => emp.Name);
            foreach (var emp in emps)
            {
                Console.WriteLine(emp.Name + "  " + emp.Basic);
            }
            Console.ReadLine();
        }
        static void Main11(string[] args)
        {
            AddRec();
            //var emps = from emp in lstEmp
            //           join dept in lstDept
            //                on emp.DeptNo equals dept.DeptNo
            //           select new { dept.DeptName, emp.Name };

            var emps1 = lstEmp.Join(lstDept,
                emp => emp.DeptNo,
                dept => dept.DeptNo,
                (emp,dept) => new { dept.DeptName, emp.Name, emp.Basic }
                );

            foreach (var emp in emps1)
            {
                Console.WriteLine(emp.Name + "  " + emp.Basic+"  "+emp.DeptName);
            }
            Console.ReadLine();
        }
        static void Main12(string[] args)
        {
            AddRec();
            //deferrd execution
            //var emps1 = (List<Employee>)from emp in lstEmp select emp;
            //emps1.RemoveAt(0);

            var emps1 = from emp in lstEmp select emp;
            lstEmp.RemoveAt(0);
            lstEmp.Add(new Employee { EmpNo = 44, DeptNo = 333, Name = "ddd", Gender = 'f', Basic = 123 });

            foreach (var emp in emps1)
            {
                Console.WriteLine(emp.Name + "  " + emp.Basic);
            }
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            AddRec();
            //deferrd execution
            //var emps1 = (List<Employee>)from emp in lstEmp select emp;
            //emps1.RemoveAt(0);

            var emps1 = from emp in lstEmp select emp;
            // immediate execution
            emps1 = emps1.ToList();
            
            lstEmp.RemoveAt(0);
            lstEmp.Add(new Employee { EmpNo = 44, DeptNo = 333, Name = "ddd", Gender = 'f', Basic = 123 });

            foreach (var emp in emps1)
            {
                // Console.WriteLine(emp.Name + "  " + emp.Basic);
                Console.WriteLine(emp.ToString());
            }
            Console.ReadLine();
        }
        public static void AddRec()
        {
            lstDept.Add(new Department { DeptNo = 100, DeptName = "aa" });
            lstDept.Add(new Department { DeptNo = 111, DeptName = "bb" });
            lstDept.Add(new Department { DeptNo = 222, DeptName = "cc" });
            lstDept.Add(new Department { DeptNo = 333, DeptName = "dd" });

            lstEmp.Add(new Employee { EmpNo = 11, DeptNo = 111, Name = "aaa", Gender = 'm', Basic = 1234 });
            lstEmp.Add(new Employee { EmpNo = 22, DeptNo = 111, Name = "bbb", Gender = 'f', Basic = 123 });
            lstEmp.Add(new Employee { EmpNo = 33, DeptNo = 222, Name = "ccc", Gender = 'm', Basic = 1234 });
            lstEmp.Add(new Employee { EmpNo = 44, DeptNo = 333, Name = "ddd", Gender = 'f', Basic = 123 });

        }
    }
    public class Department
    {
        public int DeptNo { get; set; }
        public string DeptName { get; set; }
    }
    public class Employee
    {
        public int EmpNo { get; set; }
        public int DeptNo { get; set; }
        public string Name { get; set; }
        public char Gender { get; set; }
        public decimal Basic { get; set; }


        public override string ToString() => EmpNo + " " + DeptNo + " " + Name + " " + Basic;
    }
}
