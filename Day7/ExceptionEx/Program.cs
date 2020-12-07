using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionEx
{
    class Program
    {
        static void Main1(string[] args)
        {
            //DoSometing();
            Console.ReadLine();
        }
        static void Main2(string[] args)
        {
            Class1 obj = new Class1();

            try
            {
                int x = Convert.ToInt32(Console.ReadLine());
                obj.P1 = 100 / x;
                Console.WriteLine(obj.P1);
                Console.WriteLine("NO Exceptino");
            }
            catch 
            {
                Console.WriteLine("Exception occured");
            }

            Console.ReadLine();
        }
        static void Main3(string[] args)
        {
            Class1 obj = new Class1();

            try
            {
                int x = Convert.ToInt32(Console.ReadLine());
                obj.P1 = 100 / x;
                Console.WriteLine(obj.P1);
                Console.WriteLine("NO Exceptino");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("DivideByZeroException Exception occured");
            }
            catch(FormatException ex)
            {
                Console.WriteLine("FormatException");
            }
            catch (StackOverflowException ex)
            {
                Console.WriteLine("StackOverflowException");
            }

            Console.ReadLine();
        }

        static void Main4(string[] args)
        {
            Class1 obj = new Class1();

            try
            {
                int x = Convert.ToInt32(Console.ReadLine());
                obj.P1 = 100 / x;
                Console.WriteLine(obj.P1);
                Console.WriteLine("NO Exceptino");
            }
            catch(ArithmeticException ex)
            //catch (DivideByZeroException ex)
            {
                Console.WriteLine("DivideByZeroException Exception occured");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("FormatException");
            }
            catch (StackOverflowException ex)
            {
                Console.WriteLine("StackOverflowException");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Exception !!");
            }

            Console.ReadLine();
        }
        static void Main5(string[] args)
        {
            Class1 obj = new Class1();

            try
            {
                obj = null;
                int x = Convert.ToInt32(Console.ReadLine());
                obj.P1 = 100 / x;
                Console.WriteLine(obj.P1);
                Console.WriteLine("NO Exceptino");
            }
            catch (ArithmeticException ex)
            //catch (DivideByZeroException ex)
            {
                Console.WriteLine("DivideByZeroException Exception occured");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("FormatException");
            }
            catch (StackOverflowException ex)
            {
                Console.WriteLine("StackOverflowException");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception !!");
            }
            finally
            {
                Console.WriteLine("Hello Finaly");
            }

            Console.ReadLine();
        }
        static void Main6(string[] args)
        {
            Class1 obj = new Class1();

            try
            {
                obj = null;
                int x = Convert.ToInt32(Console.ReadLine());
                obj.P1 = 100 / x;
                Console.WriteLine(obj.P1);
                Console.WriteLine("NO Exceptino");
            }
            catch (ArithmeticException ex)
            //catch (DivideByZeroException ex)
            {
                Console.WriteLine("DivideByZeroException Exception occured");
            }
            catch (FormatException ex)
            {
                try
                {
                    obj = null;
                    int x = Convert.ToInt32(Console.ReadLine());
                    obj.P1 = 100 / x;
                    Console.WriteLine(obj.P1);
                    Console.WriteLine("NO Exceptino");
                }
                catch 
                //catch (DivideByZeroException ex)
                {
                    Console.WriteLine("DivideByZeroException Exception occured");
                }
                finally
                {
                    Console.WriteLine("Hello Finaly");
                }

                Console.WriteLine("FormatException");
            }
            catch (StackOverflowException ex)
            {
                Console.WriteLine("StackOverflowException");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception !!");
            }
            finally
            {
                Console.WriteLine("Hello Finaly");
            }

            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            Class1 obj = new Class1();

            try
            {
                obj = null;
                int x = Convert.ToInt32(Console.ReadLine());
                obj.P1 = 100 / x;
                Console.WriteLine(obj.P1);
                Console.WriteLine("NO Exceptino");
            }
            catch (ArithmeticException ex)
            //catch (DivideByZeroException ex)
            {
                Console.WriteLine("DivideByZeroException Exception occured");
            }
            catch (FormatException ex)
            {
                try
                {
                    obj = null;
                    int x = Convert.ToInt32(Console.ReadLine());
                    obj.P1 = 100 / x;
                    Console.WriteLine(obj.P1);
                    Console.WriteLine("NO Exceptino");
                }
                //catch (ArithmeticException ex)
                catch
                {
                    Console.WriteLine("DivideByZeroException Exception occured");
                }
                finally
                {
                    Console.WriteLine("Hello Finaly");
                }

                Console.WriteLine("FormatException");
            }
            catch (StackOverflowException ex)
            {
                Console.WriteLine("StackOverflowException");
            }
            catch (InvalidBasicException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Hello Finaly");
            }

            Console.ReadLine();
        }
        public class Class1
        {
            private int p1;
            public int P1 { 
                get { return p1; }
                set { 
                    if (value < 100) p1 = value;
                    else 
                    {
                        Exception ex;
                        // ex = new Exception();
                        // ex = new Exception("Invalid P1");
                        ex = new InvalidBasicException("Invalid P1")
                        throw ex;
                        //Console.WriteLine("invalid value");
                    }  
                } 
            }
        }
        static void DoSometing()
        {
            int i = 0;
            i = i / i;
        }
    }
}
