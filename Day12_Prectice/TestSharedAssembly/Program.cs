﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSharedAssembly
{
    class Program
    {
        static void Main(string[] args)
        {
            SharedAssembly.Class1 obj = new SharedAssembly.Class1();
            Console.WriteLine(obj.Hello());
            Console.ReadLine();
        }
    }
}
