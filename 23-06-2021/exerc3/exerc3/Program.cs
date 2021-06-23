using System;

namespace exerc3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Clear();

            Console.WriteLine("Digite o Fahrenheit: ");
            double fahrenheit = double.Parse(Console.ReadLine());

            Console.WriteLine("Celsius: " + ((fahrenheit - 32) / 1.8));
        }
    }
}
