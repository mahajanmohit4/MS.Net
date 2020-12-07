using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            ExClass eobj = new ExClass();
            try
            {
                int x = Convert.ToInt32(Console.ReadLine());
                eobj.P1 = x;
                //eobj.P1 = 100 / x;
                Console.WriteLine(eobj.P1);
                Console.WriteLine("NO Exceptino");
            }
            catch(InvalidP1Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(FormatException ex)
            {
                // Console.WriteLine("Format Exception");
                Console.WriteLine(ex.Message);
            }
            catch(NullReferenceException ex)
            {
                Console.WriteLine("Null Reference Exception");
            }
            //catch(Exception ex)
            //{
            //    Console.WriteLine("Exception ");
            //}
            finally
            {
                Console.WriteLine("Finally Runs !!!");
            }
            Console.ReadLine();
        }

        public class ExClass
        {
            private int p1;
            public int P1
            {
                get { return p1; }
                set {
                    if (value < 100) p1 = value;
                    else
                    {
                       // Console.WriteLine("invalid value");
                        Exception ex;
                        //ex = new Exception();
                        //ex = new Exception("Invalid P1");
                        ex = new InvalidP1Exception("Invalid P1");
                        throw ex;

                    }
                }
            }
        }

        public class InvalidP1Exception : ApplicationException
        {
            public InvalidP1Exception(string massage) : base(massage)
            {

            }
        }

    }
}




namespace ExceptionHandling2
{
    class Program
    {
        static void Main2()//try with multiple catch blocks
        {
            Class1 obj = new Class1();
            try
            {
                int x = Convert.ToInt32(Console.ReadLine());
                obj.P1 = x;
                Console.WriteLine(obj.P1);
                Console.WriteLine("No Exceptions");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("FormatException occurred");
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("NRException occurred");
            }
            catch (InvalidP1Exception ex)
            {
                //Console.WriteLine("Invalid input");
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }

    public class Class1
    {
        private int p1;
        public int P1
        {
            get
            {
                return p1;
            }
            set
            {
                if (value < 100)
                    p1 = value;
                else
                {
                    //Console.WriteLine("invalid P1"); dont EVER do this

                    Exception ex;
                    //ex = new Exception();
                    //ex = new Exception("Invalid P1");
                    ex = new InvalidP1Exception("Invalid P1");

                    throw ex;
                }
            }
        }
    }
    //public class InvalidP1Exception : ApplicationException
    //{
    //    public InvalidP1Exception(string message) : base(message)
    //    {

    //    }
    //}


}


