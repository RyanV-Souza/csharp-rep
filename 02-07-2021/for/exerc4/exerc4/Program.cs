using System;

namespace exerc4
{
    class Program
    {
        static void Main(string[] args)
        {
            int menor = 0, maior = 0;
            for (int x = 0; x < 20; x++)
            {
                Console.Write("Digite o {0}° número: ", (x + 1));
                int n = int.Parse(Console.ReadLine());

                if ((n < menor) || (menor == 0))
                {
                    menor = n;
                }
                else if ((n > maior) || (maior == 0))
                {
                    maior = n;
                }

            }

            Console.WriteLine("Maior: {0}", maior);
            Console.WriteLine("Menor: {0}", menor);
        }

    }
}
