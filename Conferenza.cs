using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoreEventi
{
    internal class Conferenza : Evento
    {
        private string relatore;
        private double prezzo;

       public Conferenza(string relatore, double prezzo , string titolo, DateOnly data, int capienzamassima, int postiprenotati) : base(titolo,data,capienzamassima,postiprenotati)
        {
            this.relatore = relatore;
            this.prezzo = prezzo;
              
        }

        public double GetPrezzo()
        {
            return prezzo;
        }

        public void SetPrezzo(double value)
        {
            prezzo = value;
        }

        public string GetRelatore()
        {
            return relatore;
        }

        public void SetRelatore(string value)
        {
            relatore = value;
        }
        public override string ToString()
        {
            return this.SetData + " - " + this.GetTitolo() + " - " +this.relatore+ " - "+ this.GetPrezzo();
        }
    }

}
