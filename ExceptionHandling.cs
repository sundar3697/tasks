using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class ExceptionHandling
    {
        public int a, b, c;
        public int[] array = { 1, 2, 3, 4, 5 };
        public void runException()
        {

            /*a = 10;
            b = 20;
            b -= b;
            c = a / b;
            Console.writeline("result={0}", c);*/
            try 
            {
                
                a = 10;
                b = 20;
                b -= b;
                c = a / b;
                Console.WriteLine("Result={0}", c);
                Console.WriteLine("{0}", array[10]);
            }
            catch(Exception e)
            {
                //c = 1;
                Console.WriteLine(e.Message);
                Console.WriteLine("Please make sure that the denominator should not be zero");
                Console.WriteLine("b={0}", b);
                Console.WriteLine("c={0}", c);
            }
            finally 
            {
                Console.WriteLine("Thank you");
            }
            

        }

    }
}
