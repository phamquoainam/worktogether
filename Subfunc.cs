using System;

namespace HelloWorld
{
    class Program
    {
        public static double TinhHieu(double a, double b)
        {
            return a - b;
        }

    

        static void Main(string[] args)
        {
            Console.Write("a = ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b = ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Hiệu của {a} và {b} là: {TinhHieu(a, b)}");
        }
    }
}
