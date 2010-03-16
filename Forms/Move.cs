using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

using LcogClient.Controls;
using LcogClient.Model;

namespace LcogClient.Forms
{
    public partial class Move : Base
    {
        public List<Model.MapObject> MapObjects { get; set; }

        public Move()
        {
            InitializeComponent();
        }

        public Move(List<Model.MapObject> mapObjects)
        {
            this.MapObjects = mapObjects;

            InitializeComponent();

            foreach (Model.MapObject obj in this.MapObjects)
            {
                MoveObject moveObject = new MoveObject(obj);
                this.flowLayoutPanel.Controls.Add(moveObject);
            }

        }
    }
}
