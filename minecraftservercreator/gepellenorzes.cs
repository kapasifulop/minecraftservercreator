using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Management;
using System.Net.NetworkInformation;
using Mono.Nat;

namespace minecraftservercreator
{
    public partial class gepellenorzes : Form
    {
        int mov;
        int movX;
        int movY;
        String memorytotal;

        public gepellenorzes()
        {
            InitializeComponent();
        }

        private void gepellenorzes_Load(object sender, EventArgs e)
        {
            version.Text = mcsc.Properties.Settings.Default.version;
            circularProgressBar1.Value = 0;
            circularProgressBar1.Minimum = 0;
            circularProgressBar1.Maximum = 30;
            ram.Location = new Point(145, 224);
            ram.Text = "?";
            Color panel = Color.FromArgb(44, 62, 80);
            pinglblb.BackColor = Color.FromArgb(250, panel);
            pingbar.InnerColor = Color.FromArgb(0, panel);
            pinglblb.Refresh();
            pingbar.Minimum = 0;
            pingbar.Maximum = 60;
            pingbar.Value = 0;
        }

        //
        ////folso gombok
        //
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
        //
        ////panel
        //
        private void panel_mousedown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void panel_mousemove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void panel_mouseup(object sender, MouseEventArgs e)
        {
            mov = 0;
        }
        //
        ////betöltés funkció
        //



        //memoria

        public int memoria() {
            //
            ////Memória méret betöltése
            //
            ObjectQuery wql = new ObjectQuery("SELECT * FROM Win32_OperatingSystem");
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(wql);
            ManagementObjectCollection results = searcher.Get();

            foreach (ManagementObject result in results)
            {
                memorytotal = result["TotalVisibleMemorySize"].ToString();
            }
            int memorytotaln = Int32.Parse(memorytotal);

            //átváltás GB-t ra

            memorytotaln /= 1024;
            memorytotaln /= 1024;
            memorytotaln += 1;
            return memorytotaln;
        }

        //ping

        public int pngmenny () {
            try
            {
                Ping p = new Ping();
                //google ping
                int pingg_1 = int.Parse(p.Send("www.google.com").RoundtripTime.ToString());
                int pingg_2 = int.Parse(p.Send("www.google.com").RoundtripTime.ToString());
                int pingg_3 = int.Parse(p.Send("www.google.com").RoundtripTime.ToString());
                int pingg_4 = int.Parse(p.Send("www.google.com").RoundtripTime.ToString());
                int avgg_ping = 0;
                avgg_ping += pingg_1 + pingg_2 + pingg_3 + pingg_4;
                avgg_ping /= 4;

                //fb ping
                int pingfb_1 = int.Parse(p.Send("www.facebook.com").RoundtripTime.ToString());
                int pingfb_2 = int.Parse(p.Send("www.facebook.com").RoundtripTime.ToString());
                int pingfb_3 = int.Parse(p.Send("www.facebook.com").RoundtripTime.ToString());
                int pingfb_4 = int.Parse(p.Send("www.facebook.com").RoundtripTime.ToString());
                int avgfb_ping = pingfb_1 + pingfb_2 + pingfb_3 + pingfb_4;
                avgfb_ping /= 4;
                //átlag számítás
                int ping = avgg_ping + avgfb_ping;
                ping /= 2;
                return ping;
            }
            catch
            {
                int ping = -10;
                return ping;
            }

        }

        //Delay

        async Task PutTaskDelay()
        {
            await Task.Delay(100);
        }

        //Megjelenítés

        public async void betoltminden(int memorytotalk, int pingg)
        {
            for (int i = 0; i <= memorytotalk; i++)
            {
                await PutTaskDelay();
                if (i <= 7)
                {
                    ram.ForeColor = Color.Red;
                    circularProgressBar1.ProgressColor = Color.Red;
                }
                if (i > 7 && i < 15)
                {
                    ram.ForeColor = Color.Yellow;
                    circularProgressBar1.ProgressColor = Color.Yellow;
                }
                if (i >= 16)
                {
                    ram.ForeColor = Color.Green;
                    circularProgressBar1.ProgressColor = Color.Green;
                }
                circularProgressBar1.Value = i;
                circularProgressBar1.Update();
            }

            if (memorytotalk > 9)
            {
                ram.Text = memorytotalk.ToString() + " GB";
                ram.Location = new Point(105, 224);
            }
            else
            {
                circularProgressBar1.ForeColor = Color.Red;
                ram.Text = memorytotalk.ToString() + " GB";
                ram.Location = new Point(118, 224);
            }

            if(pingg < 60)
            {
                int val;
                val = 60;
                val -= pingg;
                pingbar.Value = val;
            } else
            {
                pingbar.Value = 1;
            }
            if(pingg > 20)
            {
                pingbar.ForeColor = Color.Yellow;
                pingbar.ProgressColor = Color.Yellow;
            }
            if(pingg > 45)
            {
                pingbar.ForeColor = Color.Red;
                pingbar.ProgressColor = Color.Red;
            }
            if(pingg < 20)
            {
                pingbar.ForeColor = Color.Green;
                pingbar.ProgressColor = Color.Green;
            }
            pingbar.Text = pingg.ToString() + " ms";

            decimal jtszam = jatekosszam(memorytotalk, pingg);
            jatekossszam.Text = jtszam.ToString();

            plugins.Text = (jtszam + 200 - 3).ToString();

            button1.Enabled = true;
            button1.Text = "tovább";


        }

        public decimal jatekosszam(int ram, int ping)
        {

            decimal jtszbyram;
            jtszbyram = ram * 20;
            decimal jtszbyping;
            jtszbyping = 2000 / ping;
            decimal jtsz = 0;
            if (jtszbyping > jtszbyram)
            {
                jtsz = jtszbyram;
            }
            else
            {
                jtsz = jtszbyping;
            }
            jtsz -= 20;
            return Math.Floor(jtsz);
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if(button1.Text != "tovább")
            {
                button1.Enabled = false;

                //memória betöltése
                int memorytotal = memoria();
                mcsc.Properties.Settings.Default.memoria = memorytotal;
                mcsc.Properties.Settings.Default.rfs = memorytotal / 2;
                mcsc.Properties.Settings.Default.Save();
                //ping betöltése
                int ping = pngmenny();
                //minden egyéb betöltése
                betoltminden(memorytotal, ping);
            }
            else
            {

                /*MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show("Ön most belép a vezrlépultba. Szertné, hogy elinduljon a memória, a processszor és a ping mérése?(A szerver indításánál automatikusan elindul)",
                    "Figyelem!", buttons, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    mcsc.Properties.Settings.Default.meres = true;
                    mcsc.Properties.Settings.Default.Save();
                }
                else
                {
                    mcsc.Properties.Settings.Default.meres = false;
                    mcsc.Properties.Settings.Default.Save();
                }
                await PutTaskDelay();*/

                mcsc.Properties.Settings.Default.ferohely = int.Parse(jatekossszam.Text);
                mcsc.Properties.Settings.Default.srv_created = true;
                mcsc.Properties.Settings.Default.Save();
                Vezerlofo vzf = new Vezerlofo();
                vzf.StartPosition = this.StartPosition;
                vzf.Show();
                this.Close();
            }
        }
    }
}
