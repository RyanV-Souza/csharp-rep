using System;

namespace exerc1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor das vendas: ");
            double valor = double.Parse(Console.ReadLine());

            if(valor < 1000)
            {
                Console.WriteLine("Sem prêmios");
            }
            else if (valor >= 1000 && valor < 3000)
            {
                Console.WriteLine("Seu prêmio é de R$150");
            }
            else if (valor > 3000)
            {
                Console.WriteLine("Seu prêmio é de R$300");
            }

        }
    }
}
