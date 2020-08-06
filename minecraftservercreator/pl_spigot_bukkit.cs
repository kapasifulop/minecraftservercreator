using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Policy;
using Microsoft.Win32;

namespace mcsc
{
    public partial class pl_spigot_bukkit : UserControl
    {
        Uri spigot_uri = new Uri("https://www.spigotmc.org/resources/categories/spigot.4/");
        Uri bukkit_uri = new Uri("https://dev.bukkit.org/bukkit-plugins");
        public pl_spigot_bukkit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            web.Url = bukkit_uri;
            web.Visible = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            web.Url = spigot_uri;
            web.Visible = true;
        }

        private void pl_spigot_bukkit_Load(object sender, EventArgs e)
        {

        }

        private void file_dwnload(object sender, EventArgs e)
        {
            
        }
    }
}
