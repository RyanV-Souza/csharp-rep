using System;

namespace exerc8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            Console.Write("Digite um número: ");
            double n1 = double.Parse(Console.ReadLine());

            if(n1 > 0)
            {
                Console.WriteLine("Seu número é positivo");
            }
            else if (n1 == 0)
            {
                Console.WriteLine("Seu número é o zero");
            }
            else
            {
                Console.WriteLine("Seu número é negativo");
            }
        }
    }
}
