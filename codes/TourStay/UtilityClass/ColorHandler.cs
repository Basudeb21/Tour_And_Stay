using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TourStay.UtilityClass
{
    internal class ColorHandler
    {
        private int r;
        private int g;
        private int b;
        private Color bck;
        public ColorHandler()
        {

        }

        public ColorHandler(int r, int g, int b, Color bck)
        {
            this.r = r;
            this.g = g;
            this.b = b;
            this.bck = bck;
        }
        public void setColor(int r, int g, int b, Color bck)
        {
            this.r = r;
            this.g = g;
            this.b = b;
            this.bck = bck;
        }

        public void colorChanger(Panel[] p, Panel pn, Label[] l, Label lb)
        {
            foreach (Panel item in p)
            {
                item.BackColor = Color.FromArgb(r, g, b);
            }
            pn.BackColor = bck;

            foreach (Label item in l)
            {
                item.BackColor = Color.FromArgb(r, g, b);
            }

            lb.BackColor = bck;
        }

        public void textColorHandler(Label []lbl, Color cs, Label l, Color c)
        {
            foreach(Label lb in lbl)
            {
                lb.ForeColor = cs;
            }
            l.ForeColor = c;
        }
    }
}
