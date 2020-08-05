using System;

namespace CenturyYear
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите год, чтобы узнать век: ");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{(year - 1) / 100 + 1} век");
            Console.ReadKey();
        }
    }
}