using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

using LcogClient.Model;

using Microsoft.DirectX.AudioVideoPlayback;

namespace LcogClient.Forms
{
    public partial class VCR : Base
    {
        private Video video;

        public VCR()
        {
            InitializeComponent();

            FileInfo filei = new FileInfo(System.Reflection.Assembly.GetExecutingAssembly().Location);
            DirectoryInfo directory = filei.Directory;

            List<Button> buttons = new List<Button>();

            foreach (FileInfo file in directory.GetFiles())
            {
                if (file.Extension == ".avi")
                {
                    Button b = new Button();
                    b.Name = file.Name;
                    b.Text = this.GetDescription(file.Name.Substring(0, file.Name.Length - 4));
                    // piggyback on tab index as property for turn, i know hacky
                    b.TabIndex = this.GetTurn(file.Name.Substring(0, file.Name.Length - 4));
                    b.AutoSize = true;
                    b.TextAlign = System.Drawing.ContentAlignment.TopLeft;
                    b.Click += new EventHandler(b_Click);
                    buttons.Add(b);
                }
            }
            // sort in descending score order
            buttons.Sort(delegate(Button a, Button b) { return a.TabIndex.CompareTo(b.TabIndex); });
            buttons.Reverse();
            foreach (Button b in buttons)
            {
                this.flowLayoutPanel.Controls.Add(b);
            }
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            if (this.video != null)
            {
                this.video.Dispose();
            }
            base.OnFormClosed(e);
        }

        private string GetDescription(string fileName)
        {
            try
            {
                string description = "";
                string[] s = fileName.Split(new char[] { '_' });

                if (Client.Instance.Player.Turn == this.GetTurn(fileName))
                {
                    description += "NEW combat!\n";
                }
                else
                {
                    description += "Turn: " + s[1] + "\n";
                }
                description += "Location: " + s[2] + "\n";
                description += "Factions: " + s[3];

                return description;
            }
            catch
            {
                return fileName;
            }
        }

        private int GetTurn(string fileName)
        {
            try
            {
                string[] s = fileName.Split(new char[] { '_' });

                string t = s[1];
                return int.Parse(t);
            }
            catch
            {
                return 0;
            }
        }

        void b_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if (this.video != null)
            {
                this.video.Dispose();
            }

            this.video = new Video(b.Name);
            video.Size = this.panel.Size;
            video.Owner = this.panel;
            video.Play();
        }
    }
}
