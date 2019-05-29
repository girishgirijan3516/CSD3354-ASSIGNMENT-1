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
    


}
