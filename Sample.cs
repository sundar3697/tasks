using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Sample
    {
        int a, b, c;
        public Sample (int x, int y)
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


    }
}
