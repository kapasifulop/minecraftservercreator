﻿using mcsc.Properties.Langs;
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
    public partial class agykerd : Form
    {
        public agykerd()
        {
            InitializeComponent();
        }

        private void agykerd_Load(object sender, EventArgs e)
        {
            if (mcsc.Properties.Settings.Default.lang == 1)
            {
                txt_box.Text = Lang_en.agy_form;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
