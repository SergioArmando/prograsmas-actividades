using System;

namespace par_o_impar
{
    class Program
    {
        static void Main(string[] args)
        {
            Double a, b;
            Console.WriteLine("ingresa un numero");
            a = Double.Parse(Console.ReadLine());
            b = a % 2;
            if (b == 0)
            {
                Console.WriteLine("El numerpo es par");
            }
            else
                Console.WriteLine("el numero es impar");

        }
    }
}
