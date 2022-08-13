using System;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A média de notas da turma de DS1!!\n");

            int media = 0;


            for (int x = 0; x <= 9; x++)
            {

                Console.Write("Digite o {0}° número: ", x + 1);
                int nota = 0;
                nota = int.Parse(Console.ReadLine());


                if (nota > 10)
                {

                    Console.WriteLine("Opção inválida");
                    break;
                }
                media = media + nota;
            }

            Console.WriteLine("A média da sala é: " + media / 10);
            Console.ReadKey();

        }
    }
}
