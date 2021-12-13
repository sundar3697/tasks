using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Reversearray
    {
        public void reversearray()
        {
            int[] a = { 1, 2, 3, 4, 5 };
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
            Console.WriteLine("reverse array");
            for (int k = a.Length - 1; k >= 0; k--)
            {
                Console.WriteLine("{0}", a[k]);
            }
            int[] b = new int[5];
            Console.WriteLine("\n enter dynamic elements");
            for (int j = 0; j < b.Length; j++)
            {
                b[j] = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("\n given dynamic elements are");
            for (int j = 0; j < b.Length; j++)
            {
                Console.WriteLine("{0}", b[j]);
            }
        }
    }
}
