using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace KELOMPOK_IX_ZOMBIE_SHOOTER
{
    public partial class Form_pilih_skin : Form
    {
        public Form_pilih_skin()
        {
            InitializeComponent();
        }
        int character_pilih = 1;
        private void button_ok_Click(object sender, EventArgs e)
        {
        } 
        List<Image> btnimg = new List<Image>();
        int p1img = 0; int p2img = 2;
        private void button_player_1_Click(object sender, EventArgs e)
        {
            character_pilih = 0; //hijau
            p1img = 1; p2img = 2;
            button_player_1.Invalidate();
            button_player_2.Invalidate();
        }

        private void button_player_2_Click(object sender, EventArgs e)
        {
            character_pilih = 1; //red
            p1img = 0; p2img = 3;
            button_player_1.Invalidate();
            button_player_2.Invalidate();
        }

        private void Form_pilih_skin_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent; 
            btnimg.Add(Image.FromFile("soldier1.png"));
            btnimg.Add(Image.FromFile("soldier1_click.png"));
            btnimg.Add(Image.FromFile("soldier2.png"));
            btnimg.Add(Image.FromFile("soldier2_click.png"));
            wrnabuttonok[0] = Color.Aqua;
            wrnabuttonok[1] = Color.DarkCyan;   
        }

        private void button_player_1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImage(btnimg[p1img],-28,-2,button_player_1.Width+57,button_player_1.Height+48);
        }

        private void button_player_2_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImage(btnimg[p2img], -28, -2, button_player_1.Width + 50, button_player_1.Height + 48);

        }
        Color[] wrnabuttonok = new Color[2]; int idxwrnbutonok = 0;
        private void Form_pilih_skin_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImage(Image.FromFile("bg8.jpg"),0,0,this.Width-5,this.Height-5);
            g.FillEllipse(new SolidBrush(Color.DarkCyan), label_OK.Location.X + label_OK.Width - 18, label_OK.Location.Y - 4, label_OK.Height + 5, label_OK.Height + 6); //kanan
            g.FillRectangle(new SolidBrush(Color.DarkCyan), label_OK.Location.X + 1, label_OK.Location.Y - 3, label_OK.Width + 2, label_OK.Height + 6); //rectangle
            g.FillEllipse(new SolidBrush(Color.DarkCyan), label_OK.Location.X - 16, label_OK.Location.Y - 3, label_OK.Height + 6, label_OK.Height + 5); 

            g.FillEllipse(new SolidBrush(wrnabuttonok[idxwrnbutonok]), label_OK.Location.X + label_OK.Width-17, label_OK.Location.Y-1, label_OK.Height, label_OK.Height+1);
            g.FillEllipse(new SolidBrush(wrnabuttonok[idxwrnbutonok]), label_OK.Location.X - 13, label_OK.Location.Y, label_OK.Height, label_OK.Height);
        }
         
        private void tb_username_MouseHover(object sender, EventArgs e)
        {   toolTip1.SetToolTip(tb_username, "Enter your name");   }

        private void button_player_1_MouseHover(object sender, EventArgs e)    {  }

        private void button_player_2_MouseHover(object sender, EventArgs e)      {   }
         

        private void label_OK_MouseClick(object sender, MouseEventArgs e)
        {
            //Maria
            Form_Game fg = new Form_Game();
            string username1 = tb_username.Text;
            if (username1 == "")
            {
                username1 = "Guest";
            }
            Form_menu.nama_player_play = username1;

            Form_menu.music.Stop();
            fg.Text = username1; 
            fg.Tag = character_pilih;  
            fg.FormClosed += Form_menu.closeform;
            fg.Show();
            this.Visible = false;
            //Maria

        }

        private void label_OK_MouseEnter(object sender, EventArgs e)
        {
            idxwrnbutonok = 1;
            label_OK.BackColor = wrnabuttonok[idxwrnbutonok];
            this.Invalidate(); 
        }

        private void label_OK_MouseLeave(object sender, EventArgs e)
        {
            idxwrnbutonok = 0;
            label_OK.BackColor = wrnabuttonok[idxwrnbutonok];
            this.Invalidate();

        }
    }
}
