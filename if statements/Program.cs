﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Random dice = new Random();

            int roll1 = dice.Next(1, 7);
            int roll2 = dice.Next(1, 7);
            int roll3 = dice.Next(1, 7);

            int total = roll1 + roll2 + roll3;

            Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

            if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))

            {
                Console.WriteLine("You rolled doubles! +2 bonus to total!");
                total += 2;
            }
            if ((roll1 == roll2) && (roll2 == roll3))
            {
                Console.WriteLine("You rolled triplets! +6 bonus to total!");
                total += 6;
            }
            if (total >= 15)
            {
                Console.WriteLine("You Win!");           
            }           
            if (total < 15)
            {
                Console.WriteLine("sorry, you loose.");
            }



            Console.ReadLine();
        }
    }
}
