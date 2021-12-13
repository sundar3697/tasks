using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    
    
    interface Iwithdraw
    {
        public void withdraw();
    }
    interface Ibalanceenq
    {
        public void balenq();
    }
    interface Ipinchange
    { 
        public void pinchange();
    }
    public class Atm : Iwithdraw, Ibalanceenq, Ipinchange
    {
        public string a;
        public int b,d,n = 100000,q=0;
        public char m;
        
        
        public void withdraw()
        {
        valid:
            Console.WriteLine("Enter withdraw amount");
            b = int.Parse(Console.ReadLine());
            d=b;
            if (d % 100 != 0)
            {
                Console.WriteLine("Enter Valid amount only 100's \n");
                goto valid;
            }
           
            Console.WriteLine("amount debited");

        }

        public void balenq()
        {
            
            Console.WriteLine("enter pin" ); 
            a = Console.ReadLine();
            q = n - d;
            Console.WriteLine("balance = {0}", q);
        }
        public void pinchange()
        {
           
            Console.WriteLine("enter old pin");
            a = Console.ReadLine();
            
            Console.WriteLine("enter new pin");
            a = Console.ReadLine();
            
            Console.WriteLine("PIN CHANGED");

        }
    }
    
}
