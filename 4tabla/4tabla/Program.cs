using System;

namespace _4tabla
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.WriteLine("Cual tabla de multiplicar desea imprimir: ");
            x = Convert.ToInt32(Console.ReadLine());
            for(int i=0; i <= 12; i++)
            {
                Console.WriteLine(x + "x" + i + "=" + (x * i)); 
                /* Re Facil xD */
            }
        }
    }
}
