
namespace KELOMPOK_IX_ZOMBIE_SHOOTER
{
    partial class Form_menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_menu));
            this.panel_btn_play = new System.Windows.Forms.Panel();
            this.panel_btn_leaderboard = new System.Windows.Forms.Panel();
            this.panel_settings = new System.Windows.Forms.Panel();
            this.button_howtoplay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel_btn_play
            // 
            this.panel_btn_play.Location = new System.Drawing.Point(122, 480);
            this.panel_btn_play.Name = "panel_btn_play";
            this.panel_btn_play.Size = new System.Drawing.Size(195, 63);
            this.panel_btn_play.TabIndex = 2;
            this.panel_btn_play.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_btn_play_Paint);
            this.panel_btn_play.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel_btn_play_MouseClick);
            // 
            // panel_btn_leaderboard
            // 
            this.panel_btn_leaderboard.Location = new System.Drawing.Point(122, 549);
            this.panel_btn_leaderboard.Name = "panel_btn_leaderboard";
            this.panel_btn_leaderboard.Size = new System.Drawing.Size(195, 63);
            this.panel_btn_leaderboard.TabIndex = 3;
            this.panel_btn_leaderboard.Click += new System.EventHandler(this.panel_btn_leaderboard_Click);
            this.panel_btn_leaderboard.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_btn_leaderboard_Paint);
            this.panel_btn_leaderboard.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel_btn_leaderboard_MouseClick);
            // 
            // panel_settings
            // 
            this.panel_settings.Location = new System.Drawing.Point(3, 662);
            this.panel_settings.Name = "panel_settings";
            this.panel_settings.Size = new System.Drawing.Size(81, 63);
            this.panel_settings.TabIndex = 3;
            this.panel_settings.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_settings_Paint);
            this.panel_settings.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel_settings_MouseClick);
            // 
            // button_howtoplay
            // 
            this.button_howtoplay.Location = new System.Drawing.Point(284, 681);
            this.button_howtoplay.Name = "button_howtoplay";
            this.button_howtoplay.Size = new System.Drawing.Size(167, 44);
            this.button_howtoplay.TabIndex = 4;
            this.button_howtoplay.Click += new System.EventHandler(this.button_howtoplay_Click);
            this.button_howtoplay.Paint += new System.Windows.Forms.PaintEventHandler(this.button_howtoplay_Paint);
            // 
            // Form_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(444, 724);
            this.Controls.Add(this.button_howtoplay);
            this.Controls.Add(this.panel_settings);
            this.Controls.Add(this.panel_btn_leaderboard);
            this.Controls.Add(this.panel_btn_play);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ZOMBIE SHOOTER";
            this.Load += new System.EventHandler(this.Form_menu_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form_menu_Paint);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_btn_play;
        private System.Windows.Forms.Panel panel_btn_leaderboard;
        private System.Windows.Forms.Panel panel_settings;
        private System.Windows.Forms.Label button_howtoplay;
    }
}