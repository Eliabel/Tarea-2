using System;

namespace _6NumeroA
{
    class Program
    {
        static void Main(string[] args)
        {
                int z, x, y, a;
                Console.WriteLine("Números de Armstrong entre 1 y 500 \n");
            for (int n = 1; n <= 500; n++)
            {
                z = n / 100;
                x = (n - z * 100) / 10;
                y = (n - z * 100 - x * 10);
                a = z * z * z + x * x * x + y * y * y;
                if (n == a)
                {
                    Console.WriteLine(n);
                }
            }
        }
    }
}
