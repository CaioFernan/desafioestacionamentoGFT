using System;
using System.Runtime.InteropServices;
using System.Text.Unicode;
using System.Collections.Generic;
using desafioestacionamento.classes;

internal class Program
{
    private static void Main(string[] args)

    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        decimal precoInicial, precoporHora = 0;

        Console.WriteLine("Bem vindo ao estacionamento da GFT. ");

        Console.WriteLine("Digite o valor inícial. ");
        precoInicial = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("Agora digite o preço por hora. ");
        precoporHora = Convert.ToDecimal(Console.ReadLine());

        Estacionamento p = new Estacionamento(precoInicial, precoporHora);
        int opcao;
        bool menu = true;

        while (menu)
        {
            Console.Clear();
            Console.WriteLine("Digite uma das seguintes opçãoes.");
            Console.WriteLine("1 - Cadastrar veiculos.");
            Console.WriteLine("2 - Remover veiculo.");
            Console.WriteLine("3 - Listar veiculos.");
            Console.WriteLine("4 - Encerrar.");

            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    p.AdicionarVeiculo();
                    break;
                case 2:
                    p.RemoverVeiculo();
                    break;
                case 3:
                    p.ListarVeiculos();
                    break;
                case 4:
                    menu = false;
                    break;
                default:
                    Console.WriteLine("Opção invalida. Tente novamente.");
                    break;
            }
            Console.WriteLine("Precione um tecla para continuar");
            Console.ReadLine();
        }
        Console.WriteLine("O program se encerrou:");
    }
}