using System;

namespace exerc4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a 1 nota: ");
            double n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a 2 nota: ");
            double n2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a 3 nota: ");
            double n3 = double.Parse(Console.ReadLine());

            double mediaFinal = (n1 * 0.25) + (n2 * 0.25) + (n3 * 0.50);

            if(mediaFinal < 6.0)
            {
                Console.WriteLine("Conceito D");
            }
            else if (mediaFinal >= 6.0 && mediaFinal < 7.5)
            {
                Console.WriteLine("Conceito C");
            }
            else if (mediaFinal >= 7.5 && mediaFinal < 9.0)
            {
                Console.WriteLine("Conceito B");
            }
            else if(mediaFinal >= 9)
            {
                Console.WriteLine("Conceito A");
            }

        }
    }
}
