using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_s_IndexOf___and_Substring__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            string message = "Find what is (inside the parentheses)";

            int openingPosition = message.IndexOf('(');
            int closingPosition = message.IndexOf(')');

            Console.WriteLine(openingPosition);
            Console.WriteLine(closingPosition);

            string message = "Find what is (inside the parentheses)";

            int openingPosition = message.IndexOf('(');
            int closingPosition = message.IndexOf(')');

            // Console.WriteLine(openingPosition);
            // Console.WriteLine(closingPosition);

            int length = closingPosition - openingPosition;
            Console.WriteLine(message.Substring(openingPosition, length));

            string message = "Find what is (inside the parentheses)";

            int openingPosition = message.IndexOf('(');
            int closingPosition = message.IndexOf(')');

            openingPosition += 1;

            int length = closingPosition - openingPosition;
            Console.WriteLine(message.Substring(openingPosition, length));


            string message = "What is the value <span>between the tags</span>?";

            int openingPosition = message.IndexOf("<span>");
            int closingPosition = message.IndexOf("</span>");

            openingPosition += 6;
            int length = closingPosition - openingPosition;
            Console.WriteLine(message.Substring(openingPosition, length));
            */

            string message = "What is the value <span>between the tags</span>?";

            const string openSpan = "<span>";
            const string closeSpan = "</span>";

            int openingPosition = message.IndexOf(openSpan);
            int closingPosition = message.IndexOf(closeSpan);

            openingPosition += openSpan.Length;
            int length = closingPosition - openingPosition;
            Console.WriteLine(message.Substring(openingPosition, length));

            Console.ReadLine();
        }
    }
}
