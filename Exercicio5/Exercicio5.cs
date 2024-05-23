using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio5
{
    internal class Exercicio5
    {
        static int numeroDeVogais (char[] vogais)
        {
            int cont = 0;

            foreach(int vogals in vogais)
            {
                if(vogals == 'a' || vogals == 'e' || vogals == 'i' || vogals == 'o' || vogals == 'u')
                {
                    cont++;
                }
            }

            return cont;
        }

        static void Main(string[] args)
        {
            char[] vogais = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i' };

            Console.WriteLine($"O número de vogais dentro do vetor é : {numeroDeVogais(vogais)}");

            Console.ReadLine();
        }
    }
}
