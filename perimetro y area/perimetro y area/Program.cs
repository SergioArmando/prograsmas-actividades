using System;

namespace perimetro_y_area
{
    class Program
    {
        static void Main(string[] args)
        {
            string q;
            float r, a, b;
            Console.WriteLine("Desea calcular(cuadrado,triangulo,rectangulo");
            q = Console.ReadLine();
            if (q == "triangulo")
            {
                Console.WriteLine("Por favor ingrese la base");
                b = float.Parse((Console.ReadLine()));
                Console.WriteLine("Por favor ingrese la altura");
                a = float.Parse((Console.ReadLine()));
                b = (float)(b * a / 2);
                    Console.WriteLine("el area es igual a: " + b);
            }
            if (q == "cuadrado") {
                Console.WriteLine("Por favor Ingrese su base");
                b = float.Parse(Console.ReadLine());
                Console.WriteLine("Por favor Ingrese su altura");
                a = float.Parse(Console.ReadLine());
                b = (float)(b * a);
                Console.WriteLine("el area es igual a: " + b);

            }
            if (q == "rectangulo") 
            {
                Console.WriteLine("Por favor ingrese su base");
                b = float.Parse(Console.ReadLine());
                Console.WriteLine("Por favor ingrese su altura");
                a = float.Parse(Console.ReadLine());
                b = (float)(b * a);
                Console.WriteLine("el area es igual a: " + b);
            }


        }
    }
}
