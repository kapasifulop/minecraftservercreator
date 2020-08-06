namespace mcsc
{
    partial class pl_spigot_bukkit
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
            this.bukkit = new System.Windows.Forms.Button();
            this.spigot = new System.Windows.Forms.Button();
            this.web = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // bukkit
            // 
            this.bukkit.Font = new System.Drawing.Font("Georgia", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bukkit.Location = new System.Drawing.Point(125, 251);
            this.bukkit.Name = "bukkit";
            this.bukkit.Size = new System.Drawing.Size(269, 166);
            this.bukkit.TabIndex = 0;
            this.bukkit.Text = "BUKKIT";
            this.bukkit.UseVisualStyleBackColor = true;
            this.bukkit.Click += new System.EventHandler(this.button1_Click);
            // 
            // spigot
            // 
            this.spigot.Font = new System.Drawing.Font("Georgia", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.spigot.Location = new System.Drawing.Point(552, 251);
            this.spigot.Name = "spigot";
            this.spigot.Size = new System.Drawing.Size(269, 166);
            this.spigot.TabIndex = 1;
            this.spigot.Text = "SPIGOT";
            this.spigot.UseVisualStyleBackColor = true;
            this.spigot.Click += new System.EventHandler(this.button2_Click);
            // 
            // web
            // 
            this.web.AllowWebBrowserDrop = false;
            this.web.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.web.IsWebBrowserContextMenuEnabled = false;
            this.web.Location = new System.Drawing.Point(0, 0);
            this.web.MinimumSize = new System.Drawing.Size(956, 662);
            this.web.Name = "web";
            this.web.ScriptErrorsSuppressed = true;
            this.web.Size = new System.Drawing.Size(956, 662);
            this.web.TabIndex = 2;
            this.web.Visible = false;
            this.web.FileDownload += new System.EventHandler(this.file_dwnload);
            // 
            // pl_spigot_bukkit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.web);
            this.Controls.Add(this.spigot);
            this.Controls.Add(this.bukkit);
            this.MinimumSize = new System.Drawing.Size(959, 665);
            this.Name = "pl_spigot_bukkit";
            this.Size = new System.Drawing.Size(959, 665);
            this.Load += new System.EventHandler(this.pl_spigot_bukkit_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bukkit;
        private System.Windows.Forms.Button spigot;
        private System.Windows.Forms.WebBrowser web;
    }
}
