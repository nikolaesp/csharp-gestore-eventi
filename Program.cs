// See https://aka.ms/new-console-template for more information
using GestoreEventi;
using System.Text;
using System.Globalization;





internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            Console.Write("Inserisci il nome del tua programa Eventi : ");
            string eventsname = Console.ReadLine();
            Console.Write("Indica il numero di eventi da inserire: ");
            int nevents = int.Parse(Console.ReadLine());
            List<Evento> listaeventi = new List<Evento>();

            for (int i = 0; i < nevents; i++)
            {
                Console.Write("Inserisci il nome dell'evento: ");
                string nome = Console.ReadLine();
                Console.Write("Inserisci la data dell'evento (gg/mm/yyyy): ");
                string date = Console.ReadLine();
                DateOnly data = DateOnly.Parse(date);
                // Console.WriteLine(data.ToString());
                Console.Write("Inserisci il numero di posti totali: ");
                int maxcap = int.Parse(Console.ReadLine());
                Console.Write("Quanti posti desiderai prenotare? ");
                int reservations = int.Parse(Console.ReadLine());
                Evento evento = new Evento(nome, data, maxcap, reservations);
                listaeventi.Add(evento);
            }
            ProgrammaEventi eventi = new ProgrammaEventi(eventsname, listaeventi);
            Console.WriteLine("Il numero di eventi nel programa e: " + eventi.EventiPreseti());
            Console.WriteLine(eventi.ToString());

            Console.Write("Inscerici data pred vedere qualle sonno le eventi :");
            string date2 = Console.ReadLine();
            DateOnly data2 = DateOnly.Parse(date2);
            List<Evento> listaeventidata = eventi.EventiData(data2);

            ProgrammaEventi.StampaLista(listaeventidata);

            eventi.EventiDelete();
            Console.WriteLine(eventi.ToString());
            Console.ReadLine();
            /*
            for (int i = 0; i < listaeventidata.Count; i++)
            {
                Console.WriteLine(listaeventidata[i].ToString());
            }
 

          Evento bubamara = new Evento(nome,data,maxcap,reservations);
          Console.Write("Quanti posti desideri prenotare ?");
          int posti =int.Parse(Console.ReadLine());   
          bubamara.PrenotaPosti(posti);
          bubamara.StampaPosti();
          Console.Write("Vuoi disdire dei posti ?(si/no)");
          string disdire = Console.ReadLine();
          if(disdire == "si")
          {
             int postidis = int.Parse(Console.ReadLine());
              bubamara.DisdiciPosti(postidis);
              bubamara.StampaPosti();
          }
          else
          {
              Console.WriteLine("Ok va benne !");
          }
          Console.Write("Vuoi disdire dei posti ?(si/no)");
           disdire = Console.ReadLine();
          if (disdire == "si")
          {
              int postidis = int.Parse(Console.ReadLine());
              bubamara.DisdiciPosti(postidis);
              bubamara.StampaPosti();
          }
          else
          {
              Console.WriteLine("Ok va benne !");
          }
          Console.Write("Vuoi disdire dei posti ?(si/no)");
           disdire = Console.ReadLine();
          if (disdire == "si")
          {
              Console.Write("Indica il numero di posti da disdire?");
              int postidis = int.Parse(Console.ReadLine());
              bubamara.DisdiciPosti(postidis);
              bubamara.StampaPosti();
          }
          else
          {
              Console.WriteLine("Ok va benne !");
          }
            */



        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}