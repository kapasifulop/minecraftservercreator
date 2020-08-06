using mcsc;
using Mono.Nat;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace minecraftservercreator
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 

        public static bool[] started;
        public static List<int> opened_ports = new List<int>();
        private static bool UPNP = false;
        private static INatDevice device;
        private static string lan_ip;
        private static string wan_ip;
        private static System.Diagnostics.Process[] process;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            NatUtility.DeviceFound += DeviceFound;
            NatUtility.StartDiscovery();
            WebClient wc = new WebClient();
            try
            {
                lan_ip = GetLocalIPAddress();
                wan_ip = wc.DownloadString("https://ipinfo.io/ip");
            }
            catch { }


            if (Directory.Exists(@"C:\mcsc\servers\"))
            {
                string[] dirs = Directory.GetDirectories(@"C:\mcsc\servers\");
                bool we_have_server = false;

                for (int i = 0; i < dirs.Length; i++)
                {
                    if (File.Exists(dirs[i] + @"\settings.mcsc"))
                    {
                        StreamReader sr = new StreamReader(dirs[i] + @"\settings.mcsc");
                        String line = sr.ReadLine();
                        bool ver = false;
                        bool agy = false;
                        while (line != null)
                        {
                            if (line.Contains("version="))
                            {
                                ver = true;
                            } else if (line.Contains("agy="))
                            {
                                agy = true;
                            }
                            line = sr.ReadLine();
                        }
                        sr.Close();
                        if(ver && agy)
                        {
                            we_have_server = true;
                        }
                        else
                        {
                            MessageBox.Show(dirs[i] + " Mappában található szerveredben, nem található értelmezhető settings fálj, így törölnünk kell(HA ESETLEG TE TÖRÖLTED AKKOR MÉG AZ OK-ra NYOMÁS ELŐTT MENTSD EL A SZERVERED ADATAIT)!");
                            Directory.Delete(dirs[i] + @"\", true);
                        }
                    }
                    else
                    {
                        MessageBox.Show(dirs[i] + " Mappában található szerveredben, nem található értelmezhető settings fálj, így törölnünk kell!");
                        Directory.Delete(dirs[i] + @"\", true);
                    }
                }
                if (!we_have_server)
                {
                    Application.Run(new Form1());
                }
                else
                {
                    Application.Run(new Vezerlofo());
                }
            }
            else
            {
                Application.Run(new Form1());
            }




        }

        private static void DeviceFound(object sender, DeviceEventArgs e)
        {
            UPNP = true;
            device = e.Device;
        }

        public static async void set_server_num_s(int num)
        {
            started = new bool[num];
            process = new System.Diagnostics.Process[num];
            for (int i = 0; i < started.Length; i++)
            {
                started[i] = false;
            }
            
            //MessageBox.Show(num.ToString());
        }

        public static void OpenPort(int port, string descript)
        {
            bool alredy_opened = false;
            if (UPNP == true)
            {
                for (int i = 0; i < opened_ports.Count(); i++)
                {
                    if(port == opened_ports[i])
                    {
                        alredy_opened = true;
                        //MessageBox.Show("THIS PORT IS ALREDY OPENED");
                    }
                }
                if(alredy_opened == false)
                {
                    Mapping TCP = new Mapping(Protocol.Tcp, port, port);
                    Mapping UDP = new Mapping(Protocol.Udp, port, port);
                    TCP.Description = descript + "TCP";
                    UDP.Description = descript + "UDP";

                    device.CreatePortMap(TCP);
                    device.CreatePortMap(UDP);
                    opened_ports.Add(port);
                }

            }
        }

        public static string get_ver(string name)
        {
            string ver = "";
            StreamReader sr = new StreamReader(@"C:\mcsc\servers\" + name + @"\settings.mcsc");
            String line = sr.ReadLine();
            while (line != null)
            {
                if (line.Contains("version="))
                {
                    line = line.Replace("version=", "");
                    ver = line;
                }
                line = sr.ReadLine();
            }
            sr.Close();
            return ver;
        }

        public static string get_agy(string name)
        {
            string ver = null;
            StreamReader sr = new StreamReader(@"C:\mcsc\servers\" + name + @"\settings.mcsc");
            List<String> lines_s = new List<string>();
            String line = sr.ReadLine();
            while (line != null)
            {
                lines_s.Add(line);
                if (line.Contains("agy="))
                {
                    line = line.Replace("agy=", "");
                    ver = line;
                }
            }
            sr.Close();
            return ver;
        }

        public static async void start_srv(int id, string name, string dir, int srv_port)
        {
            
            string ver = get_ver(name);
            
            if(File.Exists(dir + @"\log.txt"))
            {
                File.Move(dir + @"\log.txt", dir + @"\log" + DateTime.Now.ToString("dd_hh_ss") + ".txt");
                File.Create(dir + @"\log.txt");
            }

            await Task.Delay(1000);
            if(string.IsNullOrEmpty(lan_ip) || string.IsNullOrEmpty(wan_ip))
            {
                try
                {
                    WebClient wc = new WebClient();
                    lan_ip = GetLocalIPAddress();
                    wan_ip = wc.DownloadString("https://ipinfo.io/ip");
                }
                catch(Exception e) { MessageBox.Show("Hiba az ip címed lekérése közben! ERROR CODE:" + e); }
                return;
            }
            add_log("A WAN és a LAN IP címed sikeresen betöltve", dir);
            add_log("Ezek kiírásához használd a :|:lanip vagy a :|:wanip parancsokat!", dir);
            
            if (!File.Exists(dir  + @"\spigot.jar"))
            {
                add_log("A kiválasztott verzió letöltésének elindítása", dir);
                WebClient wb = new WebClient();

                int elozo = 0;
                wb.DownloadProgressChanged += (s, e) =>
                {
                    /*vz.pb2.Invoke((MethodInvoker)(() => vz.pb2.Visible = true));
                    vz.pb2.Invoke((MethodInvoker)(() => vz.pb2.Value = e.ProgressPercentage));*/
                    if (elozo != e.ProgressPercentage)
                    {
                        if (elozo != e.ProgressPercentage)
                        {
                            if (elozo == 10)
                            {
                                add_log("10%", dir);
                            }
                            else if (elozo == 20)
                            {
                                add_log("20%", dir);
                            }
                            else if (elozo == 30)
                            {
                                add_log("30%", dir);
                            }
                            else if (elozo == 40)
                            {
                                add_log("40%", dir);
                            }
                            else if (elozo == 50)
                            {
                                add_log("50%", dir);
                            }
                            else if (elozo == 60)
                            {
                                add_log("60%", dir);
                            }
                            else if (elozo == 70)
                            {
                                add_log("70%", dir); 
                            }
                            else if (elozo == 80)
                            {
                                add_log("80%", dir);
                            }
                            else if (elozo == 90)
                            {
                                add_log("90%", dir);
                            }
                        }
                    }
                    elozo = e.ProgressPercentage;
                };
                wb.DownloadFileCompleted += (s, e) =>
                {
                    //vz.pb2.Invoke((MethodInvoker)(() => vz.pb2.Visible = false));
                    add_log("100%", dir);
                    java(id, dir);
                };
                wb.DownloadFileAsync(new Uri("https://cdn.getbukkit.org/spigot/spigot-" + ver + ".jar"), dir + @"\spigot.jar");
            }
            else
            {
                java(id, dir);
            }

            if (!File.Exists(dir  + @"\eula.txt"))
            {
                add_log("EULA ELFOGADÁSA", dir);
                Boolean tryagainn = true;
                while (tryagainn)
                {
                    try
                    {
                        File.WriteAllText(dir + @"\eula.txt", "eula=true");
                        tryagainn = false;
                    }
                    catch { tryagainn = true; }
                }
                add_log("EULA automatikusan elfogadva", dir);
            }

        }

        private static async void java(int id, string dir)
        {
            if (!Directory.Exists(dir + @"\java"))
            {
                if (!File.Exists(dir + @"\java.zip"))
                {
                    add_log("Java Letöltése", dir);
                    int elozo = -50;
                    WebClient javadw = new WebClient();
                    javadw.DownloadProgressChanged += (s, e) =>
                    {
                        //dir.pb2.Invoke((MethodInvoker)(() => dir.pb2.Visible = true));
                        //dir.pb2.Invoke((MethodInvoker)(() => dir.pb2.Value = e.ProgressPercentage));
                        if (elozo != e.ProgressPercentage)
                        {
                            if (elozo != e.ProgressPercentage)
                            {
                                if (elozo == 10)
                                {
                                    add_log("10%", dir);
                                }
                                else if (elozo == 20)
                                {
                                    add_log("20%", dir);
                                }
                                else if (elozo == 30)
                                {
                                    add_log("30%", dir);
                                }
                                else if (elozo == 40)
                                {
                                    add_log("40%", dir);
                                }
                                else if (elozo == 50)
                                {
                                    add_log("50%", dir);
                                }
                                else if (elozo == 60)
                                {
                                    add_log("60%", dir);
                                }
                                else if (elozo == 70)
                                {
                                    add_log("70%", dir);
                                }
                                else if (elozo == 80)
                                {
                                    add_log("80%", dir);
                                }
                                else if (elozo == 90)
                                {
                                    add_log("90%", dir);
                                }
                            }
                        }
                        elozo = e.ProgressPercentage;
                    };
                    javadw.DownloadFileCompleted += (s, e) =>
                    {
                        //dir.pb2.Invoke((MethodInvoker)(() => dir.pb2.Visible = false));
                        add_log("100%", dir);
                        kicsomagol(id, dir);
                    };
                    javadw.DownloadFileAsync(new Uri("https://mpg.anevem.hu/dw/java/java.zip"), dir + @"\java.zip");
                }
                else
                {
                    kicsomagol(id, dir);
                }
            }
            else
            {
                szerver_indit(id, dir);
            }
        }

        public static async void kicsomagol(int id, string dir)
        {
            add_log("Fájlok kicsomagolása", dir);
            ZipFile.ExtractToDirectory(dir + @"\java.zip", dir);
            add_log("Kész!", dir);
            add_log("Tömörített fájl(ok) törlése", dir);
            File.Delete(dir + @"\java.zip");
            add_log("Kész!", dir);
            szerver_indit(id, dir);
        }

        public static async void szerver_indit(int id, string dir)
        {
            //MessageBox.Show(id.ToString());
            add_log("Szerver ip beállítása", dir);
            if (File.Exists(dir + @"\server.properties"))
            {
                StreamReader sr = new StreamReader(dir + @"\server.properties");
                List<String> lines_s = new List<string>();
                String line = sr.ReadLine();

                while (line != null)
                {
                    lines_s.Add(line);
                    if (line.Contains("server-port="))
                    {
                        line = line.Replace("server-port=", "");

                        int port = int.Parse(line);
                        if (port != null)
                        {
                            add_log("Port megnyitása: " + port + "-n", dir);
                            OpenPort(port, "MCSC - minecraft server port");
                        }
                    }
                    line = sr.ReadLine();
                }
                sr.Close();

                StreamWriter sw = new StreamWriter(dir + @"\server.properties");
                foreach (String linee in lines_s)
                {
                    if (linee.Contains("server-ip="))
                    {
                        sw.WriteLine("server-ip=" + GetLocalIPAddress());
                    }
                    else
                    {
                        sw.WriteLine(linee);
                    }
                }
                sw.Close();
                add_log("Sikeres beállítás", dir);
            }
            else
            {
                add_log("Sikertelen beállítás. Majd indítsd újra a szervert!", dir);
            }

            add_log("Szerver indítása", dir);
            add_log("*** Server will start in 20 seconds ***", dir);
            
            started[id] = true;
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo("cmd", @"/C @echo off && cd " + dir + @"\ && " + dir + @"\java\bin\java.exe -Xmx" + mcsc.Properties.Settings.Default.rfs + @"G -jar " + dir + @"\spigot.jar");
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.RedirectStandardOutput = true;
            startInfo.RedirectStandardInput = true;
            startInfo.UseShellExecute = false;
            startInfo.CreateNoWindow = true;
            process[id] = new System.Diagnostics.Process();
            process[id].StartInfo = startInfo;
            process[id].EnableRaisingEvents = true;
            process[id].OutputDataReceived += (s, e) => { add_log(e.Data, dir); };
            process[id].Exited += (s, e) => { stopped(id); };
            process[id].Start();
            process[id].BeginOutputReadLine();

        }

        public static async void stopped(int id)
        {
            started[id] = false;
        }

        public static async void stop_s(int id, server_control sc)
        {
            StreamWriter mystrwt = process[id].StandardInput;
            try
            {
                mystrwt.WriteLine("stop");
                process[id].WaitForExit();
                process[id] = null;
                sc.start_btn.Enabled = true;
                started[id] = false;
            }
            catch {
                //MessageBox.Show("error");
            }
        }

        public static async void add_log(string text, string dir)
        {
            try
            {
                StreamWriter sw = new StreamWriter(dir + @"\log.txt", true);
                sw.WriteLine(text);
                sw.Close();
            }
            catch { /*MessageBox.Show("ERROR #370"); */}

        }

        public static string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("ERR");
        }

        public static async void i_typed(int id, string name, string dir, string text)
        {
            if(process[id] != null)
            {
                StreamWriter mystrwt = process[id].StandardInput;
                try
                {
                    mystrwt.WriteLine(text);
                }
                catch { MessageBox.Show("HIBA #441! Próbáld újra!"); }
            }
        }
    }
}
