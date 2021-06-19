using System;

namespace exerc8
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3, mediaFinal;

            Console.Write("Digite a primeira nota: ");
            n1 = double.Parse(Console.ReadLine());
            Console.Write("Digite a segunda nota: ");
            n2 = double.Parse(Console.ReadLine());
            Console.Write("Digite a terceira nota: ");
            n3 = double.Parse(Console.ReadLine());

            mediaFinal = ((n1 * 2) + (n2 * 3) + (n3 * 5)) / 10;

            Console.WriteLine("A média final é " + mediaFinal);

        }
    }
}
