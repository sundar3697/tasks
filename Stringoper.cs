using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Stringoper
    {
        public void stringoper()
        {
            string name = "ABCDef";
            string firstname = "lee";
            string lastname = "sun";

            int len = name.Length;
            Console.WriteLine(len);
            //string conct = name.concat("ghij");
            //Console.WriteLine("concatination =", conct);
            string i = firstname + lastname;
            Console.WriteLine(i);
            string n = "Welcome\n" + "Hello\t" + string.Concat(firstname + lastname).ToUpper();
            Console.WriteLine(n);
            string a = name.Substring(3);
            Console.WriteLine(a);
            Console.WriteLine("sundar\b  ");
            int b = name.IndexOf('D');
            Console.WriteLine(b);
            Console.WriteLine("\"sundar23-a/4\"");
            string g = name;
            //char v = string.Concat(firstname (5));
        }
    }
}
