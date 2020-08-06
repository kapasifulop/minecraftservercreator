using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mcsc
{
    public partial class settings : Form
    {
        public settings()
        {
            InitializeComponent();
        }
        String line;
        Boolean allow_nether;
        String gamemode;
        String difficulty;
        Boolean spawn_monsters;
        Boolean pvp;
        Boolean hardcore;
        Boolean command_block;
        int maxplayers;
        Boolean spawn_npcs;
        Boolean allow_flight;
        Boolean spawn_animals;
        Boolean white_list;
        Boolean online;

        List<String> lines_s = new List<string>();

        private void settings_Load(object sender, EventArgs e)
        {
            if (mcsc.Properties.Settings.Default.console_drop == true)
            {
                cns_d_off.Enabled = true;
                cns_d_on.Enabled = false;
                ajanlott.Visible = false;
            }
            else
            {
                cns_d_off.Enabled = false;
                cns_d_on.Enabled = true;
                ajanlott.Visible = true;
            }
            if (File.Exists(@"C:\mcsc\srv\server.properties"))
            {
                StreamReader sr = new StreamReader(@"C:\mcsc\srv\server.properties");

                line = sr.ReadLine();

                while (line != null)
                {
                    lines_s.Add(line);
                    if (line.Contains("allow-nether="))
                    {
                        line = line.Replace("allow-nether=", "");
                        allow_nether = Boolean.Parse(line);
                    }
                    else if (line.Contains("gamemode="))
                    {
                        line = line.Replace("gamemode=", "");
                        gamemode = line;
                    }
                    else if (line.Contains("difficulty="))
                    {
                        line = line.Replace("difficulty=", "");
                        difficulty = line;
                    }
                    else if (line.Contains("spawn-monsters="))
                    {
                        line = line.Replace("spawn-monsters=", "");
                        spawn_monsters = Boolean.Parse(line);
                    }
                    else if (line.Contains("pvp="))
                    {
                        line = line.Replace("pvp=", "");
                        pvp = Boolean.Parse(line);
                    }
                    else if (line.Contains("hardcore="))
                    {
                        line = line.Replace("hardcore=", "");
                        hardcore = Boolean.Parse(line);
                    }
                    else if (line.Contains("enable-command-block="))
                    {
                        line = line.Replace("enable-command-block=", "");
                        command_block = Boolean.Parse(line);
                    }
                    else if (line.Contains("max-players="))
                    {
                        line = line.Replace("max-players=", "");
                        maxplayers = int.Parse(line);
                    }
                    else if (line.Contains("spawn-npcs="))
                    {
                        line = line.Replace("spawn-npcs=", "");
                        spawn_npcs = Boolean.Parse(line);
                    }
                    else if (line.Contains("allow-flight="))
                    {
                        line = line.Replace("allow-flight=", "");
                        allow_flight = Boolean.Parse(line);
                    }
                    else if (line.Contains("spawn-animals="))
                    {
                        line = line.Replace("spawn-animals=", "");
                        spawn_animals = Boolean.Parse(line);
                    }
                    else if (line.Contains("white-list="))
                    {
                        line = line.Replace("white-list=", "");
                        white_list = Boolean.Parse(line);
                    }
                    else if (line.Contains("online-mode="))
                    {
                        line = line.Replace("online-mode=", "");
                        online = Boolean.Parse(line);
                    }
                    line = sr.ReadLine();
                }
                sr.Close();
                if (allow_nether == true)
                {
                    nether_on.Enabled = false;
                    nether_off.Enabled = true;
                }
                else
                {
                    nether_on.Enabled = true;
                    nether_off.Enabled = false;
                }
                gamemode_btns();
                diffy();
                if (spawn_monsters == true)
                {
                    spw_monsters_off.Enabled = true;
                    spw_monsters_on.Enabled = false;
                }
                else
                {
                    spw_monsters_off.Enabled = false;
                    spw_monsters_on.Enabled = true;
                }
                if (pvp == true)
                {
                    pvp_on.Enabled = false;
                    pvp_off.Enabled = true;
                }
                else
                {
                    pvp_on.Enabled = true;
                    pvp_off.Enabled = false;
                }
                if (hardcore == true)
                {
                    hardcore_on.Enabled = false;
                    hardcore_off.Enabled = true;
                }
                else
                {
                    hardcore_on.Enabled = true;
                    hardcore_off.Enabled = false;
                }
                if (command_block == true)
                {
                    cmd_b_on.Enabled = false;
                    cmd_b_off.Enabled = true;
                }
                else
                {
                    cmd_b_on.Enabled = true;
                    cmd_b_off.Enabled = false;
                }
                players.Text = maxplayers.ToString();
                if (spawn_npcs == true)
                {
                    spawn_npcs_on.Enabled = false;
                    spawn_npcs_off.Enabled = true;
                }
                else
                {
                    spawn_npcs_on.Enabled = true;
                    spawn_npcs_off.Enabled = false;
                }
                if (allow_flight == true)
                {
                    flight_on.Enabled = false;
                    flight_off.Enabled = true;
                }
                else
                {
                    flight_on.Enabled = true;
                    flight_off.Enabled = false;
                }
                if (spawn_animals == true)
                {
                    spawn_animals_on.Enabled = false;
                    spawn_animals_off.Enabled = true;
                }
                else
                {
                    spawn_animals_on.Enabled = true;
                    spawn_animals_off.Enabled = false;
                }
                if (white_list == true)
                {
                    whitelist_on.Enabled = false;
                    whitelist_off.Enabled = true;
                }
                else
                {
                    whitelist_on.Enabled = true;
                    whitelist_off.Enabled = false;
                }

                if(online == true)
                {
                    online_on.Enabled = false;
                    online_off.Enabled = true;
                }
                else
                {
                    online_on.Enabled = true;
                    online_off.Enabled = false;
                }

                max_player_ajanlott_txt_beallit();
            }
            else
            {
                //elobb_inditsdel.Visible = true;
            }
        }

        public void max_player_ajanlott_txt_beallit()
        {
            try
            {
                if (int.Parse(players.Text) < mcsc.Properties.Settings.Default.ferohely)
                {
                    ajanlot_max_players.Text = "Jó";
                    ajanlot_max_players.ForeColor = Color.FromArgb(0, 192, 0);
                }
                else if (int.Parse(players.Text) == mcsc.Properties.Settings.Default.ferohely)
                {
                    ajanlot_max_players.Text = "Ajánlott";
                    ajanlot_max_players.ForeColor = Color.FromArgb(0, 192, 0);
                }
                else
                {
                    ajanlot_max_players.Text = "Nem ajánlott";
                    ajanlot_max_players.ForeColor = Color.Red;
                }
            }
            catch { }

        }

        public void gamemode_btns()
        {
            if(gamemode == "0")
            {
                gmmod_cmbox.SelectedItem = "Survival";
            }
            else if(gamemode == "1") {
                gmmod_cmbox.SelectedItem = "Creative";
            }
            else if (gamemode == "3")
            {
                gmmod_cmbox.SelectedItem = "Spectator";
            }
        }

        public void diffy()
        {
            if (difficulty == "peaceful")
            {
                difficulty_cmbox.SelectedItem = "Békés";
            }
            else if (difficulty == "easy")
            {
                difficulty_cmbox.SelectedItem = "Könnyű";
            }
            else if (difficulty == "normal")
            {
                difficulty_cmbox.SelectedItem = "Normál";
            }
            else if (difficulty == "Hard")
            {
                gmmod_cmbox.SelectedItem = "Nehéz";
            }
        }

        private void cns_d_on_Click(object sender, EventArgs e)
        {
            mcsc.Properties.Settings.Default.console_drop = true;
            mcsc.Properties.Settings.Default.Save();
            cns_d_off.Enabled = true;
            cns_d_on.Enabled = false;
            ajanlott.Visible = false;
        }

        private void cns_d_off_Click(object sender, EventArgs e)
        {
            mcsc.Properties.Settings.Default.console_drop = false;
            mcsc.Properties.Settings.Default.Save();
            cns_d_off.Enabled = false;
            cns_d_on.Enabled = true;
            ajanlott.Visible = true;
        }

        private void palyers_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') || (e.KeyChar == '.'))
            {
                e.Handled = true;
            }
            else
            {
                max_player_ajanlott_txt_beallit();
            }
        }

        private void nether_on_Click(object sender, EventArgs e)
        {
            edit_b("allow-nether=", true);
            allow_nether = true;
            nether_off.Enabled = true;
            nether_on.Enabled = false;
        }

        private void nether_off_Click(object sender, EventArgs e)
        {
            edit_b("allow-nether=", false);
            allow_nether = false;
            nether_off.Enabled = false;
            nether_on.Enabled = true;
        }

        private void spw_monsters_on_Click(object sender, EventArgs e)
        {
            edit_b("spawn-monsters=", true);
            spawn_monsters = true;
            spw_monsters_off.Enabled = true;
            spw_monsters_on.Enabled = false;
        }

        private void spw_monsters_off_Click(object sender, EventArgs e)
        {
            edit_b("spawn-monsters=", false);
            spawn_monsters = true;
            spw_monsters_off.Enabled = false;
            spw_monsters_on.Enabled = true;
        }

        public void edit_b(String mod, Boolean bl)
        {
            StreamWriter sw = new StreamWriter(@"C:\mcsc\srv\server.properties");
            foreach (String line in lines_s)
            {
                if (line.Contains(mod))
                {
                    sw.WriteLine(mod + bl.ToString().ToLower());
                }
                else
                {
                    sw.WriteLine(line);
                }
            }
            sw.Close();
        }

        private void pvp_on_Click(object sender, EventArgs e)
        {
            edit_b("pvp=", true);
            pvp = true;
            pvp_off.Enabled = true;
            pvp_on.Enabled = false;
        }

        private void pvp_off_Click(object sender, EventArgs e)
        {
            edit_b("pvp=", false);
            pvp = false;
            pvp_off.Enabled = false;
            pvp_on.Enabled = true;
        }

        private void cmd_b_on_Click(object sender, EventArgs e)
        {
            edit_b("enable-command-block=", true);
            command_block = true;
            cmd_b_off.Enabled = true;
            cmd_b_on.Enabled = false;
        }

        private void cmd_b_off_Click(object sender, EventArgs e)
        {
            edit_b("enable-command-block=", false);
            command_block = false;
            cmd_b_off.Enabled = false;
            cmd_b_on.Enabled = true;
        }

        private void spawn_npcs_on_Click(object sender, EventArgs e)
        {
            edit_b("spawn-npcs=", true);
            spawn_npcs_on.Enabled = false;
            spawn_npcs_off.Enabled = true;
        }

        private void spawn_npcs_off_Click(object sender, EventArgs e)
        {
            edit_b("spawn-npcs=", false);
            spawn_npcs_on.Enabled = true;
            spawn_npcs_off.Enabled = false;
        }

        private void flight_on_Click(object sender, EventArgs e)
        {
            edit_b("allow-flight=", true);
            flight_off.Enabled = true;
            flight_on.Enabled = false;
        }

        private void flight_off_Click(object sender, EventArgs e)
        {
            edit_b("allow-flight=", false);
            flight_off.Enabled = false;
            flight_on.Enabled = true;
        }

        private void spawn_animals_on_Click(object sender, EventArgs e)
        {
            edit_b("spawn-animals=", true);
            spawn_animals_on.Enabled = false;
            spawn_animals_off.Enabled = true;

        }

        private void spawn_animals_off_Click(object sender, EventArgs e)
        {
            edit_b("spawn-animals=", false);
            spawn_animals_on.Enabled = true;
            spawn_animals_off.Enabled = false;
        }

        private void whitelist_on_Click(object sender, EventArgs e)
        {
            edit_b("white-list=", true);
            whitelist_on.Enabled = false;
            whitelist_off.Enabled = true;
        }

        private void whitelist_off_Click(object sender, EventArgs e)
        {
            edit_b("white-list=", false);
            whitelist_on.Enabled = true;
            whitelist_off.Enabled = false;
        }

        private void hardcore_on_Click(object sender, EventArgs e)
        {
            edit_b("hardcore=", true);
            hardcore_on.Enabled = false;
            hardcore_off.Enabled = true;
        }

        private void hardcore_off_Click(object sender, EventArgs e)
        {
            edit_b("hardcore=", false);
            hardcore_on.Enabled = true;
            hardcore_off.Enabled = false;
        }

        private void ajanlott_tru(object sender, EventArgs e)
        {
            ajanlott.Visible = true;
        }

        private void ajanlott_false(object sender, EventArgs e)
        {
            if(mcsc.Properties.Settings.Default.console_drop != false)
            {
                ajanlott.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            edit_b("online-mode=", true);
            online_on.Enabled = false;
            online_off.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            edit_b("online-mode=", false);
            online_on.Enabled = true;
            online_off.Enabled = false;
        }

        private void gmmod_cmbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

