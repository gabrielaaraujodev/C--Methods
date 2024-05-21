using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    class Exercicio3
    {
        static int CalculoMMC (int primeiroValor, int segundoValor)
        {
            int maiorValor = Math.Max(primeiroValor, segundoValor);
            int resultadoMMC = 0;
            bool controleLoop = true;

            while (controleLoop)
            {
                if(maiorValor % primeiroValor == 0 && maiorValor % segundoValor == 0)
                {
                    resultadoMMC = maiorValor;
                    controleLoop = false;
                } 
                else
                {
                    maiorValor++;
                }
            }

            return resultadoMMC;
        }

        static int CalculoMDC (int primeiroValor, int segundoValor, int terceiroValor)
        {
            int menorValor = Math.Min(primeiroValor, segundoValor);
            int resultadoMDC = 0;
            bool controleLoop = true;

            while (controleLoop)
            {
                if (primeiroValor % menorValor == 0 && segundoValor % menorValor == 0 && terceiroValor % menorValor == 0)
                {
                    resultadoMDC = menorValor;
                    controleLoop = false;
                }
                else
                {
                    menorValor--;
                }
            }

            return resultadoMDC;
        }

        static void Main(String[] args)
        {

            Console.WriteLine("1) Calcular MMC\n2) Calcular MDC\n3) Sair");
            int option = int.Parse(Console.ReadLine());

            while(option != 3) { 
                switch(option)
                {
                    case 1:
                        Console.WriteLine("Informe os valores desejados para saber o MMC entre eles: ");
                        int numberOne = int.Parse(Console.ReadLine());

                        Console.WriteLine("Informe os valores desejados para saber o MMC entre eles: ");
                        int numberTwo = int.Parse(Console.ReadLine());

                        Console.WriteLine($"O valor do MMC entres os dois primeiros números digitados é: {CalculoMMC(numberOne, numberTwo)}");

                        Console.WriteLine();
                        break;

                    case 2:
                        Console.WriteLine("Informe os valores desejados para saber o MDC entre eles: ");
                        int anotherNumberOne = int.Parse(Console.ReadLine());

                        Console.WriteLine("Informe os valores desejados para saber o MDC entre eles: ");
                        int anotherNumberTwo = int.Parse(Console.ReadLine());

                        Console.WriteLine("Informe os valores desejados para saber o MDC entre eles: ");
                        int numberThree = int.Parse(Console.ReadLine());

                        Console.WriteLine($"O valor do MDC entres os três números digitados é: {CalculoMDC(anotherNumberOne, anotherNumberTwo, numberThree)}");

                        Console.WriteLine();
                        break;

                    case 3:
                        break;
                }

                Console.WriteLine("1) Calcular MMC\n2) Calcular MDC\n3) Sair");
                option = int.Parse(Console.ReadLine());

                Console.WriteLine();
            }

            Console.ReadLine();
        } 


    }
}
