using System;

namespace exerc5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

            Console.Write("Coloque um número: ");
            double n1 = double.Parse(Console.ReadLine());

            if(n1 > 20)
            {
                Console.WriteLine("A metade desse número é " + (n1 / 2));
            } 
            else
            {
                Console.WriteLine("O dobro desse número é " + (n1 * 2));
            }
            
        }
    }
}
