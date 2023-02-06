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
    public partial class Form_shop : Form
    {
        public Form_shop()
        {
            InitializeComponent();
        }

        List<Image> btnimg1 = new List<Image>(); int img1 = 0; int img2 = 2; int img3 = 4; int img4 = 6; 
        private void Form_shop_Load(object sender, EventArgs e)
        {
            //Maria 
            label_uang.Text = "$" + Form_menu.ingame_money;
            label_uang.BackColor = Color.Transparent;
            label_addshield.BackColor = Color.Transparent;
            labelcb.BackColor = Color.Red;
            label_upamunition.BackColor = Color.Transparent;
            label_addlife.BackColor = Color.Transparent;
            labelbackground.BackColor = Color.Transparent;
            btnimg1.Add(Image.FromFile("bg_grass.jpg"));
            btnimg1.Add(Image.FromFile("clicked_bg_grass.png"));
            btnimg1.Add(Image.FromFile("bg_sand1.jpg"));
            btnimg1.Add(Image.FromFile("clicked_bg_sand1.png"));
            btnimg1.Add(Image.FromFile("bg_sand2.jpg"));
            btnimg1.Add(Image.FromFile("clicked_bg_sand2.png"));
            btnimg1.Add(Image.FromFile("bg_snow.jpg"));
            btnimg1.Add(Image.FromFile("clicked_bg_snow.png"));

        }

        private void button_bg_grass_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImage(btnimg1[img1], 1, 1, button_bg_grass.Width, button_bg_grass.Height);
        }

        private void button_bg_sand1_Click(object sender, EventArgs e)
        {
            //tinggal ganti bg gameplay
            img1 = 0; img2 = 3; img3 = 4; img4 = 6; inv_all(); 
            Form_menu.bgGame = Image.FromFile("bg_sand1.jpg");
        }

        private void button_bg_sand1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImage(btnimg1[img2], 1, 1, button_bg_sand1.Width, button_bg_sand1.Height);

        }

        private void button_bg_sand2_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImage(btnimg1[img3], 1, 1, button_bg_sand2.Width, button_bg_sand2.Height);
        }

        private void button_bg_snow_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImage(btnimg1[img4], 1, 1, button_bg_snow.Width, button_bg_snow.Height);
        }

        private void button_addsoldier_Paint(object sender, PaintEventArgs e)
        {       }

        private void button_addlife_Paint(object sender, PaintEventArgs e)
        {  }

        private void button_upamunition_Paint(object sender, PaintEventArgs e)
        { 

        }

        private void button_bg_grass_Click(object sender, EventArgs e)
        {
            img1 = 1;
             img2 = 2;  img3 = 4;  img4 = 6;
            Form_menu.bgGame = Image.FromFile("bg_grass.jpg");
            inv_all();
        }

        private void button_bg_sand2_Click(object sender, EventArgs e)
        {
            Form_menu.bgGame = Image.FromFile("bg_sand2.jpg");
            img1 = 0;  img2 = 2; img3 = 5; img4 = 6;
            inv_all();
        }
        void inv_all()
        {//maria
            button_bg_grass.Invalidate();
            button_bg_snow.Invalidate();
            button_bg_sand1.Invalidate();
            button_bg_sand2.Invalidate();
        }
        private void button_bg_snow_Click(object sender, EventArgs e)
        {
            Form_menu.bgGame = Image.FromFile("bg_snow.jpg");
            img1 = 0;
            img2 = 2; img3 = 4; img4 = 7;
            inv_all();
        }

        private void Form_shop_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImage(Image.FromFile("bgShop.jpg"), 0, 0, this.Width, this.Height );


        }

        private void groupBox1_Paint(object sender, PaintEventArgs e)
        {    }

        private void button_addlife_Click(object sender, EventArgs e)
        {    }

        private void button_upamunition_Click(object sender, EventArgs e)
        {    }

        private void button_addshield_Click(object sender, EventArgs e)
        {    }

        private void button1_Click(object sender, EventArgs e)
        { 
            //Maria 

            Form_playerstats fps = new Form_playerstats(); 
            fps.Show();
        }

        private void button1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImage(Image.FromFile("btnstats.png"), -4, -6, button1.Width+10, button1.Height+12);


        }

        private void label_uang_Paint(object sender, PaintEventArgs e)
        { 
            Graphics g = e.Graphics;
            g.DrawImage(Image.FromFile("bguang.png"), 0, 0, label_uang.Width, label_uang.Height);
            g.DrawString("$" + Form_menu.ingame_money, new Font("Arial", 14, FontStyle.Italic), new SolidBrush(Color.Black), 0, 0);
        }

        private void label_addshield_Click(object sender, EventArgs e)
        {
            //Maria 
            if (Form_menu.shieldactivated)
            {
                MessageBox.Show("Shield sedang aktif");
            }
            else
            {
                if (Form_menu.ingame_money < 50)
                {
                    MessageBox.Show("Uang Tidak Cukup!");
                }
                else
                {
                    DialogResult dr = MessageBox.Show("Tambah Shield?", "Confirmation", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        MessageBox.Show("Berhasil Terbeli!");
                        Form_menu.ingame_money -= 50;
                        //label_uang.Text = "$" + parent.ingame_money; 
                        label_uang.Invalidate();
                        Form_menu.shieldactivated = true;
                    }

                }
            }

        }

        private void label_addshield_Paint(object sender, PaintEventArgs e)
        { 
            Graphics g = e.Graphics; 
            g.DrawImage(Image.FromFile("buttonshield1.png"), 0, 0, label_addshield.Width, label_addshield.Height+15);
            //g.DrawImage(Image.FromFile("addsoldier.png"), 3, 3,60, 60);
            //g.DrawString("$50", new Font("Arial", 16, FontStyle.Italic), new SolidBrush(Color.Black), 10, 80); 

        }

        private void label_addlife_Click(object sender, EventArgs e)
        { //Maria 
            if (Form_menu.ingame_money < 60)
            {
                MessageBox.Show("Uang Tidak Cukup!");
            }
            else
            {
                if (Form_menu.jumlahnyawa <= 2)
                {
                    DialogResult dr = MessageBox.Show("Membeli nyawa?", "Confirmation", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        MessageBox.Show("Berhasil Terbeli!");
                        Form_menu.ingame_money -= 60;
                        Form_menu.jumlahnyawa += 1;
                        //label_uang.Text = "$" + parent.ingame_money;
                        label_uang.Invalidate();
                    }
                }
                else if (Form_menu.jumlahnyawa == 3)
                {
                    MessageBox.Show("Nyawa Sudah Penuh! Tidak Dapat Menambah Nyawa!");
                }
            }

        }

        private void label_addlife_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImage(Image.FromFile("buttonlife1.png"), 0, 0, label_addlife.Width, label_addlife.Height + 15);

        }

        private void label_upamunition_Click(object sender, EventArgs e)
        {
            //Maria 

            if (Form_menu.ingame_money < 100)
            {
                MessageBox.Show("Uang Tidak Cukup!");
            }
            else
            {
                if (Form_menu.damagebullet <= 2)
                {
                    DialogResult dr = MessageBox.Show("Upgrade Amunisi?", "Confirmation", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        MessageBox.Show("Berhasil Terbeli!");
                        Form_menu.ingame_money -= 100;
                        Form_menu.damagebullet += 1;
                        //label_uang.Text = "$" + parent.ingame_money;
                        label_uang.Invalidate();

                    }
                }
                else if (Form_menu.damagebullet == 3)
                {
                    MessageBox.Show("Level Peluru Sudah Maksimal! Tidak Dapat Mengupgrade Peluru!");
                }
            }

        }

        private void label_upamunition_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImage(Image.FromFile("buttonamunition1.png"), 0, 0, label_upamunition.Width, label_upamunition.Height + 15);


        }

        private void labelbackground_Paint(object sender, PaintEventArgs e)
        { 
            Graphics g = e.Graphics;
            g.DrawImage(Image.FromFile("bguang.png"), -15, -10, labelbackground.Width+27, labelbackground.Height+22);
        }

        private void labelbackground_Click(object sender, EventArgs e)
        {

        }
    }
}
