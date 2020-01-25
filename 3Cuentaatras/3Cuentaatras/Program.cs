using System;

namespace _3Cuentaatras
{
    class Program
    {
        static void Main(string[] args)
        {
            int x=0;
            Console.WriteLine("Ingrese hasta que numero desea contar hacia atras:");
            x = Convert.ToInt32(Console.ReadLine());
            for (int i = x; i >=0 ; i=i-1)
            {
                Console.Write(x + ", ");
                x = x - 1;
            }
        }
    }
}
