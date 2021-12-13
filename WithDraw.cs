using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class WithDraw : Exception
    {
        public WithDraw(string message) : base(message)
        {

        }
    }
    class WithDrawTask
    {
        public double money;
        public void withDrawMoney()
        {
            Console.WriteLine("enter balance in your account:");
            money = Double.Parse(Console.ReadLine());
            if (money < 100.00 && money % 100 != 0)
            {
                throw (new WithDraw("Enter Valid "));
            }
            else
            {
                Console.WriteLine("Enter Amount to withdraw");
            }
        }
    }
}