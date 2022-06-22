using System;

namespace kata2
{
    class Program
    {
        public static int DigitalRoot(long n)
        {
            //Este procedimiento hace un recuento de la cantidad de digitos que tiene un numero
            int cant = 0;
            long n2;
            n2 = n;
            do
            {
                n2 = n2 / 10;
                cant = cant + 1;
            } while (n2 > 0);
            return cant;
        }
        static void Main(string[] args)
        {
            long n;
            Console.WriteLine("digite el numero");
            n = long.Parse(Console.ReadLine());
            Console.WriteLine("La cantidad de digitos del numero es :" + DigitalRoot(n));
        }
    }
}
