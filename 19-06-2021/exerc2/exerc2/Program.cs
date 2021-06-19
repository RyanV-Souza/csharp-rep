using System;

namespace exerc2
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2;

            Console.WriteLine("Digite um número:");
            n1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite outro número:");
            n2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Soma: " + (n1 + n2));
            Console.WriteLine("Subtração: " + (n1 - n2));
            Console.WriteLine("Multiplicação: " + (n1 * n2));
            Console.WriteLine("Divisão: " +  (n1 / n2));



        }
    }
}
