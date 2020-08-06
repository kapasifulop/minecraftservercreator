namespace mcsc
{
    partial class settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(settings));
            this.label1 = new System.Windows.Forms.Label();
            this.cns_d_on = new System.Windows.Forms.Button();
            this.cns_d_off = new System.Windows.Forms.Button();
            this.knz_kulon = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nether_off = new System.Windows.Forms.Button();
            this.nether_on = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.spw_monsters_off = new System.Windows.Forms.Button();
            this.spw_monsters_on = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.pvp_off = new System.Windows.Forms.Button();
            this.pvp_on = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cmd_b_off = new System.Windows.Forms.Button();
            this.cmd_b_on = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.spawn_npcs_off = new System.Windows.Forms.Button();
            this.spawn_npcs_on = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.whitelist_off = new System.Windows.Forms.Button();
            this.whitelist_on = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.spawn_animals_off = new System.Windows.Forms.Button();
            this.spawn_animals_on = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.flight_off = new System.Windows.Forms.Button();
            this.flight_on = new System.Windows.Forms.Button();
            this.players = new System.Windows.Forms.TextBox();
            this.gmmod_cmbox = new System.Windows.Forms.ComboBox();
            this.difficulty_cmbox = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.hardcore_off = new System.Windows.Forms.Button();
            this.hardcore_on = new System.Windows.Forms.Button();
            this.ajanlott = new System.Windows.Forms.Label();
            this.ajanlot_max_players = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.online_off = new System.Windows.Forms.Button();
            this.online_on = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(333, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alkalmazás Beállítások";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cns_d_on
            // 
            this.cns_d_on.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cns_d_on.Location = new System.Drawing.Point(64, 105);
            this.cns_d_on.Name = "cns_d_on";
            this.cns_d_on.Size = new System.Drawing.Size(75, 23);
            this.cns_d_on.TabIndex = 1;
            this.cns_d_on.Text = "BE";
            this.cns_d_on.UseVisualStyleBackColor = true;
            this.cns_d_on.Click += new System.EventHandler(this.cns_d_on_Click);
            // 
            // cns_d_off
            // 
            this.cns_d_off.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cns_d_off.Location = new System.Drawing.Point(168, 105);
            this.cns_d_off.Name = "cns_d_off";
            this.cns_d_off.Size = new System.Drawing.Size(75, 23);
            this.cns_d_off.TabIndex = 2;
            this.cns_d_off.Text = "KI";
            this.cns_d_off.UseVisualStyleBackColor = true;
            this.cns_d_off.Click += new System.EventHandler(this.cns_d_off_Click);
            this.cns_d_off.MouseLeave += new System.EventHandler(this.ajanlott_false);
            this.cns_d_off.MouseHover += new System.EventHandler(this.ajanlott_tru);
            // 
            // knz_kulon
            // 
            this.knz_kulon.Location = new System.Drawing.Point(61, 79);
            this.knz_kulon.MinimumSize = new System.Drawing.Size(100, 23);
            this.knz_kulon.Name = "knz_kulon";
            this.knz_kulon.Size = new System.Drawing.Size(182, 23);
            this.knz_kulon.TabIndex = 3;
            this.knz_kulon.Text = "Minecraft konzol külön ablakban";
            this.knz_kulon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(361, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Szerver Beállítások";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(104, 213);
            this.label3.MinimumSize = new System.Drawing.Size(100, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nether";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nether_off
            // 
            this.nether_off.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nether_off.Location = new System.Drawing.Point(168, 239);
            this.nether_off.Name = "nether_off";
            this.nether_off.Size = new System.Drawing.Size(75, 23);
            this.nether_off.TabIndex = 6;
            this.nether_off.Text = "KI";
            this.nether_off.UseVisualStyleBackColor = true;
            this.nether_off.Click += new System.EventHandler(this.nether_off_Click);
            // 
            // nether_on
            // 
            this.nether_on.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nether_on.Location = new System.Drawing.Point(64, 239);
            this.nether_on.Name = "nether_on";
            this.nether_on.Size = new System.Drawing.Size(75, 23);
            this.nether_on.TabIndex = 5;
            this.nether_on.Text = "BE";
            this.nether_on.UseVisualStyleBackColor = true;
            this.nether_on.Click += new System.EventHandler(this.nether_on_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(104, 279);
            this.label4.MinimumSize = new System.Drawing.Size(100, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Gamemode";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(104, 350);
            this.label5.MinimumSize = new System.Drawing.Size(100, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 13;
            this.label5.Text = "Nehézség";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(104, 419);
            this.label6.MinimumSize = new System.Drawing.Size(100, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 16;
            this.label6.Text = "Szörnyek leidézése";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // spw_monsters_off
            // 
            this.spw_monsters_off.Cursor = System.Windows.Forms.Cursors.Hand;
            this.spw_monsters_off.Location = new System.Drawing.Point(168, 445);
            this.spw_monsters_off.Name = "spw_monsters_off";
            this.spw_monsters_off.Size = new System.Drawing.Size(75, 23);
            this.spw_monsters_off.TabIndex = 15;
            this.spw_monsters_off.Text = "KI";
            this.spw_monsters_off.UseVisualStyleBackColor = true;
            this.spw_monsters_off.Click += new System.EventHandler(this.spw_monsters_off_Click);
            // 
            // spw_monsters_on
            // 
            this.spw_monsters_on.Cursor = System.Windows.Forms.Cursors.Hand;
            this.spw_monsters_on.Location = new System.Drawing.Point(64, 445);
            this.spw_monsters_on.Name = "spw_monsters_on";
            this.spw_monsters_on.Size = new System.Drawing.Size(75, 23);
            this.spw_monsters_on.TabIndex = 14;
            this.spw_monsters_on.Text = "BE";
            this.spw_monsters_on.UseVisualStyleBackColor = true;
            this.spw_monsters_on.Click += new System.EventHandler(this.spw_monsters_on_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.Location = new System.Drawing.Point(427, 213);
            this.label7.MinimumSize = new System.Drawing.Size(100, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 19;
            this.label7.Text = "PVP";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pvp_off
            // 
            this.pvp_off.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pvp_off.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pvp_off.Location = new System.Drawing.Point(491, 239);
            this.pvp_off.Name = "pvp_off";
            this.pvp_off.Size = new System.Drawing.Size(75, 23);
            this.pvp_off.TabIndex = 18;
            this.pvp_off.Text = "KI";
            this.pvp_off.UseVisualStyleBackColor = true;
            this.pvp_off.Click += new System.EventHandler(this.pvp_off_Click);
            // 
            // pvp_on
            // 
            this.pvp_on.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pvp_on.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pvp_on.Location = new System.Drawing.Point(387, 239);
            this.pvp_on.Name = "pvp_on";
            this.pvp_on.Size = new System.Drawing.Size(75, 23);
            this.pvp_on.TabIndex = 17;
            this.pvp_on.Text = "BE";
            this.pvp_on.UseVisualStyleBackColor = true;
            this.pvp_on.Click += new System.EventHandler(this.pvp_on_Click);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.Location = new System.Drawing.Point(427, 279);
            this.label8.MinimumSize = new System.Drawing.Size(100, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 23);
            this.label8.TabIndex = 22;
            this.label8.Text = "Command block";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmd_b_off
            // 
            this.cmd_b_off.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmd_b_off.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmd_b_off.Location = new System.Drawing.Point(491, 305);
            this.cmd_b_off.Name = "cmd_b_off";
            this.cmd_b_off.Size = new System.Drawing.Size(75, 23);
            this.cmd_b_off.TabIndex = 21;
            this.cmd_b_off.Text = "KI";
            this.cmd_b_off.UseVisualStyleBackColor = true;
            this.cmd_b_off.Click += new System.EventHandler(this.cmd_b_off_Click);
            // 
            // cmd_b_on
            // 
            this.cmd_b_on.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmd_b_on.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmd_b_on.Location = new System.Drawing.Point(387, 305);
            this.cmd_b_on.Name = "cmd_b_on";
            this.cmd_b_on.Size = new System.Drawing.Size(75, 23);
            this.cmd_b_on.TabIndex = 20;
            this.cmd_b_on.Text = "BE";
            this.cmd_b_on.UseVisualStyleBackColor = true;
            this.cmd_b_on.Click += new System.EventHandler(this.cmd_b_on_Click);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.Location = new System.Drawing.Point(427, 340);
            this.label9.MinimumSize = new System.Drawing.Size(100, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 23);
            this.label9.TabIndex = 25;
            this.label9.Text = "Maximum játékosok";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.Location = new System.Drawing.Point(427, 419);
            this.label10.MinimumSize = new System.Drawing.Size(100, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 23);
            this.label10.TabIndex = 28;
            this.label10.Text = "NPC-k leidézése";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // spawn_npcs_off
            // 
            this.spawn_npcs_off.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.spawn_npcs_off.Cursor = System.Windows.Forms.Cursors.Hand;
            this.spawn_npcs_off.Location = new System.Drawing.Point(491, 445);
            this.spawn_npcs_off.Name = "spawn_npcs_off";
            this.spawn_npcs_off.Size = new System.Drawing.Size(75, 23);
            this.spawn_npcs_off.TabIndex = 27;
            this.spawn_npcs_off.Text = "KI";
            this.spawn_npcs_off.UseVisualStyleBackColor = true;
            this.spawn_npcs_off.Click += new System.EventHandler(this.spawn_npcs_off_Click);
            // 
            // spawn_npcs_on
            // 
            this.spawn_npcs_on.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.spawn_npcs_on.Cursor = System.Windows.Forms.Cursors.Hand;
            this.spawn_npcs_on.Location = new System.Drawing.Point(387, 445);
            this.spawn_npcs_on.Name = "spawn_npcs_on";
            this.spawn_npcs_on.Size = new System.Drawing.Size(75, 23);
            this.spawn_npcs_on.TabIndex = 26;
            this.spawn_npcs_on.Text = "BE";
            this.spawn_npcs_on.UseVisualStyleBackColor = true;
            this.spawn_npcs_on.Click += new System.EventHandler(this.spawn_npcs_on_Click);
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.Location = new System.Drawing.Point(729, 340);
            this.label12.MinimumSize = new System.Drawing.Size(100, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 23);
            this.label12.TabIndex = 37;
            this.label12.Text = "Fehérlista";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // whitelist_off
            // 
            this.whitelist_off.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.whitelist_off.Cursor = System.Windows.Forms.Cursors.Hand;
            this.whitelist_off.Location = new System.Drawing.Point(793, 366);
            this.whitelist_off.Name = "whitelist_off";
            this.whitelist_off.Size = new System.Drawing.Size(75, 23);
            this.whitelist_off.TabIndex = 36;
            this.whitelist_off.Text = "KI";
            this.whitelist_off.UseVisualStyleBackColor = true;
            this.whitelist_off.Click += new System.EventHandler(this.whitelist_off_Click);
            // 
            // whitelist_on
            // 
            this.whitelist_on.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.whitelist_on.Cursor = System.Windows.Forms.Cursors.Hand;
            this.whitelist_on.Location = new System.Drawing.Point(689, 366);
            this.whitelist_on.Name = "whitelist_on";
            this.whitelist_on.Size = new System.Drawing.Size(75, 23);
            this.whitelist_on.TabIndex = 35;
            this.whitelist_on.Text = "BE";
            this.whitelist_on.UseVisualStyleBackColor = true;
            this.whitelist_on.Click += new System.EventHandler(this.whitelist_on_Click);
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.Location = new System.Drawing.Point(729, 279);
            this.label13.MinimumSize = new System.Drawing.Size(100, 23);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 23);
            this.label13.TabIndex = 34;
            this.label13.Text = "Állatok leidézése";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // spawn_animals_off
            // 
            this.spawn_animals_off.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.spawn_animals_off.Cursor = System.Windows.Forms.Cursors.Hand;
            this.spawn_animals_off.Location = new System.Drawing.Point(793, 305);
            this.spawn_animals_off.Name = "spawn_animals_off";
            this.spawn_animals_off.Size = new System.Drawing.Size(75, 23);
            this.spawn_animals_off.TabIndex = 33;
            this.spawn_animals_off.Text = "KI";
            this.spawn_animals_off.UseVisualStyleBackColor = true;
            this.spawn_animals_off.Click += new System.EventHandler(this.spawn_animals_off_Click);
            // 
            // spawn_animals_on
            // 
            this.spawn_animals_on.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.spawn_animals_on.Cursor = System.Windows.Forms.Cursors.Hand;
            this.spawn_animals_on.Location = new System.Drawing.Point(689, 305);
            this.spawn_animals_on.Name = "spawn_animals_on";
            this.spawn_animals_on.Size = new System.Drawing.Size(75, 23);
            this.spawn_animals_on.TabIndex = 32;
            this.spawn_animals_on.Text = "BE";
            this.spawn_animals_on.UseVisualStyleBackColor = true;
            this.spawn_animals_on.Click += new System.EventHandler(this.spawn_animals_on_Click);
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.Location = new System.Drawing.Point(729, 213);
            this.label14.MinimumSize = new System.Drawing.Size(100, 23);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 23);
            this.label14.TabIndex = 31;
            this.label14.Text = "Repülés";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flight_off
            // 
            this.flight_off.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flight_off.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flight_off.Location = new System.Drawing.Point(793, 239);
            this.flight_off.Name = "flight_off";
            this.flight_off.Size = new System.Drawing.Size(75, 23);
            this.flight_off.TabIndex = 30;
            this.flight_off.Text = "KI";
            this.flight_off.UseVisualStyleBackColor = true;
            this.flight_off.Click += new System.EventHandler(this.flight_off_Click);
            // 
            // flight_on
            // 
            this.flight_on.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flight_on.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flight_on.Location = new System.Drawing.Point(689, 239);
            this.flight_on.Name = "flight_on";
            this.flight_on.Size = new System.Drawing.Size(75, 23);
            this.flight_on.TabIndex = 29;
            this.flight_on.Text = "BE";
            this.flight_on.UseVisualStyleBackColor = true;
            this.flight_on.Click += new System.EventHandler(this.flight_on_Click);
            // 
            // players
            // 
            this.players.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.players.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.players.Location = new System.Drawing.Point(444, 369);
            this.players.MaxLength = 10;
            this.players.Name = "players";
            this.players.Size = new System.Drawing.Size(59, 20);
            this.players.TabIndex = 38;
            this.players.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.players.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.palyers_KeyPress);
            // 
            // gmmod_cmbox
            // 
            this.gmmod_cmbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gmmod_cmbox.FormattingEnabled = true;
            this.gmmod_cmbox.Items.AddRange(new object[] {
            "Survival",
            "Creative",
            "Spectator"});
            this.gmmod_cmbox.Location = new System.Drawing.Point(94, 307);
            this.gmmod_cmbox.Name = "gmmod_cmbox";
            this.gmmod_cmbox.Size = new System.Drawing.Size(121, 21);
            this.gmmod_cmbox.TabIndex = 39;
            this.gmmod_cmbox.SelectedIndexChanged += new System.EventHandler(this.gmmod_cmbox_SelectedIndexChanged);
            // 
            // difficulty_cmbox
            // 
            this.difficulty_cmbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.difficulty_cmbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.difficulty_cmbox.FormattingEnabled = true;
            this.difficulty_cmbox.Items.AddRange(new object[] {
            "Békés",
            "Könnyű",
            "Normál",
            "Nehéz"});
            this.difficulty_cmbox.Location = new System.Drawing.Point(94, 376);
            this.difficulty_cmbox.Name = "difficulty_cmbox";
            this.difficulty_cmbox.Size = new System.Drawing.Size(121, 21);
            this.difficulty_cmbox.TabIndex = 40;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.Location = new System.Drawing.Point(729, 419);
            this.label11.MinimumSize = new System.Drawing.Size(100, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 23);
            this.label11.TabIndex = 43;
            this.label11.Text = "Hardcore";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hardcore_off
            // 
            this.hardcore_off.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.hardcore_off.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hardcore_off.Location = new System.Drawing.Point(793, 445);
            this.hardcore_off.Name = "hardcore_off";
            this.hardcore_off.Size = new System.Drawing.Size(75, 23);
            this.hardcore_off.TabIndex = 42;
            this.hardcore_off.Text = "KI";
            this.hardcore_off.UseVisualStyleBackColor = true;
            this.hardcore_off.Click += new System.EventHandler(this.hardcore_off_Click);
            // 
            // hardcore_on
            // 
            this.hardcore_on.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.hardcore_on.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hardcore_on.Location = new System.Drawing.Point(689, 445);
            this.hardcore_on.Name = "hardcore_on";
            this.hardcore_on.Size = new System.Drawing.Size(75, 23);
            this.hardcore_on.TabIndex = 41;
            this.hardcore_on.Text = "BE";
            this.hardcore_on.UseVisualStyleBackColor = true;
            this.hardcore_on.Click += new System.EventHandler(this.hardcore_on_Click);
            // 
            // ajanlott
            // 
            this.ajanlott.AutoSize = true;
            this.ajanlott.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ajanlott.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ajanlott.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ajanlott.Location = new System.Drawing.Point(172, 131);
            this.ajanlott.MinimumSize = new System.Drawing.Size(71, 24);
            this.ajanlott.Name = "ajanlott";
            this.ajanlott.Size = new System.Drawing.Size(71, 24);
            this.ajanlott.TabIndex = 44;
            this.ajanlott.Text = "Ajánlott";
            // 
            // ajanlot_max_players
            // 
            this.ajanlot_max_players.AutoSize = true;
            this.ajanlot_max_players.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ajanlot_max_players.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ajanlot_max_players.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ajanlot_max_players.Location = new System.Drawing.Point(440, 395);
            this.ajanlot_max_players.MinimumSize = new System.Drawing.Size(71, 24);
            this.ajanlot_max_players.Name = "ajanlot_max_players";
            this.ajanlot_max_players.Size = new System.Drawing.Size(71, 24);
            this.ajanlot_max_players.TabIndex = 45;
            this.ajanlot_max_players.Text = "Ajánlott";
            this.ajanlot_max_players.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label15.Location = new System.Drawing.Point(427, 479);
            this.label15.MinimumSize = new System.Drawing.Size(100, 23);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 23);
            this.label15.TabIndex = 49;
            this.label15.Text = "Krekkelt";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // online_off
            // 
            this.online_off.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.online_off.Cursor = System.Windows.Forms.Cursors.Hand;
            this.online_off.Location = new System.Drawing.Point(387, 505);
            this.online_off.Name = "online_off";
            this.online_off.Size = new System.Drawing.Size(75, 23);
            this.online_off.TabIndex = 48;
            this.online_off.Text = "BE";
            this.online_off.UseVisualStyleBackColor = true;
            this.online_off.Click += new System.EventHandler(this.button1_Click);
            // 
            // online_on
            // 
            this.online_on.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.online_on.Cursor = System.Windows.Forms.Cursors.Hand;
            this.online_on.Location = new System.Drawing.Point(491, 505);
            this.online_on.Name = "online_on";
            this.online_on.Size = new System.Drawing.Size(75, 23);
            this.online_on.TabIndex = 47;
            this.online_on.Text = "KI";
            this.online_on.UseVisualStyleBackColor = true;
            this.online_on.Click += new System.EventHandler(this.button2_Click);
            // 
            // settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(959, 665);
            this.ControlBox = false;
            this.Controls.Add(this.label15);
            this.Controls.Add(this.online_off);
            this.Controls.Add(this.online_on);
            this.Controls.Add(this.ajanlot_max_players);
            this.Controls.Add(this.ajanlott);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.hardcore_off);
            this.Controls.Add(this.hardcore_on);
            this.Controls.Add(this.difficulty_cmbox);
            this.Controls.Add(this.gmmod_cmbox);
            this.Controls.Add(this.players);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.whitelist_off);
            this.Controls.Add(this.whitelist_on);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.spawn_animals_off);
            this.Controls.Add(this.spawn_animals_on);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.flight_off);
            this.Controls.Add(this.flight_on);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.spawn_npcs_off);
            this.Controls.Add(this.spawn_npcs_on);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmd_b_off);
            this.Controls.Add(this.cmd_b_on);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pvp_off);
            this.Controls.Add(this.pvp_on);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.spw_monsters_off);
            this.Controls.Add(this.spw_monsters_on);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nether_off);
            this.Controls.Add(this.nether_on);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.knz_kulon);
            this.Controls.Add(this.cns_d_off);
            this.Controls.Add(this.cns_d_on);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(959, 665);
            this.Name = "settings";
            this.Text = "settings";
            this.Load += new System.EventHandler(this.settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cns_d_on;
        private System.Windows.Forms.Button cns_d_off;
        private System.Windows.Forms.Label knz_kulon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button nether_off;
        private System.Windows.Forms.Button nether_on;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button spw_monsters_off;
        private System.Windows.Forms.Button spw_monsters_on;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button pvp_off;
        private System.Windows.Forms.Button pvp_on;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button cmd_b_off;
        private System.Windows.Forms.Button cmd_b_on;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button spawn_npcs_off;
        private System.Windows.Forms.Button spawn_npcs_on;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button whitelist_off;
        private System.Windows.Forms.Button whitelist_on;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button spawn_animals_off;
        private System.Windows.Forms.Button spawn_animals_on;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button flight_off;
        private System.Windows.Forms.Button flight_on;
        private System.Windows.Forms.TextBox players;
        private System.Windows.Forms.ComboBox gmmod_cmbox;
        private System.Windows.Forms.ComboBox difficulty_cmbox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button hardcore_off;
        private System.Windows.Forms.Button hardcore_on;
        private System.Windows.Forms.Label ajanlott;
        private System.Windows.Forms.Label ajanlot_max_players;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button online_off;
        private System.Windows.Forms.Button online_on;
    }
}