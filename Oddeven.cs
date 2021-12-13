using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Oddeven
    {
        public void oddeven()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i <= n; i++)
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
        }
    }
}
