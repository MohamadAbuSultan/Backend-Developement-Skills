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
                Console.Write("Hi ");
                Console.Write("Hi ");
                Console.Write("Hi ");
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
                case int j:
                    Console.WriteLine($"It's int, sqr of {j} = {j * j}");
                    break;
                case string j:
                    Console.WriteLine($"It's string, capitalization of {j} = {j.ToUpper()}");
                    break;
            }

            // switch _ predict توقع
            bool isVip = true;
            switch (isVip)
            {
                case bool j when j == true:
                    Console.WriteLine("Yes");
                    break;
                case bool j:
                    Console.WriteLine("No");
                    break;
            }

            // switch expression 
            // => lambda expression
            var cardNo = 13;
            string cardName = cardNo switch
            {
                1 => "ACE",
                13 => "KING",
                12 => "QUEEN",
                10 => "JACK",
                _ => cardNo.ToString() // string غير الأرقام إلي فوق ، رجع الرقم ك نص
            };
            Console.WriteLine(cardName);

            // Iterations 
            // while 
            // Logical Expression بداخل ال while (الشرط)
            Console.Write("This is While : ");
            var counter = 0;
            while (counter < 10)
            {
                Console.Write(counter++ + " ");
            }

            counter = 0;
            Console.Write("\nThis is Do While : ");
            // do while
            do
            {
                Console.Write(counter + " ");
                counter++;
            } while (counter < 10);

            Console.Write("\nThis is For : ");

            // for
            for (var j = 0; j < 10; ++j)
            {
                Console.Write(j + " ");
            }

            Console.WriteLine();

            // Fibonacci { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34}
            Console.Write("Fibonacci Numbers : ");
            for (int j = 0, prev = 0, current = 1; j < 10; ++j)
            {
                Console.Write(prev + " ");
                int newFib = prev + current;
                prev = current;
                current = newFib;
            }

            Console.WriteLine();

            /* 
                infinite loop
                for (; ; )
                {
                    Console.WriteLine(i);
                }
            */

            Console.Write("This is foreach : ");
            // foreach ، eazy for use ، more readable
            foreach (char c in "Full Stack Web Developer course")
            {
                Console.Write(c + " ");
            }

            Console.WriteLine();

            Console.Write("This is foreach that print array : ");

            var arr = new int[] { 1, 2, 4 };
            foreach (var n in arr)
            { Console.Write(n + " "); }

            Console.Write("\nThis is For that print array : ");
            for (int j = 0; j < arr.Length; j++)
            { Console.Write(arr[j] + " "); }

            Console.WriteLine();

            // Jump statement (break, continue, goto, return) | جمل القفز
            // break لإنهاء اللوب وعدم إكماله
            Console.Write("This is for loop with break statement : ");
            x = 0;
            while (x < 10)
            {
                if (x > 5)
                    break;
                Console.Write(x++ + " ");
            }

            // continue بتعمل سكيب للخطوة 
            Console.Write("\nThis is for loop with continue statement : ");
            for (int j = 0; j < 11; j++)
            {
                if (j % 2 == 0)
                    continue;
                Console.Write(j + " ");
            }

            // goto ، الشرح في المثال نفسه
            Console.Write("\nThis is for loop with goto statement : ");
            int i = 0;
        start:
            if (i <= 5)
            {
                Console.Write(i++ + " ");
                goto start;
            }

            // return
            var input = .44m;
            var result = AsPercentage(input);
            Console.WriteLine("\n" + result);

            Console.WriteLine();
        }

        static decimal AsPercentage(decimal value)
        {
            return value * 100;
        }
    }
}

