using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

using LcogClient.Model;

namespace LcogClient.Controls
{
    public partial class Message : Base
    {
        public Message(Model.Message message)
        {
            InitializeComponent();

            this.labelFrom.Text = "from " + message.From;
            this.labelType.Text = message.Type;
            this.labelMessage.Text = message.Body;
        }
    }
}
