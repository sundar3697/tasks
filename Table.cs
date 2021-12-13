using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Table
    {
        int b,i,c;
        int a = int.Parse(Console.ReadLine());
        public void tab()
        {
            for (i=0;i<=30;i++)
            {
                b = a*i;
                Console.Write(a);
                Console.Write("x");
                Console.Write(i);
                Console.Write("=");
                Console.WriteLine(b);
            }

            c = 25 + 54 * 456 - 844 / 7458 * 9512 + 85479 - 587456 / 8745-11000*10/100-10000-10000-88000/900;
            Console.WriteLine(c);
        }
    }
}
