using System.Drawing;
using System.Windows.Forms;
using SzachLogika;

namespace szachforms
{

    public class WyswietlaczSzachownicyWinform : WyswietlaczSzachownicy
    {
        public WyswietlaczSzachownicyWinform()
        {
            Represtation = new FigureRepresetationSeterForm();
        }
        public override void Show(Pole[,] listapol)
        {
            this.Represtation.Set(listapol);
            var formszachownicy = new szachownicaform(listapol);
            formszachownicy.Wantmove += WyswietlaczSzachownicy_wantmove;

            Application.Run(formszachownicy);
            

        }

    }

    public class FormImageFiugre : IFigureRepresentation
    {
        public Image image;
        public FormImageFiugre(Image image)
        {
            this.image = image;
        }
    }

}
