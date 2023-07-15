namespace _11___Delegate
{
    public delegate void RectDelegete(decimal Height, decimal Width); // Multicast Delegate
    class Program
    {
        static void Main(string[] args)
        {
            var emp = new Employee[]
            {
                new Employee {Id = 1, Name = "Issan A", Gender = "m", TotalSales = 65000m },
                new Employee {Id = 2, Name = "Reen 5", Gender = "F", TotalSales = 50000m },
                new Employee {Id = 3, Name = "Suzan в", Gender = "F", TotalSales = 65000m },
                new Employee {Id = 4, Name = "Sara A", Gender = "F", TotalSales = 42000m },
                new Employee {Id = 5, Name = "Salah C", Gender = "m", TotalSales = 30000m},
                new Employee {Id = 6, Name = "Rateb A", Gender = "M", TotalSales = 50000m },
                new Employee {Id = 7, Name = "Abeer C", Gender = "F", TotalSales = 16000m },
                new Employee {Id = 8, Name = "Marwan M", Gender = "M", TotalSales = 15000m },
            };

            var report = new Report();
            report.ProcessEmployee(emp, "Sales >= 60,000", delegate (Employee emp) { return emp.TotalSales > 60000m; }); // delegate بس بطريقة أسهل من الطريقة الأخيرة - إلي بعدها بسطرين
            report.ProcessEmployee(emp, "Sales <= 30,000 && sales <= 59999", (Employee emp) => emp.TotalSales < 60000m && emp.TotalSales >= 30000m); // delegate with lambda expression
            report.ProcessEmployee(emp, "Sales < 30000", IsLessThan30000); // delegate بالطريقة العادية

            var helper = new RectangleHelper();
            RectDelegete rect = helper.GetArea; // Multicast Delegate
            rect += helper.GetPerimeter;
            rect(10, 10);
            Console.WriteLine("After Unsubscribe GetPermeter : ");
            rect -= helper.GetPerimeter;
            rect(10, 10);


        }
        static bool IsGreaterThanOrEqual60000(Employee emp) => emp.TotalSales > 60000m;
        static bool IsBetween30000And59999(Employee emp) => emp.TotalSales < 60000m && emp.TotalSales >= 30000m;
        static bool IsLessThan30000(Employee emp) => emp.TotalSales < 30000m;

    }

    public class RectangleHelper
    {
        // Multicast Delegate عندي عمليتين أو أكثر بدي إياهم يتنفذوا بس ما بدي كل شوي أنادي كل وحدة فيهم ، مرة وحدة بتستدعيهم كلهم
        public void GetArea(decimal Height, decimal Width)
        {
            var result = Height * Width;
            Console.WriteLine($"{Height} * {Width} = {result}");
        }
        public void GetPerimeter(decimal Height, decimal Width)
        {
            var result = 2 * (Height + Width);
            Console.WriteLine($"2 * ({Height} + {Width}) = {result}");
        }
    }
}

