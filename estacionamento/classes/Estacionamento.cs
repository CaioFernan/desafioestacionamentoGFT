using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafioestacionamento.classes
{
    public class Estacionamento
    {
        private decimal precoInicial, precoporHora = 0;
        

        private List<String> p = new List<String>();

        public Estacionamento(decimal precoInicial, decimal precoporHora)
        {
            this.precoInicial = precoInicial;
            this.precoporHora = precoporHora;
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veiculo.");
            string placa = Console.ReadLine();
            p.Add(placa); 
        }

        public void RemoverVeiculo()
        {
            string placa = "";
            Console.WriteLine("Digite a placa do veiculo para remover.");
            placa = Console.ReadLine();

            if (p.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veiculo ficou estacionado");
                decimal horasEstacionado = Convert.ToDecimal(Console.ReadLine());
                decimal total = 0;
                total = precoInicial + (horasEstacionado * precoporHora);
                p.Remove(placa);
                Console.WriteLine($"O veiculo com a placa {placa} foi removido e deve pagar {total}.");
            }
            else
            {
                Console.WriteLine("Desculpe esse veiculo não esta estacionado");
            }
            
        }
        public void ListarVeiculos()
        {
            if (p.Any())
            {
                Console.WriteLine("Os veiculos estacionados são: ");
                foreach (string i in p)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                Console.WriteLine("Não a veiculos estacionados");
            }
        }
        public void Encerrar()
        {
            Console.WriteLine("Encerrado");
        }
        
    }
}