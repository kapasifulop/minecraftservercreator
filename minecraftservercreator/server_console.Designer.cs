namespace mcsc
{
    partial class server_console
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
            this.console_txtbox = new System.Windows.Forms.TextBox();
            this.send = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // console_txtbox
            // 
            this.console_txtbox.Dock = System.Windows.Forms.DockStyle.Top;
            this.console_txtbox.Location = new System.Drawing.Point(0, 0);
            this.console_txtbox.Multiline = true;
            this.console_txtbox.Name = "console_txtbox";
            this.console_txtbox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.console_txtbox.Size = new System.Drawing.Size(959, 505);
            this.console_txtbox.TabIndex = 0;
            // 
            // send
            // 
            this.send.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.send.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.send.Location = new System.Drawing.Point(0, 511);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(959, 22);
            this.send.TabIndex = 1;
            this.send.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.send.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.key_press);
            // 
            // server_console
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 533);
            this.Controls.Add(this.send);
            this.Controls.Add(this.console_txtbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "server_console";
            this.Load += new System.EventHandler(this.server_console_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox send;
        public System.Windows.Forms.TextBox console_txtbox;
    }
}