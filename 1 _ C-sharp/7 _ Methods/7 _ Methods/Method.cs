namespace Methods
{
    class Methods
    {
        static void Main(string[] args)
        {
            Demo demo = new Demo();

            demo.DoSomething(); // Caller إسمه - void

            demo.ReturnInteger(); // primary expression

            var z = 100 + demo.ReturnInteger();
            Console.WriteLine(z);

            var Age = 19;
            demo.CalculateAge(Age); // 18 is the argument passed

            demo.DoAnything(ref Age);
            Console.WriteLine(Age);

            int Age1;
            demo.Do(out Age1);
            Console.WriteLine(Age1);

            var numString = "123456";
            int number;
            if (!int.TryParse(numString, out number))
            {
                Console.WriteLine("invalid number");
            }
            else { Console.WriteLine(number); }

            demo.Promote(3000, "Gaza-Jerusalem-Gaza", "M - 3 day");

            var isEven = demo.IsEven(7);
            Console.WriteLine(isEven);

            var numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Demo.PrintOddNumbers(numbers); // Static Method بيتنادى بإسم الكلاس مباشرةً

        }
    }

    public class Demo
    {
        /* Method Syntax(simple)
         * <AccessModifier> <DataType>/void MethodName (<Parameter List>)
         * {
         *      // series of statement
         * }
        */
        public void DoSomething() // Callee إسمه
        {
            Console.WriteLine("Do Something...");
        }

        public int ReturnInteger()
        {
            var x = 100;
            return x * x;
        }

        public void CalculateAge(int Age) // Age is parameter
        {
            // Age بتنبعت by value
            Age = Age + 2;
            Console.WriteLine(Age);
        }

        public void DoAnything(ref int Age) // Age is parameter
        {
            // Age بتنبعت by Reference
            Age = Age + 2;
        }

        public void Do(out int Age) // Age is parameter
        {
            // out بنستخدمها لما ما تكون معطي قيمة مبدئية للمتغير 
            // out لازم تعطيه initial value
            Age = 19;
            Age = Age + 3;
        }

        // method signature (name + param type + param order)
        // Method Overloading 
        // Method Overloading (Common way of implementing polymorphism)
        public void Promote(double amount)
        {
            Console.WriteLine($"You've got a promotion of ${amount}");
        }
        public void Promote(double amount, string ticket) // Method Overloading 
        {
            Console.WriteLine($"You've got a promotion of ${amount} and a trip {ticket}");
        }
        public void Promote(double amount, string ticket, string hotel) // Method Overloading 
        {
            Console.WriteLine($"You've got a promotion of ${amount} and a trip {ticket} with {hotel}");
        }

        // Expression Bodies Method هذا بنستخدمه لما يكون عندك جملة واحدة فقط في الميثود
        public bool IsEven(int number) => number % 2 == 0; // هذا بنستخدمه لما يكون عندك جملة واحدة فقط في الميثود

        // Local Method   
        // Static Method بيتنادى بإسم الكلاس مباشرةً
        public static void PrintOddNumbers(int[] original)
        {
            foreach (int i in original)
            {
                if (IsOdd(i)) Console.WriteLine(i + " is odd");
            }
            // Local Method
            bool IsOdd(int number) => number % 2 != 0; // Local Method
        }

    }
}
