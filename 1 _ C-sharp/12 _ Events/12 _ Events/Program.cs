namespace Events
{
    class Program // subscriber 
    {
        // Events بتخبر أي حدا بستخدمه أنو في إشي صار ، في تغيير 
        static void Main(string[] args)
        {
            var stock = new Stock("Amazon");
            stock.Price = 100;
            stock.ChangeStockPriceBy(0.05m);
            Console.WriteLine(stock.Price);

            stock.OnPriceChanged += Stock_OnPriceChanged;
            stock.ChangeStockPriceBy(0.03m);
            stock.ChangeStockPriceBy(-0.02m);
            stock.ChangeStockPriceBy(0.00m);
            stock.OnPriceChanged -= Stock_OnPriceChanged;
            stock.ChangeStockPriceBy(-0.07m);
            stock.ChangeStockPriceBy(-0.03m);
        }
        private static void Stock_OnPriceChanged(Stock stock, decimal oldPrice)
        {
            string result = "";
            if (stock.Price > oldPrice)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                result = "up";
            }
            else if (oldPrice > stock.Price)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                result = "down";
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                result = "No Change";
            }
            Console.WriteLine($"{stock.Name}: ${stock.Price} - {result}");
        }
    }

    public delegate void StockPriceChangeHandler(Stock stock, decimal oldPrice);


    public class Stock // publisher
    {
        private string name;
        private decimal price;

        public event StockPriceChangeHandler OnPriceChanged; // event لازم ال data type تبعته تكون delegate

        public string Name => this.name;
        public decimal Price { get => this.price; set => this.price = value; }

        public Stock(string stockname)
        {
            this.name = stockname;
        }

        public void ChangeStockPriceBy(decimal percent)
        {
            decimal oldPrice = this.price;
            this.price += Math.Round(this.price * percent, 2);
            if (OnPriceChanged != null) // make sure there is subscriber
            {
                OnPriceChanged(this, oldPrice);  // firing the event
            }
        }
    }
}

