using System;

namespace exerc2
{
    class Program
    {
        public static void verificarTriangulo(int n1, int n2, int n3)
        {
            if((n1 < n2 + n3) && (n2 < n1 + n3) && (n3 < n2 + n1))
            {
               Console.WriteLine("É um triângulo");
            }
            else
            {
                Console.WriteLine("Não é um triângulo");
               
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Digite a primeira reta");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a segunda reta");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a terceira reta");
            int n3 = int.Parse(Console.ReadLine());
            Console.WriteLine("--------------------------------------");

            verificarTriangulo(n1, n2, n3);
            Console.ReadKey();
            
        }
    }
}
