namespace mcsc
{
    partial class Server_Name
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Server_Name));
            this.fentiszar = new System.Windows.Forms.Panel();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape2 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape3 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.version = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.name_box = new System.Windows.Forms.TextBox();
            this.next_btn = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.nextlbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.rectangleShape1,
            this.rectangleShape2,
            this.rectangleShape3});
            this.shapeContainer2.Size = new System.Drawing.Size(800, 25);
            this.shapeContainer2.TabIndex = 0;
            this.shapeContainer2.TabStop = false;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.CornerRadius = 7;
            this.rectangleShape1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rectangleShape1.FillColor = System.Drawing.Color.Red;
            this.rectangleShape1.FillGradientColor = System.Drawing.Color.Red;
            this.rectangleShape1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.rectangleShape1.Location = new System.Drawing.Point(766, 5);
            this.rectangleShape1.Name = "exit";
            this.rectangleShape1.SelectionColor = System.Drawing.Color.Red;
            this.rectangleShape1.Size = new System.Drawing.Size(15, 15);
            this.rectangleShape1.Click += new System.EventHandler(this.rectangleShape1_Click);
            // 
            // rectangleShape2
            // 
            this.rectangleShape2.CornerRadius = 7;
            this.rectangleShape2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rectangleShape2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.rectangleShape2.FillGradientColor = System.Drawing.Color.Red;
            this.rectangleShape2.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.rectangleShape2.Location = new System.Drawing.Point(264, 5);
            this.rectangleShape2.Name = "talcara";
            this.rectangleShape2.SelectionColor = System.Drawing.Color.Red;
            this.rectangleShape2.Size = new System.Drawing.Size(253, 15);
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
            this.rectangleShape3.Click += new System.EventHandler(this.rectangleShape3_Click);
            // 
            // version
            // 
            this.version.AutoSize = true;
            this.version.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.version.Location = new System.Drawing.Point(12, 28);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(56, 25);
            this.version.TabIndex = 12;
            this.version.Text = "Beta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(0, 140);
            this.label1.MinimumSize = new System.Drawing.Size(800, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 32);
            this.label1.TabIndex = 13;
            this.label1.Text = "Mi legyen a szervered neve?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // name_box
            // 
            this.name_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.name_box.Location = new System.Drawing.Point(200, 199);
            this.name_box.Name = "name_box";
            this.name_box.Size = new System.Drawing.Size(390, 38);
            this.name_box.TabIndex = 14;
            this.name_box.Text = "Server1";
            this.name_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // next_btn
            // 
            this.next_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.next_btn.BorderColor = System.Drawing.Color.Red;
            this.next_btn.BorderWidth = 2;
            this.next_btn.CornerRadius = 36;
            this.next_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.next_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.next_btn.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.next_btn.Location = new System.Drawing.Point(215, 358);
            this.next_btn.Name = "next_btn";
            this.next_btn.SelectionColor = System.Drawing.SystemColors.ControlDark;
            this.next_btn.Size = new System.Drawing.Size(346, 73);
            this.next_btn.Click += new System.EventHandler(this.nx_shp);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.next_btn});
            this.shapeContainer1.Size = new System.Drawing.Size(800, 450);
            this.shapeContainer1.TabIndex = 15;
            this.shapeContainer1.TabStop = false;
            // 
            // nextlbl
            // 
            this.nextlbl.AutoSize = true;
            this.nextlbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nextlbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nextlbl.Font = new System.Drawing.Font("Verdana", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nextlbl.ForeColor = System.Drawing.Color.White;
            this.nextlbl.Location = new System.Drawing.Point(323, 374);
            this.nextlbl.Name = "nextlbl";
            this.nextlbl.Size = new System.Drawing.Size(143, 42);
            this.nextlbl.TabIndex = 16;
            this.nextlbl.Text = "Tovább";
            this.nextlbl.Click += new System.EventHandler(this.tovabb);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 172);
            this.label2.MinimumSize = new System.Drawing.Size(800, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(800, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "(Lehetőleg ékezet nélküle nevet adj meg!)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Server_Name
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nextlbl);
            this.Controls.Add(this.name_box);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.version);
            this.Controls.Add(this.fentiszar);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Server_Name";
            this.Text = "Server_Name";
            this.Load += new System.EventHandler(this.Server_Name_Load);
            this.fentiszar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel fentiszar;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape2;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape3;
        private System.Windows.Forms.Label version;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name_box;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape next_btn;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.Label nextlbl;
        private System.Windows.Forms.Label label2;
    }
}