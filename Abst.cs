using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
            public abstract class Abst
            {
                 public abstract void display();
                    public void messege()
                    {
                            Console.WriteLine("my message Base");
                    }
            }

    public class Myderived : Abst 
    {
        public override  void display()
        {
            Console.WriteLine("derived class D1 display");

        }

         
    }

    class myderived2 : Myderived
    {
         public override void  display()
         {
         Console.WriteLine("derived class  D2 display");

         }

         

    }
}


