﻿using System;

namespace programa10
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, a, c = 0, f = 1, ban = 1;
            while (ban == 1)
            {
                Console.WriteLine(" MENÚ ");
                Console.WriteLine(" 1) Salir ");
                Console.WriteLine(" 2) Sumatoria ");
                Console.WriteLine(" 3) Factorial ");
                Console.WriteLine("Que accion desea realizar");
                num = int.Parse(Console.ReadLine());
                if (num == 1)
                {
                    Console.WriteLine("Gracias por su Visita");
                    Console.ReadLine();
                }
                else
                {
                    if (num == 2)
                    {
                        Console.WriteLine("Ingrese Numero para realizar su Sumatorio ");
                        a = int.Parse(Console.ReadLine());
                        for (int i = 0; i <= a; i++)
                        {
                            c = c + i;
                        }
                        Console.WriteLine("El sumatorio del número ingresado es " + c);
                        Console.ReadLine();
                    }
                    else
                    {
                        if (num == 3)
                        {
                            Console.WriteLine("Ingrese Numero para resolver su factorial");
                            a = int.Parse(Console.ReadLine());
                            for (int i = 1; i <= a; i++)
                            {
                                f = f * i;
                            }
                            Console.WriteLine("El factorial del numero ingresado es" + f);
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Accion no Valida ");
                            Console.ReadLine();

                        }
                    }

                }
            }
        }
    }
}
