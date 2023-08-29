using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Cognome: ");
            string cognome = Console.ReadLine();

            Console.WriteLine("Età: ");
            string eta = Console.ReadLine();

            Persona primaPersona = new Persona(nome, cognome, eta);
            Console.WriteLine(primaPersona.GetNome() + "\r\n" + primaPersona.GetCognome() + "\r\n" + primaPersona.GetEta() + "\r\n" + primaPersona.GetDettagli());
            Console.ReadLine();
        }
    }
}
