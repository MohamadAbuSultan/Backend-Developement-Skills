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
            Age = Age + 3;
            Console.WriteLine(Age);
        }

        public void DoAnything(ref int Age) // Age is parameter
        {
            // Age بتنبعت by Reference
            Age = Age + 3;
        }
    }
}
