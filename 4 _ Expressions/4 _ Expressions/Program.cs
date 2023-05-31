
using System;

namespace Expressions
{
    class Program
    {
        static void Main(string[] args)
        {

            // Expressions Types
            // 1.Primary Expression : expression return value
            var angle = Math.Cos(30) + 1;
            Console.WriteLine(angle);
            // 2.Void Expression
            Console.WriteLine("fayrouz");
            // 3.Assignment Statment
            var x = 2;
            x = x + 10;

            // Null Operator
            string s1 = null;
            s1 = s1 ?? "Issam";
            Console.WriteLine(s1);

        }
    }
}

