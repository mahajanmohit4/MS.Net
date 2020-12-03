using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main1()
        {
            Class1 o = new Class1();
            o.insert();
            o.update();
            o.delete();
            o.display();

            Console.WriteLine("----------------");
            // method 2
            IDbFunction oIDb;
            oIDb = o;
            oIDb.delete();

            Console.WriteLine("----------------");
            // method 3
            ((IDbFunction)o).delete();

            insertMethod(o);
            Console.ReadLine();
        }

        static void Main2()
        {
            Class1 o = new  Class1();
            IFileFunction oifile;
            oifile = o;
            oifile.delete();
            oifile.open();
            Console.ReadLine();
        }
        static void Main()
        {
            Class2 o = new Class2();
            IDemo idemo = new Class2();
            idemo.delete();
            Console.ReadLine();
        }

        static void insertMethod(IDbFunction idbf)
        {
            idbf.delete();
        }
        public interface IDbFunction
        {
            void insert();
            void update();
            void delete();
        }

        public interface IFileFunction
        {
            void open();
            void close();
            void delete();
        }
        public class Class1 : IDbFunction,IFileFunction
        {
            public void delete()
            {
                Console.WriteLine("delete");
            }

            public void insert()
            {
                Console.WriteLine("insert");
            }

            public void update()
            {
                Console.WriteLine("update");
            }
            public void display()
            {
                Console.WriteLine("display");
            }

            void IFileFunction.open()
            {
                Console.WriteLine("open");
            }

            void IFileFunction.close()
            {
                Console.WriteLine("close");
            }

            void IFileFunction.delete()
            {
                Console.WriteLine("file delete");
            }
        }
        public interface IDemo : IFileFunction
        {
            void hello();
        }

        public class Class2 : IDemo
        {
            public void close()
            {
                Console.WriteLine("close class2");
            }

           

            public void hello()
            {
                Console.WriteLine("hello class2");
            }

            public void open()
            {
                Console.WriteLine("open class2");
            }

            

            void IFileFunction.delete()
            {
                Console.WriteLine("Delete form Class2");
            }

           

           
        }

    }
}

