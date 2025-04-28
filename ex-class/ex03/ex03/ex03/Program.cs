using System;
using ex03;

namespace Ex03 {
    class Program {
        static void Main(string[] args) {
            Rectangle rectangle = new Rectangle();
            Console.WriteLine("Enter the width and heigth of the Rectangle: ");

            Console.Write("Width: ");
            rectangle.Width = double.Parse(Console.ReadLine());

            Console.Write("Height: ");
            rectangle.Height = double.Parse(Console.ReadLine());


            Console.WriteLine($"Area: {rectangle.Area():F2}");
            Console.WriteLine($"Perimeter: {rectangle.Perimeter():F2}");
            Console.WriteLine($"Diagonal: {rectangle.Diagonal():F2}");
        }
    }
}
