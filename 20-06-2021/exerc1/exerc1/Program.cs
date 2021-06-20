using System;

namespace exerc1
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome, primeiroNome, sobrenome;
            int count;
            
            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();
            nome = nome.Trim().ToLower();

            string[] nomeSeparado = nome.Split(' ');
            primeiroNome = nomeSeparado[0];
            sobrenome = nomeSeparado[nomeSeparado.Length - 1];

            Console.WriteLine("Nome: " + primeiroNome);
            Console.WriteLine("Sobrenome: " + sobrenome);
            Console.WriteLine("Substituição: " + nome.Replace("a", "o"));




        }
    }
}
