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
    public partial class Form_playerstats : Form
    {
        public Form_playerstats()
        {
            InitializeComponent();
        }
         

        private void Form_playerstats_Load(object sender, EventArgs e)
        { 
            label_bullet.Text = "Bullet level : " + Form_menu.damagebullet;
            label_name.Text = "Name : " + Form_menu.nama_player_play;
            label_life.Text = "Life : " + Form_menu.jumlahnyawa;
        }
         
    }
}
