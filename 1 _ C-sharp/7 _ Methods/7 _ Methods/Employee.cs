namespace Methods
{
    //<ClassModifier> -> public, internal(default) متاح ضمن قيود معينة
    public class Employee //<ClassModifier> class <ClassName>
    {

        /* 
            // <accessModifier> public, private, protected
            // Constant  -> <AccessModifier> const <DataType> <ConstantName> = <Value>;

            * Constant is a promise that can not be changed after it has been initialized
            * static member is a shared variable that can be changed after it has been initialized       
        */
        public static double TAX = 0.03;
        // <accessModifier> public, private, protected
        // Fields  -> <AccessModifier> <DataType> <FieldName> = <InitialValue>;
        public string? FName;
        public string? LName;
        public double Wage;
        public double LoggedHours;

        private double Calculate() => Wage * LoggedHours;
        private double CalculateTax() => Calculate() * TAX;
        private double CalculateNet() => Calculate() - CalculateTax();

        public string PrintSlip()
        {
            return $"\nFirst Name : {FName}" +
                   $"\nLast Name : {LName}" +
                   $"\nWage : {Wage}" +
                   $"\nlogged hours : {LoggedHours}" +
                   "\n-----------------------" +
                   $"\nSalary : {Calculate()}" +
                   $"\nDeductable Tax ({TAX * 100}%) Amount : {CalculateTax()}" +
                   $"\nnet salary : {CalculateNet()}";
        }
    }
}
