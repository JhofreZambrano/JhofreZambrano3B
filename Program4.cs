﻿using System;

namespace programa4
{
    class Program
    {
        static void Main(string[] args)
        {
            int total, horas, HorasExtras, ban = 0, a;
            while (ban == 0)
            {
                Console.WriteLine("Ingrese horas trabajadas");
                horas = int.Parse(Console.ReadLine());
                if (horas < 35)
                {
                    total = horas * 15;
                    Console.WriteLine("El valor a pagar es" + total);
                }
                else
                {
                    HorasExtras = horas - 34;
                    total = (34 * 15) + (HorasExtras * 22);
                    Console.WriteLine("El valor a pagar es" + total);
                }
                Console.WriteLine("Desea Calcular otro salario");
                Console.WriteLine("Ingrese 0 para volver a calcular o 1 para salir ");
                a = int.Parse(Console.ReadLine());
                ban = a;
            }
            Console.WriteLine("Muchas gracias ");
            Console.ReadLine();

        }
    }
}
