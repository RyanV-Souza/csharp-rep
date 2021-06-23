using System;

namespace exerc2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

            Console.Write("Digite os graus Celsius para a conversão: ");
            double celsius = double.Parse(Console.ReadLine());

            Console.WriteLine("Fahrenheit: " + ((celsius * 1.8) + 32));


            
        }
    }
}
