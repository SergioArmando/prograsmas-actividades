using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace serie_de_un_numero
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,r,limite,i, auxiliar;
            Console.WriteLine("Por favor ingrese el numero Fibonacci que desea mostrar");
            limite = int.Parse(Console.ReadLine());
            a = 0;
            r = 1;
            for (i = 0; i < limite; i++)
            {
                auxiliar = a;
                a = r;
                r = auxiliar + a;
                Console.WriteLine(a);
            }
            Console.ReadKey();


        }
    }
}
