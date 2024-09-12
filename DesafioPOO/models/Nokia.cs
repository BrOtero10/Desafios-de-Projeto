using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioPOO.models
{
    public class Nokia : Smartphone
    {
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Realizando instalação do app {nomeApp}...");
            Random random = new();
            for(int i = 0; i < 5; i++) {
                int numeroAleatorio = random.Next(20 * i, 20 * (i + 1));
                Console.WriteLine($"Download: {numeroAleatorio}%");
            }
            Console.WriteLine("Download: 100%");
            for(int i = 0; i < 4; i++) {
                int numeroAleatorio = random.Next(25 * i, 25 * (i + 1));
                Console.WriteLine($"Instalando: {numeroAleatorio}%");
            }
            Console.WriteLine("Instalando: 100%");
            Console.WriteLine($"App {nomeApp} instalado com sucesso!");
        }

        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, $"Nokia_{modelo}", imei, memoria) {}
    }
}