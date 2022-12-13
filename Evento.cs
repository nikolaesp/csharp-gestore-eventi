using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoreEventi
{
    internal class Evento
    {
        private string titolo;
        DateOnly data;
        private int capienzamassima;
        private int postiprenotati;

        public Evento(string titolo, DateOnly data, int capienzamassima, int postiprenotati)
        {
            this.titolo = titolo;
            this.data = data;
            if (capienzamassima < 0)
            {
                capienzamassima = 0;
            }
            this.capienzamassima = capienzamassima;
            if (postiprenotati < 0)
            {
                postiprenotati = 0;
            }
            this.postiprenotati = postiprenotati;
        }
        public string GetTitolo() { return this.titolo; }
        public DateOnly GetDate() { return this.data; }
        public int GetCapienzaMassima() { return this.capienzamassima; }
        public int GetPostiPrenotati() { return this.postiprenotati; }

        public void SetTitolo(string titolo) {
            if (titolo == "")
            {
                this.titolo = "Evento senza nome.";
            }
            else
            {
                this.titolo = titolo;
            }
        }
        public void SetData(DateOnly data) {
            this.data = data;
        }
       
    }
}
