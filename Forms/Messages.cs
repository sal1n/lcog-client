using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

using LcogClient.Model;

namespace LcogClient.Forms
{
    /// <summary>
    /// Form to display messages from the report.
    /// </summary>
    public partial class Messages : Base
    {
        public Messages()
        {
            InitializeComponent();

            foreach (Model.Message message in Client.Instance.Player.Messages)
            {
                this.flowLayoutPanel.Controls.Add(new Controls.Message(message));
            }
        }
    }
}
