using System;

namespace exerc3
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor, total, quantidade;
            string nome;

            Console.Write("Digite o nome: ");
            nome = Console.ReadLine();
            Console.Write("Digite o preço unitário: ");
            valor = double.Parse(Console.ReadLine());
            Console.Write("Digite a quantidade: ");
            quantidade = double.Parse(Console.ReadLine());

            total = quantidade * valor;

            if(quantidade <= 5)
            {
                Console.WriteLine("==== PRODUTO: " + nome + " ====");
                Console.WriteLine("O total bruto é: " + total);
                Console.WriteLine("O desconto é de: " + (total * 0.02));

                total = total - (total * 0.02);

                Console.WriteLine("O valor final a pagar é: " + total);

            }
            else if (quantidade > 5 && quantidade <= 10)
            {
                Console.WriteLine("==== PRODUTO: " + nome + " ====");
                Console.WriteLine("O total bruto é: " + total);
                Console.WriteLine("O desconto é de: " + (total * 0.03));

                total = total - (total * 0.03);

                Console.WriteLine("O valor final a pagar é: " + total);

            }
            else
            {
                Console.WriteLine("==== PRODUTO: " + nome + " ====");
                Console.WriteLine("O total bruto é: " + total);
                Console.WriteLine("O desconto é de: " + (total * 0.05));

                total = total - (total * 0.05);

                Console.WriteLine("O valor final a pagar é: " + total);
            }

        }
    }
}
