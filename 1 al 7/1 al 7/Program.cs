using System;

namespace _1_al_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int p;
            Console.WriteLine("Ingresa del 1 al 7");
            p = int.Parse(Console.ReadLine());
            if (p == 1)
            {
                Console.Write("Hoy es día Lunes");
            }
            if (p == 2)
            {
                Console.Write("Hoy es día Martes");
                if (p == 3)
                {
                    Console.Write("Hoy es día Miércoles");
                    if (p == 4)
                    {
                        Console.Write("Hoy es día Jueves");
                        if (p == 5)
                        {
                            Console.Write("Hoy es Viernes");
                            if (p == 6)
                            {
                                Console.Write("Hoy es día Sabado");
                                if (p == 7)
                                {
                                    Console.Write("Hoy es Domingo");

                                }
                            }
                        }
                    }
            

 
