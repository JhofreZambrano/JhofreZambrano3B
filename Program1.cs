﻿using System;

namespace JhofreZambrano3B
{
    class Program
    {
        static void Main(string[] args)
        {
            int mayor = 0, numeros = 0, num, a = 0;
            Console.WriteLine("Cuantos numeros desea ingresar");
            num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine("Digite {0} numero:", a = a + 1);
                numeros = int.Parse(Console.ReadLine());
                if (i == 1)
                {
                    mayor = numeros;
                }
                if (numeros > mayor)
                {
                    mayor = numeros;
                }
                numeros = 0;
            }
            Console.WriteLine(" numero mayor es: " + mayor);
            Console.ReadLine();
        }
    }
}
