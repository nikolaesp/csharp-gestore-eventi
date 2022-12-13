// See https://aka.ms/new-console-template for more information
using GestoreEventi;
using System.Text;
using System.Globalization;





try
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


} catch (Exception e){
    Console.WriteLine(e.Message);
}
