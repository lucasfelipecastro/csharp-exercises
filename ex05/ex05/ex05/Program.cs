using System;

namespace MyApp {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("OBJ 1 - INFOS");
            Console.WriteLine("---------------");

            Console.Write("Object 1 code: ");
            int objcode_1 = int.Parse(Console.ReadLine());

            Console.Write("Amount object 1: ");
            int amountobj_1 = int.Parse(Console.ReadLine());

            Console.Write("Price object 1: ");
            double priceobj_1 = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("OBJ 2 - INFOS");
            Console.WriteLine("---------------");

            Console.Write("Object 2 code: ");
            int objcode_2 = int.Parse(Console.ReadLine());

            Console.Write("Amount object 2: ");
            int amountobj_2 = int.Parse(Console.ReadLine());

            Console.Write("Price object 2: ");
            double priceobj_2 = double.Parse(Console.ReadLine());

            double total_price = (amountobj_1 * priceobj_1) + (amountobj_2 * priceobj_2);

            Console.WriteLine();
            Console.WriteLine($"Total Price: ${total_price:F2}");
        }   
    }
}