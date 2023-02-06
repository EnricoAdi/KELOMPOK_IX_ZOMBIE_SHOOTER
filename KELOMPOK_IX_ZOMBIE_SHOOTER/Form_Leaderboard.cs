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
    public partial class Form_Leaderboard : Form
    {
        public Form_Leaderboard()
        {
            InitializeComponent();
        }
        private void Form_Leaderboard_Load(object sender, EventArgs e)
        { 
            lbl_leaderboard_1.BackColor =Color.Transparent;
            lb_leaderboard_2.BackColor = Color.Transparent;
            lb_leaderboard_3.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;

            //Jonathan bryan
            //cetak highscore
            if (Form_menu.listname_highscore.Count>0)
            {
                lbl_leaderboard_1.Text = Form_menu.listname_highscore[0] + " - " + Form_menu.list_highscore[0];
            }
            if (Form_menu.listname_highscore.Count > 1)
            {
                lb_leaderboard_2.Text = Form_menu.listname_highscore[1] + " - " + Form_menu.list_highscore[1];
            }
            if (Form_menu.listname_highscore.Count > 2)
            {
                lb_leaderboard_3.Text = Form_menu.listname_highscore[2] + " - " + Form_menu.list_highscore[2];
            }
            //Jonathan bryan
        }

        private void Form_Leaderboard_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImage(Image.FromFile("bgleaderboard.jpg"),0,0,this.Width-10,this.Height-10);
        }
    }
}
