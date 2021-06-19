using System;

namespace exerc6
{
    class Program
    {
        static void Main(string[] args)
        {
            double alturaRetangulo, baseRetangulo; 

            Console.WriteLine("Digite a base do retângulo: ");
            baseRetangulo = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a altura do retângulo: ");
            alturaRetangulo = double.Parse(Console.ReadLine());

            Console.WriteLine("A área do retângulo é " + (baseRetangulo * alturaRetangulo));

        }
    }
}
