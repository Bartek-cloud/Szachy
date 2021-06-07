using SzachLogika;
namespace SzachyKonsola
{
    class Program
    {
        static void Main(string[] args)
        {
         //   players.AddPlayer("gracz1", ConsoleColor.White);
            //  Gracz gracz1 = new Gracz("gracz1",ConsoleColor.White);
            Szachownica plansza = new Szachownica(8, 8);
            plansza.Wyswietlacz = new WyswietlaczChownicy_konsola1();
            plansza.AddPlayer("a", System.ConsoleColor.Red);
            plansza.AddPlayer("b", System.ConsoleColor.Blue);
            plansza.GiveEachPlayerFigure();
            plansza.GoTo(1, 1, 1, 2);
            plansza.GoTo(1, 7, 0, 5);
            plansza.Show();


        }
    }
}
