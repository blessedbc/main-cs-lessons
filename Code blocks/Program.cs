using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Code_blocks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            int value = 0;


            if (flag)
            {
                Console.WriteLine($"Inside the code block: {value}");
            }

            value = 10;
            Console.WriteLine($"Outside the code block: {value}");
            

            bool flag = true;
            if (flag) Console.WriteLine(flag);
            

            string name = "steve";
            if (name == "bob") Console.WriteLine("Found bob");
            else if (name == "steve") Console.WriteLine("Found Steve");
            else Console.WriteLine("Found Chuck");
           
            string name = "steve";
            if (name == "bob")
                Console.WriteLine("Found bob");
            else if (name == "steve")
                Console.WriteLine("Found Steve");
            else 
                Console.WriteLine("Found Chuck");

            Console.ReadLine();
        }   
    }
}
