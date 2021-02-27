using System;

namespace primos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetCursorPosition(0, 0);
            Console.Write("Numeros primos del 1 al 1000");
            Console.SetCursorPosition(1, 1);
            Console.Write("");
            int cuentap = 0;
            for (int i = 0; i <= 1000; i++)
            {

                cuentap++;
            }
            int b = 2, y = 2;
            int[] vecp = new int[cuentap];
            int indice = 0;
            for (int i = 1; i <= 1000; i++)
            {

                {
                    vecp[indice] = i;
                    Console.SetCursorPosition(b, 2) ;
                    Console.Write(i);

                    indice++;
                    y++;

                    if (y == 25)
                    {
                        b += 5;
                        y = 2;
                    }
                }
            }
            Console.ReadKey();
        
        }
    }
}
