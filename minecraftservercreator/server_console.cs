using minecraftservercreator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mcsc
{
    public partial class server_console : Form
    {
        int id;
        string name;
        string dir;
        bool load = true;
        public server_console(int _id, string _name, string _dir)
        {
            InitializeComponent();
            id = _id;
            name = _name;
            dir = _dir;
        }

        private void server_console_Load(object sender, EventArgs e)
        {
            loop();
        }

        private async void loop()
        {
            if (this.Visible && File.Exists(dir + @"\log.txt") && load == true)
            {
                loadfile();
            }
            await Task.Delay(250);
            loop();
        }

        private async void loadfile()
        {
            try
            {

                String ls = File.ReadAllText(dir + @"\log.txt");
                if (ls != console_txtbox.Text)
                {
                    console_txtbox.Text = "";
                    console_txtbox.Text = ls;
                    console_txtbox.SelectionStart = console_txtbox.TextLength;
                    console_txtbox.ScrollToCaret();
                }
            }
            catch { }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private async void key_press(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (send.Text == ":|:clearfile")
                {
                    load = false;
                    await Task.Delay(100);
                    List<string> liness = File.ReadAllLines(dir + @"\log.txt").ToList();
                    liness.Clear();
                    liness.Add("");
                    File.WriteAllLines(dir + @"\log.txt", liness);
                    send.Text = "";
                    load = true;
                }
                else if (send.Text == ":|:killports")
                {
                    load = false;
                    await Task.Delay(100);
                    System.Diagnostics.Process process = new System.Diagnostics.Process();
                    System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo("powershell", @"TASKKILL /IM java.exe /F; pause");
                    process.StartInfo = startInfo;
                    process.Start();
                    send.Text = "";
                    load = true;
                }
                else
                {
                    load = false;
                    await Task.Delay(100);
                    List<string> lines = File.ReadAllLines(dir + @"\log.txt").ToList();
                    lines.Add(send.Text);

                    Program.i_typed(id, name, dir, send.Text);

                    try
                    {
                        File.WriteAllLines(dir + @"\log.txt", lines);
                    }
                    catch { MessageBox.Show("HIBA A LOG MÁR HASZNÁLATBAN VAN", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }

                    load = true;

                    send.Text = "";
                }

            }
        }
    }
}
