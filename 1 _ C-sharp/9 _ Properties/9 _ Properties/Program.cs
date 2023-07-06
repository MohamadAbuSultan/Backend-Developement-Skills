namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            // Properties promote Encapsulation
            Dollar dollar = new Dollar(1.99m);
            dollar.SetAmount(1.99m); // set
            Console.WriteLine(dollar.Amount); // get
            Console.WriteLine(dollar.IsZero); // get
        }
    }

    public class Dollar
    {
        private decimal _amount; // backing field الفيلد إلي هيتم التخزين والقراءة منه  
        public decimal Amount
        {
            // property accessors in c# (set&get)
            get
            {
                return this._amount;
            }
            private set
            {
                // validation أفضل في ال private 
                // في ال public لا يوجد validation
                // if (value <= 0)
                // {
                //     this._amount = 0;
                // }
                // else
                // {
                //     this._amount = value; // value هي القيمة إلي أسندها اليوزر أو القيمة إلي وضعها اليوزر
                // }
                this._amount = ProcessValue(value);
            }
        }
        public bool IsZero => _amount == 0; // Expression Bodied Property

        public decimal ConversionFactor { get; set; } = 1.99m; // Property And Initialization مستحيل حد يقدر يخزن فيه

        public void SetAmount(decimal value) // set private هذا عملناه عشان علمنا فوق ال
        {
            Amount = value;
        }

        public Dollar(decimal amount)
        {
            this._amount = ProcessValue(amount);
        }

        private decimal ProcessValue(decimal value) => value < 0 ? 0 : Math.Round(value);
    }

}

//public decimal Amount
//{
//    get
//    {
//        return this._amount;
//    }
//    private set
//    {
//        this._amount = value;
//    }
//}

// الكود إلي من سطر 59 نفسه إلي بسطر 75
// public decimal Amount { get; set; } // Automatic Property هذا بنسميه