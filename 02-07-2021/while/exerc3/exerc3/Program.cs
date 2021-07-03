using System;

namespace exerc3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0, cont = 0;

            while(x < 10){
                Console.Write("Digite {0}° número: ", (x + 1));
                double n = double.Parse(Console.ReadLine());

                if(n < 0)
                {
                    cont++;
                }

                x++;
            }

            Console.WriteLine("Existem {0} números negativos", cont);
            Console.ReadKey();
        }
    }
}
