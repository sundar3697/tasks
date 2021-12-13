using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public abstract class Calculatorabst
    {


        public abstract void add();
        public abstract void sub();
        public abstract void multiply();


         
    }
    public class Addition: Calculatorabst 
    {
        public  int a = 10, b = 20, c,d = 50, e = 40, f, g = 3, h = 6, i;
        public override void add()
        {

            c = a + b;
            Console.WriteLine("sum of two = {0}", c);
        }

        public override void multiply() { }
        public override void sub() { }
        
    }
     public class Sub:Addition   
    {
        
       
        public override void sub()
        {
            f = d - e;
            Console.WriteLine("substractioin of two = {0}", f);
        }
        
    }

    class Multiply:Sub   
    {
        
       
        public override  void multiply()
        {
            i = g * h;
            Console.WriteLine("product of two = {0}", i);
        }



    }

}