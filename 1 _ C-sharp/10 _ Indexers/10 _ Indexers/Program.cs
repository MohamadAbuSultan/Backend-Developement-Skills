namespace Indexer
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            arr[0] = 33; // index
            Console.WriteLine(arr[0]);

            string str = "Hello ";
            var c = str[0]; // index

            // integer لل index لا يوجد 
            // indexers أي كائن يوجد بداخله أجزاء يفضل إستخدام  

            var ip = new IP(192, 168, 1, 2);

            var firstSegment = ip[0];
            Console.WriteLine($"IP ADDRESS: {ip.IPAddress}");
            Console.WriteLine($"First segment: {firstSegment}");

            // var ip = new IP("192.168.1.2"); هذا للطريقة الثانية

            int[,] inputs = new int[,]
            {
                {1,2,3,4,5,6,7,8,9 },
                {1,2,3,4,5,6,7,8,9 },
                {1,2,3,4,5,6,7,8,9 },
                {1,2,3,4,5,6,7,8,9 },
                {1,2,3,4,5,6,7,8,9 },
                {1,2,3,4,5,6,7,8,9 },
                {1,2,3,4,5,6,7,8,9 },
                {1,2,3,4,5,6,7,8,9 },
                {1,2,3,4,5,6,7,8,9 }
            };
            var suduko = new Suduko(inputs);
            Console.WriteLine(suduko[5, 5]); // 6
            suduko[5, 5] = 10;
            Console.WriteLine(suduko[5, 5]); // 6 لأنوا القيمة إلي أضفتها مش موجودة أصلاً بكل المصفوفة

        }
    }

    public class IP
    {
        private int[] segments = new int[4];
        // ip عبارة عن 4 أجزاء ***.***.***.*** 
        // مثلاً 192.168.1.2

        public int this[int index] // indexer
        {
            get
            {
                return segments[index];
            }
            set
            {
                segments[index] = value;
            }
        }

        //طريقة أخرى 
        //public IP(string IPAddress)
        //{
        //    var segs = IPAddress.Split(".");
        //    for (int i = 0; i < segs.Length; i++)
        //    {
        //        segments[i] = Convert.ToInt32(segs[i]);
        //    }
        //}
        // segment (1-255 valid number for ip)
        public IP(int segment1, int segment2, int segment3, int segment4)
        {
            segments[0] = segment1;
            segments[1] = segment2;
            segments[2] = segment3;
            segments[3] = segment4;
        }

        public string IPAddress => string.Join(".", segments);
    }

    public class Suduko
    {
        private int[,] _matrix;

        public int this[int row, int col]
        {
            get
            {
                if (row < 0 || row > _matrix.GetLength(0) - 1) return -1; // getlength 0 return number of  rows
                if (col < 0 || col > _matrix.GetLength(1) - 1) return -1; // getlength 1 return number of columns
                return _matrix[row, col];
            }
            set
            {
                if (value < 1 || value > _matrix.GetLength(0)) return;
                _matrix[row, col] = value;
            }
        }
        public Suduko(int[,] matrix)
        {
            _matrix = matrix;
        }
    }
}

