using System;
using System.Runtime.ConstrainedExecution;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {

            // bool IsVip = true;

            var x = 10; // assign 10 to variable x
            var y = 10;



            // Performance(الأداء) vs Readability(قابلية القراءة)
            //
            Console.WriteLine(x == y); // هاي أقوى Performance من ناحية
            //
            // Expression  هو أي شيء ممكن أحوله لقيمة واحدة ، أي إشي برجع قيمة واحدة
            var z = x == y; // هاي أفضل Readability من ناحية  
            Console.WriteLine(z);



            // Trace التتبع




            // comparison operators عوامل المقارنة
            var total = 1000;
            var vipThreshold = 900;

            var isVip = total >= vipThreshold;
            Console.WriteLine(isVip);

            // Negation النفي
            isVip = !false;
            Console.WriteLine($"is Vip = {isVip}");



            Console.WriteLine("-----------------------");



            // conditional operator (and : && , or : ||) 
            // 
            // 1. Logical And &&
            Console.WriteLine($"Logical And && = {true && true}");
            Console.WriteLine($"Logical And && = {true && false}");
            Console.WriteLine($"Logical And && = {false && true}");
            Console.WriteLine($"Logical And && = {false && false}");
            //
            Console.WriteLine("-----------------------");
            // 2. Logical OR ||
            Console.WriteLine($"Logical OR || = {true || true}");
            Console.WriteLine($"Logical OR || = {true || false}");
            Console.WriteLine($"Logical OR || = {false || true}");
            Console.WriteLine($"Logical OR || = {false || false}");
            //
            Console.WriteLine("-----------------------");
            // 3. Logical XOR ^
            Console.WriteLine($"Logical XOR ^ = {true ^ true}");
            Console.WriteLine($"Logical XOR ^ = {true ^ false}");
            Console.WriteLine($"Logical XOR ^ = {false ^ true}");
            Console.WriteLine($"Logical XOR ^ = {false ^ false}");
            //
            // && || => short circuit هاي أسرع 
            // & |   => long circuit هاي أبطىء 



            // == References Type

            var x1 = 1;
            var y1 = 1;

            // compare the values (value type)
            var z1 = x1 == y1;
            Console.WriteLine(z1); // true

            //compare the references (reference type)
            var s1 = "hello";
            var s2 = "Hello";
            var s3 = s1 == s2;
            Console.WriteLine(s3); // true
            // CLR internally calls IsEqual() thats why the result is true
            // CLR : Common Language Runtime


            // ternary operator عامل ثلاثي
            var total2 = 9000;
            var vipThreshold2 = 1000;
            var isVip2 = total2 >= vipThreshold2 ? true : false;
            Console.WriteLine(isVip2);
        }
    }
}