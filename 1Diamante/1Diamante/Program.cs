using System;

namespace _1Diamante
{
    class Program
    {
        static void Main(string[] args)
        {
            int i,c, n=5;
            for (i= 1; i <= n; i++)
            {
                for (c= 1; c <= n-i; c++)              
                    Console.Write(" ");
                    for(c=1;c<=2*i-1;c++)  
                        Console.Write("*");
                        Console.Write("\n");
            }
            n--;
            for ( i = n; i >= 1; i--)
            {
                for (c = i; c <= n; c++)
                Console.Write(" ");
                for (int k = 1; k <= 2 * i - 1; k++)
                Console.Write("*");
                Console.Write("\n");
            }

        }

    }
}
  

