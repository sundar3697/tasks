using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Moneydraw : Exception 
    {
        public Moneydraw(string message) : base(message )
        {
            Console.WriteLine("invalid");
        }
    }
    class Moneydrawtask
    {
        public double draw,a;
        public void moneydraw()
        {
            Console.WriteLine("enter balance in your account:");
            draw  = Double.Parse(Console.ReadLine());
            if (draw < 100.00 && draw % 100 != 0)
            {

                throw (new Moneydraw("Enter Valid amount only 100's"));
            }
            else
            {
                valid:
                Console.WriteLine("Enter Amount to withdraw");
                a = Double.Parse(Console.ReadLine());
                if (a % 100!=0)
                {
                    Console.WriteLine("Enter Valid amount only 100's \n");
                    goto valid;
                }
                else
                {
                    Console.WriteLine("AMOUNT DEBITED :", draw);
                    
                }
            }
        }
    }
}
