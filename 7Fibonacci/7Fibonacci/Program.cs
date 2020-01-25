using System;

namespace _7Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, x=0, y=1, z;
            Console.WriteLine("Escribe la candidad de serie a imprimir: ");
            n = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i <= n; i++)
                {
                z = x;
                x = y;
                y = z + x;
                if (y == 1)
                {
                    Console.Write(0 + ", "+1+", ");

                }
                Console.Write(y+ ", ");
                }
        }
    }
}
