namespace minecraftservercreator
{
    partial class agykerd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(agykerd));
            this.txt_box = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_box
            // 
            this.txt_box.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_box.AutoSize = true;
            this.txt_box.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txt_box.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txt_box.ForeColor = System.Drawing.Color.Maroon;
            this.txt_box.Location = new System.Drawing.Point(12, 9);
            this.txt_box.MaximumSize = new System.Drawing.Size(636, 270);
            this.txt_box.Name = "txt_box";
            this.txt_box.Size = new System.Drawing.Size(636, 270);
            this.txt_box.TabIndex = 0;
            this.txt_box.Text = resources.GetString("txt_box.Text");
            this.txt_box.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(0, 309);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(654, 42);
            this.button1.TabIndex = 1;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // agykerd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(654, 351);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_box);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "agykerd";
            this.Text = "Mit válasszak agynak. És mi is az..?";
            this.Load += new System.EventHandler(this.agykerd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txt_box;
        private System.Windows.Forms.Button button1;
    }
}