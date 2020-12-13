﻿using System;

namespace MyAttributes
{
   
        [System.AttributeUsage(System.AttributeTargets.Class |
                       System.AttributeTargets.Struct, AllowMultiple = true, Inherited = true)]
        public class Attribute1 : System.Attribute
        {
            public string Name { get; set; }
            public Attribute1(string Name)
            {
                this.Name = Name;
            }
        }
    
}