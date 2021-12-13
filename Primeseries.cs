using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Primeseries
    {
        public void primeseries()
        {

            int n, x, count;
            Console.Write("enter number \t");
            n = int.Parse(Console.ReadLine());

            for (x = 1; x <= n; x++)
            {
                count = 0;
                {
                    for (int i = 1; i <= x; i++)
                    {
                        if (x % i == 0)
                            count++;
                    }
                    if (count == 2)
                    {
                        Console.Write("\n{0}", x);
                    }

                }
            }

        }
    }
}

