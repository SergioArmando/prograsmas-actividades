using System;

namespace grados_radiales
{
    class Program
    {
        static void Main(string[] args)
        {
            string p;
            Double n, r;
            Console.WriteLine("¿cantidad de radiales o grados?");
            p = Console.ReadLine();
            Console.WriteLine("ingresar cantidad");
            n = Double.Parse(Console.ReadLine());
            if (p == "grados")
            {
                r = (Double)n * 0.0175;
                Console.WriteLine("La cantidad en grados convertida en radiales: " + r);
            }
            else
            {
                r = (Double)n * 57.296;
                Console.WriteLine("cantidad radiales convertida a grados:" + r);
            }

        }
    }
}
