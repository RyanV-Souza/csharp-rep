using System;

namespace exerc4
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3;

            Console.WriteLine("Digite o primeiro número");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o terceiro número");
            n3 = int.Parse(Console.ReadLine());

            Console.WriteLine("A média aritmética é: " + ((n1 + n2 + n3) / 3));

        }
    }
}
