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
    bubamara.PrenotaPosti(10);
    Console.WriteLine(bubamara.GetPostiPrenotati());
    bubamara.ToString();
    Console.ReadLine();


} catch (Exception e){
    Console.WriteLine(e.Message);
}
