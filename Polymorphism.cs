using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Polymorphism
    {
        public int a, b, c,d;
        public double x, y, z;
        public string fname, lname, fullname;


        public Polymorphism(int a, int b,int d)
        {
            this.a = a;
            this.b = b;
            this.d = d;
        }
        public Polymorphism (int a,int b)
        {
            this.a = a;
            this.b = b;
        }

        public Polymorphism(double x, double y)
        {
            this.x = x ;
            this.y = y;
        }
        public Polymorphism(String fname, String lname)
        {
            this.fname = fname ;
            this.lname  = lname ;
        }

        public void addition(int a, int b,int d)
        {
            c = a + b+d;
            Console.WriteLine("integer sum = {0}", c);

        }
        public void addition(int a,int b)
        {
            c = a + b;
            Console.WriteLine("integer sum = {0}", c);

        }

        public void addition(double x, double y)
        {
            z = x + y;
            Console.WriteLine("double sum = {0}", z);

        }
        public void addition(String fname, String  lanme)
        {
            fullname  = fname + lname ;
            Console.WriteLine("string concat = {0}", fullname);

        }

    }
}
