namespace minecraftservercreator
{
    partial class gepellenorzes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gepellenorzes));
            this.fentiszar = new System.Windows.Forms.Panel();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.exit = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.talcara = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.about = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.circularProgressBar1 = new CircularProgressBar.CircularProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.ram = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pingbar = new CircularProgressBar.CircularProgressBar();
            this.pingpong = new System.Windows.Forms.Label();
            this.pinglblb = new System.Windows.Forms.Label();
            this.rec_set = new System.Windows.Forms.Label();
            this.jatekosok = new System.Windows.Forms.Label();
            this.plugins_lbl = new System.Windows.Forms.Label();
            this.jatekossszam = new System.Windows.Forms.Label();
            this.plugins = new System.Windows.Forms.Label();
            this.version = new System.Windows.Forms.Label();
            this.fentiszar.SuspendLayout();
            this.SuspendLayout();
            // 
            // fentiszar
            // 
            this.fentiszar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fentiszar.Controls.Add(this.shapeContainer2);
            this.fentiszar.Location = new System.Drawing.Point(0, 0);
            this.fentiszar.Name = "fentiszar";
            this.fentiszar.Size = new System.Drawing.Size(800, 25);
            this.fentiszar.TabIndex = 11;
            this.fentiszar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_mousedown);
            this.fentiszar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_mousemove);
            this.fentiszar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_mouseup);
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.exit,
            this.talcara,
            this.about});
            this.shapeContainer2.Size = new System.Drawing.Size(800, 25);
            this.shapeContainer2.TabIndex = 0;
            this.shapeContainer2.TabStop = false;
            // 
            // exit
            // 
            this.exit.CornerRadius = 7;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.FillColor = System.Drawing.Color.Red;
            this.exit.FillGradientColor = System.Drawing.Color.Red;
            this.exit.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.exit.Location = new System.Drawing.Point(766, 5);
            this.exit.Name = "exit";
            this.exit.SelectionColor = System.Drawing.Color.Red;
            this.exit.Size = new System.Drawing.Size(15, 15);
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // talcara
            // 
            this.talcara.CornerRadius = 7;
            this.talcara.Cursor = System.Windows.Forms.Cursors.Hand;
            this.talcara.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.talcara.FillGradientColor = System.Drawing.Color.Red;
            this.talcara.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.talcara.Location = new System.Drawing.Point(264, 5);
            this.talcara.Name = "talcara";
            this.talcara.SelectionColor = System.Drawing.Color.Red;
            this.talcara.Size = new System.Drawing.Size(253, 15);
            this.talcara.Click += new System.EventHandler(this.talcara_Click);
            // 
            // about
            // 
            this.about.CornerRadius = 7;
            this.about.Cursor = System.Windows.Forms.Cursors.Hand;
            this.about.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.about.FillGradientColor = System.Drawing.Color.Red;
            this.about.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.about.Location = new System.Drawing.Point(20, 5);
            this.about.Name = "about";
            this.about.SelectionColor = System.Drawing.Color.Red;
            this.about.Size = new System.Drawing.Size(15, 15);
            this.about.Click += new System.EventHandler(this.about_Click);
            // 
            // circularProgressBar1
            // 
            this.circularProgressBar1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBar1.AnimationSpeed = 500;
            this.circularProgressBar1.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.circularProgressBar1.ForeColor = System.Drawing.Color.DarkGray;
            this.circularProgressBar1.InnerColor = System.Drawing.SystemColors.Control;
            this.circularProgressBar1.InnerMargin = 2;
            this.circularProgressBar1.InnerWidth = -1;
            this.circularProgressBar1.Location = new System.Drawing.Point(88, 167);
            this.circularProgressBar1.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar1.Name = "circularProgressBar1";
            this.circularProgressBar1.OuterColor = System.Drawing.Color.DarkGray;
            this.circularProgressBar1.OuterMargin = -5;
            this.circularProgressBar1.OuterWidth = 5;
            this.circularProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.circularProgressBar1.ProgressWidth = 5;
            this.circularProgressBar1.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.circularProgressBar1.Size = new System.Drawing.Size(150, 150);
            this.circularProgressBar1.StartAngle = 90;
            this.circularProgressBar1.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar1.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBar1.SubscriptText = ".23";
            this.circularProgressBar1.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar1.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBar1.SuperscriptText = "°C";
            this.circularProgressBar1.TabIndex = 14;
            this.circularProgressBar1.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circularProgressBar1.Value = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(120, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 32);
            this.label1.TabIndex = 15;
            this.label1.Text = "RAM";
            // 
            // ram
            // 
            this.ram.AutoSize = true;
            this.ram.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ram.Location = new System.Drawing.Point(105, 224);
            this.ram.Name = "ram";
            this.ram.Size = new System.Drawing.Size(115, 38);
            this.ram.TabIndex = 16;
            this.ram.Text = "16 GB";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(264, 351);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(254, 72);
            this.button1.TabIndex = 17;
            this.button1.Text = "Adatok lekérdezése";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pingbar
            // 
            this.pingbar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.pingbar.AnimationSpeed = 500;
            this.pingbar.BackColor = System.Drawing.Color.Transparent;
            this.pingbar.Font = new System.Drawing.Font("Verdana", 24F);
            this.pingbar.ForeColor = System.Drawing.Color.Black;
            this.pingbar.InnerColor = System.Drawing.Color.White;
            this.pingbar.InnerMargin = 2;
            this.pingbar.InnerWidth = -1;
            this.pingbar.Location = new System.Drawing.Point(561, 167);
            this.pingbar.MarqueeAnimationSpeed = 2000;
            this.pingbar.Name = "pingbar";
            this.pingbar.OuterColor = System.Drawing.Color.DarkGray;
            this.pingbar.OuterMargin = -5;
            this.pingbar.OuterWidth = 5;
            this.pingbar.ProgressColor = System.Drawing.Color.Green;
            this.pingbar.ProgressWidth = 5;
            this.pingbar.SecondaryFont = new System.Drawing.Font("Verdana", 24F);
            this.pingbar.Size = new System.Drawing.Size(150, 150);
            this.pingbar.StartAngle = 90;
            this.pingbar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.pingbar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.pingbar.SubscriptText = "";
            this.pingbar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.pingbar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.pingbar.SuperscriptText = "";
            this.pingbar.TabIndex = 1;
            this.pingbar.Text = "?";
            this.pingbar.TextMargin = new System.Windows.Forms.Padding(0);
            this.pingbar.Value = 68;
            // 
            // pingpong
            // 
            this.pingpong.AutoSize = true;
            this.pingpong.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pingpong.Location = new System.Drawing.Point(589, 130);
            this.pingpong.Name = "pingpong";
            this.pingpong.Size = new System.Drawing.Size(95, 32);
            this.pingpong.TabIndex = 20;
            this.pingpong.Text = "PING";
            // 
            // pinglblb
            // 
            this.pinglblb.AutoSize = true;
            this.pinglblb.BackColor = System.Drawing.Color.White;
            this.pinglblb.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pinglblb.Location = new System.Drawing.Point(570, 224);
            this.pinglblb.Margin = new System.Windows.Forms.Padding(0);
            this.pinglblb.Name = "pinglblb";
            this.pinglblb.Size = new System.Drawing.Size(136, 38);
            this.pinglblb.TabIndex = 0;
            this.pinglblb.Text = "160 ms";
            // 
            // rec_set
            // 
            this.rec_set.AutoSize = true;
            this.rec_set.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rec_set.Location = new System.Drawing.Point(221, 28);
            this.rec_set.Name = "rec_set";
            this.rec_set.Size = new System.Drawing.Size(344, 35);
            this.rec_set.TabIndex = 21;
            this.rec_set.Text = "Ajánlott beállítások:";
            // 
            // jatekosok
            // 
            this.jatekosok.AutoSize = true;
            this.jatekosok.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.jatekosok.Location = new System.Drawing.Point(270, 179);
            this.jatekosok.MinimumSize = new System.Drawing.Size(104, 23);
            this.jatekosok.Name = "jatekosok";
            this.jatekosok.Size = new System.Drawing.Size(104, 23);
            this.jatekosok.TabIndex = 22;
            this.jatekosok.Text = "Játékosok";
            this.jatekosok.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plugins_lbl
            // 
            this.plugins_lbl.AutoSize = true;
            this.plugins_lbl.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.plugins_lbl.Location = new System.Drawing.Point(413, 179);
            this.plugins_lbl.MinimumSize = new System.Drawing.Size(92, 23);
            this.plugins_lbl.Name = "plugins_lbl";
            this.plugins_lbl.Size = new System.Drawing.Size(92, 23);
            this.plugins_lbl.TabIndex = 23;
            this.plugins_lbl.Text = "Pluginok";
            this.plugins_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // jatekossszam
            // 
            this.jatekossszam.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.jatekossszam.AutoSize = true;
            this.jatekossszam.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.jatekossszam.Location = new System.Drawing.Point(306, 224);
            this.jatekossszam.Name = "jatekossszam";
            this.jatekossszam.Size = new System.Drawing.Size(17, 18);
            this.jatekossszam.TabIndex = 24;
            this.jatekossszam.Text = "?";
            this.jatekossszam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plugins
            // 
            this.plugins.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.plugins.AutoSize = true;
            this.plugins.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.plugins.Location = new System.Drawing.Point(442, 224);
            this.plugins.Name = "plugins";
            this.plugins.Size = new System.Drawing.Size(17, 18);
            this.plugins.TabIndex = 25;
            this.plugins.Text = "?";
            this.plugins.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // version
            // 
            this.version.AutoSize = true;
            this.version.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.version.Location = new System.Drawing.Point(15, 35);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(56, 25);
            this.version.TabIndex = 26;
            this.version.Text = "Beta";
            // 
            // gepellenorzes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.version);
            this.Controls.Add(this.plugins);
            this.Controls.Add(this.jatekossszam);
            this.Controls.Add(this.plugins_lbl);
            this.Controls.Add(this.jatekosok);
            this.Controls.Add(this.rec_set);
            this.Controls.Add(this.pingbar);
            this.Controls.Add(this.pinglblb);
            this.Controls.Add(this.pingpong);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ram);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.circularProgressBar1);
            this.Controls.Add(this.fentiszar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "gepellenorzes";
            this.Text = "gepellenorzes";
            this.Load += new System.EventHandler(this.gepellenorzes_Load);
            this.fentiszar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel fentiszar;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape exit;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape talcara;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape about;
        private CircularProgressBar.CircularProgressBar circularProgressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ram;
        private System.Windows.Forms.Button button1;
        private CircularProgressBar.CircularProgressBar pingbar;
        private System.Windows.Forms.Label pingpong;
        private System.Windows.Forms.Label pinglblb;
        private System.Windows.Forms.Label rec_set;
        private System.Windows.Forms.Label jatekosok;
        private System.Windows.Forms.Label plugins_lbl;
        private System.Windows.Forms.Label jatekossszam;
        private System.Windows.Forms.Label plugins;
        private System.Windows.Forms.Label version;
    }
}