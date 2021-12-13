using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Armstrong
    {
        public void armstrong()
        {
            int a, n, x, r = 0;
            for (a = 1; a <= 1000; a++)
            {
                n = a;
                r = 0;
                while (n != 0)
                {
                    x = n % 10;
                    r = r + (x * x * x);
                    n = n / 10;
                }
                if (r == a)
                {
                    Console.WriteLine("{0}", a);
                }
            }
        }
    }
}
