using System.Collections.Generic;
using System.Drawing;
using SzachLogika;
using SzachLogika.Figury;

namespace szachforms
{
    class FigureRepresetationSeterForm : FigureRepresetationSeter
    {
        public Dictionary<int, FormImageFiugre> figuresymbol = new Dictionary<int, FormImageFiugre>
        {
            {0,new FormImageFiugre(Image.FromFile(@"Img\Image1.png"))},
            {1,new FormImageFiugre(Image.FromFile(@"Img\goniec biały.png"))},
            {2,new FormImageFiugre(Image.FromFile(@"Img\goniec czarny.png"))},
            {3,new FormImageFiugre(Image.FromFile(@"Img\kon biały.png"))},
            {4,new FormImageFiugre(Image.FromFile(@"Img\kon czarny.png"))},
            {5,new FormImageFiugre(Image.FromFile(@"Img\pionek biały.png"))},
            {6,new FormImageFiugre(Image.FromFile(@"Img\pionek czarny.png"))},
            {7,new FormImageFiugre(Image.FromFile(@"Img\krolowa biala.png"))},
            {8,new FormImageFiugre(Image.FromFile(@"Img\krolowa czana.png"))},
            {9,new FormImageFiugre(Image.FromFile(@"Img\wieza biała.png"))},
            {10,new FormImageFiugre(Image.FromFile(@"Img\wieza czarna.png"))},
            {11,new FormImageFiugre(Image.FromFile(@"Img\biały krol.png"))},
            {12,new FormImageFiugre(Image.FromFile(@"Img\czarny krol.png"))},
            //{13,new FormImageFiugre(Image.FromFile("goniectemp.png"))},
        };
        private void SetFigureSymbol(Figure figure)
        {
            int i=0;
            if (figure is Pusta) { i = 0; }
            if (figure is Bishop) { i = 1; }
            if (figure is Knight) { i = 3; }
            if (figure is Pionek) { i = 5; }
            if (figure is Queen) { i = 7; }
            if (figure is Rook) { i = 9; }
            if (figure is King) { i = 11; }
            if(figure is PlayableFigure)
            {
                var fig = figure as PlayableFigure;
                if(fig.Własciciel.color == System.ConsoleColor.Black) { i++; }
            }
            figure.representation = figuresymbol[i];

        }
        public void Set(Pole[,] listapol)
        {

            for (int i = 0; i < listapol.GetLength(0); i++)
            {
                for (int j = 0; j < listapol.GetLength(1); j++)
                {
                    SetFigureSymbol(listapol[i, j].Bierka);
                }
            }
        }

    }

}
