using System;

namespace exerc5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0;

            Console.WriteLine("Digite um valor:");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Seu antecessor é o " + (n1 - 1));

        }
    }
}
