using System;

namespace MyApp {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("Type a int number: ");
            int n1 = int.Parse(Console.ReadLine());

            if (n1 < 0) {
                Console.WriteLine($"The number {n1} is NEGATIVE");
            }
            else {
                Console.WriteLine($"The number {n1} is POSITIVE");

            }
        }
    }
}