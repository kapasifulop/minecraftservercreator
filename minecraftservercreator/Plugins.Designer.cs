namespace mcsc
{
    partial class Plugins
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
            this.pl_spigot_bukkit1 = new mcsc.pl_spigot_bukkit();
            this.SuspendLayout();
            // 
            // pl_spigot_bukkit1
            // 
            this.pl_spigot_bukkit1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pl_spigot_bukkit1.Location = new System.Drawing.Point(0, 0);
            this.pl_spigot_bukkit1.MinimumSize = new System.Drawing.Size(959, 665);
            this.pl_spigot_bukkit1.Name = "pl_spigot_bukkit1";
            this.pl_spigot_bukkit1.Size = new System.Drawing.Size(959, 665);
            this.pl_spigot_bukkit1.TabIndex = 0;
            this.pl_spigot_bukkit1.Load += new System.EventHandler(this.pl_spigot_bukkit1_Load);
            // 
            // Plugins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(959, 665);
            this.Controls.Add(this.pl_spigot_bukkit1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(959, 665);
            this.Name = "Plugins";
            this.Text = "Plugins";
            this.ResumeLayout(false);

        }

        #endregion

        private pl_spigot_bukkit pl_spigot_bukkit1;
    }
}