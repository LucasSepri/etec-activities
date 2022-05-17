using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        public struct Carro
        {
            public string modelo, cor;
            public int ano;
        }
        static void Main(string[] args)
        {
            //Exercicio - 3: Escreva um programa que apresente o seguinte menu para o usuário:

            string textoMenu = "ESCOLHA UMA OPÇÃO\n" +
                "_________________________________________________________________________________________________________\n" +
                "|1 – Cadastrar carro                                                                                    |\n" +
                "|2 – Consultar carro por ano de fabricação(deverá listar todos os carros fabricados no ano digitado     |\n" +
                "|pelo usuário)                                                                                          |\n" +
                "|3 – Consultar carro por modelo(deverá listar todos os carros cujo modelo será digitado pelo usuário)   |\n" +
                "|4 – Consultar carro por cor(deverá listar todos os carros cuja cor será digitada pelo usuário)         |\n" +
                "|5 – Exibir todos os carros cadastrados                                                                 |\n" +
                "|6 – Alterar algum dado de um carro(deverá listar todos os dados de um determinado carro e solicitar    |\n" +
                "|que o usuário escolha qual campo deseja alterar)                                                       |\n" +
                "|7 – Excluir um carro(deverá listar todos os dados de um determinado carro e solicitar a confirmação    |\n" +
                "|para exclusão)                                                                                         |\n" +
                "|0 – Sair                                                                                               |\n" +
                "|_______________________________________________________________________________________________________|";

            /*Neste exercício, deverá ser criada uma struct carro que contenha no mínimo os campos modelo, e cor.
              O usuário deverá cadastrar vários carros até um máximo de 500 registros, portanto deverá ser
              utilizado um vetor.*/
            

            Carro[] carro = new Carro[501];//vetor ultilizado para armazenar os dados dos carros;

            //VARIAVEIS ULTILIZADAS NO FOR;

            int i = 1;//VARIAVEL ULTILIZADA PARA CADASTRAR VEICULO;
            int u = 1;//VARIAVEL ULTILIZADA PARA CONTAR NUMEROS DE CARROS CADASTRADOS;
            int v = 1;

            int opicao;//VARIAVEL ULTILIZADA PARA ACESSAR O MENU, atravez do switch e for;
            

            while (true) // While responsavel por voltar ao menu.
            {
                //int opicao;

                Console.Clear();

                Console.WriteLine(textoMenu);

                Console.Write("\nDigite sua opção: ");
                opicao = int.Parse(Console.ReadLine());

                Console.Clear();

                if (opicao == 0)//se opicao 0 for selecionada vai exibir uma mensagem e logo em seguida vai dar um break no while
                {
                    Console.WriteLine("\nVocê escolheu 0 – Sair");
                    Console.WriteLine("\nPrecione ENTER para CONFIRMAR");
                    break;
                }
                else
                {
                    switch (opicao)
                    {
                        case 1:
                            //CADASTRAR VEICULO, RECEBER VARIAVEL.
                            while(i <= 500)
                            {
                                Console.WriteLine("\nVocê escolheu 1- Cadastrar carro");

                                Console.WriteLine("\nDigite o nome MODELO: ");
                                carro[i].modelo = Console.ReadLine();

                                while (true)
                                {
                                    Console.WriteLine("Selecione uma cor: ");
                                    Console.WriteLine("1 - Branco\n2 - Prata Bari\n3 - Preto\n4 - Cinza");
                                    Console.WriteLine("5 - Vermelho\n6 - Azul\n7 - Marrom\n8 - Verde\n9 - Amarelo");
                                    int cor = int.Parse(Console.ReadLine());
                                    string corDefinida;
                                    if (cor == 1)
                                    {
                                        corDefinida = "Branco";
                                        Console.WriteLine(corDefinida);
                                        carro[i].cor = corDefinida;
                                        break;
                                    }
                                    else if (cor == 2)
                                    {
                                        corDefinida = "Prata Bari";
                                        Console.WriteLine(corDefinida);
                                        carro[i].cor = corDefinida;
                                        break;
                                    }
                                    else if (cor == 3)
                                    {
                                        corDefinida = "Preto";
                                        Console.WriteLine(corDefinida);
                                        carro[i].cor = corDefinida;
                                        break;
                                    }
                                    else if (cor == 4)
                                    {
                                        corDefinida = "Cinza";
                                        Console.WriteLine(corDefinida);
                                        carro[i].cor = corDefinida;
                                        break;
                                    }
                                    else if (cor == 5)
                                    {
                                        corDefinida = "Vermelho";
                                        Console.WriteLine(corDefinida);
                                        carro[i].cor = corDefinida;
                                        break;
                                    }
                                    else if (cor == 6)
                                    {
                                        corDefinida = "Azul";
                                        Console.WriteLine(corDefinida);
                                        carro[i].cor = corDefinida;
                                        break;
                                    }
                                    else if (cor == 7)
                                    {
                                        corDefinida = "Marrom";
                                        Console.WriteLine(corDefinida);
                                        carro[i].cor = corDefinida;
                                        break;
                                    }
                                    else if (cor == 8)
                                    {
                                        corDefinida = "Verde";
                                        Console.WriteLine(corDefinida);
                                        carro[i].cor = corDefinida;
                                        break;
                                    }
                                    else if (cor == 9)
                                    {
                                        corDefinida = "Amarelo";
                                        Console.WriteLine(corDefinida);
                                        carro[i].cor = corDefinida;
                                        break;
                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("\nOPIÇÃO INVÁLIDA!!\n");
                                        Console.ResetColor();
                                        Console.WriteLine("Precione ENTER para Continuar");
                                        Console.ReadLine();
                                    }
                                }


                                Console.WriteLine("digite um ANO: ");
                                while (true)
                                {
                                    carro[i].ano = int.Parse(Console.ReadLine());
                                    if (carro[i].ano <= 2022 && carro[i].ano >= 1886)
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("\nANO INVALIDO!!\n");
                                        Console.ResetColor();
                                        Console.WriteLine("digite um ANO valido: ");
                                    }
                                }
                                i++;

                                Console.WriteLine("\n1 - Adicionar outro Carro;\n0 - Voltar ao Menu.\n");
                                int sair = int.Parse(Console.ReadLine());
                                Console.Clear();

                                if (sair == 0)
                                {
                                    u = i;
                                    break;
                                }
                                
                            }
                            Console.Clear();
                            break;

                        case 2:
                            for (i = 1; i <= u; i++)
                            {
                                if (carro[1].ano == 0)//se caso não houver cadastrado nenhum carro fazer isso:
                                {
                                    Console.WriteLine("Você escolheu 2 – Consultar carro por ano de fabricação");
                                    Console.WriteLine("\nAdicione Um Carro para Consultar os dados\n");
                                    Console.WriteLine("Precione ENTER para Voltar ao Menu.");
                                    Console.ReadLine();
                                    break;
                                }
                                else
                                {
                                    while (true)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Você escolheu 2 – Consultar carro por ano de fabricação");
                                        
                                                                                
                                        while (true)
                                        { 
                                            Console.Write("\nDigite o ano de fabricação: \n");
                                        Console.WriteLine("Ou selecione 0 para cancelar/Voltar_Menu");
                                            int p = int.Parse(Console.ReadLine());
                                            if (p == 0)
                                            {
                                                break;
                                            }
                                            else if (p <= 2022 && p >= 1886)
                                            {
                                                for (i = 1; i <= u; i++)
                                                {
                                                    if (p == carro[i].ano)
                                                    {
                                                        Console.Clear();
                                                        Console.WriteLine("Todos Os carros do Ano: {0}\n", p);
                                                        Console.WriteLine("\n{0}º - carro:", i);
                                                        Console.WriteLine("Modelo: {0}", carro[i].modelo);
                                                        Console.WriteLine("cor: {0}", carro[i].cor);
                                                        Console.WriteLine("ano: {0}\n", carro[i].ano);


                                                        Console.WriteLine("\nPrecione ENTER para continuar.");
                                                        Console.ReadKey();

                                                    }
                                                    if(p!= carro[i].ano)
                                                    {
                                                        Console.WriteLine("CARRO NÃO ENCONTRADO!");

                                                        Console.WriteLine("\nPrecione ENTER para continuar.");
                                                        Console.ReadKey();

                                                    }
                                                }
                                            }
                                            else
                                            {
                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                Console.WriteLine("\nANO INVALIDO!!\n");
                                                Console.ResetColor();
                                                Console.WriteLine("digite um ANO valido!! ");
                                            }
                                        }
                                        Console.Clear();

                                        Console.WriteLine("\n2 - Consultar carro por ano;\n0 - Voltar ao Menu.\n");
                                        int sair = int.Parse(Console.ReadLine());
                                        Console.Clear();

                                        if (sair == 0)
                                        {
                                            break;
                                        }
                                    }
                                }
                            }
                            Console.Clear();
                            break;

                        case 3:
                            Console.WriteLine("\nVocê escolheu 3 – Consultar carro por modelo");
                            Console.WriteLine("\nNÃO ESTÁ PRONTO ESTÁ OPIÇÃO");
                            Console.ReadLine();
                            Console.Clear();
                            break;

                        case 4:
                            Console.WriteLine("\nVocê escolheu 4 - Consultar carro por cor");
                            Console.WriteLine("\nNÃO ESTÁ PRONTO ESTÁ OPIÇÃO");
                            Console.ReadLine();
                            Console.Clear();
                            break;

                        case 5:
                            //EXIBIR TODOS OS CARROS!!
                            for (v = 1; v <= u; v++)
                            {
                                if (carro[v].ano == 0)//se caso não houver cadastrado nenhum carro fazer isso:
                                {

                                    Console.WriteLine("Você escolheu 5 – Exibir todos os carros cadastrados\n");
                                    Console.WriteLine("\nAdicione Um Carro para Exibi-lo\n");
                                    break;
                                }
                                else // Exibir carros cadastrados
                                {
                                    Console.WriteLine("\nVocê escolheu 5 – Exibir todos os carros cadastrados\n");
                                    Console.WriteLine(u);
                                    for (v = 1; v <= u; v++)
                                    {
                                        if (carro[v].ano == -1)
                                        {
                                            Console.Write("\n{0}º - carro: ", v);
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.WriteLine("SEM REGISTRO\n");
                                            Console.ResetColor();
                                        }
                                        else
                                        {
                                            Console.WriteLine("\n{0}º - carro:", v);
                                            Console.WriteLine("Modelo: {0}", carro[v].modelo);
                                            Console.WriteLine("cor: {0}", carro[v].cor);
                                            Console.WriteLine("ano: {0}\n", carro[v].ano);
                                        }
                                    }
                                }
                            }
                            Console.WriteLine("Precione ENTER para Voltar ao Menu.");
                            Console.ReadLine();
                            Console.Clear();
                            break;

                        case 6:
                            for (i = 1; i <= u; i++)
                            {
                                if (carro[1].ano == 0)
                                {
                                    Console.WriteLine("Você escolheu 6 – Alterar algum dado de um carro\n");
                                    Console.WriteLine("\nAdicione Um Carro para alterar os dados\n");
                                    Console.WriteLine("Precione ENTER para Voltar ao Menu.");
                                    Console.ReadLine();
                                    break;
                                }
                                else
                                {
                                    while (true)
                                    {
                                        Console.WriteLine("Você escolheu 6 – Alterar algum dado de um carro\n");
                                        Console.Write("\nSelecione um veiculo para Alterar algum dado: \n");
                                        

                                        for (i = 1; i <= u; i++)
                                        {
                                            if (carro[i].modelo == "" && carro[i].cor == "" && carro[i].ano == -1)
                                            {
                                                Console.Write("\n{0}º - carro: ", i);
                                                Console.ForegroundColor = ConsoleColor.Yellow;
                                                Console.WriteLine("SEM REGISTRO\n");
                                                Console.ResetColor();
                                            }
                                            else
                                            {
                                                Console.WriteLine("\n{0}º - carro:", i);
                                                Console.WriteLine("Modelo: {0}", carro[i].modelo);
                                                Console.WriteLine("cor: {0}", carro[i].cor);
                                                Console.WriteLine("ano: {0}\n", carro[i].ano);
                                            }
                                        }
                                        Console.WriteLine("Ou selecione 0 para cancelar");
                                        int y = int.Parse(Console.ReadLine());
                                        if (y == 0)
                                        {
                                            break;
                                        }

                                        Console.Clear();
                                        Console.WriteLine("ALTERANDO DADOS DO {0}º - carro:", y);
                                        Console.WriteLine("Modelo: {0}", carro[y].modelo);
                                        Console.WriteLine("cor: {0}", carro[y].cor);
                                        if(carro[y].ano >= 1)
                                        {
                                            Console.WriteLine("ano: {0}\n\n", carro[y].ano);
                                        }
                                        else
                                        {
                                            Console.WriteLine("ano: \n\n");
                                        }

                                        Console.WriteLine("NOVOS DADOS:");
                                        Console.WriteLine("\nDigite o nome MODELO: ");
                                        carro[y].modelo = Console.ReadLine();

                                        while (true)
                                        {
                                            Console.WriteLine("Selecione uma cor: ");
                                            Console.WriteLine("1 - Branco\n2 - Prata Bari\n3 - Preto\n4 - Cinza");
                                            Console.WriteLine("5 - Vermelho\n6 - Azul\n7 - Marrom\n8 - Verde\n9 - Amarelo");
                                            int cor = int.Parse(Console.ReadLine());
                                            string corDefinida;
                                            if (cor == 1)
                                            {
                                                corDefinida = "Branco";
                                                Console.WriteLine(corDefinida);
                                                carro[y].cor = corDefinida;
                                                break;
                                            }
                                            else if (cor == 2)
                                            {
                                                corDefinida = "Prata Bari";
                                                Console.WriteLine(corDefinida);
                                                carro[y].cor = corDefinida;
                                                break;
                                            }
                                            else if (cor == 3)
                                            {
                                                corDefinida = "Preto";
                                                Console.WriteLine(corDefinida);
                                                carro[y].cor = corDefinida;
                                                break;
                                            }
                                            else if (cor == 4)
                                            {
                                                corDefinida = "Cinza";
                                                Console.WriteLine(corDefinida);
                                                carro[y].cor = corDefinida;
                                                break;
                                            }
                                            else if (cor == 5)
                                            {
                                                corDefinida = "Vermelho";
                                                Console.WriteLine(corDefinida);
                                                carro[y].cor = corDefinida;
                                                break;
                                            }
                                            else if (cor == 6)
                                            {
                                                corDefinida = "Azul";
                                                Console.WriteLine(corDefinida);
                                                carro[y].cor = corDefinida;
                                                break;
                                            }
                                            else if (cor == 7)
                                            {
                                                corDefinida = "Marrom";
                                                Console.WriteLine(corDefinida);
                                                carro[y].cor = corDefinida;
                                                break;
                                            }
                                            else if (cor == 8)
                                            {
                                                corDefinida = "Verde";
                                                Console.WriteLine(corDefinida);
                                                carro[y].cor = corDefinida;
                                                break;
                                            }
                                            else if (cor == 9)
                                            {
                                                corDefinida = "Amarelo";
                                                Console.WriteLine(corDefinida);
                                                carro[y].cor = corDefinida;
                                                break;
                                            }
                                            else
                                            {
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                Console.WriteLine("\nOPIÇÃO INVÁLIDA!!\n");
                                                Console.ResetColor();
                                                Console.WriteLine("Precione ENTER para Continuar");
                                                Console.ReadLine();
                                            }
                                        }

                                        Console.WriteLine("digite um ANO: ");
                                        while (true)
                                        {
                                            carro[y].ano = int.Parse(Console.ReadLine());
                                            if (carro[y].ano <= 2022 && carro[y].ano >= 1886)
                                            {
                                                break;
                                            }
                                            else
                                            {
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                Console.WriteLine("\nANO INVALIDO!!\n");
                                                Console.ResetColor();
                                                Console.WriteLine("digite um ANO valido: ");
                                            }
                                        }
                                        Console.Clear();


                                        Console.WriteLine("Carro {0} foi Alterado Com Sucesso!", y);

                                        Console.WriteLine("\n6 - Alterar outro Carro;\n0 - Voltar ao Menu.\n");
                                        int sair = int.Parse(Console.ReadLine());
                                        Console.Clear();

                                        if (sair == 0)
                                        {
                                            break;
                                        }
                                    }
                                }
                            }
                            Console.Clear();
                            break;

                        case 7:
                            for (i = 1; i <= u; i++)
                            {
                                if (carro[i].ano == 0)//se caso não houver cadastrado nenhum carro fazer isso:
                                {
                                    Console.WriteLine("Você escolheu 7 – Excluir um carro\n");
                                    Console.WriteLine("\nAdicione Um Carro para Poder exclui-lo\n");
                                    Console.WriteLine("Precione ENTER para Voltar ao Menu.");
                                    Console.ReadLine();
                                    break;
                                }
                                else
                                {
                                    while (true)
                                    {
                                        Console.WriteLine("Você escolheu 7 – Excluir um carro\n");
                                        Console.Write("\nSelecione um veiculo para ");
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Exclusão:");
                                        Console.ResetColor();

                                        int b;
                                        for (b = 1; b <= u; b++)
                                        {
                                            if (carro[b].ano == -1)
                                            {
                                                Console.Write("\n{0}º - carro: ", b);
                                                Console.ForegroundColor = ConsoleColor.Yellow;
                                                Console.WriteLine("SEM REGISTRO\n");
                                                Console.ResetColor();
                                            }
                                            else //se existir carro vai mostrar todos os carros
                                            {
                                                Console.WriteLine("\n{0}º - carro:", b);
                                                Console.WriteLine("Modelo: {0}", carro[b].modelo);
                                                Console.WriteLine("cor: {0}", carro[b].cor);
                                                Console.WriteLine("ano: {0}\n", carro[b].ano);
                                            }
                                        }

                                        Console.WriteLine("Ou selecione 0 para cancelar");
                                        int y = int.Parse(Console.ReadLine());
                                        if (y == 0)
                                        {
                                            break;
                                        }
                                        carro[y].modelo = null;
                                        carro[y].cor = null;
                                        carro[y].ano = -1;// -1 DEFINIDO PARA INDICAR QUE O VEICULO FOI EXCLUIDO.
                                        Console.Clear();

                                        Console.WriteLine("Carro {0} foi excluido", y);

                                        Console.WriteLine("\n7 - Excluir outro Carro;\n0 - Voltar ao Menu.\n");
                                        int sair = int.Parse(Console.ReadLine());
                                        Console.Clear();

                                        if (sair == 0)
                                        {
                                            break;
                                        }
                                    }
                                }
                            }
                            Console.Clear();
                                break;

                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nOPIÇÃO INVÁLIDA\n");
                            Console.ResetColor();
                            Console.WriteLine("Precione ENTER para Continuar");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
/*
 PROBLEMAS NA LÓGICA

1º CASE 7 ESTÁ COM ERRO, APÓS EXCLUIR UM VEICULO É ADICIONADO UM CARRO SEM INFORMAÇÕES NO CAMPO ANTERIOR E POSTERIOR AO EDITADO.
2º 
 */
