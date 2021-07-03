using System;

namespace exerc3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("AUMENTO DE SALÁRIO");
            Console.WriteLine("==================================");
            Console.WriteLine("CARGOS");
            Console.WriteLine("1 - Gerente");
            Console.WriteLine("2 - Analista");
            Console.WriteLine("3 - Técnico");
            Console.Write("Digite uma das opções: ");
            int op = int.Parse(Console.ReadLine());
            Console.Write("Digite o salário do funcionário: ");
            double salario = double.Parse(Console.ReadLine());

            switch (op)
            {
                case 1:
                    Console.WriteLine("==================================");
                    Console.WriteLine("Salário antigo: " + salario);
                    Console.WriteLine("Diferença: " + (salario * 0.10));
                    Console.Write("Salário atual: " + (salario + (salario * 0.10)));
                    break;
                case 2:
                    Console.WriteLine("==================================");
                    Console.WriteLine("Salário antigo: " + salario);
                    Console.WriteLine("Diferença: " + (salario * 0.20));
                    Console.Write("Salário atual: " + (salario + (salario * 0.20)));
                    break;
                case 3:
                    Console.WriteLine("==================================");
                    Console.WriteLine("Salário antigo: " + salario);
                    Console.WriteLine("Diferença: " + (salario * 0.30));
                    Console.Write("Salário atual: " + (salario + (salario * 0.30)));
                    break;
            }
            Console.ReadKey();

            
        }
    }
}
