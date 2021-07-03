using System;

namespace exerc2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0, cont = 0;

            while(x < 10)
            {
                Console.Write("Qual é a idade da {0}° pessoa? ", (x +1));
                int idade = int.Parse(Console.ReadLine());

                if(idade > 18)
                {
                    cont += 1;
                }

                x++;
            }

            Console.WriteLine("{0} pessoas possuem mais de 18 anos.", cont);
        }
    }
}
