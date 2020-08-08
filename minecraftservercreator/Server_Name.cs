using mcsc.Properties.Langs;
using minecraftservercreator;
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

namespace mcsc
{
    public partial class Server_Name : Form
    {

        int mov;
        int movX;
        int movY;

        public Server_Name()
        {
            InitializeComponent();
        }
        ResourceManager rm = new ResourceManager("mcsc.Properties.Langs.Lang_hu", Assembly.GetExecutingAssembly());

        private void Server_Name_Load(object sender, EventArgs e)
        { 
            if (mcsc.Properties.Settings.Default.lang == 1)
            {
                rm = new ResourceManager("mcsc.Properties.Langs.Lang_en", Assembly.GetExecutingAssembly());

            }
            else if (mcsc.Properties.Settings.Default.lang == 0)
            {
                rm = new ResourceManager("mcsc.Properties.Langs.Lang_hu", Assembly.GetExecutingAssembly());
            }

            srv_name.Text = rm.GetString("s_name");
            spec_car_lbl.Text = rm.GetString("spec_car");
            nextlbl.Text = rm.GetString("tovabb");

        }

        private void tovabb(object sender, EventArgs e)
        {
            nx_shp(sender, e);
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

        private void nx_shp(object sender, EventArgs e)
        {
            if (name_box.Text != "")
            {
                if(!Directory.Exists(@"C:\mcsc\servers\" + name_box.Text))
                {
                    if (!Directory.Exists(@"C:\mcsc\servers\"))
                    {
                        Directory.CreateDirectory(@"C:\mcsc\servers\");
                    }
                    Directory.CreateDirectory(@"C:\mcsc\servers\" + name_box.Text);

                    verzioesegyeb ve = new verzioesegyeb(name_box.Text);
                    this.Hide();
                    ve.Show();
                }
                else
                {
                    MessageBox.Show(rm.GetString("already"), rm.GetString("error"), MessageBoxButtons.OK, MessageBoxIcon.Error);


                }
            }
            else
            {
                MessageBox.Show(rm.GetString("enter_srv_name"), rm.GetString("error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rectangleShape1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rectangleShape3_Click(object sender, EventArgs e)
        {
            About ab = new About();
            ab.StartPosition = this.StartPosition;
            ab.ShowDialog();
        }
    }
}
