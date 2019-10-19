using System;

namespace programa2
{
    class Program
    {
        static void Main(string[] args)
        {
            int t;
            Console.WriteLine("Ingrese el tamaño del cuadrado");
            t = int.Parse(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            for (int i = 0; i < t - 2; i++)
            {
                Console.Write("*");
                for (int h = 0; h < t - 2; h++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("*");
            }
            for (int i = 0; i < t; i++)
            {
                Console.Write("*");
            }
            Console.ReadLine();
        }
    }
}
