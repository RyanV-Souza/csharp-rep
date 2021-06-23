using System;

namespace exerc4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            Console.WriteLine("Digite seu peso: ");
            double peso = double.Parse(Console.ReadLine());

            Console.WriteLine("Peso em gramas: " + ((peso / 1000) + (peso * 0.10)));
        }
    }
}
