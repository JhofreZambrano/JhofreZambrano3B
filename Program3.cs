﻿using System;

namespace programa3
{
    class Program
    {
        static void Main(string[] args)
        {
            int cant = 1, ban = 1;
            Double pre, total = 0, sub;
            while (ban == 1)
            {

                Console.WriteLine("Ingrese Cantidad");
                cant = int.Parse(Console.ReadLine());
                if (cant != 0)
                {
                    Console.WriteLine("Ingrese Precio");
                    pre = Double.Parse(Console.ReadLine());
                    sub = cant * pre;
                    total = total + sub;
                }
                else
                    ban = 0;
            }

            Console.WriteLine("El total es" + total);
            Console.ReadLine();

        }
    }
}
