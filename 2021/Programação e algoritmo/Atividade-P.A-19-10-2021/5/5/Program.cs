using System;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("6) Escreva um programa que leia 15 números inteiros e exiba na tela ao final, o maior número que foi digitado pelo usuário.\n");
            int numeros, maior;
            Console.Write("Digite o 1° número: ");
            maior = int.Parse(Console.ReadLine());

            for (int x = 1; x < 15; x++)
            {
                Console.Write("Digite o {0}° número: ", x + 1);
                numeros = int.Parse(Console.ReadLine());

                if (numeros > maior)
                {
                    maior = numeros;
                }
            }
            Console.WriteLine("\nO maior número digitado foi: {0}", maior);

            Console.ReadKey();

        }
    }
}
