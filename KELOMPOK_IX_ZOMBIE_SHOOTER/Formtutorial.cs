using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KELOMPOK_IX_ZOMBIE_SHOOTER
{
    public partial class Formtutorial : Form
    {
        public Formtutorial()
        {
            InitializeComponent();
        }

        Image[] listimage = new Image[3];
        Point[] listpoint = new Point[3];
        int[] listwidth = new int[3];
        int[] listheight = new int[3];
        int idximg = 0;
        void toggle_tooltip()
        {
            if (idximg == 0)
            {
                labeltipamunition.Visible = true;
                labeltipshoot.Visible = true;
                labeltipline.Visible = true;

                labeltipbg.Visible = false;
                labeltipamun.Visible = false;
                labeltiplife.Visible = false;
                labeltipbuyshield.Visible = false;
                 
                labeltipshield.Visible = false;
            }
            if (idximg == 1)
            {
                labeltipamunition.Visible = false;
                labeltipshoot.Visible = false;
                labeltipline.Visible = false;

                labeltipbg.Visible = true;
                labeltipamun.Visible = true;
                labeltiplife.Visible = true;
                labeltipbuyshield.Visible = true;

                labeltipshield.Visible = false;
            }
            if (idximg == 2)
            {
                labeltipamunition.Visible = false;
                labeltipshoot.Visible = false;
                labeltipline.Visible = false;

                labeltipbg.Visible = false;
                labeltipamun.Visible = false;
                labeltiplife.Visible = false;
                labeltipbuyshield.Visible = false;

                labeltipshield.Visible = true;
            }
        }
        private void Formtutorial_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;
            labeltipamunition.BackColor = Color.Transparent;
            labeltipshoot.BackColor = Color.Transparent;
            labeltipline.BackColor = Color.Transparent;

            labeltipbg.BackColor = Color.Transparent;
            labeltipamun.BackColor = Color.Transparent;
            labeltiplife.BackColor = Color.Transparent;
            labeltipbuyshield.BackColor = Color.Transparent;

            labeltipshield.BackColor = Color.Transparent;
            labelmaju.BackColor = Color.Transparent;
            labelmundur.BackColor = Color.Transparent;
            for (int i = 0; i < 3; i++)  {    listimage[i] = Image.FromFile("tutorial" + i + ".jpg");  }
            listpoint[0] = new Point(60, 10);
            listpoint[1] = new Point(22, 147);
            listpoint[2] = new Point(82, 183);

            listwidth[0] = 300; listheight[0] = 550;
            listwidth[1] = 380; listheight[1] = 350;
            listwidth[2] = 240; listheight[2] = 240;
            toggle_tooltip();
            this.Invalidate();
        }

        private void Formtutorial_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics; 
            g.DrawImage(Image.FromFile("bg_sand2.jpg"), -1, -1, this.Width+10, this.Height + 10);
            g.DrawImage(listimage[idximg], listpoint[idximg].X, listpoint[idximg].Y, listwidth[idximg], listheight[idximg]);
        }

        private void labelmundur_Click(object sender, EventArgs e)
        {
            if (idximg>0)
            {
                idximg--;
                toggle_tooltip();
                this.Invalidate();

            }
        }

        private void labelmaju_Click(object sender, EventArgs e)
        { 
            if (idximg < 2)
            {
                idximg++;
                toggle_tooltip();
                this.Invalidate(); 
            }
        }

        private void labelmundur_Paint(object sender, PaintEventArgs e)
        {  
            Graphics g = e.Graphics;
            g.DrawImage(Image.FromFile("panah_kiri.png"), 0, 0, labelmundur.Width, labelmundur.Height);
        }

        private void labelmaju_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImage(Image.FromFile("panah_kanan.png"), 0, 0, labelmaju.Width, labelmaju.Height);

        }

        private void Formtutorial_Click(object sender, EventArgs e)
        {  }

        private void Formtutorial_MouseClick(object sender, MouseEventArgs e)
        {    }

        private void labeltipshield_Click(object sender, EventArgs e)
        {   }
    }
}
