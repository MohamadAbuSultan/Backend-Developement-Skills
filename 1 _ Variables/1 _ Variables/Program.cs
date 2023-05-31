using System;

namespace Mohamad 
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables : a name you can give to a memory(RAM) location to store a value that can be used later
            // Variable Scope is the area where the variable got declared

            // difference between   Value Type ||   Reference Type 

            /*
             * 
             * difference between   Stack || Heap 
             * Stack Vs Heap
             * RAM => (Stack & Heap)
             * Stack أماكن مرتبة تحت بعض في الميموري 
             * Heap أماكن عشوائية في الميموري
             * 
            */

            // 1. Value Type
            // Value Type بتتخزن فقط في ال Stack
            // Value Type storage in Stack
            // limitation of Value Type : limit  في للتخزين
            // example of value type : int  

            // 2. Reference Type
            // Reference Type بتتخزن في مكانين 
            // Identifier in Reference Type storage in stack
            // value or content of identifier in Reference Type storage in Heap
            // limitation of Reference type : Opened
            // example of Reference type : String

            // Value Type
            // 1. Declaration [ <DataType> <Identifier>; ]
            int number;

            // 2. Assignment [ <Identifier> = <Value>; ]
            number = 5;

            // 3. Initialization [ <DataType> <Identifier> = <Initial Value>; ]
            int number2 = 10;


            // Reference Type
            // String (Reference Type)
            string s1; // Identifier storage in stack
            s1 = "Mohamad"; // content storage in Heap

            string s2 = "AS.";

            // Regular Concatenation (plus sign)
            string s3 = s1 + " " + s2;
            Console.WriteLine(s3);

            // string interpolation 
            string s4 = $"{s1} {s2}";
            Console.WriteLine(s4);

            Console.WriteLine($"integer range: [{int.MinValue} => {int.MaxValue}]");


            // var and dynamic in c#
            // 1. var         resolved at compile time
            var s = "Mohamad";

            var f = 0f; // float
            var d = 0d; // double
            var m = 0m; // decimal
            var u = 0u; // unsigned integer 
            var l = 0l; // long
            var ul = 0ul; // unsigned long

            int oneMillion = 1_000_000;
            Console.WriteLine(oneMillion);


            // 2. dynamic     resolved at run time (الشرح تحت)
            // object أي حاجة بنغيرها _ أي تغيير لقيمة
            dynamic x = 9;
            x = "abc";
            x = 10m;

            // char is value type stored in the stack :)
            char Letter = 'A';
            Console.WriteLine(Letter);


        }

    }
}

