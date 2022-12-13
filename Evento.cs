using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoreEventi
{
    internal class Evento
    {
        private string titolo;
        private DateOnly data;
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
       /*PrenotaPosti: aggiunge i posti passati come parametro ai posti prenotati. Se
        l’evento è già passato o non ha posti o non ha più posti disponibili deve sollevare
        un’eccezione*/
       public void PrenotaPosti(int posti )
        {
           DateOnly date = DateOnly.FromDateTime(DateTime.Now);
            if (this.data < date)
            {
                throw new Exception("Data di evento e pasata non si puo prenotare posti.");
            }
            else
            if (this.postiprenotati + posti > this.capienzamassima)
            {
                throw new Exception("Non si po prenotare siamo a massima capacita.");
            }
            {
                this.postiprenotati += posti;
            }
        }
        public void DisdiciPosti(int posti)
        {
            DateOnly date = DateOnly.FromDateTime(DateTime.Now);
            if (this.data < date)
            {
                throw new Exception("Data di evento e pasata non si puo disdire posti.");
            }
            else
            if (this.postiprenotati - posti <= 0)
            {
                throw new Exception("Non si po disdire e vuoto.");
            }
            {
                this.postiprenotati -= posti;
            }
        }
        public override string ToString()
        {
            return data.ToString("dd/M/yyyy")+" - "+this.titolo;
        }
    }
}
