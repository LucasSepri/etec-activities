using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        public struct aluno
        {
            public string nome;
            public double nota1, nota2, media;
        }
        static void Main(string[] args)
        {
            aluno[] alunos = new aluno[20];
            int qnt;
            for (qnt = 1; qnt <= 15; qnt++)//qnt=1 se qnt menor ou igual a 15 qnt+1
            {
                Console.Write("Digite o nome do aluno: ");
                alunos[qnt].nome = Console.ReadLine();
                Console.Write("Digite a 1ª nota do aluno(a): ");
                alunos[qnt].nota1 = double.Parse(Console.ReadLine());
                Console.Write("Digite a 2ª nota do aluno(a): ");
                alunos[qnt].nota2 = double.Parse(Console.ReadLine());
                alunos[qnt].media = (alunos[qnt].nota1 + alunos[qnt].nota2) / 2;
            }
            Console.Clear();
            for (qnt = 1; qnt < 15; qnt++)
            {
                if (alunos[qnt].media >= 7)
                {
                    Console.WriteLine("Nome: {0}", alunos[qnt].nome);
                    Console.WriteLine("Nota 1: {0}", alunos[qnt].nota1);
                    Console.WriteLine("Nota 2: {0}", alunos[qnt].nota2);
                    Console.WriteLine("Média: {0}", alunos[qnt].media);
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("{0} APROVADO!!", alunos[qnt].nome);
                    Console.ResetColor();
                }
                else
                {
                    Console.WriteLine("Nome: {0}", alunos[qnt].nome);
                    Console.WriteLine("Nota 1: {0}", alunos[qnt].nota1);
                    Console.WriteLine("Nota 2: {0}", alunos[qnt].nota2);
                    Console.WriteLine("Media: {0}", alunos[qnt].media);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("{0} REPROVADO!!", alunos[qnt].nome);
                    Console.ResetColor();
                }
            }

            Console.ReadKey();
        }
    }
}
