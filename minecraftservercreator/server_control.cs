using minecraftservercreator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mcsc
{
    public partial class server_control : Form
    {
        int server_id;
        string server_name;
        string dir;
        int port;

        public void makeallenabled()
        {
            konzol.Enabled = true;
            settings_btn.Enabled = true;
        }

        public server_control(int _server_id, string _server_name, string _dir)
        {
            InitializeComponent();
            server_id = _server_id;
            server_name = _server_name;
            dir = _dir;
            srv_name_lbl.Text = server_name;
            server_loc.Text += server_name;
        }

        private void konzol_Click(object sender, EventArgs e)
        {
            open_ChildForm(new server_console(server_id, server_name, dir));
            makeallenabled();
            konzol.Enabled = false;
        }

        private void settings_btn_Click(object sender, EventArgs e)
        {
            makeallenabled();
            open_ChildForm(new server_settings(server_id, server_name, dir));
            settings_btn.Enabled = false;
        }

        private void server_control_Load(object sender, EventArgs e)
        {
            open_ChildForm(new server_settings(server_id, server_name, dir));
            settings_btn.Enabled = false;
            if(Program.started[server_id] == false)
            {
                start_btn.Text = "Indítás";
            }
            else
            {
                start_btn.Text = "Leállítás";
            }
            port = 25565;
            //port = Port;
            reload_btn();
        }

        public int Port
        {
            get {
                try
                {
                    if (File.Exists(dir + @"\server.properties"))
                    {
                        StreamReader sr = new StreamReader(dir + @"\server.properties");

                        string line = sr.ReadLine();
                        int _port = 25565;
                        while (line != null)
                        {
                            sr.ReadLine();
                            if (line.Contains("server-port=="))
                            {
                                line = line.Replace("server-port=", "");

                                _port = int.Parse(line);
                            }
                        }
                        sr.Close();
                        return _port;
                    }
                    else
                    {
                        return 25565;
                    }
                }
                catch { MessageBox.Show("Hiba a port betöltése közben, így az alapértelmezett port-t használjuk! (25565)"); return 25565; }

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

        private async void reload_btn()
        {
            if (Program.started[server_id] == false) start_btn.Text = "INDÍTÁS";
            else start_btn.Text = "LEÁLLÍTÁS";

            await Task.Delay(1000);
            reload_btn();
        }

        private void start_btn_Click(object sender, EventArgs e)
        {
            if (Program.started[server_id] == false)
            {
                Program.started[server_id] = true;
                start_btn.Text = "LEÁLLÍTÁS";
                Task.Run(() => Program.start_srv(server_id, server_name, dir, port));
            }
            else
            {
                Program.started[server_id] = false;
                start_btn.Text = "INDÍTÁS";
                start_btn.Enabled = false;
                Program.stop_s(server_id, this);
            }
        }
    }
}
