using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDay
{
    class Params
    {
       
        // Main function, execution entry point of the program  
        static void Main(string[] args)
        {
            Params.Show(2, 4, 6, 8, 10, 12, 14); // Passing arguments of variable length  
            Params.Show("Ramakrishnan Ayyer", "Ramesh", 101, 20.50, "Peter", 'A'); 
            // Passing arguments of variable length  
        }
        static void Show(params int[] val) // Params Paramater  
        {
            for (int i = 0; i < val.Length; i++)
            {
                Console.WriteLine(val[i]);
            }
        }
        static void Show(params object[] items) // Params Paramater  
        {
            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine(items[i]);
            }
        }
    }
}
