using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

using LcogClient.Model;
using LcogClient.Utility;

namespace LcogClient.Controls
{
    public partial class FactoryComponent : Base
    {
        public Model.MapObject MapObject { get; set; }
        public bool IsBuild { get; set; }

        public FactoryComponent()
        {
            InitializeComponent();
        }

        public FactoryComponent(Model.MapObject obj, bool isBuild)
        {
            InitializeComponent();

            this.MapObject = obj;
            this.IsBuild = isBuild;

            this.pictureBoxFactory.Image = LcogImage.Resize(this.pictureBoxFactory.Image, 24, 24);
            this.buttonBuild.Image = LcogImage.Resize(this.buttonBuild.Image, 16, 16);
            this.buttonCancelBuild.Image = LcogImage.Resize(this.buttonCancelBuild.Image, 16, 16);
            this.UpdateView();
        }

        private void UpdateView()
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(this.pictureBoxFactory, "Factory component");

            Model.MapObject obj = this.MapObject;

            this.labelFactories.Text = this.MapObject.Components.GetComponentCount("factory").ToString();

            if (obj.HasBuildOrder())
            {
                this.labelBuild.Visible = true;
                this.labelBuild.Text = "Building a new ship";
                this.buttonCancelBuild.Visible = true;
                this.buttonBuild.Visible = false;
            }
            else
            {
                this.labelBuild.Visible = false;
                this.buttonCancelBuild.Visible = false;
                this.buttonBuild.Visible = true;
            }

            if (obj.HasUpgradeOrder())
            {
                this.labelBuild.Visible = true;
                this.labelBuild.Text = "Upgrade " + Client.Instance.Player.Orders.GetUpgradeOrder(obj).Target.Name;
                this.buttonCancelBuild.Visible = true;
                this.buttonBuild.Visible = false;
            }

            if (this.IsBuild)
            {
                this.labelBuild.Visible = false;
                this.buttonBuild.Visible = false;
                this.buttonCancelBuild.Visible = false;
                this.Width = 70;
            }
        }

        private void buttonBuild_Click(object sender, EventArgs e)
        {
            Forms.Build form = new Forms.Build();
            form.ShowDialog();
            Client.Instance.UpdateView();
            //this.UpdateView();
        }

        private void buttonCancelBuild_Click(object sender, EventArgs e)
        {
            Client.Instance.Player.Orders.CancelBuild(Client.Instance.Selected);
            Client.Instance.UpdateView();
        }

        private void labelBuild_Click(object sender, EventArgs e)
        {

        }

        private void labelFactories_Click(object sender, EventArgs e)
        {

        }
    }
}
