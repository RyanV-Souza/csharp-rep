using System;

namespace exerc7
{
    class Program
    {
        static void Main(string[] args)
        {
            int ano, mes, dia, total;

            Console.WriteLine("Digite sua idade: ");
            Console.Write("Anos: ");
            ano = int.Parse(Console.ReadLine());
            Console.Write("Meses: ");
            mes = int.Parse(Console.ReadLine());
            Console.Write("Dias: ");
            dia = int.Parse(Console.ReadLine());

            Console.WriteLine("Sua idade equivale a " + (dia + (ano * 365) + (mes * 30)) + " dias");



        }
    }
}
