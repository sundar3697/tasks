using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class CollectionsDemo
    {
        
        public void arrayListDemo()
        {
            ArrayList a1 = new ArrayList();
            

            a1.Add(1);
            a1.Add("Example");
            a1.Add(true);

            Console.WriteLine(a1[0]);
            Console.WriteLine(a1[1]);
            Console.WriteLine(a1[2]);
            Console.ReadKey();

            Console.WriteLine(a1.Count);
            Console.WriteLine(a1.Contains(2));
            Console.WriteLine(a1[1]);
            a1.RemoveAt(1);

            ArrayList a2 = new ArrayList()
            {
                1,"Exmple",true
            };

            Console.WriteLine(a2[0]);
            Console.WriteLine(a2[1]);
            Console.WriteLine(a2[2]);
            Console.ReadKey();

            Console.WriteLine(a1.Equals(a2));
            Console.WriteLine(a1[1]);
            Console.ReadKey();



        }
        public void stackDemo()
        {
            Stack st = new Stack();
            st.Push(1);
            st.Push(2);
            st.Push(3);

            foreach (Object obj in st)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine(); Console.WriteLine();
            Console.WriteLine("The number of elements in the stack " + st.Count);
            Console.WriteLine("Does the stack contain the elements 3 " + st.Contains(3));
            Console.ReadKey();
            st.Pop();

            foreach (Object obj in st)
            {
                Console.WriteLine(obj);
            }
            Console.ReadKey();
        }
        public void queueDemo()
        {
            Queue qt = new Queue();
            qt.Enqueue(1);
            qt.Enqueue(2);
            qt.Enqueue(3);

            foreach (Object obj in qt)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine(); Console.WriteLine();
            Console.WriteLine("The number of elements in the Queue " + qt.Count);
            Console.WriteLine("Does the Queue contain " + qt.Contains(3));
            Console.ReadKey();
            qt.Dequeue();

            foreach (Object obj in qt)
            {
                Console.WriteLine(obj);
            }
            Console.ReadKey();
        }
        public void hashTableDemo()
        {
            Hashtable ht = new Hashtable();
            ht.Add("001", ".Net");
            ht.Add("002", "C#");
            ht.Add("003", "ASP.Net");

            ICollection keys = ht.Keys;

            foreach (String k in keys)
            {
                Console.WriteLine(ht[k]);
            }
            Console.ReadKey();
            Console.WriteLine(ht.ContainsKey("001"));
            Console.WriteLine(ht.ContainsValue("C#"));
            Console.ReadKey();
        }
    }
}
