using Mono.Nat;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace minecraftservercreator
{
    public partial class kezdolap : Form
    {

        public kezdolap(Vezerlofo vz)
        {
            InitializeComponent();
        }

        //delay 

        async Task PutTaskDelay(int delay)
        {
            await Task.Delay(delay);
        }

        private void kezdolap_Load(object sender, EventArgs e)
        {

        }
    }
}
