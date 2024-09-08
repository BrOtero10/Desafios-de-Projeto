using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            string placa;
            do {
                Console.WriteLine("Digite a placa do veículo para estacionar:");
                placa = Console.ReadLine() ?? string.Empty;
            } while(placa == string.Empty);

            Console.WriteLine("Pressione uma tecla para continuar");
            Console.ReadKey();

            veiculos.Add(placa);
        }

        public void RemoverVeiculo()
        {
            string placa;

            do {
                Console.WriteLine("Digite a plada do veículo para remover: ");
                placa = Console.ReadLine() ?? string.Empty;

            } while(placa == string.Empty);

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                int horas;
                decimal valorTotal; 

                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado: ");
                horas = Convert.ToInt32(Console.ReadLine());

                valorTotal = this.precoInicial + (this.precoPorHora * horas);

                // TODO: Remover a placa digitada da lista de veículos
                
                this.veiculos.Remove(placa);

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                foreach(string placa in veiculos) {
                    Console.WriteLine(placa);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}