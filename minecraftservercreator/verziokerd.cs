using mcsc.Properties.Langs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace minecraftservercreator
{
    public partial class verziokerd : Form
    {
        public verziokerd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        ResourceManager rm = new ResourceManager("mcsc.Properties.Langs.Lang_hu", Assembly.GetExecutingAssembly());

        private void verziokerd_Load(object sender, EventArgs e)
        {
            if (mcsc.Properties.Settings.Default.lang == 1)
            {
                rm = new ResourceManager("mcsc.Properties.Langs.Lang_en", Assembly.GetExecutingAssembly());
            }
            else if (mcsc.Properties.Settings.Default.lang == 0)
            {
                rm = new ResourceManager("mcsc.Properties.Langs.Lang_hu", Assembly.GetExecutingAssembly());
            }

            text_long.Text = rm.GetString("verzio_form");
            recommented.Text = rm.GetString("recommented_versions");
            not_recommented.Text = rm.GetString("not_recommented_versions");
            under.Text = rm.GetString("under");
        }
    }
}
