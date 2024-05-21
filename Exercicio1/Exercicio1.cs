using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    class Exercicio1
    {
        static int OhNumeroEhMaior(int [] numeros)
        {
            int maiorNumero = int.MinValue;
            for (int i = 0; i < numeros.Length; i++)
            {
                if(numeros[i] > maiorNumero)
                {
                    maiorNumero = numeros[i];
                }
            }

            return maiorNumero;
        }

        static void Main(string[] args)
        {
            int[] numeros = new int[4];
            Random rand = new Random();

            for(int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = rand.Next(1, 11);
            }

            foreach (int i in numeros)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine($"O maior número do vetor é: {OhNumeroEhMaior(numeros)}");

            Console.ReadLine();
        }

    }
}
