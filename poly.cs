using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
     class Poly
    {
        public int a, b, c, d;
        public double w, x, y, z,f;
        public string fname, lname, fullname;


        public Poly(int a, int b, int d)
        {
            this.a = a;
            this.b = b;
            this.d = d;
        }
        public Poly(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public Poly(double x, double y, double w, double f)
        {
            this.x = x;
            this.y = y;
            this.w = w;
            this.f = f;
        }
        public Poly(double x, double y)
        {
            this.x = x;
            this.y = y;
          
        }
        public Poly(String fname, String lname)
        {
            this.fname = fname;
            this.lname = lname;
        }

        public void addition(int a, int b, int d)
        {
            c = a + b + d;
            Console.WriteLine("integer sum = {0}", c);

        }
        public void addition(int a, int b)
        {
            c = a + b + d;
            Console.WriteLine("integer sum = {0}", c);

        }
        public void multiply(int a, int b)
        {
            c = a * b;
            Console.WriteLine("integer multiple = {0}", c);

        }

        public void div(double x, double y)
        {
            z = x / y;
            Console.WriteLine("double div = {0}", z);

        }
        public void div(double x, double y, double w,double f)
        {
            z = x / y*w/f;
            Console.WriteLine("double div and multiple = {0}", z);

        }
       
        public void addition(String fname, String lanme)
        {
            fullname = fname + lname;
            Console.WriteLine("string concat = {0}", fullname);

        }

    }

}
   
