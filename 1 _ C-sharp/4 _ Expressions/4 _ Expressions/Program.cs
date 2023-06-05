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
            object ob = new object();


            // Selection statement if, if else, switch | جمل الاختيار
            // if
            /* var mark = 90;
               if (mark >= 85) Console.WriteLine("Excellent");
               if else
               else Console.WriteLine("F"); */
            var mark = 55;
            if (mark >= 60) Console.WriteLine("Pass");
            else if (mark >= 55) Console.WriteLine("You have a chance in a make up exam");
            else Console.WriteLine("Fail");
            // nested if بنسميها if بداخل if بتقدر تكتب 

            // switch
            var amountJOD = 100; // JOD إختصار للدينار الأردني
            var currType = "USD"; // curr = currency = عملة
            var output = 0d; // d : double
            // JOD => USD = 1.41
            // JOD => EUR = 1.19
            // JOD => CAD = 1.78
            var JODTOUSD = 1.41;
            var EURTOUSD = 1.19;
            var CADTOUSD = 1.78;
            switch (currType)
            {
                case "USD":
                    output = amountJOD * JODTOUSD;
                    Console.WriteLine($"{amountJOD} JOD = ${output} USD");
                    break;
                case "EUR":
                    output = amountJOD * EURTOUSD;
                    Console.WriteLine($"{amountJOD} JOD = ${output} EUR");
                    break;
                case "CAD":
                    output = amountJOD * CADTOUSD;
                    Console.WriteLine($"{amountJOD} JOD = ${output} CAD");
                    break;
                default:
                    Console.WriteLine("Unknown currency type");
                    break;
            }

            // switch أكثر من حالة تحقق الشرط
            var num = 3;
            switch (num)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                    Console.WriteLine("Odd");
                    break;
                case 2:
                case 4:
                case 6:
                case 8:
                    Console.WriteLine("Even");
                    break;
            }

            // switch on types
            object o = "mohamad";
            switch (o)
            {
                case int i:
                    Console.WriteLine($"It's int, sqr of {i} = {i * i}");
                    break;
                case string i:
                    Console.WriteLine($"It's string, capitalization of {i} = {i.ToUpper()}");
                    break;
            }

            // switch _ predict توقع
            bool isVip = true;
            switch (isVip)
            {
                case bool i when i == true:
                    Console.WriteLine("Yes");
                    break;
                case bool i:
                    Console.WriteLine("No");
                    break;
            }

            // switch expression 
            // => lambda expression
            var cardNo = 4;
            string cardName = cardNo switch
            {
                1 => "ACE",
                13 => "KING",
                12 => "QUEEN",
                10 => "JACK",
                _ => cardNo.ToString() // string غير الأرقام إلي فوق ، رجع الرقم ك نص
            };
            Console.WriteLine(cardName);
        }
    }
}

