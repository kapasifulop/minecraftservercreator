﻿using mcsc.Properties.Langs;
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
    public partial class verzioesegyeb : Form
    {
        int mov;
        int movX;
        int movY;

        string s_name = "";

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
                if (mcsc.Properties.Settings.Default.lang == 1)
                {
                    MessageBox.Show(Lang_en.fill_all_fields, Lang_en.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (mcsc.Properties.Settings.Default.lang == 0)
                {
                    MessageBox.Show(Lang_hu.fill_all_fields, Lang_hu.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
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

            if(mcsc.Properties.Settings.Default.lang == 1)
            {
                version_lbl.Text = Lang_en.what_version;
                dont_see_lbl.Text = Lang_en.dont_see;
                spigot_bukkit_lbl.Text = Lang_en.agy;
                another.Text = Lang_en.another_agy;

                version.Text = Lang_en.select;
                svb.Text = Lang_en.select;

                nextlbl.Text = Lang_en.tovabb;

            }else if(mcsc.Properties.Settings.Default.lang == 0)
            {
                version_lbl.Text = Lang_hu.what_version;
                dont_see_lbl.Text = Lang_hu.dont_see;
                spigot_bukkit_lbl.Text = Lang_hu.agy;
                another.Text = Lang_hu.another_agy;

                version.Text = Lang_hu.select;
                svb.Text = Lang_hu.select;

                nextlbl.Text = Lang_hu.tovabb;
            }
        }

        private void svb_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (svb.SelectedItem == "Bukkit")
            {
                if (mcsc.Properties.Settings.Default.lang == 1)
                {
                    MessageBox.Show(Lang_en.bukkit_not_avaliable, Lang_en.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    svb.SelectedItem = "Spigot";
                }
                else if (mcsc.Properties.Settings.Default.lang == 0)
                {
                    MessageBox.Show(Lang_hu.bukkit_not_avaliable, Lang_hu.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    svb.SelectedItem = "Spigot";
                }

            }
        }
    }
}
