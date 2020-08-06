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
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void ok_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void About_Load(object sender, EventArgs e)
        {
            version.Text = mcsc.Properties.Settings.Default.version;
        }
    }
}
