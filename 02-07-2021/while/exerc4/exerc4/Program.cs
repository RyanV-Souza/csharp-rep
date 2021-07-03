using System;

namespace exerc4
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1, z = 1;
            string sequencia = "";

            while(x <= 10)
            {
                sequencia += "(" + Convert.ToString(x) + ",";
                while(z <= 10)
                {
                    sequencia += " " + Convert.ToString(z);

                    if(z == 10)
                    {
                        sequencia += ")";
                    }

                    z++;
                }
                Console.WriteLine(sequencia);

                sequencia = "";
                z = 1;

                x++;
            }

            Console.ReadKey();


        }
    }
}
