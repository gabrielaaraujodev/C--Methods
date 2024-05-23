using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio6
{
    internal class Exercicio6
    {
        static void MultiplicarEscalar (int[,] mat, int n)
        {
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    Console.Write($"{mat[i, j]} x {n}" + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    mat[i, j] *= n;
                    Console.Write(mat[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int[,] matriz = new int[4,4];
            Random random = new Random();

            for (int i = 0; i < matriz.GetLength(0); i++) {
                for (int j = 0; j < matriz.GetLength(1); j++) {
                    matriz[i, j] = random.Next(1, 21);
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Escola um fator multiplicador para a matriz: ");
            int fator = int.Parse(Console.ReadLine());

            Console.WriteLine();

            MultiplicarEscalar(matriz, fator);

            Console.ReadLine();
        }
    }
}
