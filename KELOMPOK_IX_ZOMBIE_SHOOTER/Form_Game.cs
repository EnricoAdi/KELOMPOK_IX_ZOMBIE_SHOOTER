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
using System.Xml;
namespace KELOMPOK_IX_ZOMBIE_SHOOTER
{
    public partial class Form_Game : Form
    {
        public Form_Game()
        {
            InitializeComponent();
        } 

        //property start gif
        int ctrtimerstarter_gif = 0;
        List<Image> startergif = new List<Image>();
        int ctrgif = 0; bool addgif = true; Random rnd = new Random();

        bool ingame = false;
        string[] list_isitips = { "Have a great game", "Level up while defeating \nthose zombies", "Aim for the win! \ndefeat all of the zombies", "To win, one must not lose", "Zombies were people to", "Don't forget to have fun", "(⚆ᗝ⚆)︻デ═一    (✖╭╮✖)","Watch out for the zombie waves"};

       int tpsint;  

        //property start gif end


        // property in game---------------------------------------------------------------------------------

        int maxday1 = 10; int maxday2 = 30; int maxday3 = 78; int maxday4 = 106; int maxday5 = 155; int maxday6 = 190;
        int ctr_animasi_tembak = 1;
        int ctrsuaratembak = 2;

        List<Image> gmbrlwn = new List<Image>();
        List<int> gerakkakilawan = new List<int>();
        List<Point> posisilawan = new List<Point>();
        List<Point> posisilawan_mati = new List<Point>();
        List<int> kaki_lawan_mati = new List<int>();


        List<Image> soldiergmbr = new List<Image>();
        int ctrtimer = 0;


        int posisiy_before = 30;
        int hadapsoldier = 0;
        int indxwarnasoldier = 0;  //0 hijau 1 merah



        List<int> list_level_lawan = new List<int>();
        int day = 0;
        int maxlvlzombie = 1;
        Rectangle rectbatas = new Rectangle(2, 420, 380, 1); 
        int gametime = 0;  
        int jumzombiemati = 0;
        int[] list_posisi_hati = { 125, 160, 195 };
        bool shop_on = false;

        int ctrTips = 0;

        SoundPlayer gunshot = new SoundPlayer();
        SoundPlayer reload = new SoundPlayer();
        SoundPlayer suarashield = new SoundPlayer();
        SoundPlayer zombiemasuk = new SoundPlayer();

        Bitmap[] gmbrshield = new Bitmap[8];
        Image[] gmbrstopplay = new Image[2];
        int ctrshield = 0;//shield nyala  
        int ctrloadamunisi = 2; 
        bool reload_amunisi = false;

        int banyak_zombie_maju = 10; 
        Point lokasitembak = new Point(0, 0);
        // property in game end---------------------------------------------------------------------------------
        private void Form_Game_Load(object sender, EventArgs e)
        {
            button_playstop.BackColor = Color.Transparent;
            gmbrstopplay[0] = Image.FromFile("btnpause.png");
            gmbrstopplay[1] = Image.FromFile("btnplay.png");
            gunshot.SoundLocation = Application.StartupPath + @"\gunshot.wav";
            reload.SoundLocation = Application.StartupPath + @"\reload.wav";
            suarashield.SoundLocation = Application.StartupPath + @"\shieldmusic.wav";
            zombiemasuk.SoundLocation = Application.StartupPath + @"\zombiemasuk.wav";


            label_uang.Text = "$"+Form_menu.ingame_money+"";
            indxwarnasoldier = (int)this.Tag;
            hadapsoldier = indxwarnasoldier * 6;
            progressbar_amunisi.Visible = false;
            progressbar_amunisi.Value = 10;
            button_shop.Visible = false;
            label_day_and_zombie.Visible = false;
            button_playstop.Visible = false;

            startergif.Add(Image.FromFile("zombie3.png"));
            startergif.Add(Image.FromFile("zombie1.png"));
            startergif.Add(Image.FromFile("zombie3.png"));
            startergif.Add(Image.FromFile("zombie2.png"));

            lbl_tips.BackColor = Color.Transparent;
            lb_loading.BackColor = Color.Transparent;
            button_shop.BackColor = Color.Transparent;
            label_uang.BackColor = Color.Transparent;
            label_day_and_zombie.BackColor = Color.Transparent;
            timer_game_started.Start();


            tpsint = rnd.Next(0, list_isitips.Length); 

            timer_tips.Start(); 
            maxday1 = rnd.Next(10, 17);
            maxday2 = rnd.Next(30, 46);
            maxday3 = rnd.Next(78, 86);
            maxday4 = rnd.Next(106, 115);
            maxday5 = rnd.Next(155, 165);
            maxday6 = rnd.Next(190, 201);

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
            //idx 0 depan 1 depan fire, 2 kanan 3 kanan fire , 4 kiri 5 kirifire

            //012 zombie1 345 zombie2, 678 zombie3  --> level 0 brti zombie1
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
            {
                int zz = i + 1;
                gmbrshield[i] = new Bitmap(Image.FromFile("shield"+zz+".png"));
            } 
            int lvllwn = 0;
            list_level_lawan.Add(lvllwn);

            int rx = rnd.Next(0, 5) * 60;
            gerakkakilawan.Add(lvllwn*3);

            posisilawan.Add(new Point(rx, 20));

            ctrtimer = rnd.Next(6, 10);

            Form_menu.replaytimezombiespawn.Enqueue(gametime);
            Form_menu.replay_levelzombiespawn.Enqueue(lvllwn);
            Form_menu.replaylistzombie.Enqueue(new Point(rx, 20)); 
        }
        private void timer_game_started_Tick(object sender, EventArgs e)
        {
            //Enrico
            ctrtimerstarter_gif++;
            if (ctrtimerstarter_gif == 101)   //fix -> 101
            {
                if (addgif)
                {
                    addgif = false;
                    lb_loading.Visible = false; lbl_tips.Text = "";
                    lbl_tips.Visible = false; 
                    timer1.Start();
                    ingame = true;
                    button_shop.Visible = true;
                    button_playstop.Visible = true;
                    label_day_and_zombie.Text = "Zombies dead : " + jumzombiemati;
                    label_day_and_zombie.Visible = true;
                    progressbar_amunisi.Visible = true;
                    progressBar_loading.Visible = false;
                    gantiday = true;
                    timer_gantiday.Start();
                }
                timer_ingame.Start();
                timer_game_started.Stop();
            }
            else
            {
                if (addgif)
                {
                    progressBar_loading.Value += 1; ctrgif++;
                    if (ctrgif == 3)
                    { ctrgif = 0; }
                    if (ctrtimerstarter_gif % 12 == 0)
                    {
                        if (lb_loading.Text == "Loading")
                        {
                            lb_loading.Text = "Loading .";
                        }
                        else if (lb_loading.Text == "Loading .")
                        {
                            lb_loading.Text = "Loading . .";
                        }
                        else if (lb_loading.Text == "Loading . .")
                        {
                            lb_loading.Text = "Loading . . .";
                        }
                        else if (lb_loading.Text == "Loading . . .")
                        {
                            lb_loading.Text = "Loading";
                        }
                    }

                }
            }
            //Enrico
            this.Invalidate();
        } 
        //timer ingame
        private void timer1_Tick(object sender, EventArgs e)
        {
            //Enrico 
            ctrtimer--;
            if (ctrtimer <= 0)
            {
                //tambah zombie dr level lawan  -- > list level lawan , posisi lawan, kaki lawan
                int lvllwn = rnd.Next(0, maxlvlzombie);
                 
                list_level_lawan.Add(lvllwn); 

                ctrtimer = rnd.Next(7-day, 9-day);
                int rx = rnd.Next(0, 5) * 60;
                posisilawan.Add(new Point(rx, posisiy_before));
                gerakkakilawan.Add(lvllwn*3);

                Form_menu.replaytimezombiespawn.Enqueue(gametime);
                Form_menu.replay_levelzombiespawn.Enqueue(lvllwn);
                Form_menu.replaylistzombie.Enqueue(new Point(rx, 20));

                if (posisiy_before == 30)
                {   posisiy_before = 0;  }
                else { posisiy_before = 0; }  //hrsnya 30
            }
            else
            {
                bool zombielewat = false;
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
                    posisilawan[i] = new Point(posisilawan[i].X, posisilawan[i].Y + banyak_zombie_maju);
                    
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
                    if (!Form_menu.shieldactivated)
                    {
                        if (Form_menu.jumlahnyawa > 1)
                        {
                            Form_menu.jumlahnyawa--;
                            zombiemasuk.Play();
                            timer_suarazombiemasuk.Start();
                        }
                        else
                        {
                            Form_menu.jumlahnyawa--;
                            //maria
                            zombiemasuk.Play();
                            timer_suarazombiemasuk.Start();
                            //maria
                            timer_ingame.Stop();
                            timer1.Stop();
                            timer_shield.Stop();
                            progressbar_amunisi.Value = 0;

                            //Enrico

                            //Jonathan bryan
                             
                            int tempScore;
                            string tempNama;
                            if (Form_menu.list_highscore[2] < jumzombiemati)
                            {
                                if (Form_menu.list_highscore[1] < jumzombiemati)
                                {
                                    if (Form_menu.list_highscore[0] < jumzombiemati)
                                    {
                                        tempNama = Form_menu.listname_highscore[1];
                                        tempScore = Form_menu.list_highscore[1];
                                        Form_menu.list_highscore[2] = tempScore;
                                        Form_menu.listname_highscore[2] = tempNama;
                                        tempNama = Form_menu.listname_highscore[0];
                                        tempScore = Form_menu.list_highscore[0];
                                        Form_menu.list_highscore[1] = tempScore;
                                        Form_menu.listname_highscore[1] = tempNama;
                                        Form_menu.list_highscore[0] = jumzombiemati;
                                        Form_menu.listname_highscore[0] = Form_menu.nama_player_play;
                                        MessageBox.Show("Congratulation, you got 1st place", "Game over");
                                    }
                                    else
                                    {
                                        tempNama = Form_menu.listname_highscore[1];
                                        tempScore = Form_menu.list_highscore[1];
                                        Form_menu.list_highscore[1] = jumzombiemati;
                                        Form_menu.listname_highscore[1] = Form_menu.nama_player_play;
                                        Form_menu.list_highscore[2] = tempScore;
                                        Form_menu.listname_highscore[2] = tempNama;
                                        MessageBox.Show("Congratulation, you got 2nd place", "Game over");
                                    }
                                }
                                else
                                {
                                    Form_menu.list_highscore[2] = jumzombiemati;
                                    Form_menu.listname_highscore[2] = Form_menu.nama_player_play;
                                    MessageBox.Show("Congratulation, you got 3rd place", "Game over");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Sorry no place for you on the Leaderboard", "Game over");
                            }

                            XmlWriterSettings xSetting = new XmlWriterSettings();
                            xSetting.Indent = true;

                            XmlWriter xWriter = XmlWriter.Create(Application.StartupPath + "\\project.xml", xSetting);

                            xWriter.WriteStartDocument();

                            xWriter.WriteStartElement("leaderBoard");
                            for (int i = 0; i < Form_menu.listname_highscore.Count(); i++)
                            {
                                xWriter.WriteElementString("user", Form_menu.listname_highscore[i]);
                                xWriter.WriteElementString("score", Form_menu.list_highscore[i].ToString());
                            }
                            xWriter.WriteEndElement();

                            xWriter.WriteEndDocument();

                            xWriter.Close();

                            //Jonathan bryan

                            DialogResult dr = MessageBox.Show("Do you want to replay your game?","Replay",MessageBoxButtons.YesNo);
                            if (dr==DialogResult.No)
                            {
                                Form_menu.clearqueue();
                                Form_menu.music.Play();
                                Form_menu.bgGame = Image.FromFile("bg_grass.jpg");
                                Form_menu.nama_player_play = "";
                                Form_menu.ingame_money = 10;
                                Form_menu.volumelagu = 70;
                                Form_menu.jumlahnyawa = 3;  
                                Form_menu.damagebullet = 1;
                                Form_menu.shieldactivated = false;
                                Form_menu.clearqueue();
                                this.Close();
                            }
                            else
                            {
                                Form_replay gm = new Form_replay(); 
                                gm.FormClosed += Form_menu.tutupreplay;
                                gm.Tag = indxwarnasoldier;
                                gm.Show();
                                this.Visible = false;

                            } 
                            //END GAME
                        }

                    }
                }
            } 
            this.Invalidate();
        }

        private void timer_animasi_tembak_Tick(object sender, EventArgs e)
        { 
            ctr_animasi_tembak--; 
            if (ctr_animasi_tembak == 0)
            {
                lokasitembak = new Point(0, 0);
                hadapsoldier--; 
                timer_animasi_tembak.Stop();
                ctr_animasi_tembak = 1;
            }
            this.Refresh();
        }
        private void timer_animasi_zombiemati(object sender, EventArgs e)
        {
            Timer z = (Timer)sender;
            int wktusisa = (int)z.Tag;
            wktusisa--;

            if (wktusisa == 0)
            {
                posisilawan_mati.RemoveAt(0);
                kaki_lawan_mati.RemoveAt(0);
                z.Stop();
                this.Invalidate();
            }
            z.Tag = wktusisa;
        }

        private void Form_Game_MouseClick(object sender, MouseEventArgs e)
        { 
            if (ingame)
            {
                if (shop_on)
                {
                    MessageBox.Show("Please close the shop first", ":(",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (playon)
                    {
                int x = e.X;
                int y = e.Y;
                lokasitembak = new Point(x, y);
                int xsoldier = 180;

                if (progressbar_amunisi.Value > 0 && !reload_amunisi)
                {
                    if (x > xsoldier)  //>180
                    { 
                         hadapsoldier = indxwarnasoldier*6 + 3;   //kanan tembak 
                    }
                    if (x > xsoldier - 110 && x < xsoldier)   
                    {
                        hadapsoldier = indxwarnasoldier * 6 +  1;
                    }
                    if (x < xsoldier - 100)  //<80
                    {
                        hadapsoldier = indxwarnasoldier * 6 +  5;    //kiri tembak
                    }
                        bool readyattack = true;
                    Rectangle serang = new Rectangle(x, y, 30, 30);
                    for (int i = 0; i < posisilawan.Count; i++)
                    {
                        Rectangle trgt = new Rectangle(posisilawan[i].X, posisilawan[i].Y, 50, 50);
                    if (readyattack)
                    {//cek level
                        if (serang.IntersectsWith(trgt))
                        {
                                Form_menu.replaytimesoldiershot.Enqueue(gametime);
                                Form_menu.replaylistsoldier.Enqueue(lokasitembak);
                                if (list_level_lawan[i]<=0)
                                {
                                    Add_Refresh_Money();
                                    kaki_lawan_mati.Add(2);
                                    posisilawan_mati.Add(new Point(posisilawan[i].X, posisilawan[i].Y)); 

                                    posisilawan.RemoveAt(i);
                                    gerakkakilawan.RemoveAt(i);
                                    list_level_lawan.RemoveAt(i); 
                                    Timer z = new Timer();
                                    z.Tick += timer_animasi_zombiemati;
                                    z.Interval = 500;
                                    z.Tag = 2;
                                    z.Start();
                                     
                                    // day0 -> 10-16 zombie 
                                    //day1 --> 30 - 46 zombie
                                    //day2 --> 78 - 85 zombie
                                    //day3 --> 106 - 115 zombie
                                    //day4 --> 155 - 165 zombie
                                    //day5 --> 190 - 200 zombie 
                                    //
                                    jumzombiemati++;
                                    if (jumzombiemati==maxday1 || jumzombiemati == maxday2 || jumzombiemati==maxday3 || jumzombiemati==maxday4 || jumzombiemati==maxday5 || jumzombiemati==maxday6)
                                    {
                                        day++; 
                                        gantiday = true;
                                        timer_gantiday.Start();
                                        if (maxlvlzombie<3)
                                        {
                                            maxlvlzombie++;
                                        }
                                        if (timer1.Interval >50)
                                        {
                                            timer1.Interval -= 50;
                                            Form_menu.replaytime_intervaldown.Enqueue(gametime);
                                        }
                                    } 
                                    else if (jumzombiemati>207 && jumzombiemati % 5 == 0)
                                    {
                                        if (timer1.Interval>3)
                                        {
                                            timer1.Interval -= 2; 
                                        }
                                        jumzombiemati += 1;
                                    }
                                    label_day_and_zombie.Text = "Zombies dead : " + jumzombiemati;
                                }

                                else
                                {
                                    Add_Refresh_Money();
                                    gerakkakilawan[i] -= 3;
                                    list_level_lawan[i] -= 1;
                                }
                                    readyattack = false;
                        }

                     }
                        
                    }
                        if (progressbar_amunisi.Value>0)
                        {
                           progressbar_amunisi.Value -= 1;

                        } 
                        gunshot.Play(); 
                        timer_suaratembak.Start(); 
                        timer_animasi_tembak.Start();

                        if (progressbar_amunisi.Value<=0)
                        { 
                             reload.Play(); 
                            timer_reload_amunisi.Start();
                        }
                    } 
                this.Invalidate(); 

                    }
                }
            } 
        }

        private void Form_Game_Paint(object sender, PaintEventArgs e)
        { 
            //Enrico
            if (ingame)
            {
                Graphics g = e.Graphics;
                g.DrawImage(Form_menu.bgGame,1,1,this.Width,this.Height); 

                if (gantiday)
                {
                    g.FillRectangle(new SolidBrush(Color.White),0,(this.Height/2) - 70 , this.Width,60);
                    g.DrawString("DAY "+ (day + 1), new Font("Arial",30, FontStyle.Italic),new SolidBrush(Color.Red),120, (this.Height/2)-70); 
                }
                g.FillRectangle(new SolidBrush(Color.Red), 2, 415, 380, 10);
                g.DrawImage(soldiergmbr[hadapsoldier], 142, 450, 55, 55);

                if (Form_menu.shieldactivated)
                { 
                    g.DrawImage(gmbrshield[ctrshield%8], 142, 450, 55, 55);
                } 
                for (int i = 0; i < Form_menu.jumlahnyawa; i++)
                {
                    g.DrawImage(Image.FromFile("heart.png"), list_posisi_hati[i] ,509, 18, 18);

                }
                if (posisilawan_mati.Count > 0 && kaki_lawan_mati.Count>0)
                {
                    for (int i = 0; i < kaki_lawan_mati.Count; i++)
                    {
                        try
                        {
                            g.DrawImage(gmbrlwn[kaki_lawan_mati[i]], posisilawan_mati[i].X, posisilawan_mati[i].Y, 50, 50); 
                        }
                        catch (Exception)
                        { 
                            throw;  
                        }
                    } 
                }

                for (int i = gerakkakilawan.Count-1; i >=0  ; i--)
                {
                    g.DrawImage(gmbrlwn[gerakkakilawan[i]], posisilawan[i].X, posisilawan[i].Y, 50, 50); 
                }

                if (!showprogressbar)
                {
                    g.DrawImage(Image.FromFile("bullet_off.png"), progressbar_amunisi.Location.X + 75, progressbar_amunisi.Location.Y-10, 35, 35);
                    g.DrawString("x " + progressbar_amunisi.Value, new Font("Arial", 16, FontStyle.Italic), new SolidBrush(Color.Black), progressbar_amunisi.Location.X + 105, progressbar_amunisi.Location.Y); 
                }
                if (!playon)
                {
                     g.DrawImage(Image.FromFile("gamepaused.png"),0,0,this.Width,this.Height); 
                }
                //Enrico
            } else  
            {   //Jonathan bryan
                Graphics g = e.Graphics;
                g.DrawImage(Image.FromFile("bgstart2.jpg"), 0, 0, this.Width, this.Height);

                g.DrawImage(Image.FromFile("logo.png"), progressBar_loading.Location.X + 40, progressBar_loading.Location.Y - 200, 140, 140);
                g.DrawImage(startergif[ctrgif], progressBar_loading.Location.X + (progressBar_loading.Value * 2), progressBar_loading.Location.Y - 50, 25, 40);
            }
           
        }
        bool showprogressbar = true;
        int nyawasebelumnya = 3; int bullet_sebelumnya = 1;
        private void button_shop_Click(object sender, EventArgs e)
        {
            //Maria
            if (!shop_on)
            { 
                try
                {
                    playandstop("stop");
                    button_playstop.Visible = false;
                    nyawasebelumnya = Form_menu.jumlahnyawa;
                    bullet_sebelumnya = Form_menu.damagebullet;
                    shop_on = true;
                    this.Location = new Point(270,75);
                    Form_shop shopp = new Form_shop();
                    shopp.Location = new Point(710,75); 
                    shopp.FormClosed += shopclose;
                    shopp.Tag = "Shop";
                    shopp.Show();
                }
                catch (Exception)
                {
                    MessageBox.Show("Opening shop");
                }
            }
            else
            {
                MessageBox.Show("Shop had been activated !",":(",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            //Maria
            
        }
        void playandstop(string a)
        {
            if (a=="stop")
            {
                timer_ingame.Stop();
                timer1.Stop();
                timer_shield.Stop();
            }
            else
            {
                timer_ingame.Start();
                timer1.Start();  
            }
        }
        void shopclose(object sender, EventArgs e)
        {
            //Enrico
            try
            {
                button_playstop.Visible = true;
                this.KeyPreview = true;  
                if (Form_menu.jumlahnyawa > nyawasebelumnya)
                {
                    Form_menu.replaytime_addlife.Enqueue(gametime);
                }
                playandstop("play");
                label_uang.Text = "$" + Form_menu.ingame_money; 
                this.Location = new Point(583, 77);
                shop_on = false;
                if (Form_menu.shieldactivated)
                {
                    suarashield.PlayLooping();
                    timer_shield.Start();
                    Form_menu.replaytimeshield.Enqueue(gametime);
                } 
                progressbar_amunisi.Maximum = Form_menu.damagebullet * 10;
                //kasih cek
                if (bullet_sebelumnya< Form_menu.damagebullet)
                { 
                    progressbar_amunisi.Value = progressbar_amunisi.Maximum; 
                }
                this.Invalidate();

            }
            catch (Exception)
            { 
                throw;
            }
            //Enrico
        }

        private void panel_button_shop_Paint(object sender, PaintEventArgs e)  { }

        private void button_shop_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImage(Image.FromFile("shop2.png"), 0, 0, button_shop.Width, button_shop.Height);
        }
        private void timer_suaratembak_Tick(object sender, EventArgs e)
        {
            //Maria 
            ctrsuaratembak--;
            if (ctrsuaratembak == 0)
            {
                gunshot.Stop();
                if (Form_menu.shieldactivated)
                {
                    suarashield.PlayLooping();
                }
                ctrsuaratembak = 2;
                timer_suaratembak.Stop();
            }
            //Maria

        }

        private void timer_ingame_Tick(object sender, EventArgs e)
        {
            if (ingame)
            {
                gametime += 1; 
            }
        }

        private void timer_reload_amunisi_Tick(object sender, EventArgs e)
        {
            //Maria 
            ctrloadamunisi--;
            reload_amunisi = true; 
            progressbar_amunisi.Value += 5* Form_menu.damagebullet;
            if (ctrloadamunisi<=0)
            {
                reload_amunisi = false;
                ctrloadamunisi = 2;
                reload.Stop();
                if (Form_menu.shieldactivated==true)
                {
                    suarashield.PlayLooping();
                }
                timer_reload_amunisi.Stop();
            }
            //Maria
        }

        bool kondisiTips = false;
        private void Add_Refresh_Money()
        {
            Form_menu.ingame_money += 1;
            label_uang.Text = "$" + Form_menu.ingame_money;

        }
        private void timer_tips_Tick(object sender, EventArgs e)  {} 
        private void timer_tips_Tick_1(object sender, EventArgs e)
        {
            //Jonathan Bryan
            if (kondisiTips)
            {
                if (ctrTips - 10 > 0)
                {
                    ctrTips -= 10;
                }
                else
                {
                    kondisiTips = false;
                    ctrTips = 0;
                    tpsint = rnd.Next(0, list_isitips.Length); 
                }
            }
            else
            {
                if (ctrTips + 10 < 255)
                {
                    ctrTips += 10;
                }
                else
                {
                    kondisiTips = true;
                    ctrTips = 255; 
                }
            }
            lbl_tips.Invalidate();
            //Jonathan bryan
        }
        private void lbl_tips_Click(object sender, EventArgs e) {}

        private void lbl_tips_Paint(object sender, PaintEventArgs e)
        {
            //Jonathan bryan
            Graphics g = e.Graphics;
            SolidBrush b = new SolidBrush(Color.FromArgb(ctrTips, Color.White));
            try
            {
                FontFamily fontFamily = new FontFamily("MS Gothic");
                Font font = new Font(fontFamily,14, FontStyle.Regular,GraphicsUnit.Pixel);
                g.DrawString(list_isitips[tpsint], font, b, 0, 0);

            }
            catch (Exception)
            {
                MessageBox.Show("Starting game....");
            }
            //Jonathan bryan
        }

        private void timer_shield_Tick(object sender, EventArgs e)
        {
            //Enrico 
            ctrshield++;
            if (ctrshield>51)
            {
                suarashield.Stop();
                Form_menu.shieldactivated = false;
                ctrshield = 0;
                timer_shield.Stop();
            }
            this.Invalidate();
            //Enrico
        }

        private void label1_Click(object sender, EventArgs e) {    } 
        private void label1_Paint(object sender, PaintEventArgs e)  {   }

        int ctrgantiday = 2; bool gantiday = false;
        private void timer_gantiday_Tick(object sender, EventArgs e)
        { 
            //Maria
            ctrgantiday--;
            if (ctrgantiday==0)
            {
                ctrgantiday = 2;
                gantiday = false;
                timer_gantiday.Stop();
            }
            this.Invalidate();
            //Maria
        }

        private void timer_ingame_Tick_1(object sender, EventArgs e)
        { 
            if (ingame)
            {
                gametime += 1;
            }
        }

        private void timer_suarazombiemasuk_Tick(object sender, EventArgs e)
        {
            //maria
            timer_suarazombiemasuk.Stop();
            //maria
        }
        bool cheatused = false;
        bool propson = true;
        int idxplay = 0; //0 play 1 pause
        bool playon = true;
        private void Form_Game_KeyPress(object sender, KeyPressEventArgs e)
        {
            //cheats
            if (e.KeyChar == 'p' || e.KeyChar == 'P')
            { 
                    if (!showprogressbar)
                    {
                        showprogressbar = true;
                        progressbar_amunisi.Visible = true;
                    }
                    else
                    {
                        showprogressbar = false;
                        progressbar_amunisi.Visible = false;
                    }
                     
                this.Invalidate();

            }
            if (e.KeyChar == 'k' || e.KeyChar == 'K')
            {
                if (propson)
                {  
                    label_day_and_zombie.Visible = false;
                    label_uang.Visible = false;
                    propson = false;
                }
                else
                {  
                    label_day_and_zombie.Visible = true;
                    label_uang.Visible = true;
                    propson = true;

                }

                this.Invalidate();

            }
            if (e.KeyChar == 'b' || e.KeyChar == 'B')
            { 
                if (Form_menu.damagebullet<=2)
                {
                    Form_menu.damagebullet +=1;
                    progressbar_amunisi.Maximum = Form_menu.damagebullet * 10;
                    progressbar_amunisi.Value = progressbar_amunisi.Maximum;

                }
                this.Invalidate();

            }
            if(e.KeyChar == 'c' || e.KeyChar == 'C')
            {
                if (!ingame)
                {
                    try
                    {
                        if (!cheatused)
                        {
                            progressBar_loading.Value = 92;
                            ctrtimerstarter_gif = 93;
                            this.Invalidate();
                            cheatused = true; 
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Hi :D");
                    }


                }
                else
                {
                    Form_menu.ingame_money += 100;
                    label_uang.Text = "$" + Form_menu.ingame_money;
                }
            }
        }

        private void button_playstop_Click(object sender, EventArgs e)
        {
            if (idxplay==0) //mau di pause
            {
                idxplay = 1;
                playon = false;
                button_shop.Enabled = false;
                playandstop("stop"); 
            }
            else
            {
                playon = true;
                button_shop.Enabled = true;
                idxplay = 0;
                playandstop("play");
            }
            button_playstop.Invalidate();
            this.Invalidate();
        }

        private void button_playstop_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImage(gmbrstopplay[idxplay], 0, 0, button_playstop.Width, button_playstop.Height);
        }
    }
}
