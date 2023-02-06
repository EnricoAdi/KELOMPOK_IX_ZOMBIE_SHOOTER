
namespace KELOMPOK_IX_ZOMBIE_SHOOTER
{
    partial class Form_playerstats
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_playerstats));
            this.label_name = new System.Windows.Forms.Label();
            this.label_life = new System.Windows.Forms.Label();
            this.label_bullet = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(76, 42);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(53, 17);
            this.label_name.TabIndex = 0;
            this.label_name.Text = "Name :";
            // 
            // label_life
            // 
            this.label_life.AutoSize = true;
            this.label_life.Location = new System.Drawing.Point(90, 85);
            this.label_life.Name = "label_life";
            this.label_life.Size = new System.Drawing.Size(39, 17);
            this.label_life.TabIndex = 1;
            this.label_life.Text = "Life :";
            // 
            // label_bullet
            // 
            this.label_bullet.AutoSize = true;
            this.label_bullet.Location = new System.Drawing.Point(45, 125);
            this.label_bullet.Name = "label_bullet";
            this.label_bullet.Size = new System.Drawing.Size(84, 17);
            this.label_bullet.TabIndex = 2;
            this.label_bullet.Text = "Bullet level :";
            // 
            // Form_playerstats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 211);
            this.Controls.Add(this.label_bullet);
            this.Controls.Add(this.label_life);
            this.Controls.Add(this.label_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_playerstats";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Your equipment";
            this.Load += new System.EventHandler(this.Form_playerstats_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_life;
        private System.Windows.Forms.Label label_bullet;
    }
}