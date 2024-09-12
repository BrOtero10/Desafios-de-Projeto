using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDeHospedagem.models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();

        public Pessoa(string nome) {
            Nome = nome;
            Sobrenome = "";
        }
        public Pessoa(string nome, string sobrenome) {
            Nome = nome;
            Sobrenome = sobrenome;
        }
    }
}