using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class FibonaccoSeries
    {
        public void fibonacci()
        {
            double a = 0, b = 1, c;
            for (int i = 0; i <= 20; i++)
            {
                c = a + b;
                a = b;
                b = c;
                Console.WriteLine(a);
            }
        }
    }
}
