using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Vibgyor
    {
        public void vibgyor()
        {
            Console.WriteLine("VIBGYOR");

            Console.WriteLine("ENTER YOUR CHOICE");
            char c = char.Parse(Console.ReadLine());

            switch (c)
            {
                case 'v':
                    Console.WriteLine("VOILET");
                    break;
                case 'i':
                    Console.WriteLine("INDIGO");
                    break;
                case 'b':
                    Console.WriteLine("BLUE");
                    break;
                case 'g':
                    Console.WriteLine("GREEN");
                    break;
                case 'y':
                    Console.WriteLine("YELLOW");
                    break;
                case 'o':
                    Console.WriteLine("ORANG");
                    break;
                case 'r':
                    Console.WriteLine("RED");
                    break;
                default:
                    Console.WriteLine("COMPLETED");
                    break;

            }
        }
    }
}
