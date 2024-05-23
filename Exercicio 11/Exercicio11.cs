using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_11
{
    internal class Exercicio11
    {
        static void ConverterSegundos(int totalSegundos, out int hora, out int min, out int seg)
        {
            hora = totalSegundos / 3600;
            min = (totalSegundos % 3600) / 60;
            seg = (totalSegundos % 3600) % 60;

            string resultado = $"{hora:00}:{min:00}:{seg:00}";
            Console.WriteLine(resultado);
        }
        static void Main(string[] args)
        {
            int hora, min, seg, totalSegundos;

            Console.WriteLine("Informe o total de segundos: ");
            totalSegundos = int.Parse(Console.ReadLine());

            ConverterSegundos(totalSegundos, out hora, out min, out seg);
            Console.ReadLine();
        }
    }
}
