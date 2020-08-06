namespace mcsc
{
    partial class servers
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.on_beallitasok = new System.Windows.Forms.Panel();
            this.selected_panel = new System.Windows.Forms.Panel();
            this.server_btn = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // on_beallitasok
            // 
            this.on_beallitasok.BackColor = System.Drawing.Color.Yellow;
            this.on_beallitasok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.on_beallitasok.Location = new System.Drawing.Point(-40, 55);
            this.on_beallitasok.Name = "on_beallitasok";
            this.on_beallitasok.Size = new System.Drawing.Size(10, 40);
            this.on_beallitasok.TabIndex = 28;
            // 
            // selected_panel
            // 
            this.selected_panel.BackColor = System.Drawing.Color.Yellow;
            this.selected_panel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selected_panel.Location = new System.Drawing.Point(0, 0);
            this.selected_panel.Name = "selected_panel";
            this.selected_panel.Size = new System.Drawing.Size(10, 40);
            this.selected_panel.TabIndex = 30;
            // 
            // server_btn
            // 
            this.server_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.server_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.server_btn.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.server_btn.FlatAppearance.BorderSize = 0;
            this.server_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.server_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.server_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.server_btn.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.server_btn.ForeColor = System.Drawing.Color.White;
            this.server_btn.Location = new System.Drawing.Point(0, 0);
            this.server_btn.MaximumSize = new System.Drawing.Size(230, 40);
            this.server_btn.MinimumSize = new System.Drawing.Size(230, 40);
            this.server_btn.Name = "server_btn";
            this.server_btn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.server_btn.Size = new System.Drawing.Size(230, 40);
            this.server_btn.TabIndex = 29;
            this.server_btn.Text = "Szerver #1";
            this.server_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.server_btn.UseVisualStyleBackColor = false;
            this.server_btn.Click += new System.EventHandler(this.server_btn_Click);
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(159, 15);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(0, 13);
            this.id.TabIndex = 31;
            this.id.Visible = false;
            // 
            // servers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.id);
            this.Controls.Add(this.selected_panel);
            this.Controls.Add(this.server_btn);
            this.Controls.Add(this.on_beallitasok);
            this.MaximumSize = new System.Drawing.Size(230, 40);
            this.MinimumSize = new System.Drawing.Size(230, 40);
            this.Name = "servers";
            this.Size = new System.Drawing.Size(230, 40);
            this.Load += new System.EventHandler(this.servers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel on_beallitasok;
        private System.Windows.Forms.Panel selected_panel;
        public System.Windows.Forms.Button server_btn;
        public System.Windows.Forms.Label id;
    }
}
