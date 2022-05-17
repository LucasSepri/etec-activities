using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercises_Csharp
{
    internal class Program
    {
        public struct Data
        {
            public int dia,mes,ano;
        }
        static void Main(string[] args)
        {
            Data data;

            Console.WriteLine("PROGRAMA DATA");


            Console.WriteLine("digite um dia: ");
            data.dia = int.Parse(Console.ReadLine());
            Console.WriteLine("digite um mes: ");
            data.mes = int.Parse(Console.ReadLine());
            Console.WriteLine("digite um ano: ");
            data.ano = int.Parse(Console.ReadLine());


            if (data.ano % 4 == 0) //ano bissexto
            {
                if (data.dia <= 0 || data.mes <= 0 || data.ano <= 0 || data.mes == 02 && data.dia > 29 || data.mes > 12)
                {
                    Console.WriteLine("Data invalida");
                }
                else
                {
                    Console.WriteLine("ano bissexto");
                    Console.WriteLine("Data digitada é: {0}/{1}/{2}", data.dia, data.mes, data.ano);
                }
            }
            else
            {
                if (data.dia <= 0 || data.mes <= 0 || data.ano <= 0 || data.dia > 31 || data.mes == 02 && data.dia > 28 || data.mes > 12)
                {
                    Console.WriteLine("Data invalida");
                }
                else
                {
                    Console.WriteLine("ano não bissexto");
                    Console.WriteLine("Data digitada é: {0}/{1}/{2}", data.dia, data.mes, data.ano);
                }
            } 

                Console.ReadKey();
        }
    }
}
