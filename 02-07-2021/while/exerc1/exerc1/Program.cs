using System;

namespace exerc1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o número inicial");
            int i = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o número final");
            int f = int.Parse(Console.ReadLine());
            Console.WriteLine("---------------------------");

            while(i <= f)
            {

                Console.WriteLine(i);
                i += 1;
            }

            Console.ReadKey();
        }
    }
}
