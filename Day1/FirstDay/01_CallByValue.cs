using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDay
{
   
    class CallByValue
    {
        // User defined function  
        public void Show(int val)
        {
            val *= val; // Manipulating value  
            Console.WriteLine("Value inside the show function " + val);
            // No return statement  
        }

        static void Main(string[] args)
        {
            int val = 50;
            CallByValue callByValue = new CallByValue(); // Creating Object  
            Console.WriteLine("Value before calling the function " + val);
            callByValue.Show(val); // Calling Function by passing value            
            Console.WriteLine("Value after calling the function " + val);
            Console.ReadLine();
        }
    }
}
