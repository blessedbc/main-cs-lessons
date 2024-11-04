using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whitespace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Example 1:
            Console
            .
            WriteLine
            (
             "Hello Example 1!"
            )
            ;

            //Example 2:
            string firstWord = "Hello";string lastword = "Example 2"; Console.WriteLine(firstWord+" "+lastword+"+");

            /*
               This code reverses a message, counts the number of times
               a particuler character apears, then prints the results
               to the console window.
            */

            string originalMessage = "The quick brown fox jumps over the lazy dog.";
            char[] message = originalMessage.ToCharArray();
            Array.Reverse(message);

            int letterCount = 0;

            foreach (char letter in message)
            {
                if (letter == 'o')
                {
                    letterCount++;
                }
            }
            string newMessage = new string(message);

            Console.WriteLine(newMessage);
            Console.WriteLine($"'o' appears {letterCount} times.");

            Console.ReadLine();

        }  

    }
}

