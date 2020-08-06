using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using mcsc;
using Mono.Nat;

namespace minecraftservercreator
{
    public partial class Vezerlofo : Form
    {
        int mov;
        int movX;
        int movY;
        int btns = 0;

        servers[] s_btn;

        Thread ip_k;
        szerverindul szv = new szerverindul();
        konzol kz;
        Boolean on_konzoll = false;
        public bool stop_T = false;



        public Vezerlofo()
        {
            kz = new konzol(this);
            on_konzoll = false;
            InitializeComponent();
        }
        //
        ////folso gombok
        //
        private async void exit_Click(object sender, EventArgs e)
        {
            szerverindul si = new szerverindul();
            string stop = si.stop();
            await PutTaskDelay(100);
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

        //delay 

        async Task PutTaskDelay(int delay)
        {
            await Task.Delay(delay);
        }



        //Betöltött a vezerlofo:

        private void Vezerlofo_Load(object sender, EventArgs e)
        {
            version.Text = mcsc.Properties.Settings.Default.version;
            mcsc.Properties.Settings.Default.szerverfut = false;
            on_pluginok.Visible = false;
            on_kl.Visible = true;
            open_ChildForm(new kezdolap(this));
            on_konzoll = false;



            if (!Directory.Exists(@"C:\mcsc\")){

                Directory.CreateDirectory(@"C:\mcsc\");
            }

            if (!Directory.Exists(@"C:\mcsc\servers"))
            {
                Directory.CreateDirectory(@"C:\mcsc\servers");
                Directory.CreateDirectory(@"C:\mcsc\servers\srv1");
            }


            string[] dirs = Directory.GetDirectories(@"C:\mcsc\servers\");

            s_btn = new servers[dirs.Length];
            /*if (dirs.Length == 0)
            {
                Directory.CreateDirectory(@"C:\mcsc\servers\srv1");
                //MessageBox.Show("DIR CREATED");
            }*/

            btns = dirs.Length;
            Program.set_server_num_s(btns);
            for (int i = 0; i < dirs.Length; i++)
            {
                s_btn[i] = new servers();
                s_btn[i].Btn_txt = dirs[i].Replace(@"C:\mcsc\servers\", "");
                s_btn[i].Selected = false;
                s_btn[i].id.Text = i.ToString();
                s_btn[i].server_btn.Click += new EventHandler(servers_clicked);
                servers_panel.Controls.Add(s_btn[i]);
            }
        }
       
        public void servers_clicked(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            servers s = (servers)b.Parent;
            int id = int.Parse(s.id.Text);
            string name = s.Btn_txt;
            string dir = @"C:\mcsc\servers\" + s.Btn_txt;
            for(int i = 0; btns > i; i++)
            {
                s_btn[i].Selected = false;
            }
            s_btn[id].Selected = true;

            //OPEN CHILD FORM

            on_kl.Visible = false;
            on_konzoll = false;
            on_pluginok.Visible = false;

            open_ChildForm(new server_control(id, name, dir));
        }




        private void kezdlapbtn_Click(object sender, EventArgs e)
        {

            if(on_kl.Visible != true)
            {
                open_ChildForm(new kezdolap(this));
                on_kl.Visible = true;
                on_konzoll = false;
                on_pluginok.Visible = false;
                for (int i = 0; btns > i; i++)
                {
                    s_btn[i].Selected = false;
                }
            }
        }

        private Form activeForm = null;

        private void open_ChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Hide();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelplayer.Controls.Add(childForm);
            panelplayer.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        public void inditas(Boolean ind, kezdolap kl)
        {
            if(ind = true)
            {
                ip_k = new Thread(start: iptolt);
                ip_k.Start();
                stop_T = false;
                oflnoonl.FillColor = Color.Yellow;
                oflnpics.BackColor = Color.Yellow;
            }
        }

        public async void leallitas(Boolean ind, kezdolap kl)
        {
            stop_T = true;
            szv.killprocess(this);
            ip_k.Abort();
            oflnoonl.FillColor = Color.Red;
            oflnpics.BackColor = Color.Red;
        }

        public void enteredtext(string txt)
        {
            if(szv != null)
            {
                szv.entertext(txt);
            }
        }

        private void panelplayer_Paint(object sender, PaintEventArgs e)
        {

        }

        public void iptolt()
        {
            if (!stop_T)
            {
                //Thread.Sleep(1000);
                String ip_kerdes = new szerverindul().ip_betoltes(this);
                if (ip_kerdes != "error")
                {
                    /*   lanip.Invoke((MethodInvoker)(() => lanip.Text = mcsc.Properties.Settings.Default.lan_ip));
                       wnip.Invoke((MethodInvoker)(() => wnip.Text = mcsc.Properties.Settings.Default.wan_ip));
                       lanip.Invoke((MethodInvoker)(() => lanip.Visible = true));
                       lanipp.Invoke((MethodInvoker)(() => lanipp.Visible = true));
                       wnip.Invoke((MethodInvoker)(() => wnip.Visible = true));
                       wnip.Invoke((MethodInvoker)(() => wnipp.Visible = true));*/
                    MessageBox.Show("IP KÉSZ!");
                    szerverindul szi = new szerverindul();
                    MessageBox.Show("Indítás");
                    szi.start(this);
                }
                else MessageBox.Show("Hiba történt! Ellenőrizd a hálózat kapcsolatodat");
            }
        }

        public void konzoladdtext(string txt)
        {
            if(on_konzoll == true)
            {
                kz.nl(txt);
            }
        }

        private void plugins_btn_Click(object sender, EventArgs e)
        {
            if (on_pluginok.Visible != true)
            {
                open_ChildForm(new Plugins());
                on_kl.Visible = false;
                on_pluginok.Visible = true;
                on_konzoll = false;
                for (int i = 0; btns > i; i++)
                {
                    s_btn[i].Selected = false;
                }
            }
        }

        private void sizing(object sender, EventArgs e)
        {
            panel2.Height = this.Height - 25;
            fentiszar.Width = this.Width;
            talcara.Location = new Point(this.Width / 2 - 150, 5);
            panelplayer.Width = this.Width - panel2.Width;
            panelplayer.Height = this.Height - fentiszar.Height - 25;
        }

        private void sizing_begin(object sender, EventArgs e)
        {
            //panel2.Height = this.Height;
            //fentiszar.Width = this.Width;
        }

        private void maximaze(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized) {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }

        }

        private void Vezerlofo_Resize(object sender, EventArgs e)
        {
            sizing(sender, e);
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("EZ AZ ÖSSZES SZERVEREDET TÖRÖLNI FOGJA! Biztosan folytatod?", "FIGYELEM", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dr == DialogResult.Yes)
            {
                if (Directory.Exists(@"C:\mcsc\servers\"))
                {
                    var dir = new DirectoryInfo(@"C:\mcsc\servers\");
                    dir.Attributes = dir.Attributes & ~FileAttributes.ReadOnly;
                    dir.Delete(true);
                }
                await Task.Delay(1000);
                mcsc.Properties.Settings.Default.srv_created = false;
                mcsc.Properties.Settings.Default.Save();

                //Directory.CreateDirectory(@"C:\mcsc\srv\");

                Form1 f1 = new Form1();
                f1.Show();
                this.Hide();
            }
        }
    }
}
