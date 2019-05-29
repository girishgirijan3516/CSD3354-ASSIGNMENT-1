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
    
}
