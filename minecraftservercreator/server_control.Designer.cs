namespace mcsc
{
    partial class server_control
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(server_control));
            this.panel1 = new System.Windows.Forms.Panel();
            this.start_btn = new System.Windows.Forms.Button();
            this.settings_btn = new System.Windows.Forms.Button();
            this.konzol = new System.Windows.Forms.Button();
            this.srv_name_lbl = new System.Windows.Forms.Label();
            this.panelplayer = new System.Windows.Forms.Panel();
            this.server_loc = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.start_btn);
            this.panel1.Controls.Add(this.settings_btn);
            this.panel1.Controls.Add(this.konzol);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(959, 70);
            this.panel1.TabIndex = 0;
            // 
            // start_btn
            // 
            this.start_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.start_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.start_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.start_btn.Location = new System.Drawing.Point(390, 0);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(128, 70);
            this.start_btn.TabIndex = 0;
            this.start_btn.UseVisualStyleBackColor = true;
            this.start_btn.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // settings_btn
            // 
            this.settings_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.settings_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settings_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.settings_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.settings_btn.Location = new System.Drawing.Point(850, 0);
            this.settings_btn.Name = "settings_btn";
            this.settings_btn.Size = new System.Drawing.Size(109, 70);
            this.settings_btn.TabIndex = 2;
            this.settings_btn.Text = "BEÁLLÍTÁSOK";
            this.settings_btn.UseVisualStyleBackColor = true;
            this.settings_btn.Click += new System.EventHandler(this.settings_btn_Click);
            // 
            // konzol
            // 
            this.konzol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.konzol.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.konzol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.konzol.Location = new System.Drawing.Point(0, 0);
            this.konzol.Name = "konzol";
            this.konzol.Size = new System.Drawing.Size(109, 70);
            this.konzol.TabIndex = 0;
            this.konzol.Text = "KONZOL";
            this.konzol.UseVisualStyleBackColor = true;
            this.konzol.Click += new System.EventHandler(this.konzol_Click);
            // 
            // srv_name_lbl
            // 
            this.srv_name_lbl.AutoSize = true;
            this.srv_name_lbl.BackColor = System.Drawing.Color.Silver;
            this.srv_name_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.srv_name_lbl.Location = new System.Drawing.Point(0, 74);
            this.srv_name_lbl.MinimumSize = new System.Drawing.Size(959, 55);
            this.srv_name_lbl.Name = "srv_name_lbl";
            this.srv_name_lbl.Size = new System.Drawing.Size(959, 55);
            this.srv_name_lbl.TabIndex = 1;
            this.srv_name_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelplayer
            // 
            this.panelplayer.BackColor = System.Drawing.Color.Silver;
            this.panelplayer.Location = new System.Drawing.Point(0, 131);
            this.panelplayer.Name = "panelplayer";
            this.panelplayer.Size = new System.Drawing.Size(959, 533);
            this.panelplayer.TabIndex = 2;
            // 
            // server_loc
            // 
            this.server_loc.AutoSize = true;
            this.server_loc.BackColor = System.Drawing.Color.Silver;
            this.server_loc.Location = new System.Drawing.Point(7, 115);
            this.server_loc.Name = "server_loc";
            this.server_loc.Size = new System.Drawing.Size(166, 13);
            this.server_loc.TabIndex = 3;
            this.server_loc.Text = "A szerver helye C:\\mcsc\\servers\\";
            // 
            // server_control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(959, 665);
            this.Controls.Add(this.server_loc);
            this.Controls.Add(this.panelplayer);
            this.Controls.Add(this.srv_name_lbl);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(959, 665);
            this.Name = "server_control";
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.server_control_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label srv_name_lbl;
        private System.Windows.Forms.Button konzol;
        private System.Windows.Forms.Button settings_btn;
        private System.Windows.Forms.Panel panelplayer;
        public System.Windows.Forms.Button start_btn;
        private System.Windows.Forms.Label server_loc;
    }
}