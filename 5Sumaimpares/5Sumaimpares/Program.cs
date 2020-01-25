using System;

namespace _5Sumaimpares
{
    class Program
    {
        static void Main(string[] args)
        {
            int x,n=0;
            Console.WriteLine("Ingrese el numero del intervalo: ");
            x = Convert.ToInt32(Console.ReadLine());
            
            
                for (int i = 1; i < x; i = i + 2)
                {
                n = n + i;
                }
            Console.WriteLine(n);

   
        }
    }
}
