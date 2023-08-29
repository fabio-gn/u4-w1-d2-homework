using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Persona
    {
        private string _nome;
        private string _cognome;
        private string _eta;

        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Eta { get; set; }

        public Persona() { }

        public Persona(string Nome)
        {
            this.Nome = Nome;
        }
        public Persona(string Nome, string Cognome) : this(Nome)
        {
            
            this.Cognome = Cognome;

        }
        public Persona(string nome, string cognome, string eta) : this(nome, cognome)
        {
            this.Eta = eta;
        }
        public string GetNome()
        {
            return this.Nome;
        }
        public string GetCognome()
        {
            return this.Cognome;
        }
        public string GetEta()
        {
            return this.Eta;
        }
        public string GetDettagli()
        {
            return (Nome + " " + Cognome + " " + "di anni " + Eta);
        }
    }
}
