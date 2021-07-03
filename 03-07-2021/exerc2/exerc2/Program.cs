using System;

namespace exerc2
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 0;
            double nota, media = 0;
            string resposta = " ";

            do
            {
                Console.WriteLine("----------------------------------");
                Console.Write("Digite a {0}° nota: ", (cont + 1));
                nota = double.Parse(Console.ReadLine());

                if(nota >= 0 && nota <= 10)
                {
                    media += nota;
                    cont++;
                }
                else
                {
                    Console.WriteLine("----------------------------------");
                    Console.WriteLine("Digite uma nota entre 0 e 10!");
                }
                Console.WriteLine("----------------------------------");
                Console.WriteLine("Deseja continuar? [S/N]");
                resposta = Console.ReadLine();

                resposta = resposta.Trim().ToUpper();

                if(resposta == "N")
                {
                    break;
                }

            } while (cont < 4);

            if(cont == 4)
            {
                Console.WriteLine("----------------------------------");
                Console.WriteLine("A média final é: {0}", (media / 4));
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("----------------------------------");
                Console.WriteLine("Não possui notas suficientes para a média");
                Console.ReadKey();
            }
        }
    }
}
