using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace foreach_statement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Rowena", "Robin", "Bao" };
            foreach (string name in names)
            {
                Console.WriteLine(name);

                int[] inventory = { 200, 450, 700, 175, 250 };
                int sum = 0;
                int bin = 0;
                foreach (int items in inventory)
                {
                    sum += items;
                    bin++;
                    Console.WriteLine($"Bin {bin} = {items} (Running total: {sum})");
                }

                Console.WriteLine($"We have {sum} items in inventory");

                string[] orderIDs = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

                foreach (string orderID in orderIDs)
                {
                    if (orderID.StartsWith("B"))
                    {
                        Console.WriteLine(orderID);
                    }

                }
                Console.ReadLine();
            }
        } 
    }
}
