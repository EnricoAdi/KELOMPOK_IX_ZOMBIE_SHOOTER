
namespace KELOMPOK_IX_ZOMBIE_SHOOTER
{
    partial class Form_shop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_shop));
            this.button_bg_grass = new System.Windows.Forms.Button();
            this.button_bg_sand1 = new System.Windows.Forms.Button();
            this.button_bg_sand2 = new System.Windows.Forms.Button();
            this.button_bg_snow = new System.Windows.Forms.Button();
            this.label_uang = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label_addshield = new System.Windows.Forms.Label();
            this.label_addlife = new System.Windows.Forms.Label();
            this.label_upamunition = new System.Windows.Forms.Label();
            this.labelbackground = new System.Windows.Forms.Label();
            this.labelcb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_bg_grass
            // 
            this.button_bg_grass.Location = new System.Drawing.Point(99, 63);
            this.button_bg_grass.Name = "button_bg_grass";
            this.button_bg_grass.Size = new System.Drawing.Size(110, 190);
            this.button_bg_grass.TabIndex = 0;
            this.button_bg_grass.UseVisualStyleBackColor = true;
            this.button_bg_grass.Click += new System.EventHandler(this.button_bg_grass_Click);
            this.button_bg_grass.Paint += new System.Windows.Forms.PaintEventHandler(this.button_bg_grass_Paint);
            // 
            // button_bg_sand1
            // 
            this.button_bg_sand1.Location = new System.Drawing.Point(269, 63);
            this.button_bg_sand1.Name = "button_bg_sand1";
            this.button_bg_sand1.Size = new System.Drawing.Size(110, 190);
            this.button_bg_sand1.TabIndex = 1;
            this.button_bg_sand1.UseVisualStyleBackColor = true;
            this.button_bg_sand1.Click += new System.EventHandler(this.button_bg_sand1_Click);
            this.button_bg_sand1.Paint += new System.Windows.Forms.PaintEventHandler(this.button_bg_sand1_Paint);
            // 
            // button_bg_sand2
            // 
            this.button_bg_sand2.Location = new System.Drawing.Point(453, 63);
            this.button_bg_sand2.Name = "button_bg_sand2";
            this.button_bg_sand2.Size = new System.Drawing.Size(110, 190);
            this.button_bg_sand2.TabIndex = 2;
            this.button_bg_sand2.UseVisualStyleBackColor = true;
            this.button_bg_sand2.Click += new System.EventHandler(this.button_bg_sand2_Click);
            this.button_bg_sand2.Paint += new System.Windows.Forms.PaintEventHandler(this.button_bg_sand2_Paint);
            // 
            // button_bg_snow
            // 
            this.button_bg_snow.Location = new System.Drawing.Point(624, 63);
            this.button_bg_snow.Name = "button_bg_snow";
            this.button_bg_snow.Size = new System.Drawing.Size(110, 190);
            this.button_bg_snow.TabIndex = 3;
            this.button_bg_snow.UseVisualStyleBackColor = true;
            this.button_bg_snow.Click += new System.EventHandler(this.button_bg_snow_Click);
            this.button_bg_snow.Paint += new System.Windows.Forms.PaintEventHandler(this.button_bg_snow_Paint);
            // 
            // label_uang
            // 
            this.label_uang.AutoSize = true;
            this.label_uang.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_uang.Location = new System.Drawing.Point(892, 26);
            this.label_uang.Name = "label_uang";
            this.label_uang.Size = new System.Drawing.Size(42, 31);
            this.label_uang.TabIndex = 6;
            this.label_uang.Text = "$0";
            this.label_uang.Paint += new System.Windows.Forms.PaintEventHandler(this.label_uang_Paint);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(883, 543);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.TabIndex = 10;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.Paint += new System.Windows.Forms.PaintEventHandler(this.button1_Paint);
            // 
            // label_addshield
            // 
            this.label_addshield.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label_addshield.Location = new System.Drawing.Point(123, 331);
            this.label_addshield.Name = "label_addshield";
            this.label_addshield.Size = new System.Drawing.Size(135, 208);
            this.label_addshield.TabIndex = 13;
            this.label_addshield.Click += new System.EventHandler(this.label_addshield_Click);
            this.label_addshield.Paint += new System.Windows.Forms.PaintEventHandler(this.label_addshield_Paint);
            // 
            // label_addlife
            // 
            this.label_addlife.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label_addlife.Location = new System.Drawing.Point(348, 331);
            this.label_addlife.Name = "label_addlife";
            this.label_addlife.Size = new System.Drawing.Size(135, 208);
            this.label_addlife.TabIndex = 14;
            this.label_addlife.Click += new System.EventHandler(this.label_addlife_Click);
            this.label_addlife.Paint += new System.Windows.Forms.PaintEventHandler(this.label_addlife_Paint);
            // 
            // label_upamunition
            // 
            this.label_upamunition.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label_upamunition.Location = new System.Drawing.Point(561, 331);
            this.label_upamunition.Name = "label_upamunition";
            this.label_upamunition.Size = new System.Drawing.Size(135, 208);
            this.label_upamunition.TabIndex = 15;
            this.label_upamunition.Click += new System.EventHandler(this.label_upamunition_Click);
            this.label_upamunition.Paint += new System.Windows.Forms.PaintEventHandler(this.label_upamunition_Paint);
            // 
            // labelbackground
            // 
            this.labelbackground.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labelbackground.Location = new System.Drawing.Point(38, 26);
            this.labelbackground.Name = "labelbackground";
            this.labelbackground.Size = new System.Drawing.Size(748, 267);
            this.labelbackground.TabIndex = 16;
            this.labelbackground.Click += new System.EventHandler(this.labelbackground_Click);
            this.labelbackground.Paint += new System.Windows.Forms.PaintEventHandler(this.labelbackground_Paint);
            // 
            // labelcb
            // 
            this.labelcb.AutoSize = true;
            this.labelcb.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcb.Location = new System.Drawing.Point(310, 32);
            this.labelcb.Name = "labelcb";
            this.labelcb.Size = new System.Drawing.Size(222, 22);
            this.labelcb.TabIndex = 17;
            this.labelcb.Text = "Change Background";
            // 
            // Form_shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 575);
            this.Controls.Add(this.labelcb);
            this.Controls.Add(this.button_bg_snow);
            this.Controls.Add(this.button_bg_sand2);
            this.Controls.Add(this.button_bg_sand1);
            this.Controls.Add(this.label_upamunition);
            this.Controls.Add(this.button_bg_grass);
            this.Controls.Add(this.label_addlife);
            this.Controls.Add(this.label_addshield);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label_uang);
            this.Controls.Add(this.labelbackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_shop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "SHOP";
            this.Load += new System.EventHandler(this.Form_shop_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form_shop_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_bg_grass;
        private System.Windows.Forms.Button button_bg_sand1;
        private System.Windows.Forms.Button button_bg_sand2;
        private System.Windows.Forms.Button button_bg_snow;
        private System.Windows.Forms.Label label_uang;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_addshield;
        private System.Windows.Forms.Label label_addlife;
        private System.Windows.Forms.Label label_upamunition;
        private System.Windows.Forms.Label labelbackground;
        private System.Windows.Forms.Label labelcb;
    }
}