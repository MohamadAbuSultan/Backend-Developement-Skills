using _6___Field___Constant;

namespace Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            // Object Syntax 
            // Declaration <Type> <ObjectName>;
            // Assignment <ObjectName> = new <Type>();
            // Initialization <Type> <ObjectName> = new <Type>();
            Employee employee = new Employee();

            Console.Write("Enter Your First Name: ");
            employee.FName = Console.ReadLine();

            Console.Write("Enter Your Last Name: ");
            employee.LName = Console.ReadLine();

            Console.Write("Enter the Wage : ");
            employee.Wage = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the Logged Hours : ");
            employee.LoggedHours = Convert.ToDouble(Console.ReadLine());

            var netSalary = employee.Wage * employee.LoggedHours - (employee.Wage * employee.LoggedHours * Employee.TAX);

            Console.WriteLine($"First Name : {employee.FName}");
            Console.WriteLine($"Last Name : {employee.LName}");
            Console.WriteLine($"Wage : {employee.Wage}");
            Console.WriteLine($"logged hours : {employee.LoggedHours}");
            Console.WriteLine($"net salary : {netSalary}");
        }
    }
}

