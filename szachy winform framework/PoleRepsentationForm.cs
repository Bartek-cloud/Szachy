using System.Drawing;
using SzachLogika;

namespace szachforms
{
    class PoleRepsentationForm : PoleRepresentation
    {
        public PoleRepsentationForm(Image image)
        {
            this.image = image;
        }
        public Image image;
    }
}
