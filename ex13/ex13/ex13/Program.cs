using System;
namespace Program {
    class Program {
        static void Main(string[] args) {
            Console.Write("Enter a number: ");
            int x = int.Parse(Console.ReadLine());
      

            for (int i = 1; i <= x; i++) {
                if (i % 2 != 0) {
                    Console.WriteLine(i);
                }
            }
        }
    }
}