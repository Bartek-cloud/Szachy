using System;
using System.Collections.Generic;
using SzachLogika;
using SzachLogika.Figury;
namespace SzachyKonsola
{
    public class KonsolaFiugreSignSeter : FigureRepresetationSeter
    {
        public void Set(Pole[,] listapol)
        {
            for (int i = 0; i < listapol.GetLength(0); i++)
            {
                for (int j = 0; j < listapol.GetLength(1); j++)
                {
                    SetFigureSymbol(listapol[i,j].Bierka);
                }
            }          
        }
        public Dictionary<int, KonsolaFiugreSign> figuresymbol = new Dictionary<int, KonsolaFiugreSign>
        {
            {0,new KonsolaFiugreSign(' ')},
            {1,new KonsolaFiugreSign('B')},
            {2,new KonsolaFiugreSign('I')},
            {3,new KonsolaFiugreSign('T')},
            {4,new KonsolaFiugreSign('K')},
            {5,new KonsolaFiugreSign('Q')},
            {6,new KonsolaFiugreSign('+')},
        };
        private void SetFigureSymbol(Figure figure)
        {         
            if (figure is Pusta) { figure.representation = figuresymbol[0]; }
            if (figure is Bishop) { figure.representation = figuresymbol[1]; }
            if (figure is Knight) { figure.representation = figuresymbol[3]; }
            if (figure is Pionek) { figure.representation = figuresymbol[2]; }
            if (figure is Queen) { figure.representation = figuresymbol[5]; }
            if (figure is Rook) { figure.representation = figuresymbol[6]; }
            if (figure is King) { figure.representation = figuresymbol[4]; }
        }



    }
    public class KonsolaFiugreSign : IFigureRepresentation
    {
        public readonly char sign;

        public KonsolaFiugreSign(char sign)
        {
            this.sign = sign;
        }
    }
    public class WyswietlaczChownicy_konsola1 : WyswietlaczSzachownicy
    {
        
        public Dictionary<int, char> Alfabet = new Dictionary<int, char>
        {
            {0,'A' },
            {1,'B' },
            {2,'C' },
            {3,'D' },
            {4,'E' },
            {5,'F' },
            {6,'G' },
            {7,'H' },
            {8,'I' },
            {9,'J' },
            {10,'K' }
        };
        // List<List<Pole>> listapol;
        List<ConsoleColor> usedcolor = new List<ConsoleColor> { ConsoleColor.White };

        public WyswietlaczChownicy_konsola1()
        {
            Represtation = new KonsolaFiugreSignSeter();
            }
        private bool seted = false;
        public override void Show(Pole[,] listapol)
        {
            if(seted == false)
            {
                Set(listapol);
                seted = true;
            }
            for (int i = 0; i < listapol.GetLength(0); i++)
            {
                Console.Write(listapol.GetLength(0) - i+"|");
                for (int j = 0; j < listapol.GetLength(1); j++)
                {
                    if (listapol[j, i].Bierka is PlayableFigure)                                        
                    {
                        var FigureTemp = listapol[j, i].Bierka as PlayableFigure;
                        Console.ForegroundColor = FigureTemp.Własciciel.color;
                    }
                    var res = listapol[j, i].Bierka.representation;
                    if (res is KonsolaFiugreSign)
                    {
                        var kres = res as KonsolaFiugreSign;
                        Console.Write( kres.sign);
                    }
                    else { Console.Write(' '); }
                    
                    //Console.Write(FigureSymbol(listapol[j, i].Bierka));
                    Console.Write(" ");
                    Console.ResetColor();
                }
                Console.WriteLine();
            }
            Console.Write("  ");
            for (int j = 0; j < listapol.GetLength(0); j++)
            {
                Console.Write(Alfabet[j] + " ");
            }
        }
    }
}
