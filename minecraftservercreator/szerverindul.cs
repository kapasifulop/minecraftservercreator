using Mono.Nat;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace minecraftservercreator
{
    class szerverindul
    {
        string filePath = @"C:\mcsc\log.txt";
        INatDevice device;
        bool fnd = false;
        bool err = false;
        konzol kz;
        System.Diagnostics.Process process = new System.Diagnostics.Process();

        public string ip_betoltes(Vezerlofo vz)
        {
            try
            {
                write_file("MSCS: WAN és LAN ip cím betöltése!", vz);
                WebClient wc = new WebClient();
                string teszt = wc.DownloadString("https://ipinfo.io/ip");
                mcsc.Properties.Settings.Default.wan_ip = new WebClient().DownloadString("https://ipinfo.io/ip");
                mcsc.Properties.Settings.Default.lan_ip = GetLocalIPAddress();
                mcsc.Properties.Settings.Default.Save();
                //write_file("MCSC: EZEN TÚL VAGYUNK!", vz);
                return "MCSC: ip-k betöltése";
            }
            catch
            {
                write_file("MCSC-ERROR: Hiba az ip címek betöltése közben!",vz);
                return "error";
            }
        }

        public async void start(Vezerlofo vz)
        {
            /*if (!vz.stop_T)
            {*/
            
            MessageBox.Show("startnál");

            /*if (true)
            {*/
            write_file("MCSC: Portok létrehozása!", vz);

            /*var discoverer = new NatDiscoverer();
            var cts = new CancellationTokenSource(10000);
            try
            {
                IPAddress ip = new IPAddress(new byte[] { 192, 168, 0, 122 });
                var device = await discoverer.DiscoverDeviceAsync(PortMapper.Upnp, cts).ConfigureAwait(true);
                await device.CreatePortMapAsync(new Mapping(Protocol.Tcp, 25565, 25565, "MC_TCP")).ConfigureAwait(true);
                await device.CreatePortMapAsync(new Mapping(Protocol.Udp, 25565, 25565, "MC_UDP")).ConfigureAwait(true);
                write_file("Sikeres létrehozás", vz);
            }
            catch { write_file("Hiba történt", vz); }*/


            NatUtility.DeviceFound += DeviceFound;
            NatUtility.DeviceLost += DeviceLost;
            NatUtility.StartDiscovery();
            await PutTaskDelay(1000);
            upnp_ell(vz);



                if (!Directory.Exists(@"C:\mcsc"))
                    {
                        write_file(@"Főmappa létrehozása C:\mcsc", vz);
                        Directory.CreateDirectory(@"C:\mcsc");
                    }
                    if (!Directory.Exists(@"C:\mcsc\srv"))
                    {
                        write_file(@"Minecraft szerver mappa létrehozása C:\mcsc\srv",vz);
                        Directory.CreateDirectory(@"C:\mcsc\srv");
                    }
                    if (true)
                    {
                        if (!File.Exists(@"C:\mcsc\srv\spigot.jar"))
                        {
                            await PutTaskDelay(1000);
                            write_file("a kiválasztott verzió letöltése (" + mcsc.Properties.Settings.Default.verzio + ")", vz);
                            WebClient wb = new WebClient();

                            int elozo = 0;
                            wb.DownloadProgressChanged += (s, e) =>
                            {
                                vz.pb2.Invoke((MethodInvoker)(() => vz.pb2.Visible = true));
                                vz.pb2.Invoke((MethodInvoker)(() => vz.pb2.Value = e.ProgressPercentage));
                                if (elozo != e.ProgressPercentage)
                                {
                                    if (elozo != e.ProgressPercentage)
                                    {
                                        if (elozo == 10)
                                        {
                                            write_file("10%", vz);
                                        }
                                        else if (elozo == 20)
                                        {
                                            write_file("20%", vz);
                                        }
                                        else if (elozo == 30)
                                        {
                                            write_file("30%", vz);
                                        }
                                        else if (elozo == 40)
                                        {
                                            write_file("40%", vz);
                                        }
                                        else if (elozo == 50)
                                        {
                                            write_file("50%", vz);
                                        }
                                        else if (elozo == 60)
                                        {
                                            write_file("60%", vz);
                                        }
                                        else if (elozo == 70)
                                        {
                                            write_file("70%", vz);
                                        }
                                        else if (elozo == 80)
                                        {
                                            write_file("80%", vz);
                                        }
                                        else if (elozo == 90)
                                        {
                                            write_file("90%", vz);
                                        }
                                    }
                                }
                                elozo = e.ProgressPercentage;
                            };
                            wb.DownloadFileCompleted += (s, e) =>
                            {
                                vz.pb2.Invoke((MethodInvoker)(() => vz.pb2.Visible = false));
                                write_file("100%", vz);
                                java(vz);
                            };
                            wb.DownloadFileAsync(new Uri("https://cdn.getbukkit.org/spigot/spigot-" + mcsc.Properties.Settings.Default.verzio + ".jar"), @"C:\mcsc\srv\spigot.jar");
                        }
                        else
                        {
                            java(vz);
                        }
                        if (!File.Exists(@"C:\mcsc\srv\eula.txt"))
                        {
                            write_file("EULA ELFOGADÁSA", vz);
                            Boolean tryagainn = true;
                            while (tryagainn)
                            {
                                try
                                {
                                    File.WriteAllText(@"C:\mcsc\srv\eula.txt", "eula=true");
                                    tryagainn = false;
                                }
                                catch { tryagainn = true; }
                            }
                            write_file("EULA ELFOGADVA", vz);
                        }
                    }
                //}
            //}
        }

        public async void java(Vezerlofo vzzz)
        {
            if (true)
            {
                if (!Directory.Exists(@"C:\mcsc\srv\java"))
                {
                    if (!File.Exists(@"C:\mcsc\srv\java.zip"))
                    {
                        write_file("Java Letöltése", vzzz);
                        int elozo = -50;
                        WebClient javadw = new WebClient();
                        javadw.DownloadProgressChanged += (s, e) =>
                        {
                            vzzz.pb2.Invoke((MethodInvoker)(() => vzzz.pb2.Visible = true));
                            vzzz.pb2.Invoke((MethodInvoker)(() => vzzz.pb2.Value = e.ProgressPercentage));
                            if (elozo != e.ProgressPercentage)
                            {
                                if (elozo != e.ProgressPercentage)
                                {
                                    if (elozo == 10)
                                    {
                                        write_file("10%", vzzz);
                                    }
                                    else if (elozo == 20)
                                    {
                                        write_file("20%", vzzz);
                                    }
                                    else if (elozo == 30)
                                    {
                                        write_file("30%", vzzz);
                                    }
                                    else if (elozo == 40)
                                    {
                                        write_file("40%", vzzz);
                                    }
                                    else if (elozo == 50)
                                    {
                                        write_file("50%", vzzz);
                                    }
                                    else if (elozo == 60)
                                    {
                                        write_file("60%", vzzz);
                                    }
                                    else if (elozo == 70)
                                    {
                                        write_file("70%", vzzz);
                                    }
                                    else if (elozo == 80)
                                    {
                                        write_file("80%", vzzz);
                                    }
                                    else if (elozo == 90)
                                    {
                                        write_file("90%", vzzz);
                                    }
                                }
                            }
                            elozo = e.ProgressPercentage;
                        };
                        javadw.DownloadFileCompleted += (s, e) =>
                        {
                            vzzz.pb2.Invoke((MethodInvoker)(() => vzzz.pb2.Visible = false));
                            write_file("100%", vzzz);
                            kicsomagol(vzzz);
                        };
                        javadw.DownloadFileAsync(new Uri("https://mpg.anevem.hu/dw/java/java.zip"), @"C:\mcsc\srv\java.zip");
                    }
                    else
                    {
                        kicsomagol(vzzz);
                    }
                }
                else
                {
                    szerver_indit(vzzz);
                }
            }
        }

        public void kicsomagol(Vezerlofo vzf)
        {
            write_file("Fájlok kicsomagolása", vzf);
            ZipFile.ExtractToDirectory(@"C:\mcsc\srv\java.zip", @"C:\mcsc\srv\");
            write_file("Kész!", vzf);
            write_file("Tömörített fájl(ok) törlése", vzf);
            File.Delete(@"C:\mcsc\srv\java.zip");
            write_file("Kész!", vzf);
            szerver_indit(vzf);
        }

        public void szerver_indit(Vezerlofo vzf)
        {
            write_file("Szerver ip beállítása", vzf);
            if (File.Exists(@"C:\mcsc\srv\server.properties"))
            {
                StreamReader sr = new StreamReader(@"C:\mcsc\srv\server.properties");
                List<String> lines_s = new List<string>();
                String line = sr.ReadLine();

                while (line != null)
                {
                    lines_s.Add(line);
                    line = sr.ReadLine();
                }
                sr.Close();

                StreamWriter sw = new StreamWriter(@"C:\mcsc\srv\server.properties");
                foreach (String linee in lines_s)
                {
                    if (linee.Contains("server-ip="))
                    {
                        sw.WriteLine("server-ip=" + mcsc.Properties.Settings.Default.lan_ip);
                    }
                    else
                    {
                        sw.WriteLine(linee);
                    }
                }
                sw.Close();
                write_file("Sikeres beállítás", vzf);
            }
            else
            {
                write_file("Sikertelen beállítás. Majd indítsd újra a szervert!", vzf);
            }
            
            write_file("Szerver indítása", vzf);
            if(mcsc.Properties.Settings.Default.console_drop == false)
            {
                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo("cmd", @"/C @echo off && cd C:\mcsc\srv && C:\mcsc\srv\java\bin\java.exe -Xmx" + mcsc.Properties.Settings.Default.rfs + @"G -jar C:\mcsc\srv\spigot.jar");
                startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                startInfo.RedirectStandardOutput = true;
                startInfo.RedirectStandardInput = true;
                startInfo.UseShellExecute = false;
                startInfo.CreateNoWindow = true;
                process.StartInfo = startInfo;
                process.OutputDataReceived += (s, e) => { write_file(e.Data, vzf); };
                process.Start();
                process.BeginOutputReadLine();
            }
            else
            {
                write_file("konzol megnyitva külön ablakban", vzf);
                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo("cmd", @"/C @echo off && cd C:\mcsc\srv && C:\mcsc\srv\java\bin\java.exe -Xmx" + mcsc.Properties.Settings.Default.rfs + @"G -jar C:\mcsc\srv\spigot.jar && pause");
                process.StartInfo = startInfo;
                process.Start();
            }

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

        public void killprocess(Vezerlofo vzf)
        {
            StreamWriter mystrw = process.StandardInput;
            try
            {
                write_file("Leállítás", vzf);
                mystrw.WriteLine("stop");
                write_file("process killed", vzf);
                process.WaitForExit();
                mcsc.Properties.Settings.Default.szerverfut = false;
            }
            catch
            {

            }
        }

        public void entertext(string text)
        {
            if(process.StartInfo.Arguments != "" && mcsc.Properties.Settings.Default.console_drop == false)
            {
                StreamWriter mystrwt = process.StandardInput;
                try
                {
                    mystrwt.WriteLine(text);
                }
                catch { }
            }
        }

        private void DeviceFound(object sender, DeviceEventArgs args)
        {
            Mapping minecraftTCP = new Mapping(Protocol.Tcp, 25565, 25565);
            Mapping minecraftUDP = new Mapping(Protocol.Udp, 25565, 25565);
            minecraftTCP.Description = "MinecraftTCP";
            minecraftUDP.Description = "MinecraftUDP";


            device = args.Device;
            try
            {
                device.DeletePortMap(minecraftTCP);
                device.DeletePortMap(minecraftUDP);
            }
            catch {
            }
            device.CreatePortMap(minecraftTCP);
            device.CreatePortMap(minecraftUDP);
            device.CreatePortMap(new Mapping(Protocol.Udp, 2, 2));
            
            // on device found code

            //cport.Text = "okay";

        }

        private void DeviceLost(object sender, DeviceEventArgs args)
        {
            device = args.Device;
            // on device disconnect code
        }


        public void upnpport()
        {
            NatUtility.DeviceFound += DeviceFound;
            NatUtility.DeviceLost += DeviceLost;
            NatUtility.StartDiscovery();
        }

        //ellenőrzés
        public async void upnp_ell(Vezerlofo vzf)
        {
            write_file("MCSC: Portok létrehozásának eredményének ellenőrzése", vzf);
            try
            {
                device.DeletePortMap(new Mapping(Protocol.Udp, 2, 2));
                write_file("MCSC: Portok sikeresen létrehozva", vzf);
            }
            catch
            {
                write_file("MCSC-ERROR: PORTOK LÉTREHOZÁSA LEHETETLEN", vzf);
                MessageBox.Show("Sajnos neked nem elérhető az automatikus port létrehozás");
                NatUtility.StopDiscovery();
                err = true;
            }
        }
        
        //delay 

        async Task PutTaskDelay(int delay)
        {
            await Task.Delay(delay);
        }

        public void write_file(String szoveg,Vezerlofo vzf)
        {
            /*bool tryagain = true;
            while (tryagain) { */
                try
                {
                    List<string> lines = File.ReadAllLines(filePath).ToList();
                    lines.Add(szoveg);
                    File.WriteAllLines(filePath, lines);
                    //tryagain = false;
                }
                catch { }
            //}
            vzf.konzoladdtext(szoveg);
        }

        public string stop()
        {
            /*try
            {
                if(device != null)
                {
                    device.DeletePortMap(new Mapping(Protocol.Udp, 25565, 25565));
                    device.DeletePortMap(new Mapping(Protocol.Tcp, 25565, 25565));
                    NatUtility.StopDiscovery();
                }
            }
            catch { }*/
            return "okay";
        }

        public szerverindul()
        {
        }
    }
}
