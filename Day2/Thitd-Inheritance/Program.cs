using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace Thitd_Inheritance
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            //BaseClass o = new BaseClass();
//            DerivedClass o1 = new DerivedClass();
            
//        }
//    }

//    public class BaseClass
//    {
//        public int a;

//    }
//    public class DerivedClass : BaseClass
//    {
//        public int b;

//    }
//}


namespace Thitd_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // BaseClass o = new BaseClass();
            DerivedClass o1 = new DerivedClass();
            // AccessSpecifires.BaseClass o = new AccessSpecifires.BaseClass();
            
            Console.ReadLine();
        }
    }

    /* public class BaseClass
    {
        public int Public;
        private int Private;
        protected int Protected;
        internal int Internal;
        protected internal int Protected_Internal;

    } */
    public class DerivedClass : AccessSpecifires.BaseClass
    {
        void Derived()
        {
            /*
            this.Public 
            this.Protected
            this.Internal
            this.Protected_Internal
            */
            Console.WriteLine(this.Protected);
            Console.WriteLine(this.Protected_Internal);
            Console.WriteLine(this.Public);
            
        }

    }
}
