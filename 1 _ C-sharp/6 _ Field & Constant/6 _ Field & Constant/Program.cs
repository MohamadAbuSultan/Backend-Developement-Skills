using _6___Field___Constant;

namespace Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             بالستاك تخزن الأوبجكت وبالهيب تخزنت القيمة تعت الأوبجكت
             object stored in stack , value of obj stored in heap
             */
            // Object (Instance) Syntax 
            // Declaration <Type> <ObjectName>;
            // Assignment <ObjectName> = new <Type>();
            // Initialization <Type> <ObjectName> = new <Type>();

            Console.WriteLine("First Employee\n");

            Employee employee = new Employee();

            Console.Write("Enter Your First Name: ");
            employee.FName = Console.ReadLine();

            Console.Write("Enter Your Last Name: ");
            employee.LName = Console.ReadLine();

            Console.Write("Enter the Wage : ");
            employee.Wage = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the Logged Hours : ");
            employee.LoggedHours = Convert.ToDouble(Console.ReadLine());

            //var netSalary = employee.Wage * employee.LoggedHours - (employee.Wage * employee.LoggedHours * Employee.TAX);

            //Console.WriteLine($"First Name : {employee.FName}");
            //Console.WriteLine($"Last Name : {employee.LName}");
            //Console.WriteLine($"Wage : {employee.Wage}");
            //Console.WriteLine($"logged hours : {employee.LoggedHours}");
            //Console.WriteLine($"net salary : {netSalary}");

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
                var netSalary = employee1.Wage * employee1.LoggedHours - (employee1.Wage * employee1.LoggedHours * Employee.TAX);
                Console.WriteLine($"First Name : {employee1.FName}");
                Console.WriteLine($"Last Name : {employee1.LName}");
                Console.WriteLine($"Wage : {employee1.Wage}");
                Console.WriteLine($"logged hours : {employee1.LoggedHours}");
                Console.WriteLine($"net salary : {netSalary}");
            }
        }
    }
}

