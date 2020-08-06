using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mcsc
{
    public partial class servers : UserControl
    {
        public servers()
        {
            InitializeComponent();
        }


        private string _btn_txt;
        private bool _sel;

        public String Btn_txt
        {
            get { return _btn_txt; }
            set { _btn_txt = value; server_btn.Text = value; }
        }

        public bool Selected
        {
            get { return _sel; }
            set { _sel = value; selected_panel.Visible = value;}
        }

        private void servers_Load(object sender, EventArgs e)
        {

        }

        private void server_btn_Click(object sender, EventArgs e)
        {
        }
    }
}
