namespace OOPConstructor
{
    class Program
    {
        static void Main(string[] args)
        {

            //Date date = new Date(31, 01, 2002);
            Date date = new Date(05, 2002);
            Console.WriteLine(date.GetDate());

            // date.Day = 01;
            // date.Month = 01;
            // date.Year = 0001;
            // Console.WriteLine(date.GetDate());

            // Object Initializer
            // Employee e = new Employee // Object Initializer
            // {
            //     id = 1000,
            //     fName = "Test",
            //     lName = " 1",
            // };

            Employee e1 = Employee.Create(1000, "Issam", "A.");
            Console.WriteLine(e1.DisplayName());
        }
    }

    // Modeling تحويل المسألة إلى كلاس
    public class Date
    {
        // readonly : لا يمكن لأحدٍ تغييرها إلا في الكونستراكتور
        private static readonly int[] DaystoMonths365 = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        private static readonly int[] DaystoMonths366 = { 0, 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        // private int dayInMonth; // private لتعريف متغير 
        //  or 
        // private int _dayInMonth; // private لتعريف متغير 
        private readonly int day;
        private readonly int month;
        private readonly int year;

        // Constructor 
        // <AccessModifier>  <ClassName>(<Parameters list>) {}
        public Date(int day, int month, int year)
        {
            var isLeap = year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);

            if (year >= 1 && year <= 9999 && month >= 1 && month <= 12)
            {
                int[] days = isLeap ? DaystoMonths366 : DaystoMonths365;
                if (day >= 1 && day <= days[month])
                {
                    this.day = day;
                    this.month = month;
                    this.year = year;

                }
                else
                {
                    this.day = 01;
                    this.month = 01;
                    this.year = 01;
                }
            }
            else
            {
                this.day = 01;
                this.month = 01;
                this.year = 01;
            }
        }

        // Constructor Overloading 
        public Date(int year) : this(01, 01, year) { } // Constructor Overloading 
        public Date(int month, int year) : this(01, month, year) { } // Constructor Overloading

        // Implicit constructor |  الكونستركتر الضمني
        // public Date() { } // Implicit constructor |  الكونستركتر الضمني

        public string GetDate() => $"{day.ToString().PadLeft(2, '0')}/{month.ToString().PadLeft(2, '0')}/{year.ToString().PadLeft(4, '0')} ";
    }
    public class Employee
    {
        private Employee() { }
        private Employee(int id, string fname, string lname)
        {
            this.id = id;
            this.fName = fname;
            this.lName = lname;
        }

        public static Employee Create(int id, string fname, string lname)
        {
            return new Employee(id, fname, lname);
        }

        public int id;
        public string fName;
        public string lName;

        public string DisplayName()
        {
            return $"Id: {id} Name:{fName} {lName}\n";
        }
    }
}