using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class InterfacePractice
    {
        static void Main()
        {
            Class01 obj = new Class01();
            obj.insert();
            Console.WriteLine("---------------------");
            IFirst i = new DerivedClass01();
            i.insert();
            Console.ReadLine();
        }
    }
    public interface IFirst
    {
        void insert();
        void update();
        void delete();
    }
    public class Class01 : IFirst
    {
        public void delete()
        {
            throw new NotImplementedException();
        }

        public void insert()
        {
            Console.WriteLine(" Insert Class01 ");
        }

        public void update()
        {
            throw new NotImplementedException();
        }
    }
    public class DerivedClass01 : Class01,IFirst
    {
        public new void delete()
        {
            throw new NotImplementedException();
        }

        public new void insert()
        {
            Console.WriteLine(" Insert Derived Class01 ");
        }

        public new void update()
        {
            throw new NotImplementedException();
        }
    }
}
