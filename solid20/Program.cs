﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace solid20
{
    /// <summary>
    /// דוגמא של מאפיין property 
    /// מקביל לדוגמא EX95
    /// </summary>
    class MyClass
    {
        private int m_x;
        public int X
        {
            get { return m_x; }
            set { m_x = value; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            myClass.X = 8;
            Console.WriteLine(myClass.X);
        }
    }
}
