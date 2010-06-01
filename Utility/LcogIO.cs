using System;
using System.Collections.Specialized;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Text;
using System.Xml;

using LcogClient.Model;
using LcogClient.Model.Collections;

using ICSharpCode.SharpZipLib.Zip;
using ICSharpCode.SharpZipLib.Zip.Compression.Streams;

namespace LcogClient.Utility
{
    /// <summary>
    /// I/O Handling.
    /// </summary>
    public class LcogIO
    {
        /// <summary>
        /// Load XML document from file.
        /// </summary>
        public static XmlDocument LoadXml(string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);

            XmlDocument xml = new XmlDocument();
            xml.Load(fs);

            fs.Close();

            return xml;
        }

        /// <summary>
        /// Write string to file.
        /// </summary>
        public static void WriteOrders(string orders, string fileName)
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                writer.Write(orders);
            }
        }

        #region Load Methods
        /// <summary>
        /// Loads game data.
        /// </summary>
        /// <param name="fileName">File name.</param>
        public static void LoadGameData(string fileName)
        {
            Client.Instance.Map = new Map();
            Client.Instance.Components = new Components();

            XmlDocument xml = LcogIO.LoadXml(fileName);

            XmlNode gameNode = xml.SelectSingleNode("/game");
            Client.Instance.GameName = gameNode.Attributes["name"].Value;

            XmlNode mapNode = xml.SelectSingleNode("//map");
            Client.Instance.Map.Name = mapNode.Attributes["name"].Value;
            Client.Instance.Map.Size = int.Parse(mapNode.Attributes["extremes"].Value);

            foreach (XmlNode node in xml.SelectNodes("//planet"))
            {
                Planet planet = new Planet();
                planet.Image = global::LcogClient.Properties.Resources.planet;
                planet.ID = int.Parse(node.Attributes["id"].Value);
                planet.Name = node.Attributes["name"].Value;
                planet.X = int.Parse(node.Attributes["x"].Value);
                planet.Y = int.Parse(node.Attributes["y"].Value);
                Client.Instance.Map.Add(planet);
            }

            foreach (XmlNode node in xml.SelectNodes("//component"))
            {
                Component component = new Component();
                component.Name = node.Attributes["name"].Value;
                component.Description = node.Attributes["desc"].Value;
                component.Cost = int.Parse(node.Attributes["cost"].Value);
                component.Size = int.Parse(node.Attributes["size"].Value);
               foreach (XmlNode n in node.SelectNodes("tech"))
                {
                    Technology tech = new Technology();
                    tech.Level = int.Parse(n.Attributes["level"].Value);
                    tech.Name = n.Attributes["name"].Value;
                    component.Tech.Add(tech);
                }
                Client.Instance.Components.Add(component);
            }
        }

        /// <summary>
        /// Loads a turn report.
        /// </summary>
        /// <param name="fileName">File name.</param>
        public static void LoadReport(string fileName)
        {
            Client.Instance.Player = new Player();
            Client.Instance.Factions = new Factions();
            //Client.Instance.Selected = null;
            //Client.Instance.Target = null;

            XmlDocument xml = LcogIO.LoadXml(fileName);

            Client.Instance.Player.ID = int.Parse(xml.DocumentElement.Attributes["id"].Value);
            Client.Instance.Player.Turn = int.Parse(xml.DocumentElement.Attributes["turn"].Value);
            Client.Instance.Player.Password = xml.DocumentElement.Attributes["password"].Value;
            Client.Instance.Player.Energy = int.Parse(xml.DocumentElement.Attributes["energy"].Value);

            foreach (XmlNode node in xml.SelectNodes("//message"))
            {
                Message message = new Message();
                message.Type = node.Attributes["type"].Value;
                message.From = node.Attributes["from"].Value;
                message.Body = node.InnerText;
                Client.Instance.Player.Messages.Add(message);
            }

            Client.Instance.Player.Tech.Researching = xml.SelectSingleNode("//technology").Attributes["researching"].Value;
            Client.Instance.Player.Tech.CurrentResearch = int.Parse(xml.SelectSingleNode("//technology").Attributes["current_research"].Value);
            foreach (XmlNode node in xml.SelectNodes("//tech"))
            {
                Technology tech = new Technology();
                tech.Level = int.Parse(node.Attributes["level"].Value);
                tech.Name = node.Attributes["name"].Value;
                try
                {
                    tech.Research = int.Parse(node.Attributes["research"].Value);
                }
                catch
                {
                    tech.Research = 0;
                }
                Client.Instance.Player.Tech.Add(tech);
            }

            foreach (XmlNode node in xml.SelectNodes("//faction"))
            {
                Faction faction = new Faction();
                faction.ID = int.Parse(node.Attributes["id"].Value);
                faction.Name = node.Attributes["name"].Value;
                faction.Planets = int.Parse(node.Attributes["planets"].Value);
                faction.Score = int.Parse(node.Attributes["score"].Value);
                faction.Ships = int.Parse(node.Attributes["ships"].Value);
                faction.Mass = int.Parse(node.Attributes["shipmass"].Value);

                if (node.Attributes["diplomacy"] != null)
                {
                    faction.Relations = node.Attributes["diplomacy"].Value;
                }
                else
                {
                    faction.Relations = "Neutral";
                }
                Client.Instance.Factions.Add(faction);

                // assign faction to player
                if (faction.ID == Client.Instance.Player.ID)
                {
                    Client.Instance.Player.Faction = faction;
                }
            }

            foreach (XmlNode node in xml.SelectNodes("//planet"))
            {
                // just get the planet reference from the map
                Planet planet = Client.Instance.Map.GetPlanetByID(int.Parse(node.Attributes["id"].Value));
                if (node.Attributes["energy"] != null)
                {
                    planet.Energy = int.Parse(node.Attributes["energy"].Value);
                }
                if (node.Attributes["factionId"] != null)
                {
                    planet.Faction = Client.Instance.Factions.GetFactionByID(int.Parse(node.Attributes["factionId"].Value));
                }
                if (planet.Faction == Client.Instance.Player.Faction)
                {
                    Client.Instance.Player.Planets.Add(planet);
                }

                foreach (XmlNode component in node.SelectNodes("slot"))
                {
                    planet.Components.Add(Client.Instance.Components.GetComponentByName(component.InnerText));
                }
            }

            foreach (XmlNode node in xml.SelectNodes("//ship"))
            {
                Ship ship = new Ship();
                ship.Image = global::LcogClient.Properties.Resources.ship;
                ship.ID = int.Parse(node.Attributes["id"].Value);
                ship.X = int.Parse(node.Attributes["x"].Value);
                ship.Y = int.Parse(node.Attributes["y"].Value);

                if (node.Attributes["damage"] != null)
                {
                    ship.Damage = int.Parse(node.Attributes["damage"].Value);
                }

                ship.Faction = Client.Instance.Factions.GetFactionByID(int.Parse(node.Attributes["factionId"].Value));
                ship.Name = node.Attributes["name"].Value;

                string wp = node.Attributes["waypoint"].Value;
                if (wp.Length > 1)
                {
                    int x = int.Parse(wp.Substring(0, wp.IndexOf(',')));
                    int y = int.Parse(wp.Substring(wp.IndexOf(',') + 1));
                    ship.Waypoint = new Point(x, y);
                }
                else
                {
                    ship.Waypoint = ship.Location;
                }

                ship.HullClass = node.Attributes["class"].Value;
                ship.Hull = int.Parse(node.Attributes["hull"].Value);

                //ship.Image = LcogIO.GetHullImage(ship.Hull.Name);

                ship.Mass = int.Parse(node.Attributes["mass"].Value);

                foreach (XmlNode component in node.SelectNodes("slot"))
                {
                    ship.Components.Add(Client.Instance.Components.GetComponentByName(component.InnerText));
                }

                if (ship.Faction == Client.Instance.Player.Faction)
                {
                    ship.MaxMove = int.Parse(node.Attributes["maxmove"].Value);
                    Client.Instance.Player.Ships.Add(ship);
                }
                Client.Instance.Map.Add(ship);
            }
        }

        public static Image GetHullImage(string name)
        {
            if (name == "Scout")
            {
                return global::LcogClient.Properties.Resources.scout32x32;
            }
            else if (name == "Corvette")
            {
                return global::LcogClient.Properties.Resources.corvette32x32;
            }
            else if (name == "Freighter")
            {
                return global::LcogClient.Properties.Resources.freighter32x32;
            }
            else if (name == "Frigate")
            {
                return global::LcogClient.Properties.Resources.frigate32x32;
            }
            else if (name == "Destroyer")
            {
                return global::LcogClient.Properties.Resources.destroyer32x32;
            }
            else if (name == "Battleship")
            {
                return global::LcogClient.Properties.Resources.battleship32x32;
            }
            else
            {
                return global::LcogClient.Properties.Resources.ship;
            }
        }
        #endregion

        
        Stream responseStream;
        Stream fileStream;

        /// <summary>
        /// Download report from the website.
        /// </summary>
        public void DownloadReport()
        {
            using (WebClient webClient = new WebClient())
            {
                try
                {
                    string url = LcogConfig.ReportURL + "Report" + LcogConfig.FactionID + ".zip";

                    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                    request.Credentials = CredentialCache.DefaultCredentials;

                    HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                    Int64 fileSize = response.ContentLength;

                    this.responseStream = webClient.OpenRead(url);
                    this.fileStream = new FileStream("Report" + LcogConfig.FactionID + ".zip", FileMode.Create, FileAccess.Write, FileShare.None);


                    int byteSize = 0;

                    byte[] downloadBuffer = new byte[2048];

                    while ((byteSize = this.responseStream.Read(downloadBuffer, 0, downloadBuffer.Length)) > 0)
                    {
                        this.fileStream.Write(downloadBuffer, 0, byteSize);
                    }
                }
                catch
                {
                    //// Calculate the download progress in percentages
                    //PercentProgress = Convert.ToInt32((BytesRead * 100) / TotalBytes);
                    //// Make progress on the progress bar
                    //prgDownload.Value = PercentProgress;
                }
                finally
                {
                    this.responseStream.Close();
                    this.fileStream.Close();
                }
            }

            string savepath = "Report" + LcogConfig.FactionID + ".zip";
            WebClient client = new WebClient();
            client.DownloadFile(LcogConfig.ReportURL + "Report" + LcogConfig.FactionID + ".zip", savepath);
        }

        public static void DownloadPlayerFile()
        {
            WebClient client = new WebClient();
            client.DownloadFile(LcogConfig.PlayerFileURL, "playerfile.xml");
        }

        public static bool UploadOrders()
        {
            string[] file = new string[1];
            file[0] = "orders" + LcogConfig.FactionID + ".xml";

            NameValueCollection n = new NameValueCollection();
            n.Add("password", LcogConfig.Password);
            
            return LcogIO.UploadFilesToRemoteUrl(LcogConfig.SubmitTurnURL, file, "lcog_download.log", n);
        }


        public static void UnzipReport()
        {
            string report = "report" + LcogConfig.FactionID + ".zip";
            using (ZipInputStream s = new ZipInputStream(File.OpenRead(report)))
            {

                ZipEntry theEntry;
                while ((theEntry = s.GetNextEntry()) != null)
                {

                    Console.WriteLine(theEntry.Name);

                    string directoryName = Path.GetDirectoryName(theEntry.Name);
                    string fileName = Path.GetFileName(theEntry.Name);

                    // create directory
                    if (directoryName.Length > 0)
                    {
                        Directory.CreateDirectory(directoryName);
                    }

                    if (fileName != String.Empty)
                    {
                        using (FileStream streamWriter = File.Create(theEntry.Name))
                        {

                            int size = 2048;
                            byte[] data = new byte[2048];
                            while (true)
                            {
                                size = s.Read(data, 0, data.Length);
                                if (size > 0)
                                {
                                    streamWriter.Write(data, 0, size);
                                }
                                else
                                {
                                    break;
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Method for uploading orders to the website, essentially constructs a HTTP POST
        /// on the fly and uses that.
        /// </summary>
        public static bool UploadFilesToRemoteUrl(string url, string[] files, string
            logpath, NameValueCollection nvc)
            {

            string boundary = "----------------------------" +
            DateTime.Now.Ticks.ToString("x");


            HttpWebRequest httpWebRequest2 = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest2.ContentType = "multipart/form-data; boundary=" +
            boundary;
            httpWebRequest2.Method = "POST";
            httpWebRequest2.KeepAlive = true;
            httpWebRequest2.Credentials =
            System.Net.CredentialCache.DefaultCredentials;

            Stream memStream = new System.IO.MemoryStream();

            byte[] boundarybytes = System.Text.Encoding.ASCII.GetBytes("\r\n--" +
            boundary + "\r\n");


            string formdataTemplate = "\r\n--" + boundary +
            "\r\nContent-Disposition: form-data; name=\"{0}\";\r\n\r\n{1}";

            foreach(string key in nvc.Keys)
            {
            string formitem = string.Format(formdataTemplate, key, nvc[key]);
            byte[] formitembytes = System.Text.Encoding.UTF8.GetBytes(formitem);
            memStream.Write(formitembytes, 0, formitembytes.Length);
            }


            memStream.Write(boundarybytes,0,boundarybytes.Length);

            string headerTemplate = "Content-Disposition: form-data; name=\"{0}\";filename=\"{1}\";\r\n Content-Type: application/octet-stream\r\n\r\n";

            for(int i=0;i<files.Length;i++)
            {

          string header = string.Format(headerTemplate,"userfile",files[i]);

            byte[] headerbytes = System.Text.Encoding.UTF8.GetBytes(header);

            memStream.Write(headerbytes,0,headerbytes.Length);


            FileStream fileStream = new FileStream(files[i], FileMode.Open,
            FileAccess.Read);
            byte[] buffer = new byte[1024];

            int bytesRead = 0;

            while ( (bytesRead = fileStream.Read(buffer, 0, buffer.Length)) != 0 )
            {
            memStream.Write(buffer, 0, bytesRead);

            }


            memStream.Write(boundarybytes,0,boundarybytes.Length);


            fileStream.Close();
            }

            httpWebRequest2.ContentLength = memStream.Length;

            Stream requestStream = httpWebRequest2.GetRequestStream();

            memStream.Position = 0;
            byte[] tempBuffer = new byte[memStream.Length];
            memStream.Read(tempBuffer,0,tempBuffer.Length);
            memStream.Close();
            requestStream.Write(tempBuffer,0,tempBuffer.Length );
            requestStream.Close();

            string t = Encoding.ASCII.GetString(tempBuffer);

            WebResponse webResponse2 = httpWebRequest2.GetResponse();

            Stream stream2 = webResponse2.GetResponseStream();
            StreamReader reader2 = new StreamReader(stream2);

            // parse this for success
            string response = reader2.ReadToEnd();

            webResponse2.Close();
            httpWebRequest2 = null;
            webResponse2 = null;

            if (response.Contains("upload OK!"))
            {
                return true;
            }
            else
            {
                return false;
            }
            }

    }
}
