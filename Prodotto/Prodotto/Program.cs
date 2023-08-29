using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prodotto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci prodotto: ");
            string nomeProdotto = Console.ReadLine();

            Console.WriteLine("Inserisci prezzo: ");
            string prezzo = Console.ReadLine();

            Console.WriteLine("Inserisci quantità: ");
            string quantita = Console.ReadLine();

            Prodotto prodotto1 = new Prodotto(nomeProdotto, prezzo, quantita);

            Console.WriteLine($"il totale sarà: {prodotto1.CalcolaTotale()} euro");
            Console.ReadLine();


        }
    }
}
