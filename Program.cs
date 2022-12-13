// See https://aka.ms/new-console-template for more information
using GestoreEventi;
using System.Globalization;

try
{
    Console.WriteLine("Nome di evento");
    string nome = Console.ReadLine();
    Console.WriteLine("Giorno di evento");
    int day = int.Parse(Console.ReadLine());
    Console.WriteLine("Meze di evento");
    int month = int.Parse(Console.ReadLine());
    Console.WriteLine("Anno di evento");
    int year = int.Parse(Console.ReadLine());
    Console.WriteLine("Max Capacita");
    int maxcap = int.Parse(Console.ReadLine());
    Console.WriteLine("Prenotati");
    int reservations = int.Parse(Console.ReadLine());
    DateOnly data= new DateOnly(year, month, day);
    Evento bubamara = new Evento(nome,data,maxcap,reservations);
    bubamara.PrenotaPosti(10);
    Console.WriteLine(bubamara.GetPostiPrenotati());
    bubamara.ToString();
    Console.ReadLine();


} catch (Exception e){
    Console.WriteLine(e.Message);
}
