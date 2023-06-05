namespace Expressions
{
    class Program
    {
        static void Main(string[] args)
        {
            // Expression هو أي شيء نهايته راح تكون شيء واحد فقط
            // Expressions Types
            // 1.Primary Expression : expression return value له قيمة
            var angle = Math.Cos(30) + 1;
            Console.WriteLine(angle);
            // 2.Void Expression ما برجع قيمة
            Console.WriteLine("mohamad khaled");
            // 3.Assignment Statment
            var x = 2;
            x = x + 10; // x = 12
            int y = 10;
            Console.WriteLine($"x + y = {x + y}");

            // Null Operator _ Null coalescing operator "??" . | الاندماج الصفري
            string s1 = null;
            s1 = s1 ?? "Issam";
            Console.WriteLine(s1);
            s1 = s1 ?? "Other";
            Console.WriteLine(s1);

            // Null conditional "?." | شرط الانعدام
            string s2 = null;
            var s3 = s2?.ToUpper();
            // = var s3 = s2 is null ? null : s2.ToUpper();

            // Statement vs Statement blocks: | الجمل والجمل المجمعة
            // 1. Statement block :
            Console.WriteLine("Hello World");
            // 2. Statement blocks مجموعة من الجمل داخل ال curly brace
            {
                Console.WriteLine("Hi");
                Console.WriteLine("Hi");
                Console.WriteLine("Hi");
                Console.WriteLine("Hi");
            }

            // Expression Statement
            // 1. change state of the variable / assignment
            var name = "Mohamad";
            name = name + " A. S.";
            Console.WriteLine(name);
            // 2. call something that change the state of the variable
            name = name.ToUpper();
            Console.WriteLine(name);
            // 3. Increment / decrement
            // Increment
            var totalFriends = 150;
            ++totalFriends;
            Console.WriteLine(totalFriends);
            // Decrement
            --totalFriends;
            Console.WriteLine(totalFriends);
            // 4. Object Instansiation
            object o = new object();
        }
    }
}

