using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDay
{
    class OutParameter
    {
        // User defined function  
        public void Show(out int val) // Out parameter  
        {
            int square = 5;
            val = square;
            val *= val; // Manipulating value  
        }
        // Main function, execution entry point of the program  
        static void Main(string[] args)
        {
            int val = 50;
            OutParameter outParameter = new OutParameter(); // Creating Object  
            Console.WriteLine("Value before passing out variable " + val);
            outParameter.Show(out val); // Passing out argument  
            Console.WriteLine("Value after recieving the out variable " + val);

            Console.ReadLine();
        }
    }
}
