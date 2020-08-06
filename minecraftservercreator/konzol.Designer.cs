namespace minecraftservercreator
{
    partial class konzol
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
            this.console_txbox = new System.Windows.Forms.TextBox();
            this.send = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // console_txbox
            // 
            this.console_txbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.console_txbox.BackColor = System.Drawing.Color.Silver;
            this.console_txbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.console_txbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.console_txbox.ForeColor = System.Drawing.Color.Green;
            this.console_txbox.Location = new System.Drawing.Point(0, 1);
            this.console_txbox.Multiline = true;
            this.console_txbox.Name = "console_txbox";
            this.console_txbox.ReadOnly = true;
            this.console_txbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.console_txbox.Size = new System.Drawing.Size(959, 618);
            this.console_txbox.TabIndex = 0;
            this.console_txbox.TextChanged += new System.EventHandler(this.console_txbox_TextChanged);
            // 
            // send
            // 
            this.send.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.send.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.send.Location = new System.Drawing.Point(0, 625);
            this.send.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.send.MinimumSize = new System.Drawing.Size(959, 38);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(959, 38);
            this.send.TabIndex = 1;
            this.send.TextChanged += new System.EventHandler(this.send_TextChanged);
            this.send.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.key_press);
            // 
            // konzol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(959, 665);
            this.Controls.Add(this.send);
            this.Controls.Add(this.console_txbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(959, 665);
            this.Name = "konzol";
            this.Text = "konzol";
            this.Activated += new System.EventHandler(this.konzol_Load);
            this.Load += new System.EventHandler(this.konzol_Load);
            this.MdiChildActivate += new System.EventHandler(this.konzol_Load);
            this.Shown += new System.EventHandler(this.konzol_Load);
            this.VisibleChanged += new System.EventHandler(this.konzol_Load);
            this.Enter += new System.EventHandler(this.konzol_Load);
            this.Move += new System.EventHandler(this.konzol_Load);
            this.StyleChanged += new System.EventHandler(this.konzol_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox send;
        public System.Windows.Forms.TextBox console_txbox;
    }
}