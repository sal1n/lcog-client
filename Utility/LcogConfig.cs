using System;
using System.Configuration;

namespace LcogClient.Utility
{
    public class LcogConfig
    {
        public static string FactionID
        {
            get
            {
                return ConfigurationManager.AppSettings["factionID"];
            }
            set
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.AppSettings.Settings["factionID"].Value = value;
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");  
            }
        }
        public static string Password
        {
            get
            {
                return ConfigurationManager.AppSettings["password"];
            }
            set
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.AppSettings.Settings["password"].Value = value;
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");  
            }
        }
        public static string ReportURL
        {
            get
            {
                return ConfigurationManager.AppSettings["reportURL"];
            }
        }
        public static string PlayerFileURL
        {
            get
            {
                return ConfigurationManager.AppSettings["playerFileURL"];
            }
        }
        public static string SubmitTurnURL
        {
            get
            {
                return ConfigurationManager.AppSettings["submitTurnURL"];
            }
        }
        public static int ShipTargetRadius
        {
            get
            {
                return int.Parse(ConfigurationManager.AppSettings["shipTargetRadius"]);
            }
        }
        public static string VideoPlayerCall
        {
            get
            {
                return ConfigurationManager.AppSettings["videoPlayerCall"];
            }
        }

    }
}
