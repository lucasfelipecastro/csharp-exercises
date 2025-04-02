using System;

namespace MyApp {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Type below three values (A, B & C): ");
            Console.WriteLine("---------------------------------------");

            Console.Write("A: ");
            float a = float.Parse(Console.ReadLine());

            Console.Write("B: ");
            float b = float.Parse(Console.ReadLine());

            Console.Write("C: ");
            float c = float.Parse(Console.ReadLine());

            Console.WriteLine();

            float field_triangle = (a * c) / 2;
            float field_circle = 3.14159f * (c * c);
            float field_trapezoid = ((a + b) * c ) / 2;
            float field_square = (b * b);
            float field_rectangle = (a * b);

            Console.WriteLine($"Triangle: {field_triangle:F3}");
            Console.WriteLine($"Circle: {field_circle:F3}");
            Console.WriteLine($"Trapezoid: {field_trapezoid:F3}");
            Console.WriteLine($"Square: {field_square:F3}");
            Console.WriteLine($"Rectangle: {field_rectangle:F3}");
        }
    }
}