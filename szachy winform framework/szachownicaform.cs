using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using SzachLogika;
using SzachLogika.Figury;
using szachy_winform_framework;

namespace szachforms
{

    public partial class szachownicaform : Form
    {
        internal protected Pole[,] listapol;
        internal protected float szerokoscPola, wysokoscPola, odstepszerokosc, odestepwyokosc;
        private int lastclikedx, lastclikedy;
        public event WantMove Wantmove;
        //Image szachwonca = (Image.FromFile(@"Img\szachownica1.png"));
        private float scale_factor = 0.7f;
        List<Listboxmove> ruchy = new List<Listboxmove>();
        int Idgry;
        private void szachownicaform_Load(object sender, EventArgs e)
        {
          //  this.ruchyTableAdapter1.Fill(this.szachyDataSet1.Ruchy);
           // this.gryTableAdapter1.Fill(this.szachyDataSet1.Gry);
           
            gryTableAdapter1.Insert(1,1,1);
            Idgry = (int)gryTableAdapter1.ostanieid();
          //  gryTableAdapter1.Update(szachyDataSet1.Gry);


        }

        private void szachownicaform_Leave(object sender, EventArgs e)
        {
        }

        private void szachownicaform_Scroll(object sender, ScrollEventArgs e)
        {
        }

        private void szachownicaform_Deactivate(object sender, EventArgs e)
        {
            foreach (object ruch in ruchy)
            {
                var ruchm = ruch as Listboxmove;
                ruchy.Add(ruchm);
            }
            Thread zapis = new Thread(zapisywanie);
            zapis.Start();
        }
        private void zapisywanie()
        {
            foreach (Listboxmove ruchm in ruchy)
            {
                ruchyTableAdapter1.Insert(ruchm.xstart, ruchm.ystart, ruchm.xtarget, ruchm.ytarget, this.Idgry);
            }
        }

        private void szachownicaform_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                scale_factor = scale_factor * 1.01f;
                
            }
            else if (e.KeyCode == Keys.Down && scale_factor>=0.5f)
            {
                scale_factor = scale_factor * 0.99f;

            }
            this.Size = new Size((int)(szerokoscPola * 12 * scale_factor), (int)(wysokoscPola * 10 * scale_factor));
            Refresh();
        }

        private void szachownicaform_MouseClick_1(object sender, MouseEventArgs e)
        {
            //  e.X//,e.Y
            int x = ((int)(e.X / ((odstepszerokosc + szerokoscPola) * scale_factor) ) - 1);
            int y = ((int)(e.Y / ((odestepwyokosc + wysokoscPola) * scale_factor) ) - 1);
            if (x < 0 || x >= listapol.GetLength(0) || y < 0 || y >= listapol.GetLength(1))
            {
                if (lastclikedx != -1 || lastclikedy != -1)
                {
                    listapol[lastclikedx, lastclikedy].Look = null;
                    lastclikedx = -1;
                    lastclikedy = -1;
                }
            }
            else if (lastclikedx == -1)
            {
                if (listapol[x, y].Bierka is PlayableFigure)
                {
                    var selfigure = listapol[x, y].Bierka as PlayableFigure;
                    listapol[x, y].Look = new PoleRepsentationForm(Image.FromFile(@"Img\Image1.png"));
                    lastclikedx = x;
                    lastclikedy = y;
                    // if (selfigure.Własciciel == Tura)
                }
            }
            else
            {
                //zdarzenie
                bool moved = (bool)(Wantmove?.Invoke(lastclikedx, lastclikedy, x, y));
                if (moved)
                {
                    var a = listapol[x, y].Bierka as PlayableFigure;
                    
                    listapol[lastclikedx, lastclikedy].Look = null;
                    listBox1.Items.Add(new Listboxmove(lastclikedx,lastclikedy,x,y));
                    // new Thread = 
                   // ruchyTableAdapter1.Insert(lastclikedx, lastclikedy, x, y, this.Idgry);//dopracowac
                    lastclikedx = -1;
                    lastclikedy = -1;
                    if (a.Własciciel.color == ConsoleColor.Black) { label1.Text = "Tura gracza białego"; label1.ForeColor = Color.White; }
                    if (a.Własciciel.color == ConsoleColor.White) { label1.Text = "Tura gracza czarnego"; ; label1.ForeColor = Color.Black; }
                   

                }
            }
            this.Refresh();
        }
        private void szachownicaform_Paint_1(object sender, PaintEventArgs e)
        {
            Pen penw = new Pen(Color.FromArgb(200, Color.White), 3);
            Pen penb = new Pen(Color.FromArgb(200, Color.Black), 3);
            e.Graphics.ScaleTransform(scale_factor, scale_factor);
            //   e.Graphics.DrawImage(szachwonca, 100 , 100);
        //    e.Graphics.ScaleTransform(scaleFactor, scaleFactor);
            for (int i = 0; i < listapol.GetLength(0); i++)
            {
                for (int j = 0; j < listapol.GetLength(1); j++)
                {

                    Rectangle rectangleF = new Rectangle((int)(100F + j * (odstepszerokosc + szerokoscPola)), (int)(100 + i * (odstepszerokosc + szerokoscPola)), (int)szerokoscPola, (int)wysokoscPola);
                    e.Graphics.FillRectangle(((j + i % 2) % 2 == 0 ? Brushes.White : Brushes.Black), rectangleF);
                    if (listapol[j, i].Look is PoleRepsentationForm && listapol[j, i].Look != null)
                    {
                        var poleimg = listapol[j, i].Look as PoleRepsentationForm;
                        e.Graphics.DrawImage(poleimg.image, 100 + j * (odstepszerokosc + szerokoscPola),100 + i * (odstepszerokosc + szerokoscPola));
                    }
                    var figureimg = listapol[j, i].Bierka.representation;
                    if (figureimg is FormImageFiugre && !(listapol[j, i].Bierka is Pusta))
                    {
                        var formfigureimg = figureimg as FormImageFiugre;
                        e.Graphics.DrawImage(formfigureimg.image, 100 + j * (odstepszerokosc + szerokoscPola), 100 + i * (odstepszerokosc + szerokoscPola)); //rysujemy auto środkiem w środku układu
                    }
                }
            }   
        }
        public szachownicaform(Pole[,] listapol)
        {
            this.listapol = listapol;
            // tury = new KontrolaturyTury(lis);
            szerokoscPola = 100;
            wysokoscPola = 100;
            odstepszerokosc = 0;
            odestepwyokosc = 0;
            //cliked = false;
            lastclikedx = -1; lastclikedy = -1;
            InitializeComponent();
            this.Size = new Size((int)(szerokoscPola * 12*scale_factor), (int)(wysokoscPola * 10 * scale_factor));
            label1.Text = "Tura gracza białego"; label1.ForeColor = Color.White;
           // label1.AutoSize = true;
          //  label1.

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Refresh();
        }

    }
}

