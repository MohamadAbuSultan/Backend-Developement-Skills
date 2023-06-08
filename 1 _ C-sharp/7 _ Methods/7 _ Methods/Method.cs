namespace Methods
{
    class Methods
    {
        static void Main(string[] args)
        {
            Demo demo = new Demo();

            demo.DoSomething(); // Caller إسمه
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
    }
}
