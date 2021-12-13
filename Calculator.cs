using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Calculator
    {
        public void calculator()
        {
            Console.WriteLine("CALCULATOR");
            Console.WriteLine("\n a.ADDDITION \n b.SUBSTRACTION \n c.MULTIPLICATION \n d.DIVISION \n e. EXIT  ");

            Console.WriteLine("ENTER YOUR CHOICE");
            char c = char.Parse(Console.ReadLine());
            switch (c)
            {
                case 'a':
                    Console.WriteLine("ENTER first value");
                    int a = int.Parse(Console.ReadLine());
                    Console.WriteLine("ENTER second value");
                    int b = int.Parse(Console.ReadLine());
                    int d = a + b;
                    Console.WriteLine("ADDITION OF TWO NO{0}", d);
                    break;

                case 'b':
                    Console.WriteLine("ENTER first value");
                    int e = int.Parse(Console.ReadLine());
                    Console.WriteLine("ENTER second value");
                    int f = int.Parse(Console.ReadLine());
                    int g = e - f;
                    Console.WriteLine("SUBSTRACTION OF TWO NO{0}", g);
                    break;

                case 'c':
                    Console.WriteLine("ENTER first value");
                    int h = int.Parse(Console.ReadLine());
                    Console.WriteLine("ENTER second value");
                    int i = int.Parse(Console.ReadLine());
                    double j = h * i;
                    Console.WriteLine("MULTIPLICATION OF TWO NO {0}", j);
                    break;
                case 'd':
                    Console.WriteLine("ENTER first value");
                    int k = int.Parse(Console.ReadLine());
                    Console.WriteLine("ENTER second value");
                    int l = int.Parse(Console.ReadLine());
                    double m = k / l;
                    Console.WriteLine("DIVISION OF TWO NO {0}", m);
                    break;

                case 'e':
                    Console.WriteLine("THANKYOU");
                    break;
                default:
                    Console.WriteLine("COMPLETED");
                    break;

            }

        }
    }
}
