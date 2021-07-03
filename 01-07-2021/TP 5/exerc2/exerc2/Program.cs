using System;

namespace exerc2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número");
            int valor = int.Parse(Console.ReadLine());

            if(valor % 3 == 0 && valor % 7 == 0)
            {
                Console.WriteLine("É múltiplo de 3 e 7");
            }
            else
            {
                Console.WriteLine("Não é múltiplo");
            }
        }
    }
}
