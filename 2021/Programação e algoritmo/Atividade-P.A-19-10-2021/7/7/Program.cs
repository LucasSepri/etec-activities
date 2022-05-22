using System;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Contagem de 0 a 100.\n");


            for (int x = 0; x <= 100; x++)
            {
                Console.WriteLine(x);
            }
            for (int multiplo = 10; multiplo <= 100; multiplo = multiplo + 10)
            {
                Console.WriteLine(multiplo + " : multiplo de 10");
            }


            Console.ReadKey();

        }
    }
}
