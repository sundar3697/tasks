using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Overridedemo
    {
        public virtual void  displaymsg()
        {
            Console.WriteLine("\n I'm from BASE CLASS");
        }

    }
    class Derived1 : Overridedemo
    {
        public override  void displaymsg()
        {
            Console.WriteLine("\n i'm from DERIVED CLASS 1");
        }
    }
    class Derived2 : Overridedemo
    {
        public override  void displaymsg()
        {
            Console.WriteLine("\n i'm from DERIVED CLASS 2");
        }
    }
}
