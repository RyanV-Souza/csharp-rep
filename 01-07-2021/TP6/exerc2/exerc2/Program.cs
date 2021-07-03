using System;

namespace exerc2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CALCULADORA");
            Console.WriteLine("===========================");
            Console.WriteLine("1 - Somar");
            Console.WriteLine("2 - Subtrair");
            Console.WriteLine("3 - Multiplicar");
            Console.WriteLine("4 - Dividir");
            Console.Write("Selecione uma opção: ");
            int op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1:
                    Console.WriteLine("SOMAR");
                    Console.WriteLine("===========================");
                    Console.WriteLine("Digite o primeiro valor: ");
                    double v1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o segundo valor: ");
                    double v2 = double.Parse(Console.ReadLine());

                    Console.WriteLine("Resultado: " + (v1 + v2));
                    break;
                case 2:
                    Console.WriteLine("SUBTRAIR");
                    Console.WriteLine("===========================");
                    Console.WriteLine("Digite o primeiro valor: ");
                    v1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o segundo valor: ");
                    v2 = double.Parse(Console.ReadLine());

                    Console.WriteLine("Resultado: " + (v1 - v2));
                    break;
                case 3:
                    Console.WriteLine("MULTIPLICAR");
                    Console.WriteLine("===========================");
                    Console.WriteLine("Digite o primeiro valor: ");
                    v1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o segundo valor: ");
                    v2 = double.Parse(Console.ReadLine());

                    Console.WriteLine("Resultado: " + (v1 * v2));
                    break;
                case 4:
                    Console.WriteLine("DIVIDIR");
                    Console.WriteLine("===========================");
                    Console.WriteLine("Digite o primeiro valor: ");
                    v1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o segundo valor: ");
                    v2 = double.Parse(Console.ReadLine());

                    Console.WriteLine("Resultado: " + (v1 / v2));
                    break;

            }

        }
    }
}
