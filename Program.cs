using System;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Multiarray ademo1 = new Multiarray();
            ademo1.matrixadd();
            Console.ReadKey();


            /*ListDemo ld = new ListDemo();
            ld.listExamples();
            ld.listAddRange();
            Console.ReadKey();*/


            CollectionsDemo cd = new CollectionsDemo();
            cd.arrayListDemo();
            cd.hashTableDemo();
            cd.queueDemo();
            cd.stackDemo();
            Console.ReadKey();





            Files testexp = new Files();
            testexp.textex();
            Console.ReadKey();





            
            String message = "hello";
            Test tes = new Test(message);
            Btest bb = new Btest();
            Console.ReadKey();



            Moneydrawtask mdt = new Moneydrawtask();
                try
                {
                mdt.moneydraw();
                }
                catch (Moneydraw M)
                {
                Console.WriteLine("Note: {0}", M.Message );
                Console.WriteLine("amount debited");
            }

            
            Console.WriteLine("\n \n ************** THANK YOU *****************");
            Console.ReadKey();




            WithDrawTask obj = new WithDrawTask();
            try
            {
                obj.withDrawMoney();

            }
            catch (WithDraw w)
            {
                Console.WriteLine("Note: {0}", w.Message);
            }
            //Console.ReadKey();
            //int a = 20,b = 80;
            //if(a < b)
            // Console.WriteLine("b is great than a" );
            Console.ReadKey();
            Console.WriteLine("\n \n *******************************");




            Console.WriteLine("\n enter number \n ");
            Table table = new Table();
            table.tab();
            Console.ReadKey();


            ATM:
            Console.WriteLine("\n     ATM ");
            Atm  atm = new Atm ();

           
            Console.WriteLine("\n a. WITHDRAW \n b. BALANCE ENQUIRE \n c. PIN CHANGE \n d. EXIT");
            
            Console.WriteLine("\n Choose Your Option");
            char m = char.Parse(Console.ReadLine());
            

            switch (m)
            {
                case 'a':
                    Iwithdraw idraw = new Atm();
                    idraw.withdraw();
                    Console.ReadKey();
                    goto ATM ;
                    

                case 'b':    Ibalanceenq ibaleq = new Atm();
                    ibaleq.balenq();
                    
                    Console.ReadKey();
                    goto ATM ;

                case 'c':   Ipinchange ipin = new Atm();
                    ipin.pinchange();
                    Console.ReadKey();
                    goto ATM ;

                case 'd': Console.WriteLine("THANK YOU \n \n \n"); 
                    break;

                default:Console.WriteLine(" \n INVALID TRANSACTION \n \n \n");
                    break;
            }
            Console.ReadKey();


            ExceptionHandling eobj = new ExceptionHandling();
            eobj.runException();
            Console.ReadKey();


            week a1 = week.sunday;
            Console.WriteLine(a1);
            week b1 = week.monday ;
            Console.WriteLine(b1);
            week c1 = week.tuesday ;
            Console.WriteLine(c1);
            
            Console.ReadKey();

            Console.WriteLine("multiple inhertence using more interfaces \n");
            Calcimultipleinherit calc = new Calcimultipleinherit();
            calc.addon();
            calc.subon();
            calc.multion();
            Iaddition iadd=new Calcimultipleinherit ();
            iadd.addon();
            Console.ReadKey();

            Console.WriteLine("interface \n");
            Addi addi = new Addi();
            addi.addis();
            addi.mult();
            addi.subs();
            Console.ReadKey();


            Console.WriteLine("\n abstract class and override \n");
            Calculatorabst calci = new Multiply();
            Addition ad = new Addition();
            ad.add ();
            Sub su = new Sub();
            su.sub ();
            Multiply  mu = new Multiply ();
            mu .multiply ();

            Console.ReadKey();


            C c = new C();
            
            Console.ReadKey();


            Console.WriteLine("\n abstract class");
            Myderived md = new Myderived();
            md.display  ();
            myderived2 md2 = new myderived2();
            md2.display ();
            Abst abs = new myderived2 ();
            abs.display ();
            Console.ReadKey();

            Console.WriteLine("\n override overload");
            Poly intobjt = new Poly(10, 20, 30);
            Poly intobjt1 = new Poly(10, 20);
            Poly intobjt3 = new Poly(10, 20);
            Poly doubleobjt4 = new Poly(3.85, 2.35);
            Poly doubleobjt2 = new Poly(1.25, 2.20, 3.25,5.25);
            Poly stringobjt = new Poly("lee", "sun");

            intobjt.addition(intobjt.a, intobjt.b);
            intobjt1.addition(intobjt1.a, intobjt1.b, intobjt1.d);
            intobjt.multiply (intobjt3.a, intobjt3.b);
            doubleobjt4.div (doubleobjt4.x, doubleobjt4.y);
            doubleobjt2.div (doubleobjt2.x, doubleobjt2.y,doubleobjt2.w, doubleobjt2 .f);
            stringobjt.addition(stringobjt.fname, stringobjt.lname);
            Console.ReadKey();


            Console.WriteLine("\n override");
            Overridedemo od = new Overridedemo();
            Overridedemo d1 = new Derived1();
            Overridedemo d2 = new Derived2();
            od.displaymsg();
            d1.displaymsg();
            d2.displaymsg();
            Console.ReadKey();

            Console.WriteLine("\n polymorphism");
            Polymorphism intobj1 = new Polymorphism(10, 20,30);
            Polymorphism intobj = new Polymorphism(10, 20);
            Polymorphism doubleobj = new Polymorphism(1.25, 2.20);
            Polymorphism stringobj = new Polymorphism("lee", "sun");
            
            intobj. addition(intobj.a,intobj. b);
            intobj1.addition(intobj1.a, intobj1.b,intobj1.d );
            doubleobj.addition(doubleobj.x, doubleobj.y);
            stringobj.addition(stringobj.fname, stringobj.lname);
            Console.ReadKey();



            Sample sam1 = new Sample(10, 20);
            sam1.message();
            Console.ReadKey();

            Samp  samp = new Samp();
            samp.message();
            Console.ReadKey();

            Demo de = new Demo(5, 10);
            de.message ();
            Console.ReadKey();

            Console.WriteLine("\n VIBGYOR");
            Vibgyor vb = new Vibgyor();
            vb.vibgyor();
            Console.ReadKey();

            Console.WriteLine("\n ODD or EVEN");
            Oddeven oe = new Oddeven();
            oe.oddeven();
            Console.ReadKey();

            Console.WriteLine("\n String Operations");
            Stringoper strop = new Stringoper();
            strop.stringoper();
            Console.ReadKey();

            Console.WriteLine("\n PRIME");
            Prime pr = new Prime();
            pr.prime();
            Console.ReadKey();

            Console.WriteLine("\n REVERSE ARRAY");
            Reversearray revarr = new Reversearray();
            revarr.reversearray();
            Console.ReadKey();

            Console.WriteLine("\n PRIME SERIES");
            Primeseries ps = new Primeseries();
            ps.primeseries();
            Console.ReadKey();

            Armstrong ams = new Armstrong();
            Console.WriteLine("\n ARMSTRONG");
            ams.armstrong();
            Console.ReadKey();

            Console.WriteLine("\n FIBONACCI");
            FibonaccoSeries fb = new FibonaccoSeries();
            fb.fibonacci();
            Console.ReadKey();

            Console.WriteLine("\n CALCULATOR");
            Calculator cal = new Calculator();
            cal.calculator();
            Console.ReadKey();


        }

       
    }
}












/*int mat[3][3] = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
for (int i = 0;i < mat[i];i++)
    {
    for (int j = 0; ; j < mat[j];j++)
        {
    Console.Write("{0}", mat[i][j]);
        }
Console.Write(mat[i][j]);
    } */
