using System;

namespace exerc3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;

            do
            {
                Console.WriteLine("----------------------------------");
                Console.Write("Digite um número: ");
                n = int.Parse(Console.ReadLine());

                if(n > 1)
                {
                    Console.WriteLine("----------------------------------");
                    Console.WriteLine("Digite um número menor ou igual a 1");
                }

            } while (n > 1);

            Console.WriteLine("O número {0} é menor ou igual a 1! Parabéns", n);
        }
    }
}
