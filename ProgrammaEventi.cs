using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoreEventi
{
    internal class ProgrammaEventi
    {
        private string titlo;
        private List<Evento> eventi;

        public ProgrammaEventi(string titlo, List<Evento> eventi)
        {
            this.titlo = titlo;
            this.eventi = eventi;
        }
        public void AggiungiEvento(Evento evento)
        {
            eventi.Add(evento);
        }
        public List<Evento> EventiData(DateOnly eventidata)
        {
            List<Evento> dataeventi = new();
            
            for(int i = 0; i < eventi.Count; i++)
            {
                if (eventi[i].GetDate() == eventidata)
                {
                    dataeventi.Add(eventi[i]);
                }
            }

            return dataeventi;
        }
        public static void StampaLista(List<Evento> eventi)
        {
            for (int i = 0; i < eventi.Count; i++)
            {
                Console.WriteLine(eventi[i].ToString());
            }
        }
        public int EventiPreseti()
        {
            int count = this.eventi.Count;
            return count;
        }
        public void EventiDelete()
        {
            this.eventi.Clear();

        }
        public override string ToString()
        {
            StringBuilder t = new StringBuilder();
            foreach (Evento evento in this.eventi)
            {
                t.AppendLine(evento.GetDate() + " - " + evento.GetTitolo());
            }
           return t.ToString();
        }

    }
}
