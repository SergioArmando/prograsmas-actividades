using System;

namespace factorial_de_un_numero
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numero=");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("El factorial es " + (n));
            Console.ReadKey();
        }
        public static int factorial (int n)
        {
            int fact = 1;
            if (n == 0 || n == 1)
                return 1;
            for (int i = n; i >= 1; i--)
                fact *= i;
            return fact;


        }
    }
}
