﻿using System;

namespace programa5
{
    class Program
    {
        static void Main(string[] args)
        {
            int g, d, n, p;
            Console.WriteLine("Ingrese altura de la piramide ");
            n = int.Parse(Console.ReadLine());
            for (g = 1; g <= n; g++)
            {
                for (d = n - g; d >= 1; d--)
                {
                    Console.Write(" ");
                }
                for (p = 1; p <= (g * 2) - 1; p++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
