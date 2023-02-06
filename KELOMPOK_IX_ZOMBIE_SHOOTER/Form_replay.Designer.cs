
namespace KELOMPOK_IX_ZOMBIE_SHOOTER
{
    partial class Form_replay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_replay));
            this.timer_replay = new System.Windows.Forms.Timer(this.components);
            this.timer_animasi_tembak = new System.Windows.Forms.Timer(this.components);
            this.timer_shield = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // timer_replay
            // 
            this.timer_replay.Interval = 50;
            this.timer_replay.Tick += new System.EventHandler(this.timer_replay_Tick);
            // 
            // timer_animasi_tembak
            // 
            this.timer_animasi_tembak.Interval = 200;
            this.timer_animasi_tembak.Tick += new System.EventHandler(this.timer_animasi_tembak_Tick);
            // 
            // timer_shield
            // 
            this.timer_shield.Interval = 300;
            this.timer_shield.Tick += new System.EventHandler(this.timer_shield_Tick);
            // 
            // Form_replay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 741);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_replay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game replay";
            this.Load += new System.EventHandler(this.Form_replay_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form_replay_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer_replay;
        private System.Windows.Forms.Timer timer_animasi_tembak;
        private System.Windows.Forms.Timer timer_shield;
    }
}