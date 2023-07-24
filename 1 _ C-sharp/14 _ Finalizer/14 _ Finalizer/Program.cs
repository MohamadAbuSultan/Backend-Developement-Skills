namespace Finalizer
{
    class Program
    {
        static void Main(string[] args)
        {
            // garbage collector : طبقة مسؤوليتها تنفذ عملية إدارة للذاكرة عشان تنظف الشغلات الغير مستخدمة ، تتم بشكل ضمني
            // destructor : دالة داخل الكلاس يتم مناداتها لإتلاف الكيان

            // أي عندما يخرج خارج النطاق out of scope ؟؟ لما يصير  object متى بيتدمر ال
            {
                // scope 1
                var p = new Person();
                p.Name = "Test";
            }

            {
                // garbage collection لأنه في نطاق آخر وتم حذفه بواسطة الp لا يمكنك الوصول إلى الأوبجكت 
            }

            /* 
             * When Object get disposed ? 
                1. end of program execution (implicit) ضمنياً عند نهاية البرنامج
                2. memory full (implicit) ضمنياً أثناء إمتلاء الذاكرة وقت التنفيذ 
                3. GC.COLLECT (implicit) يتم إستدعائها عن طريق المبرمج
             */
            MakeSomeGarabge();
            Console.WriteLine($"Veeory used Before Collection: {GC.GetTotalMemory(false):N0}");
            GC.Collect(); // Explicit Cleaning
            Console.WriteLine($"Memory used after collection: {GC.GetTotalMemory(true):N}");

        }

        private static void MakeSomeGarabge()
        {
            Version v;
            for (int i = 0; i < 1000; i++)
            {
                v = new Version();
            }
        }
    }

    class Person
    {
        public string Name { get; set; }
        public Person() // constructor
        {
            Console.WriteLine("This is constructor");
        }
        ~Person() // destructor
        {
            Console.WriteLine("This is destructor");
        }
    }
}

