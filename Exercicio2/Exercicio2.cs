using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    class Exercicio2
    {
        static double CalculoDaHipotenusa(double lado1, double lado2)
        {
            double hipotenusa = Math.Sqrt(Math.Pow(lado1, 2) + Math.Pow(lado2, 2));
            return hipotenusa;
        }
        static void Main(string[] args)
        {
            double[] ladosTriangulo = new double[2];

            for(int i = 0; i < ladosTriangulo.Length; i++)
            {
                Console.WriteLine($"Informe o valor do {i+1} lado: ");
                ladosTriangulo[i] = double.Parse(Console.ReadLine());
            }

            double hipotenusa = CalculoDaHipotenusa(ladosTriangulo[0],ladosTriangulo[1]);

            Console.WriteLine($"O valor da hipotenusa é: {hipotenusa}");

            Console.ReadLine();
        }
    }
}
