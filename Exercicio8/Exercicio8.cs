using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio8
{
    internal class Exercicio8
    {
        static double ResultadoSoma(int n) {
            double soma = 0;
            for (int i = 1; i <= n; i++)
            {
                soma += ((Math.Pow(i, 2) + 1) / (i + 3));
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
