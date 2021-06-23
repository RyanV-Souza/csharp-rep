using System;

namespace exerc1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Console.WriteLine("Digite seu salário:");
            double salario = double.Parse(Console.ReadLine());

            double quantidadeSalario = salario / 1100;
            quantidadeSalario = Math.Round(quantidadeSalario);

            Console.WriteLine("Você recebe " + quantidadeSalario + " salários minimos");
            Console.ReadKey();

            
            
        }
    }
}
