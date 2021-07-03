using System;

namespace exerc4
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = 0, soma = 0;

            do
            {
                Console.WriteLine("----------------------------------");
                Console.Write("Digite um número: ");
                n = double.Parse(Console.ReadLine());

                soma += n;

            } while (n != 0);
            Console.WriteLine("----------------------------------");
            Console.WriteLine("A soma de todos os números digitados é {0}", soma);
        }
    }
}
