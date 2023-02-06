
namespace KELOMPOK_IX_ZOMBIE_SHOOTER
{
    partial class Form_pilih_skin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_pilih_skin));
            this.button_player_1 = new System.Windows.Forms.Button();
            this.button_player_2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label_OK = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_player_1
            // 
            this.button_player_1.Location = new System.Drawing.Point(62, 130);
            this.button_player_1.Name = "button_player_1";
            this.button_player_1.Size = new System.Drawing.Size(168, 134);
            this.button_player_1.TabIndex = 1;
            this.toolTip1.SetToolTip(this.button_player_1, "Green Soldier");
            this.button_player_1.UseVisualStyleBackColor = true;
            this.button_player_1.Click += new System.EventHandler(this.button_player_1_Click);
            this.button_player_1.Paint += new System.Windows.Forms.PaintEventHandler(this.button_player_1_Paint);
            this.button_player_1.MouseHover += new System.EventHandler(this.button_player_1_MouseHover);
            // 
            // button_player_2
            // 
            this.button_player_2.Location = new System.Drawing.Point(283, 130);
            this.button_player_2.Name = "button_player_2";
            this.button_player_2.Size = new System.Drawing.Size(168, 134);
            this.button_player_2.TabIndex = 2;
            this.toolTip1.SetToolTip(this.button_player_2, "Red Soldier");
            this.button_player_2.UseVisualStyleBackColor = true;
            this.button_player_2.Click += new System.EventHandler(this.button_player_2_Click);
            this.button_player_2.Paint += new System.Windows.Forms.PaintEventHandler(this.button_player_2_Paint);
            this.button_player_2.MouseHover += new System.EventHandler(this.button_player_2_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("MS Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label1.Location = new System.Drawing.Point(22, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Who\'s your name?";
            // 
            // tb_username
            // 
            this.tb_username.BackColor = System.Drawing.Color.FloralWhite;
            this.tb_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_username.Font = new System.Drawing.Font("Harrington", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_username.Location = new System.Drawing.Point(229, 16);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(179, 31);
            this.tb_username.TabIndex = 4;
            this.toolTip1.SetToolTip(this.tb_username, "Enter your name");
            this.tb_username.MouseHover += new System.EventHandler(this.tb_username_MouseHover);
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipTitle = "Zombie Shooter";
            // 
            // label_OK
            // 
            this.label_OK.BackColor = System.Drawing.Color.Cyan;
            this.label_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_OK.Font = new System.Drawing.Font("Harrington", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label_OK.Location = new System.Drawing.Point(182, 298);
            this.label_OK.Name = "label_OK";
            this.label_OK.Size = new System.Drawing.Size(140, 43);
            this.label_OK.TabIndex = 5;
            this.label_OK.Text = "OK";
            this.label_OK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_OK.MouseClick += new System.Windows.Forms.MouseEventHandler(this.label_OK_MouseClick);
            this.label_OK.MouseEnter += new System.EventHandler(this.label_OK_MouseEnter);
            this.label_OK.MouseLeave += new System.EventHandler(this.label_OK_MouseLeave);
            // 
            // Form_pilih_skin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(521, 425);
            this.Controls.Add(this.label_OK);
            this.Controls.Add(this.button_player_2);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.button_player_1);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_pilih_skin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Choose Your Character";
            this.Load += new System.EventHandler(this.Form_pilih_skin_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form_pilih_skin_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_player_1;
        private System.Windows.Forms.Button button_player_2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label_OK;
    }
}