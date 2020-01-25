using System;

namespace _9NuInvertidos
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, xInver=0;
            Console.WriteLine("Ingrese el numero que desea invertir");
            x = Convert.ToInt32(Console.ReadLine());
            while (x > 0)
            {
                xInver = xInver * 10 + (x % 10);
                x = x / 10;
            }
            Console.WriteLine("Su numero inverito es: " + xInver);
        }
    }
}
