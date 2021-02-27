using System;

namespace impuesto_producto
{
    class Program
    {
        static void Main(string[] args)
        {
            string prod,med;
            float pre , b;
            Console.WriteLine("El producto es medicina ( si, no)");
            med = Console.ReadLine();
            if (med == "si")
            {
                Console.WriteLine("usted no deberá pagar impuesto");
            }
            else
            {
                Console.WriteLine("Ingrese el nombre del producto");
                prod = Console.ReadLine();
                Console.WriteLine("Ingrese precio del producto");
                pre = float.Parse(Console.ReadLine());
                b = (float)(pre * 0.13);
                Console.WriteLine("Nombre del producto:" + prod);
                Console.WriteLine("impuesto:" + b);
            }



        }
    }
}
