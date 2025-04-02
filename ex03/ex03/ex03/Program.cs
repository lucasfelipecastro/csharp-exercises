using System;

namespace MyApp {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Type four int values: ");
            Console.WriteLine("---------------------");

            Console.Write("A: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("B: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("C: ");
            int c = int.Parse(Console.ReadLine());

            Console.Write("D: ");
            int d = int.Parse(Console.ReadLine());


            int ab = (a * b);
            int cd = (c * d);

            int dif = (ab - cd);

            Console.WriteLine($"Difference: {dif}");
        }
    }
}