using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDisposableExample
{
    class Program
    {
        static void Main1()
        {
            Class1 o = new Class1();
            
                o.Display();

            o.Display();
            o.Dispose();
            o.Display();
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            using (Class1 o = new Class1())
            {
                o.Display();
            }
            //    o.Display();
            //o.Dispose();
            //o.Display();
            Console.ReadLine();
        }

        public class Class1 : IDisposable
        {
            public void Display()
            {
                CheckForDisposed();
                Console.WriteLine("c1 Display");
            }

            private bool isDispose = false;
            private void CheckForDisposed()
            {
                if (isDispose)
                    throw new ObjectDisposedException("Class1");
            }
            public void Dispose()
            {
                Console.WriteLine("Dispose free resouce");
                isDispose = true;
            }
        }
    }
}
