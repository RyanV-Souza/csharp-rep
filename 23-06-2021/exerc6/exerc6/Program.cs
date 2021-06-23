using System;

namespace exerc6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            Console.Write("Digite um número: ");
            int n1 = int.Parse(Console.ReadLine());

            if(n1 % 5 == 0)
            {
                Console.WriteLine("É múltiplo de 5");
            }
            else
            {
                Console.WriteLine("Não é múltioplo de 5");
            }

            
        }
    }
}
