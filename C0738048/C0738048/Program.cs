using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0738048
{
    class Program
    {
        static void Main(string[] args)
        {
            AA a = new AA();
            a.Run(); // calling function in AA class
            BB b = new BB();
            b.Run(); // calling function in BB class
            CC c = new CC();
            c.Run(); // calling function in CC class
            DD d = new DD();
            d.Run(); // calling function in DD class
            EE e = new EE();
            e.Run(); // calling function in EE class
            FF f = new FF();
            f.Run(); // calling function in FF class
            GG g = new GG();
            g.Run(); // calling function in GG class
            HH h = new HH();
            h.Run(); // calling function in HH class
            II i = new II();
            i.Run(); // calling function in II class

            Console.ReadLine();
        }
    }
    class AA
    {
        public void Run()
        {
            Console.WriteLine("Enter your name");  
            string name = Console.ReadLine();// Reading name
            Console.WriteLine("Hello! {0}", name); // Displaying name 
        }
    }
    class BB
    {
        public void Run()
        {
            int a, b;
            Console.WriteLine("Enter two numbers");
            a = Int32.Parse(Console.ReadLine());// Reading first variable a
            b = Int32.Parse(Console.ReadLine());// Reading second variable b
            Console.WriteLine("Sum = {0}", a + b); // Display sum 
            Console.WriteLine("Multiplication = {0}", a * b); // Display product 
            Console.WriteLine("Division = {0}", a / b); // Display product
        }
    }
    class CC
    {
        public void Run()
        {
            int a, b , t;
            Console.WriteLine("Enter two numbers");
            a = Int32.Parse(Console.ReadLine());// Reading first variable a
            b = Int32.Parse(Console.ReadLine());// Reading second variable b
            Console.WriteLine("Before Swapping A = {0} B = {1}", a , b); // 
            t = a;
            a = b;
            b = t;
            Console.WriteLine("After Swapping A = {0} B = {1}", a, b); // 
        }
    }
    class DD
    {
        public void Run()
        {
            int a, b, c;
            Console.WriteLine("Enter 3 numbers");
            a = Int32.Parse(Console.ReadLine());// Reading first variable a
            b = Int32.Parse(Console.ReadLine());// Reading second variable b
            c = Int32.Parse(Console.ReadLine());// Reading third variable c
            Console.WriteLine("Product of {0} * {1} * {2} = {3}", a, b, c , a*b*c); //           
             
        }
    }
    class EE
    {
        public void Run()
        {
            int a, i;
            Console.WriteLine("Enter a numbers to get multipilication table");
            a = Int32.Parse(Console.ReadLine());// Reading first variable a
            for(i=1;i<=10;++i)
                Console.WriteLine("{0} * {1}  = {2}", i, a, i*a); //    

        }
    }
    class FF
    {
        public void Run()
        {
            int a, b, c, d;
            Console.WriteLine("Enter a numbers to get multipilication table");
            a = Int32.Parse(Console.ReadLine());// Reading first variable a
            b = Int32.Parse(Console.ReadLine());// Reading second variable b
            c = Int32.Parse(Console.ReadLine());// Reading third variable c
            d = Int32.Parse(Console.ReadLine());// Reading fourth variable d
            Console.WriteLine("({0} + {1} + {2} + {3}) / 4 = {4}", a, b, c, d, (a + b + c + d) / 4.0); //     

        }
    }
    class GG
    {
        public void Run()
        {
            int age;
            string name;
            Console.WriteLine("Enter your name and age");
            name = Console.ReadLine();
            age = Int32.Parse(Console.ReadLine());// Reading age
            if(age > 28)
            Console.WriteLine("{0}, You look older than {1}", name , age); //     

        }
    }
    class HH
    {
        public void Run()
        {
            int a, b ;            
            Console.WriteLine("Enter two numbers");            
            a = Int32.Parse(Console.ReadLine());// Reading number a
            b = Int32.Parse(Console.ReadLine());// Reading number b
            if(a == b)
                Console.WriteLine("Sum = {0}", (a + b) * (a + b) * (a + b));
            else
                Console.WriteLine("Sum = {0}", (a + b));

        }
    }
    class II
    {
        public void Run()
        {
            int a;
            Console.WriteLine("Enter two numbers");
            a = Int32.Parse(Console.ReadLine());// Reading number a
           
            if (a>=20 && a<=100)
                Console.WriteLine("{0} is within 20 of 100", a);
            else
                Console.WriteLine("{0} is not within 20 of 100", a);

        }
    }




}
