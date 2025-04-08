using System;

namespace MyApp {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Type 2 integer numbers: ");
            Console.WriteLine("------------------------");

            Console.Write("A: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("B: ");
            int b = int.Parse(Console.ReadLine());

            if (a == b) {
                Console.WriteLine("They are multiples");
            }
            else if (a > b) {
                if (a % b == 0) {
                    Console.WriteLine("They are multiples");
                }
                else {
                    Console.WriteLine("They are NOT multiples");
                }
            }
            else {
                if (b % a == 0) {
                    Console.WriteLine("They are multiples");
                }
                else {
                    Console.WriteLine("They are NOT multiples");
                }
            }
        }
    }
}
