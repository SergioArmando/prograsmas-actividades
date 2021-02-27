using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tablasdemultiplicar
{
    class Program
    {
        private static void Main(string[] args)
        {
            int num, resultado;

            Console.WriteLine("Ingrese el valor a multiplicar:");
            num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                resultado = num * i;
                Console.WriteLine(num + "*" + i + "=" + resultado);

            }
            Console.WriteLine("");
            Console.WriteLine("presiona enter para terminar la ejecución gracias");
            Console.Read();
        }
    }
}
