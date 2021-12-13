using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    interface Icalci
    {
        public void addis();
        public void subs();
        public void mult();
    }
    
    class Addi:Icalci 
    {
        int a = 20, b = 10, c;
        public void addis()
        {
            c = a + b;
            Console.WriteLine("add = {0}",c);

        }
        public void subs()
        {
            c = a - b;
            Console.WriteLine("sub = {0}", c);     
        }
        public void mult()
        {
            c = a * b;
            Console.WriteLine("product = {0}", c);
        }
    }
}
