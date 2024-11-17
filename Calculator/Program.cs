using System;
namespace Calculat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число:");
            double number1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            double number2 = Convert.ToDouble(Console.ReadLine());
            double result = number1 - number2;
            Console.WriteLine($"Результат: {result}");
        }
    }
}