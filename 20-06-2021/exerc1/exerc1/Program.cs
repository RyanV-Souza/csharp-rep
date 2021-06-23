using System;

namespace exerc1
{
    class Program
    {
        static void Main(string[] args)
        {

            double raio;

            Console.Write("Digite o raio: ");
            raio = double.Parse(Console.ReadLine());

            Console.WriteLine("Área: " + (Math.PI * Math.Pow(raio, 2)));
            Console.WriteLine("Perimetro: " + (2 * Math.PI * raio));
            Console.WriteLine("Diametro: " + (raio * 2));
        }
    }
}
