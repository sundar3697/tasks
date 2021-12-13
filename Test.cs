using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Test
    {
        public Test(string messege)
        {
            Console.WriteLine(messege);
        }
    }

    class Btest:Test
    {
        public  Btest() : base ("hello A")
        { 
            Console.WriteLine("B");
        }
    }

}
