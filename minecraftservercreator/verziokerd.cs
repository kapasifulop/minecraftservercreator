using mcsc.Properties.Langs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        private void verziokerd_Load(object sender, EventArgs e)
        {
            if(mcsc.Properties.Settings.Default.lang == 1)
            {
                text_long.Text = Lang_en.verzio_form;
                recommented.Text = Lang_en.recommented_versions;
                not_recommented.Text = Lang_en.not_recommented_versions;
                under.Text = Lang_en.under;
            }
        }
    }
}
