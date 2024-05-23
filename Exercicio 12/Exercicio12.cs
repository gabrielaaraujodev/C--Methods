using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_12
{
    internal class Exercicio12
    {
        static void RetornaValoresDaMatriz(int[,] matriz, out int k, out int lin, out int col)
        {
            k = int.MinValue;
            lin = 0;
            col = 0;
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (matriz[i, j] > k)
                    {
                        k = matriz[i, j];
                        lin = i;
                        col = j;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a dimensão da matriz: ");
            int dimensao = int.Parse(Console.ReadLine());

            int[,] matriz = new int[dimensao, dimensao];
            int k, lin, col;
            Random random = new Random();
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = random.Next(1, 101);
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }

            RetornaValoresDaMatriz(matriz, out k, out lin, out col);

            Console.WriteLine($"O maior valor presente na matriz é: {k} e se encontra na posição [{lin},{col}].");

            Console.ReadLine();
        }
    }
}
