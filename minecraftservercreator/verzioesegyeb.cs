using mcsc.Properties.Langs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace minecraftservercreator
{
    public partial class verzioesegyeb : Form
    {
        int mov;
        int movX;
        int movY;

        string s_name = "";

        ResourceManager rm = new ResourceManager("mcsc.Properties.Langs.Lang_hu", Assembly.GetExecutingAssembly());



        public verzioesegyeb(string _s_name)
        {
            InitializeComponent();
            verzio.DropDownStyle = ComboBoxStyle.DropDownList;
            svb.DropDownStyle = ComboBoxStyle.DropDownList;
            if(_s_name == "")
            {
                MessageBox.Show("HIBA #28 AZ APPLIKÁCIÓ LEÁLL AMINT BEZÁROD EZT AZ ABLAKOT!");
                Application.Exit();
            }
            s_name = _s_name;
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

        private void verziokrd_Click(object sender, EventArgs e)
        {
            verziokerd vk = new verziokerd();
            vk.StartPosition = this.StartPosition;
            vk.Show();
        }

        private void agykerd_Click(object sender, EventArgs e)
        {
            agykerd agyk = new agykerd();
            agyk.StartPosition = this.StartPosition;
            agyk.Show();
        }

        private void nextshp_Click(object sender, EventArgs e)
        {
            if(verzio.Text != "" && svb.Text != "" && verzio.Text != Lang_en.select && verzio.Text != Lang_hu.select && svb.Text != Lang_hu.select && svb.Text != Lang_en.select)
            {
                /*mcsc.Properties.Settings.Default.verzio = verzio.Text;
                mcsc.Properties.Settings.Default.agy = svb.Text;
                mcsc.Properties.Settings.Default.Save();*/
                StreamWriter sw = new StreamWriter(@"C:\mcsc\servers\" + s_name + @"\settings.mcsc");
                sw.WriteLine("version=" + verzio.Text);
                sw.WriteLine("agy=" + svb.Text);
                sw.Close();
                gepellenorzes gepell = new gepellenorzes();
                gepell.StartPosition = this.StartPosition;
                gepell.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(rm.GetString("fill_all_fields"), rm.GetString("error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

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

        private void verzioesegyeb_Load(object sender, EventArgs e)
        {
            //nextlbl.BackColor = Color.FromArgb(250, Color.White);
            version.Text = mcsc.Properties.Settings.Default.version;

            if (mcsc.Properties.Settings.Default.lang == 1)
            {
                rm = new ResourceManager("mcsc.Properties.Langs.Lang_en", Assembly.GetExecutingAssembly());

            }
            else if (mcsc.Properties.Settings.Default.lang == 0)
            {
                rm = new ResourceManager("mcsc.Properties.Langs.Lang_hu", Assembly.GetExecutingAssembly());
            }

                version_lbl.Text = rm.GetString("what_version");
                dont_see_lbl.Text = rm.GetString("dont_see");
                spigot_bukkit_lbl.Text = rm.GetString("agy");
                another.Text = rm.GetString("another_agy");

                version.Text = rm.GetString("select");
                svb.Text = rm.GetString("select");

                nextlbl.Text = rm.GetString("tovabb");
        }

        private void svb_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (svb.SelectedItem == "Bukkit")
            {
                MessageBox.Show(rm.GetString("bukkit_not_avaliable"), rm.GetString("error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                svb.SelectedItem = "Spigot";
            }
        }
    }
}
