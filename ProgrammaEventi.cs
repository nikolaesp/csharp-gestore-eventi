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
            List<Evento> lista = new List<Evento>();
        }
        public void AggiungiEvento(Evento evento)
        {
            eventi.Add(evento);
        }
        public List<Evento> EventiData(DateOnly eventidata)
        {
            List<Evento> dataeventi = new List<Evento>();
            
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
                eventi[i].ToString();
            }
        }
        public int EventiPreseti()
        {
            return eventi.Count;
        }
        public void EventDelete()
        {
            eventi.Clear();

        }
        public override string ToString()
        {
            for (int i = 0; i < eventi.Count; i++)
            {
                eventi[i].ToString();
            }
            return ToString();
        }
    }
}
