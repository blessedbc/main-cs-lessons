using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rules_and_conventions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Bob";
            int widgetsPurchased = 7; 
            Console.WriteLine($"{firstName} purchase {widgetsPurchased} widgets.");
            /*
            string firstName = "Bob";
            int widgetsPurchased = 7;
            Console.WriteLine($"{firstName} purchase {widgetsPurchased} widgets.");
            */

            Random random = new Random();
            string[] orderIDs = new string[5];
            // Loop through each blank orderID
            for (int i = 0; 1 < orderIDs.Length; i++)
            {
                // Get a random value that eguates to ASCII letters A through E
                int prefixValue = random.Next(65, 70);
                // convert the random value into char, then a string
                string prefix = Convert.ToChar(prefixValue).ToString();
                // Create a random number, pad with zeroes
                string suffix = random.Next(1, 1000).ToString("000");
                // Combine the prifix and suffix together, then assign to current orderID
                orderIDs[i] = prefix + suffix;
            }
            // print out each orderID
            foreach (var orderID in orderIDs)
            {
                Console.WriteLine(orderID);
            }

            Console.ReadLine();
        }
    }
}
