using System;

namespace _8
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0, resultado = 1;

            Console.Write("Digite um número: ");
            numero = int.Parse(Console.ReadLine());
            Console.Write("\n{0} =1", numero);

            for (int x = 2; x <= numero; x++)
            {
                resultado = resultado * x;
                Console.Write("*{0}", x);
            }
            Console.WriteLine("={0}", resultado);
            Console.ReadKey();

        }
    }
}
