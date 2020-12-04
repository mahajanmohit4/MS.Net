using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueType
{
    class StructEx
    {
        static void Main()
        {
            //StructName name;
            //name.i = 100;

            StructName sname = new StructName(11);

            Console.WriteLine(sname.i);

            Console.ReadLine();
        }
    }

    public struct StructName
    {
        public StructName(int i)
        {
            this.i = i;
        }
       public  int i;
    }
}
