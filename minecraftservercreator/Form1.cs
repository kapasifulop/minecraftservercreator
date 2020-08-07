using mcsc;
using mcsc.Properties;
using mcsc.Properties.Langs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.PropertyGridInternal;
using System.Windows.Forms.VisualStyles;

namespace minecraftservercreator
{
    public partial class Form1 : Form
    {
        int mov;
        int movX;
        int movY;

        public Form1()
        {
            //this.Opacity = 0.95;
            InitializeComponent();
            Color panel = Color.FromArgb(44, 62, 80); 
            welcome.BackColor = Color.FromArgb(0, panel);
            //szpanel.BackColor = Color.FromArgb(250, panel);
            szoveg.BackColor = Color.FromArgb(0, panel);

            if (mcsc.Properties.Settings.Default.lang == 1)
            {
                szoveg.Text = Lang_en.udv;
                startlbl.Text = Lang_en.f_bele;
                button1.Text = "MAGYAR";
            }
            else if(mcsc.Properties.Settings.Default.lang == 0)
            {
                szoveg.Text = Lang_hu.udv;
                startlbl.Text = Lang_hu.f_bele;
            }

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void talcara_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void about_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.StartPosition = this.StartPosition;
            about.Show();
        }



        private void start_Click(object sender, EventArgs e)
        {
            Server_Name sn = new Server_Name();
            sn.StartPosition = this.StartPosition;
            sn.Show();
            this.Hide();
        }

        private void pnale_mousedown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void panel_mousemove(object sender, MouseEventArgs e)
        {
            if(mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void panel_mouseup(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            version.Text = mcsc.Properties.Settings.Default.version;
            await Task.Delay(200);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vezerlofo vzf = new Vezerlofo();
            vzf.StartPosition = this.StartPosition;
            vzf.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if(button1.Text == "ENGLISH")
            {
                mcsc.Properties.Settings.Default.lang = 1;
                mcsc.Properties.Settings.Default.Save();
                szoveg.Text = Lang_en.udv;
                startlbl.Text = Lang_en.f_bele;
                button1.Text = "MAGYAR";
            }
            else if(button1.Text == "MAGYAR")
            {
                mcsc.Properties.Settings.Default.lang = 0;
                mcsc.Properties.Settings.Default.Save();
                szoveg.Text = Lang_hu.udv;
                startlbl.Text = Lang_hu.f_bele;
                button1.Text = "ENGLISH";
            }

        }
    }
}