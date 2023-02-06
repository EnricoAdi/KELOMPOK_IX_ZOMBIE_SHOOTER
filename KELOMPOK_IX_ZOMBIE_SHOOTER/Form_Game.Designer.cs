
namespace KELOMPOK_IX_ZOMBIE_SHOOTER
{
    partial class Form_Game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Game));
            this.timer_game_started = new System.Windows.Forms.Timer(this.components);
            this.lbl_tips = new System.Windows.Forms.Label();
            this.lb_loading = new System.Windows.Forms.Label();
            this.progressBar_loading = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer_animasi_tembak = new System.Windows.Forms.Timer(this.components);
            this.button_shop = new System.Windows.Forms.Button();
            this.progressbar_amunisi = new System.Windows.Forms.ProgressBar();
            this.timer_suaratembak = new System.Windows.Forms.Timer(this.components);
            this.label_uang = new System.Windows.Forms.Label();
            this.timer_ingame = new System.Windows.Forms.Timer(this.components);
            this.timer_reload_amunisi = new System.Windows.Forms.Timer(this.components);
            this.timer_tips = new System.Windows.Forms.Timer(this.components);
            this.timer_shield = new System.Windows.Forms.Timer(this.components);
            this.label_day_and_zombie = new System.Windows.Forms.Label();
            this.timer_gantiday = new System.Windows.Forms.Timer(this.components);
            this.timer_suarazombiemasuk = new System.Windows.Forms.Timer(this.components);
            this.button_playstop = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer_game_started
            // 
            this.timer_game_started.Tick += new System.EventHandler(this.timer_game_started_Tick);
            // 
            // lbl_tips
            // 
            this.lbl_tips.Font = new System.Drawing.Font("MS Gothic", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tips.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_tips.Location = new System.Drawing.Point(90, 381);
            this.lbl_tips.Name = "lbl_tips";
            this.lbl_tips.Size = new System.Drawing.Size(305, 124);
            this.lbl_tips.TabIndex = 2;
            this.lbl_tips.Click += new System.EventHandler(this.lbl_tips_Click);
            this.lbl_tips.Paint += new System.Windows.Forms.PaintEventHandler(this.lbl_tips_Paint);
            // 
            // lb_loading
            // 
            this.lb_loading.AutoSize = true;
            this.lb_loading.Font = new System.Drawing.Font("MS Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_loading.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_loading.Location = new System.Drawing.Point(170, 340);
            this.lb_loading.Name = "lb_loading";
            this.lb_loading.Size = new System.Drawing.Size(79, 19);
            this.lb_loading.TabIndex = 1;
            this.lb_loading.Text = "Loading";
            // 
            // progressBar_loading
            // 
            this.progressBar_loading.BackColor = System.Drawing.Color.Red;
            this.progressBar_loading.ForeColor = System.Drawing.Color.Chartreuse;
            this.progressBar_loading.Location = new System.Drawing.Point(95, 308);
            this.progressBar_loading.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.progressBar_loading.Name = "progressBar_loading";
            this.progressBar_loading.Size = new System.Drawing.Size(300, 18);
            this.progressBar_loading.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Interval = 350;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer_animasi_tembak
            // 
            this.timer_animasi_tembak.Interval = 200;
            this.timer_animasi_tembak.Tick += new System.EventHandler(this.timer_animasi_tembak_Tick);
            // 
            // button_shop
            // 
            this.button_shop.Location = new System.Drawing.Point(379, 663);
            this.button_shop.Name = "button_shop";
            this.button_shop.Size = new System.Drawing.Size(76, 66);
            this.button_shop.TabIndex = 1;
            this.button_shop.Text = " ";
            this.button_shop.UseVisualStyleBackColor = true;
            this.button_shop.Click += new System.EventHandler(this.button_shop_Click);
            this.button_shop.Paint += new System.Windows.Forms.PaintEventHandler(this.button_shop_Paint);
            // 
            // progressbar_amunisi
            // 
            this.progressbar_amunisi.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.progressbar_amunisi.Location = new System.Drawing.Point(77, 12);
            this.progressbar_amunisi.Maximum = 10;
            this.progressbar_amunisi.Name = "progressbar_amunisi";
            this.progressbar_amunisi.Size = new System.Drawing.Size(318, 23);
            this.progressbar_amunisi.TabIndex = 2;
            // 
            // timer_suaratembak
            // 
            this.timer_suaratembak.Interval = 1000;
            this.timer_suaratembak.Tick += new System.EventHandler(this.timer_suaratembak_Tick);
            // 
            // label_uang
            // 
            this.label_uang.AutoSize = true;
            this.label_uang.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_uang.Location = new System.Drawing.Point(418, 13);
            this.label_uang.Name = "label_uang";
            this.label_uang.Size = new System.Drawing.Size(31, 22);
            this.label_uang.TabIndex = 3;
            this.label_uang.Text = "$0";
            // 
            // timer_ingame
            // 
            this.timer_ingame.Tick += new System.EventHandler(this.timer_ingame_Tick_1);
            // 
            // timer_reload_amunisi
            // 
            this.timer_reload_amunisi.Interval = 1000;
            this.timer_reload_amunisi.Tick += new System.EventHandler(this.timer_reload_amunisi_Tick);
            // 
            // timer_tips
            // 
            this.timer_tips.Tick += new System.EventHandler(this.timer_tips_Tick_1);
            // 
            // timer_shield
            // 
            this.timer_shield.Interval = 200;
            this.timer_shield.Tick += new System.EventHandler(this.timer_shield_Tick);
            // 
            // label_day_and_zombie
            // 
            this.label_day_and_zombie.AutoSize = true;
            this.label_day_and_zombie.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_day_and_zombie.Location = new System.Drawing.Point(12, 674);
            this.label_day_and_zombie.Name = "label_day_and_zombie";
            this.label_day_and_zombie.Size = new System.Drawing.Size(143, 21);
            this.label_day_and_zombie.TabIndex = 4;
            this.label_day_and_zombie.Text = "Zombies Dead  :  ";
            // 
            // timer_gantiday
            // 
            this.timer_gantiday.Interval = 1000;
            this.timer_gantiday.Tick += new System.EventHandler(this.timer_gantiday_Tick);
            // 
            // timer_suarazombiemasuk
            // 
            this.timer_suarazombiemasuk.Interval = 1000;
            this.timer_suarazombiemasuk.Tick += new System.EventHandler(this.timer_suarazombiemasuk_Tick);
            // 
            // button_playstop
            // 
            this.button_playstop.Location = new System.Drawing.Point(16, 698);
            this.button_playstop.Name = "button_playstop";
            this.button_playstop.Size = new System.Drawing.Size(46, 34);
            this.button_playstop.TabIndex = 5;
            this.button_playstop.Click += new System.EventHandler(this.button_playstop_Click);
            this.button_playstop.Paint += new System.Windows.Forms.PaintEventHandler(this.button_playstop_Paint);
            // 
            // Form_Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(467, 741);
            this.Controls.Add(this.button_playstop);
            this.Controls.Add(this.label_day_and_zombie);
            this.Controls.Add(this.label_uang);
            this.Controls.Add(this.lbl_tips);
            this.Controls.Add(this.progressbar_amunisi);
            this.Controls.Add(this.lb_loading);
            this.Controls.Add(this.button_shop);
            this.Controls.Add(this.progressBar_loading);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Game";
            this.Load += new System.EventHandler(this.Form_Game_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form_Game_Paint);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form_Game_KeyPress);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form_Game_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer_game_started;
        private System.Windows.Forms.ProgressBar progressBar_loading;
        private System.Windows.Forms.Label lb_loading;
        private System.Windows.Forms.Label lbl_tips;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer_animasi_tembak;
        private System.Windows.Forms.Button button_shop;
        private System.Windows.Forms.ProgressBar progressbar_amunisi;
        private System.Windows.Forms.Timer timer_suaratembak;
        private System.Windows.Forms.Label label_uang;
        private System.Windows.Forms.Timer timer_ingame;
        private System.Windows.Forms.Timer timer_reload_amunisi;
        private System.Windows.Forms.Timer timer_tips;
        private System.Windows.Forms.Timer timer_shield;
        private System.Windows.Forms.Label label_day_and_zombie;
        private System.Windows.Forms.Timer timer_gantiday;
        private System.Windows.Forms.Timer timer_suarazombiemasuk;
        private System.Windows.Forms.Label button_playstop;
    }
}