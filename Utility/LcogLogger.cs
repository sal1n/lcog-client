using System;
using System.IO;

namespace LcogClient.Utility
{
    /// <summary>
    /// Ultra-simple logging.
    /// </summary>
    public class LcogLogger
    {
        public static void Log(string text)
        {
            using (StreamWriter writer = new StreamWriter("lcog-client.log", true))
            {
                writer.WriteLine("==============================================================");
                writer.WriteLine("LcogClient - Error...Jim probably attempting to cheat!");
                writer.WriteLine(DateTime.Now.ToString());
                writer.Write(text);
                writer.WriteLine("==============================================================");
            }
        }
    }
}
