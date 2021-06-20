using System;

namespace exerc3
{
    class Program
    {
        static void Main(string[] args)
        {
            string nomeCompleto;

            Console.Write("Digite seu nome: ");
            nomeCompleto = Console.ReadLine();

            string[] nomeSeparado = nomeCompleto.Trim().Split(' ');

            Console.WriteLine("Seu nome e-mail é " + nomeSeparado[0].ToLower() + "." + nomeSeparado[nomeSeparado.Length - 1].ToLower() + "@fatec.sp.gov.br");
        }
    }
}
