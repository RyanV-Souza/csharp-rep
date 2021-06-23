using System;

namespace exerc2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, delta;

            Console.WriteLine("Digite o valor de A: ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de B: ");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de C: ");
            c = double.Parse(Console.ReadLine());

            delta = (b * b) - (4 * a * c);
            
            if(delta >= 0){
                Console.WriteLine("X1: " + (((-b) + Math.Sqrt(delta)) / 2 * a));
                Console.WriteLine("X2: " + (((-b) - Math.Sqrt(delta)) / 2 * a));
            }
            else{
                Console.WriteLine("Menor que 0");
            }

        }
    }
}
