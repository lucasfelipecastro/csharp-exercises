using System;
using ex00;

namespace Program {
    class Program {
        static void Main(string[] args) {
            Console.Write("Dollar Quote: $");
            double quote = double.Parse(Console.ReadLine());

            Console.Write("How much dollars are you buying: $");
            double amount = double.Parse(Console.ReadLine());

            double result = CoinConvert.ConvertDollarToBrl(quote, amount);

            Console.WriteLine($"Amount to be paid in BRL: R${result:F2}");
        }
    }

}