namespace Methods
{
    class Program
    {
        static void Main1(string[] args)
        {

            Console.Write("TAX : ");
            Employee.TAX = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nFirst Employee\n");

            Employee employee = new Employee();

            Console.Write("Enter Your First Name: ");
            employee.FName = Console.ReadLine();

            Console.Write("Enter Your Last Name: ");
            employee.LName = Console.ReadLine();

            Console.Write("Enter the Wage : ");
            employee.Wage = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the Logged Hours : ");
            employee.LoggedHours = Convert.ToDouble(Console.ReadLine());

            Employee[] employees = new Employee[2];

            employees[0] = employee;

            Console.WriteLine("\nSecond Employee");

            Employee employee2 = new Employee();

            Console.Write("Enter Your First Name: ");
            employee2.FName = Console.ReadLine();

            Console.Write("Enter Your Last Name: ");
            employee2.LName = Console.ReadLine();

            Console.Write("Enter the Wage : ");
            employee2.Wage = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the Logged Hours : ");
            employee2.LoggedHours = Convert.ToDouble(Console.ReadLine());

            employees[1] = employee2;

            foreach (var employee1 in employees)
            {
                Console.WriteLine(employee.PrintSlip());
            }
        }
    }
}

