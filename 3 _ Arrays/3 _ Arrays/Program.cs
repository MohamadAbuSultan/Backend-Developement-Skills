using System;
using System.Linq;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            // array : fixed number of variables بتتخزن جنب بعض
            // array => Reference Type ( variable stored in stack & value stored in heap _in the RAM_ )

            Console.WriteLine("------------------");
            Console.WriteLine("Array 1");
            // A. Single dimensional array
            // 1. Declaration 
            string[] friends = new string[5];
            // 2. Accessing Element
            friends[0] = "Ali";
            friends[1] = "Reem";
            friends[2] = "Faisal";
            friends[3] = "Ahmed";
            friends[4] = "Fayrouz";
            Console.WriteLine(friends[0]);
            Console.WriteLine(friends[1]);
            Console.WriteLine(friends[2]);
            Console.WriteLine(friends[3]);
            Console.WriteLine(friends[4]);
            // 3. Initialization (version 1) = Declaration + Assignment
            string[] friends2 = new string[5]
            {
                "Ali",
                "Reem",
                "Faisal",
                "Ahmed",
                "Fayrouz",
            };
            Console.WriteLine("------------------");
            Console.WriteLine("Array 2");
            Console.WriteLine(friends2[0]);
            Console.WriteLine(friends2[1]);
            Console.WriteLine(friends2[2]);
            Console.WriteLine(friends2[3]);
            Console.WriteLine(friends2[4]);
            Console.WriteLine("------------------");
            // 3. Initialization (version 2) 
            string[] friends3 =
            {
                "Ali",
                "Reem",
                "Faisal",
                "Ahmed",
                "Fayrouz",
            };
            Console.WriteLine("------------------");
            Console.WriteLine("Array 3");
            Console.WriteLine(friends3[0]);
            Console.WriteLine(friends3[1]);
            Console.WriteLine(friends3[2]);
            Console.WriteLine(friends3[3]);
            Console.WriteLine(friends3[4]);
            Console.WriteLine("------------------");
            // Explicitly Defining Data Type  تحديد المتغير بشكل صريح


            // B. Multidimensional array (rectangular array)
            int[,] suduko =
            {
                // أرقام لعبة السودوكو ، بديش أكتبهم مكسل
            };


            // C. Jagged Array (array inside array) المصفوفة المتعرجة
            // performance أعلى 
            // multidimensional من ال
            var jagged = new int[][]
            {
                new int[] {1, 2},
                new int[] {3, 4},
                new int[] {5, 6},
                new int[] { 7 }
            };



            Console.WriteLine("*");



            // Indices and Ranges النطاق والمؤشرات
            var Friends = new string[] { "Ali", "Reem", "Faisal", "Ahmed", "Fayrouz" };
            Console.WriteLine(Friends[4]);
            var Slice1 = Friends[..2]; // بس بنطبع أول 2
            Console.WriteLine(Slice1[1]);
            var Slice2 = Friends[2..]; // Skip first 2 ( بنستثني أول 2)
            Console.WriteLine(Slice2[2]);
            var Slice3 = Friends[0..5]; // Starting from 2 , Take until 3 
            Console.WriteLine(Slice3[4]);
            var Slice4 = Friends[4..^0]; // starting from the last of the array
            Console.WriteLine(Slice4[0]);
        }

    }                                          
}                                        
                                         