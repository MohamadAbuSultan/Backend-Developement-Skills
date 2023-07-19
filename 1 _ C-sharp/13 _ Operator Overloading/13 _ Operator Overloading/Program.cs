namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            // operator overloading :
            // user defined type that can overload predefined operators
            // قابلية نوع بيانات محدد من قبل المستخدم لأن يتبنى عوامل محددة مسبقاً كالجمع والطرح
            Money m1 = new Money(10);
            Money m2 = new Money(20);
            Money m3 = m1 + m2;
            Console.WriteLine($"Money m1 = {m1.Amount} , Money m2 = {m2.Amount}");
            Console.WriteLine($"Money m3 = {m3.Amount}");
            Money m4 = m3 - m1 + m2;
            Console.WriteLine($"Money m4 = {m4.Amount}");
            Console.WriteLine(m4 < m1);
            Console.WriteLine(m2 > m1);
            Console.WriteLine($"m4 + 1 : {(++m4).Amount}");
        }
    }
    class Money
    {
        private decimal amount;
        public decimal Amount => amount;

        public Money(decimal value)
        {
            this.amount = Math.Round(value, 2);
        }

        public static Money operator +(Money money1, Money money2)
        {
            var m3 = money1.Amount + money2.Amount;
            return new Money(m3);
        }

        public static Money operator -(Money money1, Money money2)
        {
            var m3 = money1.Amount - money2.Amount;
            return new Money(m3);
        }
        public static bool operator >(Money money1, Money money2)
        {
            return money1.Amount > money2.Amount;
        }
        public static bool operator <(Money money1, Money money2)
        {
            return money1.Amount < money2.Amount;
        }
        public static bool operator >=(Money money1, Money money2)
        {
            return money1.Amount >= money2.Amount;
        }
        public static bool operator <=(Money money1, Money money2)
        {
            return money1.Amount <= money2.Amount;
        }
        public static bool operator ==(Money money1, Money money2)
        {
            return money1.Amount == money2.Amount;
        }
        public static bool operator !=(Money money1, Money money2)
        {
            return money1.Amount != money2.Amount;
        }

        public static Money operator ++(Money money)
        {
            var value = money.Amount;
            return new Money(++value);
        }
        public static Money operator --(Money money)
        {
            var value = money.Amount;
            return new Money(--value);
        }
    }

}

