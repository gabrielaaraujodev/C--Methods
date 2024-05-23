using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    internal class Exercicio4
    {
        static void ValorResultadoDaMediaEscolhida()
        {
            int numberOne, numberTwo, numberThree;
            char letra;
            do
            {
                Console.WriteLine("Informa um letra:\nA) Média Aritimética\nP) Média Ponderada");
                letra = char.Parse(Console.ReadLine());
                switch (letra) {
                    case 'A':
                        Console.WriteLine("Informe o 1º número desejado: ");
                        numberOne = int.Parse(Console.ReadLine());
                        Console.WriteLine("Informe o 2º número desejado: ");
                        numberTwo = int.Parse(Console.ReadLine());
                        Console.WriteLine("Informe o 3º número desejado: ");
                        numberThree = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine((numberOne + numberTwo + numberThree) / 3);
                    break;

                    case 'P':
                        Console.WriteLine("Informe o 1º número desejado: ");
                        numberOne = int.Parse(Console.ReadLine());
                        Console.WriteLine("Informe o 2º número desejado: ");
                        numberTwo = int.Parse(Console.ReadLine());
                        Console.WriteLine("Informe o 3º número desejado: ");
                        numberThree = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine((5*numberOne + 3* numberTwo + 2* numberThree) / 10);
                    break;

                    default:
                        Console.WriteLine("Não é possível fazer nenhum cálculo !");
                    break;
                }
                Console.WriteLine();
            } while (letra == 'A' || letra == 'P');
        }

        static void Main(string[] args)
        {
            ValorResultadoDaMediaEscolhida();
            Console.ReadLine();
        }
    }
}
