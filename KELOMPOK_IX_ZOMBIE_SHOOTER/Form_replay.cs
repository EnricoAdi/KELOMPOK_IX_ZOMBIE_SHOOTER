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

namespace KELOMPOK_IX_ZOMBIE_SHOOTER
{
    public partial class Form_replay : Form
    {
        public Form_replay()
        {
            InitializeComponent();
        }
        SoundPlayer ingamemusic = new SoundPlayer(); 
        Point lokasi_shoot;
        bool adashoot = false;
        List<Point> posisilawan = new List<Point>();
        List<Image> gmbrlwn = new List<Image>();

        List<int> gerakkakilawan = new List<int>();
        List<Point> posisilawan_mati = new List<Point>();

        List<int> list_level_lawan = new List<int>();

        List<Image> soldiergmbr = new List<Image>();
        int hadapsoldier = 0;
        int indxwarnasoldier = 0;

        Rectangle rectbatas = new Rectangle(2, 420, 380, 1);

        Bitmap[] gmbrshield = new Bitmap[8];
        int tmr = 0;
        int target_time_shoot = 0;
        int time_zombie_spawn = 0;

        bool shieldactivated = false;
        int ctrshield = 0;
        int target_time_shield = 0;
        int jumlahnyawa = 3;
        int intervalbagi = 7;  //coba 7 di timer1 game interval 350
        int target_time_intervaldown = 0;

        int target_time_addlife = 0;
        int[] list_posisi_hati = { 125, 160, 195 };
        int jumlahzombiemati = 0;
        private void Form_replay_Load(object sender, EventArgs e)
        { 
            indxwarnasoldier = (int)this.Tag; 
            ingamemusic.SoundLocation = Application.StartupPath + @"\ingamemusic.wav";
            ingamemusic.Play();
            soldiergmbr.Add(Image.FromFile("player_depan.png"));
            soldiergmbr.Add(Image.FromFile("player_depan_fire.png"));
            soldiergmbr.Add(Image.FromFile("player_kanan.png"));
            soldiergmbr.Add(Image.FromFile("player_kanan_fire.png"));
            soldiergmbr.Add(Image.FromFile("player_kiri.png"));
            soldiergmbr.Add(Image.FromFile("player_kiri_fire.png"));

            soldiergmbr.Add(Image.FromFile("player2_depan.png"));
            soldiergmbr.Add(Image.FromFile("player2_depan_fire.png"));
            soldiergmbr.Add(Image.FromFile("player2_kanan.png"));
            soldiergmbr.Add(Image.FromFile("player2_kanan_fire.png"));
            soldiergmbr.Add(Image.FromFile("player2_kiri.png"));
            soldiergmbr.Add(Image.FromFile("player2_kiri_fire.png"));

            gmbrlwn.Add(Image.FromFile("zombie-1b.png"));
            gmbrlwn.Add(Image.FromFile("zombie-1c.png"));
            gmbrlwn.Add(Image.FromFile("zombie-1b_fall.png"));
            gmbrlwn.Add(Image.FromFile("zombie-2b.png"));
            gmbrlwn.Add(Image.FromFile("zombie-2c.png"));
            gmbrlwn.Add(Image.FromFile("zombie-1b_fall.png"));
            gmbrlwn.Add(Image.FromFile("zombie-3b.png"));
            gmbrlwn.Add(Image.FromFile("zombie-3c.png"));
            gmbrlwn.Add(Image.FromFile("zombie-1b_fall.png"));

            for (int i = 0; i < 8; i++)
            {  int zz = i + 1;
                gmbrshield[i] = new Bitmap(Image.FromFile("shield" + zz + ".png"));   }
            //Maria
            if (Form_menu.replaylistsoldier.Count > 0)
            {
                target_time_shoot = Form_menu.replaytimesoldiershot.Dequeue() * 2;
                Form_menu.replaytimesoldiershot.Enqueue(target_time_shoot);
            }
            if (Form_menu.replaytimeshield.Count > 0)
            {
                target_time_shield = Form_menu.replaytimeshield.Dequeue() * 2;
                Form_menu.replaytimeshield.Enqueue(target_time_shield);
            }
            time_zombie_spawn = Form_menu.replaytimezombiespawn.Dequeue() * 2;
            Form_menu.replaytimezombiespawn.Enqueue(time_zombie_spawn);
            if (Form_menu.replaytime_intervaldown.Count > 0)
            {
                target_time_intervaldown = Form_menu.replaytime_intervaldown.Dequeue() * 2;
            }
            if (Form_menu.replaytime_addlife.Count > 0)
            {
                target_time_addlife = Form_menu.replaytime_addlife.Dequeue() * 2;
            } 
            this.Invalidate();
            timer_replay.Start();
            //Maria

        }

        private void timer_replay_Tick(object sender, EventArgs e)
        { 
            //Enrico
            if (tmr == target_time_intervaldown)
            {
                if (intervalbagi > 1)
                {
                    intervalbagi--;  
                }
                if (Form_menu.replaytime_intervaldown.Count > 0)
                {
                    target_time_intervaldown = Form_menu.replaytime_intervaldown.Dequeue() * 2;
                }
            }
            //zombie
            if (tmr == time_zombie_spawn)
            {
                if (Form_menu.replaytimezombiespawn.Count > 0)
                {
                    time_zombie_spawn = Form_menu.replaytimezombiespawn.Dequeue() * 2;
                }
                if (Form_menu.replaylistzombie.Count > 0)
                {
                    posisilawan.Add(Form_menu.replaylistzombie.Dequeue());
                    if (Form_menu.replay_levelzombiespawn.Count > 0)
                    {
                        int lvllawan = Form_menu.replay_levelzombiespawn.Dequeue();
                        list_level_lawan.Add(lvllawan);
                        gerakkakilawan.Add(lvllawan * 3);

                    }
                }
            }
            else
            {
                if (tmr % intervalbagi == 0)  //sesuaiin sama interval aja
                {
                    bool zombielewat = false;
                    if (posisilawan.Count > 0)
                    {
                        for (int i = 0; i < gerakkakilawan.Count; i++)
                        {
                            gerakkakilawan[i]++;

                            if (gerakkakilawan[i] == 2)
                            {
                                gerakkakilawan[i] = 0;
                            }
                            if (gerakkakilawan[i] == 5)
                            {
                                gerakkakilawan[i] = 3;
                            }
                            if (gerakkakilawan[i] == 8)
                            {
                                gerakkakilawan[i] = 6;
                            }
                            posisilawan[i] = new Point(posisilawan[i].X, posisilawan[i].Y + 10);
                            Rectangle zmb = new Rectangle(posisilawan[i].X + 20, posisilawan[i].Y + 20, 10, 10);
                            if (rectbatas.IntersectsWith(zmb))
                            {
                                zombielewat = true;

                                posisilawan.RemoveAt(i);
                                gerakkakilawan.RemoveAt(i);
                                list_level_lawan.RemoveAt(i);
                            }
                        }
                        if (zombielewat)
                        { 
                            if (!shieldactivated)
                            {
                                if (jumlahnyawa > 1)
                                {
                                    jumlahnyawa--;
                                }
                                else
                                {
                                    jumlahnyawa--;
                                    timer_replay.Stop();
                                    //END GAME  
                                    ingamemusic.Stop();
                                    MessageBox.Show("Replay end", "Thanks", MessageBoxButtons.OK);
                                    Form_menu.music.Play();
                                    Form_menu.bgGame = Image.FromFile("bg_grass.jpg");
                                    Form_menu.nama_player_play = "";
                                    Form_menu.ingame_money = 10;
                                    Form_menu.volumelagu = 70;
                                    Form_menu.jumlahnyawa = 3;   //kalo udh habis kembaliin ke 3 lagi
                                    Form_menu.damagebullet = 1;
                                    Form_menu.shieldactivated = false;
                                     
                                    Form_menu.maxday1 = 10; Form_menu.maxday2 = 30; Form_menu.maxday3 = 78; Form_menu.maxday4 = 106; Form_menu.maxday5 = 155; Form_menu.maxday6 = 190;
                                    this.Close();

                                    //END GAME
                                }

                            }
                        }
                    }

                }

            }

            if (tmr == target_time_addlife)
            {
                if (jumlahnyawa < 3)
                {
                    jumlahnyawa++;

                }
                if (Form_menu.replaytime_addlife.Count > 0)
                {
                    target_time_addlife = Form_menu.replaytime_addlife.Dequeue() * 2;
                }
                else
                {
                    target_time_addlife = 0;
                }
            }
            //shield
            if (Form_menu.replaytimeshield.Count > 0)
            {
                if (tmr == target_time_shield)
                {
                    shieldactivated = true;
                    target_time_shield = Form_menu.replaytimeshield.Dequeue() * 2;
                    timer_shield.Start();
                }
                else
                {
                    shieldactivated = false;
                }
            }
            //soldier
            if (Form_menu.replaylistsoldier.Count > 0)
            {
                if (tmr == target_time_shoot)
                {
                    if (Form_menu.replaytimesoldiershot.Count > 0)
                    {
                        target_time_shoot = Form_menu.replaytimesoldiershot.Dequeue() * 2;
                    }
                    lokasi_shoot = Form_menu.replaylistsoldier.Dequeue();
                    //label_day_and_zombie.Text += "| ";
                    adashoot = true;      
                    int xsoldier = 180;//cek intersect  
                    if (lokasi_shoot.X > xsoldier)
                    {
                        hadapsoldier = indxwarnasoldier * 6 + 3;

                    }
                    if (lokasi_shoot.X > xsoldier - 99 && lokasi_shoot.X < xsoldier)
                    {
                        hadapsoldier = indxwarnasoldier * 6 + 1;
                    }
                    if (lokasi_shoot.X < xsoldier - 100)
                    {
                        hadapsoldier = indxwarnasoldier * 6 + 5;
                    }
                    timer_animasi_tembak.Start();

                    Rectangle serang = new Rectangle(lokasi_shoot.X - 30, lokasi_shoot.Y - 30, 80, 80);
                    for (int i = 0; i < posisilawan.Count; i++)
                    {
                        Rectangle trgt = new Rectangle(posisilawan[i].X, posisilawan[i].Y, 50, 50);
                        if (serang.IntersectsWith(trgt))
                        {
                            if (list_level_lawan[i] <= 0)
                            {
                                jumlahzombiemati++; 
                                posisilawan_mati.Add(new Point(posisilawan[i].X, posisilawan[i].Y));
                                posisilawan.RemoveAt(i);
                                gerakkakilawan.RemoveAt(i);
                                list_level_lawan.RemoveAt(i);
                                Timer z = new Timer();
                                z.Tick += timer_animasi_zombiemati;
                                z.Interval = 500;
                                z.Tag = 2;
                                z.Start();
                            }

                            else
                            {
                                gerakkakilawan[i] -= 3;
                                list_level_lawan[i] -= 1;
                            }

                        }
                    }

                }
                else
                {
                    adashoot = false;
                }
            }
            else
            {
                adashoot = false;
            }
            this.Invalidate(); 
            tmr++;


        }
        private void timer_animasi_zombiemati(object sender, EventArgs e)
        {
            //Maria
            Timer z = (Timer)sender;
            int wktusisa = (int)z.Tag;
            wktusisa--;
            if (wktusisa == 0)
            {
                posisilawan_mati.RemoveAt(0);
                z.Stop();
                this.Invalidate();
            }
            z.Tag = wktusisa;
        }

        private void Form_replay_Paint(object sender, PaintEventArgs e)
        { 
            Graphics g = e.Graphics;
            g.DrawImage(Form_menu.bgGame, 1, 1, this.Width, this.Height);
            g.FillRectangle(new SolidBrush(Color.Red), 2, 415, 380, 10);
            try
            {
                g.DrawImage(soldiergmbr[hadapsoldier], 142, 450, 55, 55);
            }
            catch (Exception)
            {
                g.DrawImage(soldiergmbr[0 * indxwarnasoldier], 142, 450, 55, 55);
            }

            if (shieldactivated)
            {
                g.DrawImage(gmbrshield[ctrshield % 8], 142, 450, 55, 55);
            }
            if (posisilawan_mati.Count > 0)
            {
                for (int i = 0; i < posisilawan_mati.Count; i++)
                {
                    g.DrawImage(gmbrlwn[2], posisilawan_mati[i].X, posisilawan_mati[i].Y, 50, 50);
                } 
            }
            for (int i = gerakkakilawan.Count - 1; i >= 0; i--)
            {
                g.DrawImage(gmbrlwn[gerakkakilawan[i]], posisilawan[i].X, posisilawan[i].Y, 50, 50);
            }

            try
            {
                for (int i = 0; i < jumlahnyawa; i++)
                {
                    g.DrawImage(Image.FromFile("heart.png"), list_posisi_hati[i], 516, 18, 18);

                }

            }
            catch (Exception)
            {
                g.DrawImage(soldiergmbr[hadapsoldier], 142, 450, 55, 55);

            } 

        }

        int ctr_animasi_tembak = 1;

        private void timer_animasi_tembak_Tick(object sender, EventArgs e)
        {
            ctr_animasi_tembak--;
            if (ctr_animasi_tembak == 0)
            {
                hadapsoldier--;
                timer_animasi_tembak.Stop();
                ctr_animasi_tembak = 2;
            }
            this.Refresh();

        }

        private void timer_shield_Tick(object sender, EventArgs e)
        {
            ctrshield++;
            if (ctrshield > 61)
            {
                shieldactivated = false;
                ctrshield = 0;
                timer_shield.Stop();
            }
            this.Invalidate();

        }
    }
}
