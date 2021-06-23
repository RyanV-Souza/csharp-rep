using System;

namespace exerc7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            Console.Write("Digite o salário: ");
            double salario = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor da prestação: ");
            double prestacao = double.Parse(Console.ReadLine());

            if((salario * 0.30) >  prestacao)
            {
                Console.WriteLine("Seu empréstimo foi aprovado");
            }
            else
            {
                Console.WriteLine("Seu empréstimo foi recusado");
            }
        }
    }
}
