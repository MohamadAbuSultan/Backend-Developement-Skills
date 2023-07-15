namespace _11___Delegate
{
    public class Report
    {
        // Delegate (condition)هو الشخص القادر على تغيير الشرط
        public delegate bool IllegibleSales(Employee employee);
        public void ProcessEmployee(Employee[] employees, string title, IllegibleSales isIllegible)
        {
            Console.WriteLine(title);
            Console.WriteLine("_______________________________");

            foreach (Employee employee in employees)
            {
                if (isIllegible(employee))
                {
                    Console.WriteLine($"{employee.Id} | {employee.Name} | {employee.Gender} | ${employee.TotalSales}");
                }
            }
            Console.WriteLine("\n\n");
        }

    }
}
