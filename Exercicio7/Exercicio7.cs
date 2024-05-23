using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio7
{
    internal class Exercicio7
    {
        static double ResultadoSoma(int n)
        {
            double soma = 1;

            for (int i = 2; i <= n; i++)
            {
                soma += (double)1/i;
            }

            return soma;
        }
        static void Main(string[] args)
        {
            int n;
            do
            {
                Console.WriteLine("Informe um número: ");
                n = int.Parse(Console.ReadLine());

                if (n > 0)
                {
                    Console.WriteLine($"O resultado da soma é: {ResultadoSoma(n)}");
                }

            } while (n < 0);


            Console.ReadLine();
        }
    }
}
