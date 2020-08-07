namespace minecraftservercreator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.welcome = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.start = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.about = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.talcara = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.exit = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.fentiszar = new System.Windows.Forms.Panel();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.szpanel = new System.Windows.Forms.Panel();
            this.szoveg = new System.Windows.Forms.Label();
            this.version = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.startlbl = new System.Windows.Forms.Label();
            this.fentiszar.SuspendLayout();
            this.szpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // welcome
            // 
            this.welcome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.welcome.AutoSize = true;
            this.welcome.BackColor = System.Drawing.Color.Black;
            this.welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.welcome.ForeColor = System.Drawing.Color.Black;
            this.welcome.Location = new System.Drawing.Point(217, 26);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(346, 73);
            this.welcome.TabIndex = 0;
            this.welcome.Text = "Üdvözöllek";
            this.welcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.start});
            this.shapeContainer1.Size = new System.Drawing.Size(800, 450);
            this.shapeContainer1.TabIndex = 1;
            this.shapeContainer1.TabStop = false;
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.start.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.start.BorderWidth = 2;
            this.start.CornerRadius = 10;
            this.start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.start.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.start.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.start.Location = new System.Drawing.Point(216, 367);
            this.start.Name = "start";
            this.start.SelectionColor = System.Drawing.SystemColors.ControlDark;
            this.start.Size = new System.Drawing.Size(346, 73);
            this.start.Click += new System.EventHandler(this.start_Click);
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
            // fentiszar
            // 
            this.fentiszar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fentiszar.Controls.Add(this.shapeContainer2);
            this.fentiszar.Location = new System.Drawing.Point(0, 0);
            this.fentiszar.Name = "fentiszar";
            this.fentiszar.Size = new System.Drawing.Size(800, 25);
            this.fentiszar.TabIndex = 0;
            this.fentiszar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnale_mousedown);
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
            // szpanel
            // 
            this.szpanel.BackColor = System.Drawing.Color.Silver;
            this.szpanel.Controls.Add(this.szoveg);
            this.szpanel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.szpanel.Location = new System.Drawing.Point(12, 102);
            this.szpanel.Name = "szpanel";
            this.szpanel.Size = new System.Drawing.Size(776, 196);
            this.szpanel.TabIndex = 4;
            // 
            // szoveg
            // 
            this.szoveg.AutoSize = true;
            this.szoveg.BackColor = System.Drawing.Color.Silver;
            this.szoveg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.szoveg.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.szoveg.ForeColor = System.Drawing.Color.Black;
            this.szoveg.Location = new System.Drawing.Point(0, 0);
            this.szoveg.MaximumSize = new System.Drawing.Size(778, 190);
            this.szoveg.Name = "szoveg";
            this.szoveg.Size = new System.Drawing.Size(778, 190);
            this.szoveg.TabIndex = 0;
            this.szoveg.Text = resources.GetString("szoveg.Text");
            this.szoveg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // version
            // 
            this.version.AutoSize = true;
            this.version.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.version.Location = new System.Drawing.Point(15, 28);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(56, 25);
            this.version.TabIndex = 6;
            this.version.Text = "Beta";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(291, 304);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 56);
            this.button1.TabIndex = 7;
            this.button1.Text = "ENGLISH";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // startlbl
            // 
            this.startlbl.AutoSize = true;
            this.startlbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.startlbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startlbl.Font = new System.Drawing.Font("Verdana", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.startlbl.ForeColor = System.Drawing.Color.White;
            this.startlbl.Location = new System.Drawing.Point(219, 385);
            this.startlbl.MinimumSize = new System.Drawing.Size(340, 0);
            this.startlbl.Name = "startlbl";
            this.startlbl.Size = new System.Drawing.Size(340, 42);
            this.startlbl.TabIndex = 0;
            this.startlbl.Text = "Fogjunk bele!";
            this.startlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.startlbl.Click += new System.EventHandler(this.start_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.startlbl);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.version);
            this.Controls.Add(this.fentiszar);
            this.Controls.Add(this.szpanel);
            this.Controls.Add(this.welcome);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "kezdolap";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.fentiszar.ResumeLayout(false);
            this.szpanel.ResumeLayout(false);
            this.szpanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcome;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape start;
        private System.Windows.Forms.Panel szpanel;
        private System.Windows.Forms.Label szoveg;
        private System.Windows.Forms.Panel fentiszar;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape exit;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape talcara;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape about;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private System.Windows.Forms.Label version;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label startlbl;
    }
}

