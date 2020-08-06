using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mcsc
{
    public partial class server_settings : Form
    {
        int id;
        string name;
        string dir;

        String line;

        List<String> lines_s = new List<string>();


        //SERVER SETTINGS ->
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
        // <-

        //SET VARIABLES VALUES

        public server_settings(int _id, string _name, string _dir)
        {
            InitializeComponent();
            id = _id;
            name = _name;
            dir = _dir;
        }

        //ON FORM LOADED

        private void server_settings_Load(object sender, EventArgs e)
        {
            betolt_settings();
        }

        //LOAD SERVER SETTINGS

        public void betolt_settings()
        {
            rfs_txtbox.Text = mcsc.Properties.Settings.Default.rfs.ToString();
            if (File.Exists(dir + @"\server.properties"))
            {
                elobb_inditsdel.Visible = false;
                StreamReader sr = new StreamReader(dir + @"\server.properties");

                line = sr.ReadLine();

                while (line != null)
                {
                    lines_s.Add(line);
                    if (line.Contains("allow-nether="))
                    {
                        line = line.Replace("allow-nether=", "");
                        allow_nether = Boolean.Parse(line);
                    }
                    else if (line.Contains("gamemode=") && !line.Contains("force-gamemode="))
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

                //SET VALUES
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
                //MessageBox.Show("#152");
                gamemode_btns();
                //MessageBox.Show("#154");
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

                if (online == true)
                {
                    online_on.Enabled = false;
                    online_off.Enabled = true;
                }
                else
                {
                    online_on.Enabled = true;
                    online_off.Enabled = false;
                }
                //MessageBox.Show("#251");
                //max_player_ajanlott_txt_beallit();
            }
            else
            {
                //elobb_inditsdel.Visible = true;
            }
        }

        public void gamemode_btns()
        {
            if(gamemode == "0")
            {
                gmmod_cmbox.SelectedItem = "survival";
            }
            else if(gamemode == "1")
            {
                gmmod_cmbox.SelectedItem = "creative";
            } else if(gamemode == "3") 
            {
                gmmod_cmbox.SelectedItem = "spectator";
            }
            else
            {
                gmmod_cmbox.SelectedItem = gamemode;
            }
        }

        public void diffy()
        {
            difficulty_cmbox.SelectedItem = difficulty;
        }

        //IF ANY SETTINGS BUTTON CLICK

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

        private void cracked_off_Click(object sender, EventArgs e)
        {
            edit_b("online-mode=", true);
            online_on.Enabled = false;
            online_off.Enabled = true;
        }

        private void cracked_on_Click(object sender, EventArgs e)
        {
            edit_b("online-mode=", false);
            online_on.Enabled = true;
            online_off.Enabled = false;
        }

        //EDIT SETTINGS VOID

        public void edit_b(String mod, Boolean bl)
        {
            StreamWriter sw = new StreamWriter(dir + @"\server.properties");
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

        private async void palyers_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13)
            {
                StreamWriter sw = new StreamWriter(dir + @"\server.properties");
                foreach (String line in lines_s)
                {
                    if (line.Contains("max-players="))
                    {
                        sw.WriteLine("max-players=" + players.Text);
                    }
                    else
                    {
                        sw.WriteLine(line);
                    }
                }
                sw.Close();
                mth.Text = "Mentve";
                mth.ForeColor = Color.Green;
                await Task.Delay(1000);
                mth.Visible = false;
            }
            else if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') || (e.KeyChar == '.'))
            {
                e.Handled = true;
            }
            else
            {
                mth.Text = "A mentéshez nyomja meg az Enter-t";
                mth.ForeColor = Color.Red;
                mth.Visible = true;
            }

        }

        private void gmmod_cmbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            string val = "";
            if (gmmod_cmbox.Text == "survival")val = "0";
            else if (gmmod_cmbox.Text == "creative") val = "1";
            else if (gmmod_cmbox.Text == "spectator") val = "3";
            */
            for_c_box("gamemode=", gmmod_cmbox.Text);
        }

        private void difficulty_cmbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            for_c_box("difficulty=", difficulty_cmbox.Text);
        }

        public void for_c_box(string fs, string value)
        {
            StreamWriter sw = new StreamWriter(dir + @"\server.properties");
            foreach (String line in lines_s)
            {
                if (line.Contains(fs) && !line.Contains("force-gamemode="))
                {
                    sw.WriteLine(fs + value);
                }
                else
                {
                    sw.WriteLine(line);
                }
            }
            sw.Close();
        }

        public int memoria()
        {
            //
            ////Memória méret betöltése
            //
            ObjectQuery wql = new ObjectQuery("SELECT * FROM Win32_OperatingSystem");
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(wql);
            ManagementObjectCollection results = searcher.Get();

            string memorytotal = "0";

            foreach (ManagementObject result in results)
            {
                memorytotal = result["TotalVisibleMemorySize"].ToString();
            }
            int memorytotaln = Int32.Parse(memorytotal);

            //átváltás GB-t ra

            memorytotaln /= 1024;
            memorytotaln /= 1024;
            memorytotaln += 1;
            return memorytotaln;
        }

        private async void ram_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if(int.Parse(rfs_txtbox.Text) > memoria())
                {
                    MessageBox.Show("Nem tudsz megadni több ram-t a géped kapacitásánál(A géped kapacitása: " + memoria().ToString() + " GB)");
                    rfs_save.Text = "Hiba!";
                    rfs_save.ForeColor = Color.Red;
                    await Task.Delay(1000);
                    rfs_save.Visible = false;
                }
                else
                {
                    mcsc.Properties.Settings.Default.rfs = int.Parse(rfs_txtbox.Text);
                    mcsc.Properties.Settings.Default.Save();
                    rfs_save.Text = "Mentve!";
                    rfs_save.ForeColor = Color.Green;
                    await Task.Delay(1000);
                    rfs_save.Visible = false;
                }
            }
            else if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') || (e.KeyChar == '.'))
            {
                e.Handled = true;
            }
            else
            {
                rfs_save.Text = "A mentéshez nyomja meg az Enter-t";
                rfs_save.ForeColor = Color.Red;
                rfs_save.Visible = true;
            }
        }
    }
}
