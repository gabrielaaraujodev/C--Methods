using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio9
{
    internal class Exercicio9
    {
        static void ObterMaiorMenor(double[] vetor, out double maior, out double menor)
        {
            maior = double.MinValue;
            menor = double.MaxValue;
            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] > maior)
                {
                    maior = vetor[i];
                }

                if (vetor[i] < menor)
                {
                    menor = vetor[i];
                }
            }
        }
        static void Main(string[] args)
        {
            double[] vet = new double[10];
            double maior, menor;

            Random random = new Random();

            for (int i = 0; i < vet.Length; i++) { 
                vet[i] = random.Next(1,1001);
            }

            foreach (int i in vet) { 
                Console.Write(i + " ");   
            }

            Console.WriteLine();    

            ObterMaiorMenor(vet, out maior, out menor);
            Console.WriteLine($"O maior número do vetor é: {maior}");
            Console.WriteLine($"O menor número do vetor é: {menor}");
            Console.ReadLine();
        }
    }
}
