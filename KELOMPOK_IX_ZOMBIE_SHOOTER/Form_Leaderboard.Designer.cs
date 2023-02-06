
namespace KELOMPOK_IX_ZOMBIE_SHOOTER
{
    partial class Form_Leaderboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Leaderboard));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_leaderboard_1 = new System.Windows.Forms.Label();
            this.lb_leaderboard_2 = new System.Windows.Forms.Label();
            this.lb_leaderboard_3 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Font = new System.Drawing.Font("Hobo Std", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(136, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 61);
            this.label1.TabIndex = 0;
            this.label1.Text = "Leaderboard";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Hobo Std", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(109, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 57);
            this.label2.TabIndex = 1;
            this.label2.Text = "1.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Hobo Std", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FloralWhite;
            this.label4.Location = new System.Drawing.Point(109, 322);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 57);
            this.label4.TabIndex = 3;
            this.label4.Text = "3.";
            // 
            // lbl_leaderboard_1
            // 
            this.lbl_leaderboard_1.AutoSize = true;
            this.lbl_leaderboard_1.Font = new System.Drawing.Font("Hobo Std", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_leaderboard_1.Location = new System.Drawing.Point(181, 169);
            this.lbl_leaderboard_1.Name = "lbl_leaderboard_1";
            this.lbl_leaderboard_1.Size = new System.Drawing.Size(36, 57);
            this.lbl_leaderboard_1.TabIndex = 6;
            this.lbl_leaderboard_1.Text = "-";
            // 
            // lb_leaderboard_2
            // 
            this.lb_leaderboard_2.AutoSize = true;
            this.lb_leaderboard_2.Font = new System.Drawing.Font("Hobo Std", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_leaderboard_2.ForeColor = System.Drawing.Color.LightGoldenrodYellow;
            this.lb_leaderboard_2.Location = new System.Drawing.Point(181, 246);
            this.lb_leaderboard_2.Name = "lb_leaderboard_2";
            this.lb_leaderboard_2.Size = new System.Drawing.Size(36, 57);
            this.lb_leaderboard_2.TabIndex = 7;
            this.lb_leaderboard_2.Text = "-";
            // 
            // lb_leaderboard_3
            // 
            this.lb_leaderboard_3.AutoSize = true;
            this.lb_leaderboard_3.Font = new System.Drawing.Font("Hobo Std", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_leaderboard_3.ForeColor = System.Drawing.Color.FloralWhite;
            this.lb_leaderboard_3.Location = new System.Drawing.Point(181, 322);
            this.lb_leaderboard_3.Name = "lb_leaderboard_3";
            this.lb_leaderboard_3.Size = new System.Drawing.Size(36, 57);
            this.lb_leaderboard_3.TabIndex = 8;
            this.lb_leaderboard_3.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Hobo Std", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightGoldenrodYellow;
            this.label3.Location = new System.Drawing.Point(109, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 57);
            this.label3.TabIndex = 2;
            this.label3.Text = "2.";
            // 
            // Form_Leaderboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 534);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_leaderboard_3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_leaderboard_2);
            this.Controls.Add(this.lbl_leaderboard_1);
            this.Controls.Add(this.label4);
            this.ForeColor = System.Drawing.Color.Gold;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Leaderboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Leaderboard";
            this.Load += new System.EventHandler(this.Form_Leaderboard_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form_Leaderboard_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_leaderboard_1;
        private System.Windows.Forms.Label lb_leaderboard_2;
        private System.Windows.Forms.Label lb_leaderboard_3;
        private System.Windows.Forms.Label label3;
    }
}