using System;

namespace exerc1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("FORMULAS ");
            Console.WriteLine("============================= ");
            Console.WriteLine("1 - Bhaskara ");
            Console.WriteLine("2 - Força ");
            Console.WriteLine("3 - Velocidade ");
            Console.WriteLine("============================= ");
            Console.Write("Digite uma opção: ");
            int op = int.Parse(Console.ReadLine());
            Console.Clear();

            switch(op)
            {
                case 1:
                    Console.WriteLine("BHASKARA");
                    Console.WriteLine("============================= ");
                    Console.WriteLine("Digite o valor de A");
                    double a = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o valor de B");
                    double b = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o valor de C");
                    double c = double.Parse(Console.ReadLine());

                    double delta = (b * b) - (4 * a * c);
                    double raiz = Math.Sqrt(delta);

                    double x1 = ((-b) + raiz) / (2 * a);
                    double x2 = ((-b) - raiz) / (2 * a);

                    Console.WriteLine("O valor de X1 é " + x1);
                    Console.WriteLine("O valor de X2 é " + x2);
                    break;

                case 2:
                    Console.WriteLine("FORÇA");
                    Console.WriteLine("============================= ");
                    Console.WriteLine("Digite a massa: ");
                    double massa = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite a aceleração: ");
                    double aceleracao = double.Parse(Console.ReadLine());

                    Console.WriteLine("Força: " + (massa * aceleracao));

                    break;

                case 3:
                    Console.WriteLine("VELOCIDADE");
                    Console.WriteLine("============================= ");
                    Console.WriteLine("Digite a velocidade inicial");
                    double velocidadeInicial = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite a aceleração");
                    double aceleracaoVelocidade = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o tempo");
                    double tempo = double.Parse(Console.ReadLine());

                    Console.WriteLine("A velocidade é " + (velocidadeInicial + (tempo * aceleracaoVelocidade)));

                    break;
            }

            Console.ReadKey();
        }
    }
}
