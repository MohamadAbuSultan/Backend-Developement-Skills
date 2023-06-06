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

            // Int16 s; // = short s; => 16 bit
            // Int32 x; // = int x; => 32 bit
            // Int64 l; // = long l; => 64 bit 

            // UInt16 ush; // = ushort ush

            // Implicit Conversion and Explicit Casting | التحويل الضمني والتصريحي
            // دائماً التحويل من الصغير للكبير ما فيه مشكلة ، تحويل ضمني عطول بتحول
            /*
             * Implicit Conversion تحويل ضمني 
             * long بداخل متغير  من نوع integer زي لما تحط 
             * example :-
             * int numberInt = 300;
             * long numberLong = numberInt;
             */

            /*
             * Explicit Casting  
             * أنت بتتحمل عواقب التحويل من خسارة بيانات وغيرها
             */
            long nL = 1000;
            if (nL <= Int32.MaxValue) /* integer يمتلك قيمة ضمن إمكانيات ال nL بنفحص إذا المتغير  */
            {
                int nI = (int)nL;
            }

            double d = 1234.5;
            int i = (int)d;
            Console.WriteLine("Explicit Casting from double to integer : " + i);


            /* Boxing and Unboxing . | التحويل من قيمة لاوبجكت */
            // Boxing convert from datatype value to datatype reference 
            /*Example of Boxing :*/
            int m = 10; // value type
            Object obj; // reference type
            obj = m; // conversion done implicitly تم التحويل بشكل ضمني (boxing)

            // UnBoxing
            // UnBoxing convert from datatype reference to datatype value
            int y = (int)obj;


            // Convert from string to Numerical one
            //  Parse() Method | دالة Parse
            string value = "120";
            // 1. convert using Parse() Method => int.Parse(), double.Parse()....etc
            // لازم تكون عارف شو بتعمل و ع شو بتشيك 
            int number = int.Parse(value);
            Console.WriteLine("convert string to Numerical using Parse() Method : " + number);

            // TryParse() Method | دالة TryParse
            string stringValue = "9999999999999999";
            if (int.TryParse(stringValue, out int number2))
            /* out
             * بتاخذ قيمة النص إلي بدنا نحوله وبتعطيه للميثود 
             * number2 لو طلع معك إشي نتيجة للتحويل بتحفظ القيمة في المتغير 
            */
            {
                Console.WriteLine(number2); // no output مش هيطبع إشي ، لأنوا الشرط ما تحقق
            }
            else
            {
                Console.WriteLine("Invalid Number provided or does not fit integer");
            }

            // 2. Convert Class   |  فئة التحويل
            var i7 = Convert.ToInt32(value);
            Console.WriteLine("convert string to Numerical using Convert Class : " + i7);
            // decimal ToDecimal(String)
            // float ToSingle(String)
            // double ToDouble(String)
            // short ToInt16(String)
            // int ToInt32(String)
            // long ToInt64(String)
            // ushor ToUInt16(String)
            // uint ToUInt32(String)
            // ulong ToUInt64(String)

            /* BitConverter And Value Types | فئة التحويل للنطفة */
            var number5 = 255;
            var bytes = BitConverter.GetBytes(number5);
            Console.Write("bytes : ");
            foreach (var b in bytes)
            {
                Console.Write(b + " ");
            }
            Console.Write("\nbinary : ");
            foreach (var item in bytes)
            {
                var binary = Convert.ToString(item, 2).PadLeft(8, '0');
                // padleft 8 أي رقم بدك تطبعه لازم يكون ثمانية خانات
                Console.Write(binary + " ");
            }

            Console.WriteLine();

            // Convert from string to binary or hexa
            var name = "Issam";
            char[] letters = name.ToCharArray();
            foreach (var l1 in letters)
            {
                int ascii = Convert.ToInt32(l1);
                var output = $"'{l1}' => ASCII: {ascii}," +
                    $" Binary: {Convert.ToString(ascii, 2).PadLeft(8, '0')}," +
                    $" HexaDecimal: {ascii:x}";
                Console.WriteLine(output);
            }
            // بيطبعه بالهيكسا ديسيمل x أي شيء بداخل الأقواس بتعطيه 

            string[] hexValues = { "49", "73", "73", "61", "6D" };
            foreach (var hex in hexValues)
            {
                int value6 = Convert.ToInt32(hex, 16);
                var stringValue1 = Char.ConvertFromUtf32(value6); // الطريقة الأولى
                var ch = (char)value6;
                Console.Write("stringValue1 " + stringValue1);
                Console.Write("\nch " + ch + "\n");
            }

            // hexa to int
            var HexaNumber = "8E2";
            int number15 = Int32.Parse(HexaNumber, System.Globalization.NumberStyles.HexNumber);
            Console.WriteLine("Convert Hexa To Int : " + number15);
        }
    }
}

