using System;

namespace exerc1
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome, primeiroNome, sobrenome;
            
            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();
            nome = nome.Trim();

            string[] nomeSeparado = nome.Split(' ');
            primeiroNome = nomeSeparado[0];
            sobrenome = nomeSeparado[nomeSeparado.Length - 1];

            Console.WriteLine("Nome: " + primeiroNome);
            Console.WriteLine("Sobrenome: " + sobrenome);
            Console.WriteLine("Substituição: " + nome.ToLower().Replace("a", "o"));




        }
    }
}
