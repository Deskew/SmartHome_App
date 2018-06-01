namespace SmartHome_App
{
    partial class ConnectSpecifiedWlanForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.WlanList_listBoxAdv = new DevComponents.DotNetBar.ListBoxAdv();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // WlanList_listBoxAdv
            // 
            this.WlanList_listBoxAdv.AutoScroll = true;
            // 
            // 
            // 
            this.WlanList_listBoxAdv.BackgroundStyle.Class = "ListBoxAdv";
            this.WlanList_listBoxAdv.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.WlanList_listBoxAdv.ContainerControlProcessDialogKey = true;
            this.WlanList_listBoxAdv.DragDropSupport = true;
            this.WlanList_listBoxAdv.Location = new System.Drawing.Point(12, 0);
            this.WlanList_listBoxAdv.Name = "WlanList_listBoxAdv";
            this.WlanList_listBoxAdv.Size = new System.Drawing.Size(456, 260);
            this.WlanList_listBoxAdv.TabIndex = 0;
            this.WlanList_listBoxAdv.Text = "listBoxAdv1";
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Location = new System.Drawing.Point(502, 43);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(96, 38);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 1;
            this.buttonX1.Text = "连接";
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX2.Location = new System.Drawing.Point(502, 128);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Size = new System.Drawing.Size(96, 33);
            this.buttonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX2.TabIndex = 2;
            this.buttonX2.Text = "断开";
            // 
            // ConnectSpecifiedWlanForm
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(610, 280);
            this.Controls.Add(this.buttonX2);
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.WlanList_listBoxAdv);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConnectSpecifiedWlanForm";
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ListBoxAdv WlanList_listBoxAdv;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.ButtonX buttonX2;
    }
}
