
namespace KELOMPOK_IX_ZOMBIE_SHOOTER
{
    partial class Formtutorial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formtutorial));
            this.labelmundur = new System.Windows.Forms.Label();
            this.labelmaju = new System.Windows.Forms.Label();
            this.labeltipamunition = new System.Windows.Forms.Label();
            this.labeltipshoot = new System.Windows.Forms.Label();
            this.labeltipline = new System.Windows.Forms.Label();
            this.labeltiplife = new System.Windows.Forms.Label();
            this.labeltipbuyshield = new System.Windows.Forms.Label();
            this.labeltipbg = new System.Windows.Forms.Label();
            this.labeltipamun = new System.Windows.Forms.Label();
            this.labeltipshield = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelmundur
            // 
            this.labelmundur.Location = new System.Drawing.Point(209, 696);
            this.labelmundur.Name = "labelmundur";
            this.labelmundur.Size = new System.Drawing.Size(54, 41);
            this.labelmundur.TabIndex = 0;
            this.labelmundur.Click += new System.EventHandler(this.labelmundur_Click);
            this.labelmundur.Paint += new System.Windows.Forms.PaintEventHandler(this.labelmundur_Paint);
            // 
            // labelmaju
            // 
            this.labelmaju.Location = new System.Drawing.Point(279, 696);
            this.labelmaju.Name = "labelmaju";
            this.labelmaju.Size = new System.Drawing.Size(54, 41);
            this.labelmaju.TabIndex = 1;
            this.labelmaju.Text = " ";
            this.labelmaju.Click += new System.EventHandler(this.labelmaju_Click);
            this.labelmaju.Paint += new System.Windows.Forms.PaintEventHandler(this.labelmaju_Paint);
            // 
            // labeltipamunition
            // 
            this.labeltipamunition.BackColor = System.Drawing.Color.Red;
            this.labeltipamunition.Location = new System.Drawing.Point(375, 81);
            this.labeltipamunition.Name = "labeltipamunition";
            this.labeltipamunition.Size = new System.Drawing.Size(89, 25);
            this.labeltipamunition.TabIndex = 2;
            this.toolTip1.SetToolTip(this.labeltipamunition, "Amunition\r\nThis bar shows your amount of amunition left\r\nfor shooting the zombies" +
        "");
            // 
            // labeltipshoot
            // 
            this.labeltipshoot.BackColor = System.Drawing.Color.Red;
            this.labeltipshoot.Location = new System.Drawing.Point(344, 172);
            this.labeltipshoot.Name = "labeltipshoot";
            this.labeltipshoot.Size = new System.Drawing.Size(89, 25);
            this.labeltipshoot.TabIndex = 3;
            this.toolTip1.SetToolTip(this.labeltipshoot, "Click on those zombies for killing them\r\nRemember, you can only shoot when your a" +
        "munition\r\nis not zero :)");
            // 
            // labeltipline
            // 
            this.labeltipline.BackColor = System.Drawing.Color.Red;
            this.labeltipline.Location = new System.Drawing.Point(117, 401);
            this.labeltipline.Name = "labeltipline";
            this.labeltipline.Size = new System.Drawing.Size(89, 25);
            this.labeltipline.TabIndex = 4;
            this.toolTip1.SetToolTip(this.labeltipline, "Don\'t Let the zombies Cross the line!\r\nFor every zombies that succeed to passing\r" +
        "\nthe line will occur to substract amount of \r\nyour player life");
            // 
            // labeltiplife
            // 
            this.labeltiplife.BackColor = System.Drawing.Color.AntiqueWhite;
            this.labeltiplife.Location = new System.Drawing.Point(174, 401);
            this.labeltiplife.Name = "labeltiplife";
            this.labeltiplife.Size = new System.Drawing.Size(89, 25);
            this.labeltiplife.TabIndex = 5;
            this.toolTip1.SetToolTip(this.labeltiplife, "Add Life\r\nMake sure you have enough \r\namount of money\r\n\r\n");
            // 
            // labeltipbuyshield
            // 
            this.labeltipbuyshield.BackColor = System.Drawing.Color.AntiqueWhite;
            this.labeltipbuyshield.Location = new System.Drawing.Point(12, 401);
            this.labeltipbuyshield.Name = "labeltipbuyshield";
            this.labeltipbuyshield.Size = new System.Drawing.Size(89, 25);
            this.labeltipbuyshield.TabIndex = 6;
            this.toolTip1.SetToolTip(this.labeltipbuyshield, "Buy Shield\r\nMake sure you have enough \r\namount of money");
            // 
            // labeltipbg
            // 
            this.labeltipbg.BackColor = System.Drawing.Color.AntiqueWhite;
            this.labeltipbg.Location = new System.Drawing.Point(423, 293);
            this.labeltipbg.Name = "labeltipbg";
            this.labeltipbg.Size = new System.Drawing.Size(89, 25);
            this.labeltipbg.TabIndex = 7;
            this.toolTip1.SetToolTip(this.labeltipbg, "Click on the image for choosing\r\nthe best scene for your gameplay :)");
            // 
            // labeltipamun
            // 
            this.labeltipamun.BackColor = System.Drawing.Color.AntiqueWhite;
            this.labeltipamun.Location = new System.Drawing.Point(432, 469);
            this.labeltipamun.Name = "labeltipamun";
            this.labeltipamun.Size = new System.Drawing.Size(89, 39);
            this.labeltipamun.TabIndex = 8;
            this.toolTip1.SetToolTip(this.labeltipamun, "Upgrade amunition\r\nMake sure you have enough \r\namount of money\r\n");
            // 
            // labeltipshield
            // 
            this.labeltipshield.BackColor = System.Drawing.Color.PeachPuff;
            this.labeltipshield.Location = new System.Drawing.Point(174, 316);
            this.labeltipshield.Name = "labeltipshield";
            this.labeltipshield.Size = new System.Drawing.Size(196, 133);
            this.labeltipshield.TabIndex = 9;
            this.toolTip1.SetToolTip(this.labeltipshield, "The blue circle indicates that your shield had\r\nbeen activated. You\'re now free f" +
        "rom zombies\r\nbeating you as long as the shield is active !");
            this.labeltipshield.Click += new System.EventHandler(this.labeltipshield_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(195, 755);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "*hover on each text";
            // 
            // Formtutorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(562, 784);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labeltipamun);
            this.Controls.Add(this.labeltipbg);
            this.Controls.Add(this.labeltipbuyshield);
            this.Controls.Add(this.labeltiplife);
            this.Controls.Add(this.labeltipline);
            this.Controls.Add(this.labeltipshoot);
            this.Controls.Add(this.labeltipamunition);
            this.Controls.Add(this.labelmaju);
            this.Controls.Add(this.labelmundur);
            this.Controls.Add(this.labeltipshield);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Formtutorial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "How To Play";
            this.Load += new System.EventHandler(this.Formtutorial_Load);
            this.Click += new System.EventHandler(this.Formtutorial_Click);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Formtutorial_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Formtutorial_MouseClick);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelmundur;
        private System.Windows.Forms.Label labelmaju;
        private System.Windows.Forms.Label labeltipamunition;
        private System.Windows.Forms.Label labeltipshoot;
        private System.Windows.Forms.Label labeltipline;
        private System.Windows.Forms.Label labeltiplife;
        private System.Windows.Forms.Label labeltipbuyshield;
        private System.Windows.Forms.Label labeltipbg;
        private System.Windows.Forms.Label labeltipamun;
        private System.Windows.Forms.Label labeltipshield;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label1;
    }
}