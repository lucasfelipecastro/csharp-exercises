using System;

namespace Program {
    class Program {
        static void Main(string[] args) {
            while (true) {
                Console.Write("Coordinate X: ");
                int x = int.Parse(Console.ReadLine());
                Console.Write("Coordinate Y: ");
                int y = int.Parse(Console.ReadLine());
                Console.WriteLine();

                if (x == 0 || y == 0) {
                    break;
                }

                if (x > 0 && y > 0) {
                    Console.WriteLine("Quadrant I");
                }
                else if (x < 0 && y > 0) {
                    Console.WriteLine("Quadrant II");
                }
                else if (x < 0 && y < 0) {
                    Console.WriteLine("Quadrant III");
                }
                else if (x > 0 && y < 0) {
                    Console.WriteLine("Quadrant IV");
                }

                Console.WriteLine();
            }
        }
    }
}