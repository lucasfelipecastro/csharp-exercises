using System;

namespace MyApp {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("Type the radius value: ");
            double radius = double.Parse(Console.ReadLine());
            double pi = 3.14159;
            double field = pi * (radius * radius);

            Console.Write($"Output: {field:F4}");
        }
    }
}