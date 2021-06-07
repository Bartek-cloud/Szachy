namespace szachforms
{
    public class Listboxmove
    {
        public int xstart, ystart, xtarget, ytarget;
        public Listboxmove(int xstart, int ystart, int xtarget, int ytarget)
        {
            this.xstart = xstart; this.ystart = ystart; this.xtarget = xtarget; this.ytarget = ytarget;
        }
        public override string ToString()
        {
            return (xstart + 1).ToString() + (ystart + 1).ToString() + " " + (xtarget + 1).ToString() + (ytarget + 1).ToString();
        }
    }
}
