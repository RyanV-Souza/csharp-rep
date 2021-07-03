using System;

namespace exerc3
{
    class Program
    {
        static void Main(string[] args)
        {
            int soma = 0;

            for(int x = 0; x < 10; x++)
            {
                Console.Write("Digite o {0}° número: ", (x + 1));
                int n = int.Parse(Console.ReadLine());

                if(n > 10)
                {
                    soma += n;
                }
            }

            Console.WriteLine("=======================");
            Console.WriteLine("Total: {0}", soma);
            Console.ReadKey();
        }
    }
}
