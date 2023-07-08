namespace _11___Delegate
{
    public class Report
    {
        // Delegate (condition)هو الشخص القادر على تغيير الشرط
        public void ProcessEmployeeWith60000PlusSales(Employee[] employees)
        {
            Console.WriteLine("Employees With $60,000+ Sales");
            Console.WriteLine("_______________________________");

            foreach (Employee employee in employees)
            {
                if (employee.TotalSales >= 60000m)
                {
                    Console.WriteLine($"{employee.Id} | {employee.Name} | {employee.Gender} | ${employee.TotalSales}");
                }
            }
            Console.WriteLine("\n\n");
        }

        public void ProcessEmployeeWithSalesBetween30000And59999(Employee[] employees)
        {
            Console.WriteLine("Employees With Sales between $30,000 and $59,000 Sales");
            Console.WriteLine("_______________________________");

            foreach (Employee employee in employees)
            {
                if (employee.TotalSales < 60000m && employee.TotalSales >= 30000m)
                {
                    Console.WriteLine($"{employee.Id} | {employee.Name} | {employee.Gender} | ${employee.TotalSales}");
                }
            }
            Console.WriteLine("\n\n");
        }

        public void ProcessEmployeeWithSalesLessThan30000(Employee[] employees)
        {
            Console.WriteLine("Employees With Less Than $30,000+ Sales");
            Console.WriteLine("_______________________________");

            foreach (Employee employee in employees)
            {
                if (employee.TotalSales < 30000m)
                {
                    Console.WriteLine($"{employee.Id} | {employee.Name} | {employee.Gender} | ${employee.TotalSales}");
                }
            }
            Console.WriteLine("\n\n");
        }
    }
}
