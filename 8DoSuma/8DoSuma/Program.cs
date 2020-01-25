using System;

namespace _8DoSuma
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y,n ;
            do
            {
                Console.WriteLine("Escriba Los numeros que desea sumar: ");
                x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Siguiente numero: ");
                y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("La suma de sus numeros es: " + (x + y));
                Console.WriteLine("Ingrese el numero [1] si Desea contuniar o cualquiera si desea terminar");
                n = Convert.ToInt32(Console.ReadLine());
            } while (n == 1);


        }
    }
}
