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

namespace minecraftservercreator
{
    public partial class konzol : Form
    {
        List<string> linesb;
        string filePath = @"C:\mcsc\log.txt";
        int i = 0;
        Vezerlofo vzf;
        public konzol(Vezerlofo vz)
        {
            vzf = vz;
            InitializeComponent();
        }

        private async void konzol_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(@"C:\mcsc"))
            {
                //(@"Főmappa létrehozása C:\mcsc");
                Directory.CreateDirectory(@"C:\mcsc");
            }
            if (!File.Exists(@"C:\mcsc\log.txt"))
            {
                File.Create(@"C:\mcsc\log.txt");
            }
            console_txbox.Text = "";
            load_file();
        }

        async Task PutTaskDelay(int delay)
        {
            await Task.Delay(delay);
        }

        private void key_press(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if(send.Text == ":|:clearfile")
                {
                    List<string> liness = File.ReadAllLines(filePath).ToList();
                    liness.Clear();
                    liness.Add("");
                    File.WriteAllLines(filePath, liness);
                    load_file();
                    send.Text = "";
                }
                else if (send.Text == ":|:killports")
                {
                    System.Diagnostics.Process process = new System.Diagnostics.Process();
                    System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo("powershell", @"TASKKILL /IM java.exe /F; pause");
                    process.StartInfo = startInfo;
                    process.Start();
                    send.Text = "";
                }
                else
                {
                    List<string> lines = File.ReadAllLines(filePath).ToList();
                    lines.Add(send.Text);
                    vzf.enteredtext(send.Text);
                    Boolean tryagain = true;
                    /*while (tryagain)
                    {*/
                        try
                        {
                            File.WriteAllLines(filePath, lines);
                            tryagain = false;
                        }
                        catch { MessageBox.Show("HIBA A LOG MÁR HASZNÁLATBAN VAN", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    //}
                    
                    console_txbox.Text += Environment.NewLine + send.Text;
                    console_txbox.SelectionStart = console_txbox.TextLength;
                    console_txbox.ScrollToCaret();
                    send.Text = "";
                }

            }
        }

        public void nl(string text)
        {
            console_txbox.Invoke((MethodInvoker)(() => console_txbox.Text += Environment.NewLine + text));
            console_txbox.Invoke((MethodInvoker)(() => console_txbox.SelectionStart = console_txbox.TextLength));
            console_txbox.Invoke((MethodInvoker)(() => console_txbox.ScrollToCaret()));
        }

        public void load_file()
        {
            //Boolean tryagain = true;
            /*while (tryagain == true)
            {*/
                try
                {
                    /*List<string> lines;
                    lines = File.ReadAllLines(filePath).ToList();*/
                    String ls = File.ReadAllText(filePath);
                    console_txbox.Text = "";
                    /*foreach (String line in lines)
                    {
                        if (console_txbox.Text == "")
                        {
                            console_txbox.Text = line;
                        }
                        else
                        {
                            console_txbox.Text += Environment.NewLine + line;
                        }

                    }*/
                    console_txbox.Text = ls;
                    console_txbox.SelectionStart = console_txbox.TextLength;
                    console_txbox.ScrollToCaret();
                    //tryagain = false;
                }
                catch { }
            //}
        }

        private void console_txbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void send_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
