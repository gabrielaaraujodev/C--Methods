using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_10
{
    internal class Exercicio10
    {
        static void Main(string[] args)
        {
            int[] matriculaAlunosAtp = new int[5];
            int[] matriculaAlunosDiw = new int[10];
            Random random = new Random();

            for (int i = 0; i < matriculaAlunosAtp.Length; i++) {
                matriculaAlunosAtp[i] = random.Next(1, 11);

                for (int j = 1; j < matriculaAlunosAtp.Length; j++) {
                    if (matriculaAlunosAtp[i] == matriculaAlunosAtp[j]) {
                        matriculaAlunosAtp[j] = random.Next(1, 11); ;
                    }
                }
            }

            foreach (int i in matriculaAlunosAtp)
            {
                Console.Write(i + " ");
            }

            Console.ReadLine();
        }
    }
}
