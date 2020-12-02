using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceEx
{
    class Program
    {
        static void Main(string[] args)
        {
            // DerivedClass obj = new DerivedClass();
            DerivedClass obj = new DerivedClass(11,22);
            Console.ReadLine();
        }
    }

    //class BaseClass
    //{
    //    public int i;
    //    public BaseClass()
    //    {
    //        i = 10;
    //        Console.WriteLine("base class");
    //    }
    //    public BaseClass(int i)
    //    {
    //        Console.WriteLine("param base class");
    //        this.i = i;
    //    }
    //}
    //class DerivedClass : BaseClass
    //{
    //    public int j;
    //    public DerivedClass()
    //    {
    //        j = 20;
    //        Console.WriteLine("derived class");
    //    }
      
    //    public DerivedClass(int i, int j) : base(i)
    //    {
    //        Console.WriteLine("param derived class");   
    //        this.j = j;
    //    }
    //} 
}
