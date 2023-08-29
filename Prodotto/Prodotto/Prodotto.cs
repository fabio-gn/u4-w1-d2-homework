using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prodotto
{
    internal class Prodotto
    {
        public string NomeProdotto { get; set; }
        private double _prezzo;
        public double Prezzo
        {
            get
            {
                return _prezzo;
            }
            set
            {
                _prezzo = value;
            }
        }

        private double _quantità;
        public double Quantità
        {
            get
            {
                return _quantità;
            }
            set
            {
                _quantità = value;
            }
        }


        public Prodotto(string nomeProdotto, string prezzo, string quantita ) 
        {
            this.NomeProdotto = nomeProdotto;
            this.Prezzo = Convert.ToDouble(prezzo);
            this.Quantità = Convert.ToDouble(quantita);
        }

        public double CalcolaTotale()
        {
            return Prezzo * Quantità;
        }
    }
}
