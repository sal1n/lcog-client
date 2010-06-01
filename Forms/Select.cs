using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

using LcogClient.Controls;
using LcogClient.Model;

namespace LcogClient.Forms
{
    public partial class Select : Base
    {
        public List<Model.MapObject> MapObjects { get; set; }

        public Select()
        {
            InitializeComponent();
        }

        public Select(string title, List<Model.MapObject> mapObjects)
        {
            InitializeComponent();

            this.Text = title + "    |    Lost Colonies of Guernsey";
            this.MapObjects = mapObjects;

            foreach (Model.MapObject obj in this.MapObjects)
            {
                OtherObject moveObject = new OtherObject(obj);
                this.flowLayoutPanel.Controls.Add(moveObject);
            }
        }
    }
}