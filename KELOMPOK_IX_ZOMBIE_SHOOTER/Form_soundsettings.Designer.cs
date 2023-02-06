
namespace KELOMPOK_IX_ZOMBIE_SHOOTER
{
    partial class Form_soundsettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_soundsettings));
            this.trackBar_volume = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.rb_on = new System.Windows.Forms.RadioButton();
            this.rb_off = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_volume)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBar_volume
            // 
            this.trackBar_volume.BackColor = System.Drawing.SystemColors.Menu;
            this.trackBar_volume.Location = new System.Drawing.Point(102, 25);
            this.trackBar_volume.Maximum = 100;
            this.trackBar_volume.Name = "trackBar_volume";
            this.trackBar_volume.Size = new System.Drawing.Size(162, 56);
            this.trackBar_volume.TabIndex = 0;
            this.trackBar_volume.Scroll += new System.EventHandler(this.trackBar_volume_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Location = new System.Drawing.Point(287, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "0";
            // 
            // rb_on
            // 
            this.rb_on.AutoSize = true;
            this.rb_on.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_on.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.rb_on.Location = new System.Drawing.Point(84, 87);
            this.rb_on.Name = "rb_on";
            this.rb_on.Size = new System.Drawing.Size(103, 26);
            this.rb_on.TabIndex = 2;
            this.rb_on.TabStop = true;
            this.rb_on.Text = "Song ON";
            this.rb_on.UseVisualStyleBackColor = true;
            this.rb_on.CheckedChanged += new System.EventHandler(this.rb_on_CheckedChanged);
            // 
            // rb_off
            // 
            this.rb_off.AutoSize = true;
            this.rb_off.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_off.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.rb_off.Location = new System.Drawing.Point(211, 87);
            this.rb_off.Name = "rb_off";
            this.rb_off.Size = new System.Drawing.Size(113, 26);
            this.rb_off.TabIndex = 3;
            this.rb_off.TabStop = true;
            this.rb_off.Text = "Song OFF";
            this.rb_off.UseVisualStyleBackColor = true;
            this.rb_off.CheckedChanged += new System.EventHandler(this.rb_off_CheckedChanged);
            // 
            // Form_soundsettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 260);
            this.Controls.Add(this.rb_off);
            this.Controls.Add(this.rb_on);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar_volume);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_soundsettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Sound";
            this.Load += new System.EventHandler(this.Form_soundsettings_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form_soundsettings_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_volume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBar_volume;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rb_on;
        private System.Windows.Forms.RadioButton rb_off;
    }
}