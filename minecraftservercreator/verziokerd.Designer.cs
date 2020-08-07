namespace minecraftservercreator
{
    partial class verziokerd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(verziokerd));
            this.text_long = new System.Windows.Forms.Label();
            this.recommented = new System.Windows.Forms.Label();
            this.not_recommented = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.under = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // text_long
            // 
            this.text_long.AutoSize = true;
            this.text_long.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.text_long.Location = new System.Drawing.Point(12, 9);
            this.text_long.MaximumSize = new System.Drawing.Size(625, 54);
            this.text_long.Name = "text_long";
            this.text_long.Size = new System.Drawing.Size(625, 54);
            this.text_long.TabIndex = 0;
            this.text_long.Text = resources.GetString("text_long.Text");
            this.text_long.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // recommented
            // 
            this.recommented.AutoSize = true;
            this.recommented.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.recommented.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.recommented.Location = new System.Drawing.Point(12, 81);
            this.recommented.Name = "recommented";
            this.recommented.Size = new System.Drawing.Size(262, 150);
            this.recommented.TabIndex = 1;
            this.recommented.Text = "Ajánlott verziók: 1.14.4\r\n                          1.14.3\r\n                     " +
    "     1.14.2\r\n                          1.14\r\n                          1.12.2\r\n " +
    "                         1.12";
            // 
            // not_recommented
            // 
            this.not_recommented.AutoSize = true;
            this.not_recommented.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.not_recommented.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.not_recommented.Location = new System.Drawing.Point(301, 81);
            this.not_recommented.Name = "not_recommented";
            this.not_recommented.Size = new System.Drawing.Size(287, 23);
            this.not_recommented.TabIndex = 2;
            this.not_recommented.Text = "Nem ajánlott verziók: 1.16.1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 14.25F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(515, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "1.15";
            // 
            // under
            // 
            this.under.AutoSize = true;
            this.under.Font = new System.Drawing.Font("Verdana", 14.25F);
            this.under.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.under.Location = new System.Drawing.Point(486, 150);
            this.under.Name = "under";
            this.under.Size = new System.Drawing.Size(130, 23);
            this.under.TabIndex = 4;
            this.under.Text = "1.12 alattiak";
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(0, 286);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(641, 64);
            this.button1.TabIndex = 5;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 14.25F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(505, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 23);
            this.label6.TabIndex = 6;
            this.label6.Text = "1.15.2";
            // 
            // verziokerd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(641, 350);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.under);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.not_recommented);
            this.Controls.Add(this.recommented);
            this.Controls.Add(this.text_long);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "verziokerd";
            this.Text = "Mit válasszak verziónak?";
            this.Load += new System.EventHandler(this.verziokerd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label text_long;
        private System.Windows.Forms.Label recommented;
        private System.Windows.Forms.Label not_recommented;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label under;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
    }
}