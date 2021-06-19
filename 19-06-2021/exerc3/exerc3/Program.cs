using System;

namespace exerc3
{
    class Program
    {
        static void Main(string[] args)
        {
            int ano;
            
            Console.WriteLine("Digite o ano que você nasceu: ");
            ano = int.Parse(Console.ReadLine());

            Console.WriteLine("Você tem " + (2021 - ano) + " anos");

        }
    }
}
