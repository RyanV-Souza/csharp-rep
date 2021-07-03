using System;

namespace exerc1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;

            do
            {
                Console.Write("Digite um número par: ");
                n = int.Parse(Console.ReadLine());

                if(n % 2 != 0)
                {
                    Console.WriteLine("Digite um número par correto!");
                    Console.WriteLine("---------------------------------");
                }

            } while (n % 2 != 0);

            Console.WriteLine("---------------------------------");
            Console.WriteLine("O número {0} é par", n);
            Console.ReadKey();


        }
    }
}
