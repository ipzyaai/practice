using System;
using System.Text;

namespace SumOfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = UTF8Encoding.UTF8;

            Console.Write("Введіть перше число: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введіть друге число: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double sum = num1 + num2;
            Console.WriteLine($"Сума чисел: {sum}");

            Console.ReadKey();
        }
    }
}