using System;

namespace exerc1
{
    class Program
    {
        public static double adicao(double n1, double n2)
        {
            return n1 + n2;
        }

        public static double subtracao(double n1, double n2)
        {
            return n1 - n2;
        }

        public static double multiplicacao(double n1, double n2)
        {
            return n1 * n2;
        }

        public static double divisao(double n1, double n2)
        {
            return n1 / n2;
        }



        static void Main(string[] args)
        {
            int op = 1;
            do
            {
                Console.Clear();
                Console.WriteLine("------------------------------");
                Console.WriteLine("CALCULADORA");
                Console.WriteLine("------------------------------");
                Console.WriteLine("1 - Adição");
                Console.WriteLine("2 - Subtração");
                Console.WriteLine("3 - Multiplicação");
                Console.WriteLine("4 - Divisão");
                Console.WriteLine("0 - Sair");
                Console.WriteLine("------------------------------");
                Console.Write("Selecione uma opção: ");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Console.Clear();
                        double n1 = 0, n2 = 0;

                        Console.Write("Digite um número: ");
                        n1 = double.Parse(Console.ReadLine());
                        Console.Write("Digite outro número: ");
                        n2 = double.Parse(Console.ReadLine());

                        double resultado = adicao(n1, n2);

                        Console.WriteLine("O resultado é {0}", resultado);
                        Console.WriteLine("Aperte qualquer tecla para sair");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();

                        Console.Write("Digite um número: ");
                        n1 = double.Parse(Console.ReadLine());
                        Console.Write("Digite outro número: ");
                        n2 = double.Parse(Console.ReadLine());

                        resultado = subtracao(n1, n2);

                        Console.WriteLine("O resultado é {0}", resultado);
                        Console.WriteLine("Aperte qualquer tecla para sair");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();

                        Console.Write("Digite um número: ");
                        n1 = double.Parse(Console.ReadLine());
                        Console.Write("Digite outro número: ");
                        n2 = double.Parse(Console.ReadLine());

                        resultado = multiplicacao(n1, n2);

                        Console.WriteLine("O resultado é {0}", resultado);
                        Console.WriteLine("Aperte qualquer tecla para sair");
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();

                        Console.Write("Digite um número: ");
                        n1 = double.Parse(Console.ReadLine());
                        Console.Write("Digite outro número: ");
                        n2 = double.Parse(Console.ReadLine());

                        resultado = divisao(n1, n2);

                        Console.WriteLine("O resultado é {0}", resultado);
                        Console.WriteLine("Aperte qualquer tecla para sair");
                        Console.ReadKey();
                        break;
                }
                    

            } while (op != 0);

            Console.ReadKey();


        }
    }
}
