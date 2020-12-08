using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//implicit variable
namespace LanguageFeatures
{
    class Program
    {
        static void Main1(string[] args)
        {
            int i = 11;
            var i2 = 100; // implicit variable
            var s = "Mohit";
            Console.WriteLine(i2.GetType().ToString()) ;
            Console.ReadLine();
        }
        static void Main2(string[] args)
        {
            Class1 o = new Class1();
            o.i = 123;
            o.j = 456;
            Class1 o2 = new Class1{ i = 11, j = 22 };
            Console.ReadLine();
        }
    }
    public class Class1
    {
        public int i;
        public int j;

    }
}

namespace LanguageFeatures3
{
    class Program
    {
        static void Main1(string[] args)
        {
            var myCar = new { Color = "red", Model = "Farrari", Version = "v1" };
            var myCar1 = new { Color = "red2", Model = "Farrari2", Version = "v12", CurentSpeend =222 };

            Console.WriteLine("{0} {1} {2}",myCar.Color,myCar.Model,myCar.Version);


            Console.WriteLine(myCar1.GetType().ToString());
            Console.WriteLine(myCar.GetType().ToString());

            Console.ReadLine();
        }
      
    }

}

namespace LanguageFeatures4
{
    class Program
    {
        static void Main1(string[] args)
        {
            int i = 100;
            i.Display();

            int j = 456;
            j.Display();

            // i = i.Reverse() 
            string s = "aaa";
            s.Show();
            s.Method(2);
            Console.ReadLine();
        }
        static void Main2(string[] args)
        {
            int i = 100;
            i.Display();
            MyExtensionMehtods.Display(i); // Internally it converted to this process
            i.ExtMethod();

            string s = "aaa";
            s.Show();
            MyExtensionMehtods.Show(s);

            s.Method(2);

            Console.ReadLine();
        }
        static void Main3(string[] args)
        {
            ClsMath obj = new ClsMath();
            obj.ExtMethod();
            Console.WriteLine(obj.Add(11, 22));
            Console.ReadLine();
        }
        static int Reverse(int i)
        {
            int r = 0;
            return r;
        }
    }
    public static class MyExtensionMehtods
    {
        public static void ExtMethod(this object o)
        {
            Console.WriteLine(o);
        }
        public static void Display(this int i)
        {
            Console.WriteLine(i);
        }
        public static void Show(this string s)
        {
            Console.WriteLine(s);
        }
        public static void Method(this string s, int i)
        {
            Console.WriteLine(s+i);
        }

    }
    public interface IMathOperation
    {
        int Add(int a, int b);
    }
    public class ClsMath : IMathOperation
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
    }

}

namespace LanguageFeatures5
{
    class Program
    {
        
        static void Main3(string[] args)
        {
            Class1 o = new Class1();
            
            Console.ReadLine();
        }
       
    }
   public partial class Class1
    {
        public int i;
    }
    public partial class Class1
    {
        public int j;
    }

}

namespace LanguageFeatures6
{
    class Program
    {

        static void Main(string[] args)
        {
            Class1 o = new Class1();
            Console.WriteLine(o.Check());
            Console.ReadLine();
        }

    }
    public partial class Class1
    {
        public int i;
        private bool isValid = true;
        partial void Validate();
        public bool Check()
        {
            Validate();

            return isValid;
        }

        
    }
    public partial class Class1
    {
        partial void Validate()
        {
            isValid = false;
            Console.WriteLine("Validateion");
        }
    }

}