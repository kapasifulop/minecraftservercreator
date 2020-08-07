namespace minecraftservercreator
{
    partial class Vezerlofo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vezerlofo));
            this.fentiszar = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.talcara = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape3 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.kezdlapbtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.servers_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.on_pluginok = new System.Windows.Forms.Panel();
            this.plugins_btn = new System.Windows.Forms.Button();
            this.pb2 = new System.Windows.Forms.ProgressBar();
            this.version = new System.Windows.Forms.Label();
            this.oflnpics = new System.Windows.Forms.PictureBox();
            this.on_kl = new System.Windows.Forms.Panel();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.oflnoonl = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.panelplayer = new System.Windows.Forms.Panel();
            this.fentiszar.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oflnpics)).BeginInit();
            this.SuspendLayout();
            // 
            // fentiszar
            // 
            this.fentiszar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fentiszar.Controls.Add(this.panel1);
            this.fentiszar.Controls.Add(this.shapeContainer2);
            this.fentiszar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fentiszar.Location = new System.Drawing.Point(0, 0);
            this.fentiszar.MinimumSize = new System.Drawing.Size(1200, 25);
            this.fentiszar.Name = "fentiszar";
            this.fentiszar.Size = new System.Drawing.Size(1200, 25);
            this.fentiszar.TabIndex = 12;
            this.fentiszar.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.maximaze);
            this.fentiszar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_mousedown);
            this.fentiszar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_mousemove);
            this.fentiszar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_mouseup);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 17;
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1,
            this.talcara,
            this.rectangleShape3});
            this.shapeContainer2.Size = new System.Drawing.Size(1200, 25);
            this.shapeContainer2.TabIndex = 0;
            this.shapeContainer2.TabStop = false;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rectangleShape1.CornerRadius = 7;
            this.rectangleShape1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rectangleShape1.FillColor = System.Drawing.Color.Red;
            this.rectangleShape1.FillGradientColor = System.Drawing.Color.Red;
            this.rectangleShape1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.rectangleShape1.Location = new System.Drawing.Point(1160, 5);
            this.rectangleShape1.Name = "exit";
            this.rectangleShape1.SelectionColor = System.Drawing.Color.Red;
            this.rectangleShape1.Size = new System.Drawing.Size(15, 15);
            this.rectangleShape1.Click += new System.EventHandler(this.exit_Click);
            // 
            // talcara
            // 
            this.talcara.CornerRadius = 7;
            this.talcara.Cursor = System.Windows.Forms.Cursors.Hand;
            this.talcara.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.talcara.FillGradientColor = System.Drawing.Color.Red;
            this.talcara.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.talcara.Location = new System.Drawing.Point(450, 5);
            this.talcara.Name = "talcara";
            this.talcara.SelectionColor = System.Drawing.Color.Red;
            this.talcara.Size = new System.Drawing.Size(300, 15);
            this.talcara.Click += new System.EventHandler(this.talcara_Click);
            // 
            // rectangleShape3
            // 
            this.rectangleShape3.CornerRadius = 7;
            this.rectangleShape3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rectangleShape3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rectangleShape3.FillGradientColor = System.Drawing.Color.Red;
            this.rectangleShape3.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.rectangleShape3.Location = new System.Drawing.Point(20, 5);
            this.rectangleShape3.Name = "about";
            this.rectangleShape3.SelectionColor = System.Drawing.Color.Red;
            this.rectangleShape3.Size = new System.Drawing.Size(15, 15);
            this.rectangleShape3.Click += new System.EventHandler(this.about_Click);
            // 
            // kezdlapbtn
            // 
            this.kezdlapbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.kezdlapbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kezdlapbtn.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.kezdlapbtn.FlatAppearance.BorderSize = 0;
            this.kezdlapbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.kezdlapbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.kezdlapbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kezdlapbtn.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kezdlapbtn.ForeColor = System.Drawing.Color.White;
            this.kezdlapbtn.Location = new System.Drawing.Point(5, 20);
            this.kezdlapbtn.Name = "kezdlapbtn";
            this.kezdlapbtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.kezdlapbtn.Size = new System.Drawing.Size(230, 40);
            this.kezdlapbtn.TabIndex = 16;
            this.kezdlapbtn.Text = "Home";
            this.kezdlapbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.kezdlapbtn.UseVisualStyleBackColor = false;
            this.kezdlapbtn.Click += new System.EventHandler(this.kezdlapbtn_Click);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.servers_panel);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.on_pluginok);
            this.panel2.Controls.Add(this.plugins_btn);
            this.panel2.Controls.Add(this.pb2);
            this.panel2.Controls.Add(this.version);
            this.panel2.Controls.Add(this.oflnpics);
            this.panel2.Controls.Add(this.on_kl);
            this.panel2.Controls.Add(this.kezdlapbtn);
            this.panel2.Controls.Add(this.shapeContainer1);
            this.panel2.Location = new System.Drawing.Point(0, 25);
            this.panel2.MinimumSize = new System.Drawing.Size(240, 670);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(240, 670);
            this.panel2.TabIndex = 17;
            // 
            // servers_panel
            // 
            this.servers_panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.servers_panel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.servers_panel.Location = new System.Drawing.Point(5, 112);
            this.servers_panel.Name = "servers_panel";
            this.servers_panel.Size = new System.Drawing.Size(230, 337);
            this.servers_panel.TabIndex = 28;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(57, 455);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 52);
            this.button1.TabIndex = 27;
            this.button1.Text = "Összes szerver törlése";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // on_pluginok
            // 
            this.on_pluginok.BackColor = System.Drawing.Color.Yellow;
            this.on_pluginok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.on_pluginok.Location = new System.Drawing.Point(5, 66);
            this.on_pluginok.Name = "on_pluginok";
            this.on_pluginok.Size = new System.Drawing.Size(10, 40);
            this.on_pluginok.TabIndex = 24;
            // 
            // plugins_btn
            // 
            this.plugins_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.plugins_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.plugins_btn.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.plugins_btn.FlatAppearance.BorderSize = 0;
            this.plugins_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.plugins_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.plugins_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plugins_btn.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.plugins_btn.ForeColor = System.Drawing.Color.White;
            this.plugins_btn.Location = new System.Drawing.Point(5, 66);
            this.plugins_btn.Name = "plugins_btn";
            this.plugins_btn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.plugins_btn.Size = new System.Drawing.Size(230, 40);
            this.plugins_btn.TabIndex = 23;
            this.plugins_btn.Text = "Plugins";
            this.plugins_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.plugins_btn.UseVisualStyleBackColor = false;
            this.plugins_btn.Click += new System.EventHandler(this.plugins_btn_Click);
            // 
            // pb2
            // 
            this.pb2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pb2.Location = new System.Drawing.Point(20, 513);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(180, 23);
            this.pb2.TabIndex = 22;
            this.pb2.Visible = false;
            // 
            // version
            // 
            this.version.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.version.AutoSize = true;
            this.version.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.version.ForeColor = System.Drawing.Color.White;
            this.version.Location = new System.Drawing.Point(3, 623);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(56, 25);
            this.version.TabIndex = 7;
            this.version.Text = "Beta";
            // 
            // oflnpics
            // 
            this.oflnpics.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.oflnpics.BackColor = System.Drawing.Color.Red;
            this.oflnpics.BackgroundImage = global::mcsc.Properties.Resources.icons8_offline_52;
            this.oflnpics.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.oflnpics.Cursor = System.Windows.Forms.Cursors.No;
            this.oflnpics.Location = new System.Drawing.Point(88, 558);
            this.oflnpics.MaximumSize = new System.Drawing.Size(50, 50);
            this.oflnpics.Name = "oflnpics";
            this.oflnpics.Size = new System.Drawing.Size(50, 50);
            this.oflnpics.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.oflnpics.TabIndex = 21;
            this.oflnpics.TabStop = false;
            // 
            // on_kl
            // 
            this.on_kl.BackColor = System.Drawing.Color.Yellow;
            this.on_kl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.on_kl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.on_kl.Location = new System.Drawing.Point(5, 20);
            this.on_kl.Name = "on_kl";
            this.on_kl.Size = new System.Drawing.Size(10, 40);
            this.on_kl.TabIndex = 18;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.oflnoonl});
            this.shapeContainer1.Size = new System.Drawing.Size(240, 670);
            this.shapeContainer1.TabIndex = 20;
            this.shapeContainer1.TabStop = false;
            // 
            // oflnoonl
            // 
            this.oflnoonl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.oflnoonl.BorderColor = System.Drawing.Color.White;
            this.oflnoonl.BorderWidth = 2;
            this.oflnoonl.Cursor = System.Windows.Forms.Cursors.No;
            this.oflnoonl.FillColor = System.Drawing.Color.Red;
            this.oflnoonl.FillGradientColor = System.Drawing.Color.Red;
            this.oflnoonl.FillGradientStyle = Microsoft.VisualBasic.PowerPacks.FillGradientStyle.Central;
            this.oflnoonl.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.oflnoonl.Location = new System.Drawing.Point(74, 544);
            this.oflnoonl.Name = "oflnoonl";
            this.oflnoonl.Size = new System.Drawing.Size(75, 75);
            // 
            // panelplayer
            // 
            this.panelplayer.Location = new System.Drawing.Point(240, 25);
            this.panelplayer.MinimumSize = new System.Drawing.Size(959, 665);
            this.panelplayer.Name = "panelplayer";
            this.panelplayer.Size = new System.Drawing.Size(959, 665);
            this.panelplayer.TabIndex = 18;
            this.panelplayer.Paint += new System.Windows.Forms.PaintEventHandler(this.panelplayer_Paint);
            // 
            // Vezerlofo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1200, 685);
            this.ControlBox = false;
            this.Controls.Add(this.panelplayer);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.fentiszar);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1216, 701);
            this.Name = "Vezerlofo";
            this.Load += new System.EventHandler(this.Vezerlofo_Load);
            this.ResizeBegin += new System.EventHandler(this.sizing_begin);
            this.ResizeEnd += new System.EventHandler(this.sizing);
            this.Resize += new System.EventHandler(this.Vezerlofo_Resize);
            this.fentiszar.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oflnpics)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel fentiszar;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape talcara;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button kezdlapbtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel on_kl;
        private System.Windows.Forms.Panel panelplayer;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.OvalShape oflnoonl;
        private System.Windows.Forms.PictureBox oflnpics;
        private System.Windows.Forms.Label version;
        public System.Windows.Forms.ProgressBar pb2;
        private System.Windows.Forms.Panel on_pluginok;
        private System.Windows.Forms.Button plugins_btn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel servers_panel;
    }
}