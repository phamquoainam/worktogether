using System;

namespace HelloWorld
{
    class Program
    {
        // Hàm tính tổng của hai số
        public static double TinhTong(double a, double b)
        {
            return a + b;
        }

        // Hàm tính hiệu của hai số
        public static double TinhHieu(double a, double b)
        {
            return a - b;
        }

        // Hàm tính tích của hai số
        public static double TinhTich(double a, double b)
        {
            return a * b;
        }

        // Hàm tính thương của hai số
        // Cần kiểm tra điều kiện chia cho 0
        public static double TinhThuong(double a, double b)
        {
            if (b == 0)
            {
                throw new ArgumentException("Không thể chia cho 0");
            }
            return a / b;
        }

        static void Main(string[] args)
        {
            Console.Write("a = ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b = ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Tổng của {a} và {b} là: {TinhTong(a, b)}");
            Console.WriteLine($"Hiệu của {a} và {b} là: {TinhHieu(a, b)}");
            Console.WriteLine($"Tích của {a} và {b} là: {TinhTich(a, b)}");

            try
            {
                Console.WriteLine($"Thương của {a} và {b} là: {TinhThuong(a, b)}");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
