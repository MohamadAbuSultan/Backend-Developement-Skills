namespace Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
             * 
             * Data Types are Objects | انواع البيانات بالاصل اوبجكت
             * class أو type عبارة عن dot net أي شيء في ال
             * Object is a very special class 
             * Object is the root of every thing in dot net 
             * (أي شيء في الدوت نت مردها للأوبجكت (أساسه الأوبجكت
             * 
            */

            Int16 s; // = short s; => 16 bit
            Int32 x; // = int x; => 32 bit
            Int64 l; // = long l; => 64 bit 

            UInt16 ush; // = ushort ush

            // Implicit Conversion and Explicit Casting | التحويل الضمني والتصريحي
            // دائماً التحويل من الصغير للكبير ما فيه مشكلة ، تحويل ضمني عطول بتحول
            /*
             * Implicit Conversion تحويل ضمني 
             * long بداخل متغير  من نوع integer زي لما تحط 
             * example :-
             * int numberInt = 300;
             * long numberLong = numberInt;
             */

            /* Explicit Casting */
            long nL = 1000;
            if (nL <= Int32.MaxValue) /* integer يمتلك قيمة ضمن إمكانيات ال nL بنفحص إذا المتغير  */
            {
                int nI = (int)nL;
            }

            double d = 1234.5;
            int i = (int)d;
            Console.WriteLine("Explicit Casting from double to integer : " + i);


            /* Boxing and Unboxing . | التحويل من قيمة لاوبجكت */
        }
    }
}

