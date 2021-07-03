using System;

namespace exerc2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("-----------------------");

            for (int x = 1; x <= n; x++)
            {
                Console.WriteLine(x);
            }

            Console.ReadKey();
        }
    }
}
