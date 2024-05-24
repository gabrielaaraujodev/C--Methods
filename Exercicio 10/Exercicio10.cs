using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_10
{
    internal class Exercicio10
    {
        static void LerMatriculas(int[] turma)
        {
            for (int i = 0; i < turma.Length; i++)
            {
                Console.Write($"Matrícula {i + 1}: ");
                turma[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        static int[] EncontrarMatriculasComuns(int[] turma1, int[] turma2)
        {

            int[] comuns = new int[10];
            int indice = 0;

            foreach (int matricula in turma1)
            {
                if (Array.BinarySearch(turma2, matricula) >= 0)
                {
                    comuns[indice] = matricula;
                    indice++;
                }
            }

            return comuns;
        }


        static void Main(string[] args)
        {
            int[] turma1 = new int[10];
            int[] turma2 = new int[10];

            Console.WriteLine("Insira as matrículas dos alunos da turma 1:");
            LerMatriculas(turma1);

            Console.WriteLine("Insira as matrículas dos alunos da turma 2:");
            LerMatriculas(turma2);

            int[] matriculasComuns = EncontrarMatriculasComuns(turma1, turma2);

            if (matriculasComuns.Length > 0)
            {
                Console.WriteLine("Alunos matriculados simultaneamente nas duas turmas:");
                foreach (int matricula in matriculasComuns)
                {
                    if(matricula != 0)
                    {
                    Console.WriteLine(matricula);

                    } 
                }
            }
            else
            {
                Console.WriteLine("Não existem alunos matriculados simultaneamente nas duas turmas.");
            }

            Console.ReadLine();
        }
    }
}
