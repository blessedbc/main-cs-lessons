using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console.cs
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
                if ((roll1 == roll2) && (roll2 == roll3))
                {
                    Console.WriteLine("You rolled triplets! +6 bonus to total!");
                    total += 6;
                }
                else
                {
                    Console.WriteLine("You rolled triplets! +2 bonus to total!");
                    total += 2;
                }
                Console.WriteLine($"Your total including the bonus: {total}");

            }
            if (total >=16)
            {
                Console.WriteLine("You Win a car!");
            }
            else if (total >= 10)
            {
                Console.WriteLine("You Win a laptop!");
            }
            else if (total == 7)
            {
                Console.WriteLine("You Win a trip for two!");
            }
            else
            {
                Console.WriteLine("You wine a kitten!");
            }
            Console.ReadLine();
        }
    }
}
