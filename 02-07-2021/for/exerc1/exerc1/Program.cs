using System;

namespace exerc1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número");
            int n = int.Parse(Console.ReadLine());

            for(int x = 0; x <= 10; x++)
            {
                Console.WriteLine("{0} x {1} = {2}", n, x, (x * n));
            }

            Console.ReadKey();
        }
    }
}
