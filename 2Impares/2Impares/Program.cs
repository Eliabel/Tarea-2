using System;

namespace _2Impares
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.WriteLine("Ingrese hasta que numero desea mostrar:");
           x= Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i<x; i=i+2) 
            {
                Console.Write(i + ", ");
                   
            } 
        }
    }
}
