using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            Double n1, n2, impar = 0, menor, maior;
            Console.WriteLine("\nQuantidade de números impares, a contagem será feita a partir de dois números.\n");
            Console.WriteLine("Digite o primeiro número");
            n1 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número");
            n2 = Double.Parse(Console.ReadLine());

            if (n1 <= n2)
            {
                menor = n1;
                maior = n2;
            }
            else
            {
                menor = n2;
                maior = n1;
            }

            for (Double x = menor; x <= maior; x++)
            {
                if (x % 2 != 0) { impar++; }
            }
            Console.WriteLine("De {0} a {1} possuem {2} números ímpares", menor, maior, impar);

            Console.ReadKey();

        }
    }
}
