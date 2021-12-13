using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace ConsoleApp1
{
    class Files
    {
        public void textex()
        {
            String path = @"E:/leela.doc";

            if (File.Exists(path))
            {
                Console.WriteLine("File Exists");
            }
            Console.ReadKey();

            String[] list;
            list  = File.ReadAllLines(path);

            Console.WriteLine(list [0]);
            Console.WriteLine(list [1]);

            Console.ReadKey();
        }
        
    }
}
