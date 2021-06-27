using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SzachLogika;
using SzachLogika.Figury;

namespace szachforms
{
    static class Program
    {
        /// <summary>
        /// na podstawie 3 grafik chce wygenerowac plansze
        /// nastepnie szukac naciesniecia recznie
        /// 
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Szachownica plansza = new Szachownica(-1, 8);
                plansza.Wyswietlacz = new WyswietlaczSzachownicyWinform();
                plansza.AddPlayer("a", System.ConsoleColor.White);
                plansza.AddPlayer("b", System.ConsoleColor.Black);
                plansza.GiveEachPlayerFigure();
                // plansza.GoTo(1, 1, 1, 2);
                //  plansza.GoTo(1, 7, 0, 5);
                plansza.Show();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }

            //Application.Run(plansza.wyswietlacz as Form);




        }
    }
}
