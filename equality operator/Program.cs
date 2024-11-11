using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace equality_operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("a"=="a");
            Console.WriteLine("a"=="A");
            Console.WriteLine(1 == 2);

            string myValue = "a";
            Console.WriteLine(myValue == "a");

            
            string value1 = " a";
            string value2 = "A ";
            Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());
            

            Console.WriteLine("a" != "a");
            Console.WriteLine("a" != "A");
            Console.WriteLine(1 != 2);

            string myValue = "a";
            Console.WriteLine(myValue != "a");
            

            Console.WriteLine(1> 2);
            Console.WriteLine(1< 2);
            Console.WriteLine(1>= 1);
            Console.WriteLine(1<= 1);
            

            string program = "The quick brown fox jumps over the lazy dog.";
            Console.WriteLine(program.Contains("fox"));
            Console.WriteLine(program.Contains("cow"));

            // These two lines of code will create the same output

            Console.WriteLine(program.Contains("fox") == false);
            Console.WriteLine(!program.Contains("fox"));
            

            int a = 7;
            int b = 6;
            Console.WriteLine(a != b);
            string s1 = "Hello";
            string s2 = "Hello";
            Console.WriteLine(s1 != s2);
            */

            int saleAmount = 1001;
            //int discount = saleAmount > 1000 ? 100 : 50;
            Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");

            Random coin = new Random();
            int flip = coin.Next(0, 2);
            Console.WriteLine((flip == 0) ? "heads" : "tails");


            Console.ReadLine();
        }
    }
}
