using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    interface Iaddition
    {
        public void addon();
    }
    interface Isubstraction
    {
        public void subon();
    }
    interface Imultiply
    {
        public void multion();
    }
    public class Calcimultipleinherit : Iaddition ,Isubstraction ,Imultiply 
    {
        int a = 40, b = 10, c;
        public void addon()
        {
            c = a + b;
            Console.WriteLine("add = {0}", c);

        }
        public void subon()
        {
            c = a - b;
            Console.WriteLine("sub = {0}", c);
        }
        public void multion()
        {
            c = a * b;
            Console.WriteLine("product = {0}", c);
        }
    }
}
