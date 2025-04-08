using System;
using System.ComponentModel;

namespace Program {
    class Program {
        static void Main(string[] args) {
            int password = 2002;

            Console.Write("Type the password: ");
            int user_password = int.Parse(Console.ReadLine());

            while (user_password != password) {
                Console.WriteLine("Password Invalid!");
                Console.Write("Type the password: ");
                user_password = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Password Valid!");
        }
    }
}
