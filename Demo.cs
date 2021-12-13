using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Demo
    {
        int a, b, c;
        public Demo(int a,int b)
        {
            this.a = a;
            this.b = b;
        }
        public void message()
        {
            c = a + b;
            Console.WriteLine("welcome");
            Console.WriteLine("sum ={0}", c);
        }


    }
}

/*
        public Demo(int a, int b)
        {
            a = x;
            b = y;
        }
        public void message()
        {
            c = a + b;
            Console.WriteLine("welcome");
            Console.WriteLine("sum ={0}", c);
        }
*/


/*      public Demo()
        {
            Console.WriteLine("hi");
        }
        public void message()
        {
            
            Console.WriteLine("welcome");
            
        }
*/
