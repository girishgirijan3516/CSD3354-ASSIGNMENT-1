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
            JJ j = new JJ();
            j.Run(); // calling function in JJ class
            KK k = new KK();
            k.Run(); // calling function in KK class
            LL l = new LL();
            l.Run(); // calling function in LL class
            MM m = new MM();
            m.Run(); // calling function in MM class
            B1 b1 = new B1();
            b1.Run(); // calling function in B1 class
            B2 b2 = new B2();
            b2.Run(); // calling function in B2 class

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
    class JJ
    {
        public void Run()
        {
            int i, sum = 0;
            for (i = 1; i <= 10; ++i)
                sum += i;
            
           Console.WriteLine("Sum of first 10 natural numbers {0}", sum);
        

        }
    }
    class KK
    {
        public void Run()
        {
            int i = 1, sum = 0;
            while (i <= 10)
            {
                sum += i;
                ++i;
            }            

            Console.WriteLine("Sum of first 10 natural numbers {0}", sum);
        }
    }
    class LL
    {
        public void Run()
        {
            int a, b;
            Console.WriteLine("Enter two numbers");
            a = Int32.Parse(Console.ReadLine());// Reading first variable a
            b = Int32.Parse(Console.ReadLine());// Reading second variable b
            if(a == b)
                Console.WriteLine("They are equal"); // 
            else
                Console.WriteLine("They are not equal"); // 
        }
    }

    class MM
    {
        public void Run()
        {
            int a, b, c ;
            Console.WriteLine("Enter 3 numbers");
            a = Int32.Parse(Console.ReadLine());// Reading first variable a
            b = Int32.Parse(Console.ReadLine());// Reading second variable b
            c = Int32.Parse(Console.ReadLine());// Reading second variable c
            if (a > b && a > c)
                Console.WriteLine("Largest Number is {0}", a); // 
            else if (b > a && b > c)
                Console.WriteLine("Largest Number is {0}", b); //
            else if (c > a && c > b)
                Console.WriteLine("Largest Number is {0}", c); //
            else
                Console.WriteLine("They are equal"); //
        }
    }

    class B1
    {
        public void Run()
        {
            int i, j, flag, count = 0;
            Console.WriteLine("First 500 prime numbers");
            for (i = 1; i > 0; ++i)
            {                
                flag = 0;
                for (j = 2; j <= i/2; ++j)
                {
                    if(i % j == 0)
                    {
                        flag = 1;
                        break;
                    }
                }
                if(flag == 0)
                {
                    Console.WriteLine(i);
                    ++count;
                }

                if (count == 500)
                    break;                    

            }    

        }
    }

    class B2
    {
        public void Run()
        {
            Console.WriteLine("Enter a String");
            string s = Console.ReadLine();
            int lengthOfMovingPart = 2;
            if (s.Length > lengthOfMovingPart)
            {
                Console.WriteLine("Before moving 2 charactres -> {0}", s);
                s = string.Format("{0}{1}", s.Substring(s.Length - lengthOfMovingPart), s.Substring(0, s.Length - lengthOfMovingPart));
                Console.WriteLine("After moving 2 charactres -> {0}",s); 
            }
            else
                Console.WriteLine("String length should be more than 2");

        }
    }


}
