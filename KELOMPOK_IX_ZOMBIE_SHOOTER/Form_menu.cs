using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Xml;

namespace KELOMPOK_IX_ZOMBIE_SHOOTER
{
    public partial class Form_menu : Form
    {
        public Form_menu()
        {
            InitializeComponent();
        }
        //FORM MAIN

        //KELOMPOK 9
        public static int maxday1 = 10; public static int maxday6 = 190;
        public static int maxday2 = 30; public static int maxday3 = 78;
        public static int maxday4 = 106; public static int maxday5 = 155;

        //Enrico
        public static Queue<Point> replaylistsoldier = new Queue<Point>();
        public static Queue<int> replaytimesoldiershot = new Queue<int>();

        public static Queue<int> replaytimezombiespawn = new Queue<int>();
        public static Queue<Point> replaylistzombie = new Queue<Point>();
        public static Queue<int> replay_levelzombiespawn = new Queue<int>();

        public static Queue<int> replaytimeshield = new Queue<int>();

        public static Queue<int> replaytime_intervaldown = new Queue<int>();
        public static Queue<int> replaytime_addlife = new Queue<int>();
        //Enrico

        public static List<string> listname_highscore = new List<string>();
        public static List<int> list_highscore = new List<int>();



        public static Image bgGame = Image.FromFile("bg_grass.jpg");
        public static string nama_player_play = "";
        public static int ingame_money = 10;
        public static int volumelagu = 70;
        public static int jumlahnyawa = 3;
        public static int damagebullet = 1;
        public static bool shieldactivated = false;

        public static bool song_on = true;

        //lagu pake soundplayer
        public static SoundPlayer music = new SoundPlayer();

        private const int APPCOMMAND_VOLUME_UP = 0xA0000;
        private const int APPCOMMAND_VOLUME_DOWN = 0x90000;
        private const int WM_APPCOMMAND = 0x319;

        [DllImport("user32.dll")]
        public static extern IntPtr SendMessageW(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);
        string nodeName = "";

        public static void clearqueue()
        {
            //MARIA
            while (replaylistsoldier.Count > 0)
            {
                replaylistsoldier.Dequeue();
            }
            while (replaylistzombie.Count > 0)
            {
                replaylistzombie.Dequeue();
            }
            while (replaytimesoldiershot.Count > 0)
            {
                replaytimesoldiershot.Dequeue();
            }
            while (replaytimezombiespawn.Count > 0)
            {
                replaytimezombiespawn.Dequeue();
            }
            while (replaytimeshield.Count > 0)
            {
                replaytimeshield.Dequeue();
            }
            while (replay_levelzombiespawn.Count > 0)
            {
                replay_levelzombiespawn.Dequeue();
            }
            while (replaytime_intervaldown.Count > 0)
            {
                replaytime_intervaldown.Dequeue();
            }
            while (replaytime_addlife.Count > 0)
            {
                replaytime_addlife.Dequeue();
            }

            //MARIA
        }
        public static void tutupreplay(object sender, EventArgs e)
        {
            clearqueue();
            Form_menu fm = new Form_menu();
            fm.Tag = "menu";
            fm.Show();

        }
        private void Form_menu_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImage(Image.FromFile("bgstart4.jpg"),0,0,this.Width,this.Height);
            g.DrawImage(Image.FromFile("logo.png"),80,80,180,180);
        }

        public static void closeform(object sender, EventArgs e)
        {
            Form_menu fm = new Form_menu();
            fm.Tag = "sudahplay";
            fm.Show();
        }
        public void closeapp(object sender, EventArgs e)
        { Application.Exit();    }
        private void Form_menu_Load(object sender, EventArgs e)
        {  
            music.SoundLocation = Application.StartupPath + @"\Mainmenu.wav";

            //Enrico 
            this.FormClosed += closeapp;
            string teg = this.Tag + "";
            if (teg!="sudahplay")
            {
                song_on = true;
                music.Play();
            } 
            //Enrico

            panel_btn_play.BackColor = Color.Transparent;
            panel_btn_leaderboard.BackColor = Color.Transparent;
            panel_settings.BackColor = Color.Transparent;
            button_howtoplay.BackColor = Color.Transparent;
            if (teg=="")
            {
                // JONATHAN BRYAN 
                XmlReader xReader = XmlReader.Create(Application.StartupPath + "\\project.xml");

                while (xReader.Read())
                {
                    switch (xReader.NodeType)
                    {
                        case XmlNodeType.Element:
                            nodeName = xReader.Name;
                            break;
                        case XmlNodeType.Text:
                            if (nodeName == "user")
                            {
                                listname_highscore.Add(xReader.Value);
                            }
                            else if (nodeName == "score")
                            {
                                list_highscore.Add(Convert.ToInt32(xReader.Value));
                            }
                            break;
                    }
                }
                xReader.Close();
                // JONATHAN BRYAN 

            }
        }

        private void panel_button_start_Paint(object sender, PaintEventArgs e)
        {    }  

        private void panel_btn_play_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImage(Image.FromFile("start_button.png"),0,-2,146,51);
        }

        private void panel_btn_play_MouseClick(object sender, MouseEventArgs e)
        {

            Form_pilih_skin ps = new Form_pilih_skin();
            ps.Tag = "Play";
            ps.FormClosed += closeform;
            ps.Show();
            this.Visible = false;
        }

        private void panel_btn_leaderboard_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImage(Image.FromFile("btnleaderboard.png"), 1, -8, 146, 65);

        }

        private void panel_btn_leaderboard_Click(object sender, EventArgs e)
        { } 
        private void panel_btn_leaderboard_MouseClick(object sender, MouseEventArgs e)
        {
            Form_Leaderboard lb = new Form_Leaderboard();
            lb.Tag = "Leaderboard";
            lb.FormClosed += closeform;
            lb.Show(); 
            this.Visible= false;
        }
        private void panel_settings_Paint(object sender, PaintEventArgs e)
        { 
            Graphics g = e.Graphics;
            g.DrawImage(Image.FromFile("btnsoundsettings.png"), 2, -2, 60, 55);
        }

        private void panel_settings_MouseClick(object sender, MouseEventArgs e)
        {
            Form_soundsettings lb = new Form_soundsettings();
            lb.Tag = "Sound"; 
            lb.Location = new Point(950, 75); 
            lb.Show();

        }

        private void button_howtoplay_Click(object sender, EventArgs e)
        { 
            Formtutorial fm = new Formtutorial();
            fm.Tag = "HowToPlay";
            fm.FormClosed += closeform;
            fm.Show();
            this.Visible = false;
        }

        private void button_howtoplay_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImage(Image.FromFile("btntutorial.png"),9,0,button_howtoplay.Width-10,button_howtoplay.Height-10);
        }
    }
}
