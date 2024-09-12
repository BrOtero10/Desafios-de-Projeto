using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioPOO.models
{
    public class Iphone : Smartphone
    {
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine("Buscando aplicativo...");
            Console.WriteLine("Aplicativo encontrado.");
            Console.WriteLine("Realizando download...");
            Console.WriteLine("Realizando instalação...");
            Console.WriteLine($"O aplicativo '{nomeApp}' foi instalado com sucesso!");
        }

        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, $"Iphone{modelo}", imei, memoria) {}
    }
}