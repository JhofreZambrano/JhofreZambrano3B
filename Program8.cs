using System;

namespace programa8
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, a = -2, o = -3, q = 0;
            Console.WriteLine(""Ingrese Numero");
           
            numero = int.Parse(Console.ReadLine());
            for (int i = 0; i <= numero; i++)
            {

                Console.WriteLine("{0}>>>>>{1}<<<<<{2}", q++, a = a + 2, o = o + 3);
            }
            Console.ReadLine();

        }
    }
}
