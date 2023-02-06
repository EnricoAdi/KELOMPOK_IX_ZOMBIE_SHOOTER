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
using System.Runtime.InteropServices;
using System.Diagnostics;
namespace KELOMPOK_IX_ZOMBIE_SHOOTER
{
    public partial class Form_soundsettings : Form
    {
        public Form_soundsettings()
        {
            InitializeComponent();
        } 
        private const int APPCOMMAND_VOLUME_UP = 0xA0000;
        private const int APPCOMMAND_VOLUME_DOWN = 0x90000;
        private const int WM_APPCOMMAND = 0x319; 

        [DllImport("user32.dll")]
        public static extern IntPtr SendMessageW(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam); 
        private void trackBar_volume_Scroll(object sender, EventArgs e)
        {
            //Enrico 
            label1.Text = trackBar_volume.Value + "%";
            if (trackBar_volume.Value > Form_menu.volumelagu)
            {
            SendMessageW(this.Handle, WM_APPCOMMAND, this.Handle, (IntPtr)APPCOMMAND_VOLUME_UP);
                Form_menu.volumelagu = trackBar_volume.Value;

            }
            else
            { 
                SendMessageW(this.Handle, WM_APPCOMMAND, this.Handle, (IntPtr)APPCOMMAND_VOLUME_DOWN);
                Form_menu.volumelagu = trackBar_volume.Value;
            }
            //Enrico
        }

        private void Form_soundsettings_Load(object sender, EventArgs e)
        {
            //Enrico 
            trackBar_volume.Value = Form_menu.volumelagu;
            label1.Text = trackBar_volume.Value + "%";
            label1.BackColor = Color.Transparent;
            //trackBar_volume.BackColor = Color.Transparent;
            rb_off.BackColor = Color.Transparent; rb_on.BackColor = Color.Transparent;
            if (Form_menu.song_on)
            {
                rb_on.Checked = true;
            }
            else
            {
                rb_off.Checked = true;
            }
            //Enrico
        }

        private void rb_on_CheckedChanged(object sender, EventArgs e)
        { 
            if (!Form_menu.song_on)
            {
                Form_menu.song_on = true;
                Form_menu.music.Play();
            }

        }

        private void rb_off_CheckedChanged(object sender, EventArgs e)
        {
            if (Form_menu.song_on)
            {
                Form_menu.song_on = false;
                Form_menu.music.Stop(); 
            }
        }

        private void Form_soundsettings_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImage(Image.FromFile("bgsoundsettings.jpg"),-1,-1,this.Width,this.Height);
        }
    }
}
