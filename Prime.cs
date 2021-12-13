using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Prime
    {
        public void prime()
        {
            int n,  count;
            Console.Write("enter number \t");
            n = int.Parse(Console.ReadLine());
                  count = 0;
                
                    for (int i = 1; i <= n; i++)
                    {
                        if (n % i == 0)
                            count++;
                    }
                    if (count == 2)
                    {
                        Console.Write("\npime = {0}", n);
                    }

                
            
        }
    }
}
