namespace _11___Delegate
{
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
                new Employee {Id = 8, Name = "Marwan м", Gender = "M", TotalSales = 15000m },
            };

            var report = new Report();
            report.ProcessEmployeeWith60000PlusSales(emp);
            report.ProcessEmployeeWithSalesBetween30000And59999(emp);
            report.ProcessEmployeeWithSalesLessThan30000(emp);
        }
    }
}





