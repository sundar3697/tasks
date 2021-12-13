using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class A
    {
        
        public  A()
        {
            Console.WriteLine ("A");
        }
        void display()
        {
            Console.WriteLine("A1");
        }
       
    }
    class B:A
    {
        public  B()
        {
            Console.WriteLine ("b");
        }
        void display()
        {
            Console.WriteLine("B1");
        }
    }

    class C:B
    {
        public  C()
        {
            Console.WriteLine ("c");
        }
        void display()
        {
            Console.WriteLine("c1");
        }
    }
}
