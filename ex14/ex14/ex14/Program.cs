using System;
    namespace Program {
    class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());
            int n_in = 0;
            int n_out = 0;

            for (int i = 1; i <= n; i++) {
                int x = int.Parse(Console.ReadLine());

                if (x >= 10 && x <= 20) {
                    n_in++;
                }
                else {
                    n_out++;
                }
            }
            Console.WriteLine($"Count In: {n_in}");
            Console.WriteLine($"Count Out: {n_out}");
        
        }
    }
}