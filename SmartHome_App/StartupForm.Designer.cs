namespace SmartHome_App
{
    partial class StartupForm
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
            this.metroTilePanel1 = new DevComponents.DotNetBar.Metro.MetroTilePanel();
            this.ConnectSpecifiedWlan_metroTileItem = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.StartCheckStatus_metroTileItem = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.SuspendLayout();
            // 
            // metroTilePanel1
            // 
            // 
            // 
            // 
            this.metroTilePanel1.BackgroundStyle.Class = "MetroTilePanel";
            this.metroTilePanel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroTilePanel1.ContainerControlProcessDialogKey = true;
            this.metroTilePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTilePanel1.DragDropSupport = true;
            this.metroTilePanel1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.ConnectSpecifiedWlan_metroTileItem,
            this.StartCheckStatus_metroTileItem});
            this.metroTilePanel1.ItemSpacing = 8;
            this.metroTilePanel1.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.metroTilePanel1.Location = new System.Drawing.Point(14, 16);
            this.metroTilePanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.metroTilePanel1.Name = "metroTilePanel1";
            this.metroTilePanel1.Size = new System.Drawing.Size(236, 230);
            this.metroTilePanel1.TabIndex = 0;
            this.metroTilePanel1.Text = "metroTilePanel1";
            // 
            // ConnectSpecifiedWlan_metroTileItem
            // 
            this.ConnectSpecifiedWlan_metroTileItem.ImageIndent = new System.Drawing.Point(2, 0);
            this.ConnectSpecifiedWlan_metroTileItem.ImageTextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.ConnectSpecifiedWlan_metroTileItem.Name = "ConnectSpecifiedWlan_metroTileItem";
            this.ConnectSpecifiedWlan_metroTileItem.NotificationMarkColor = System.Drawing.Color.White;
            this.ConnectSpecifiedWlan_metroTileItem.NotificationMarkPosition = DevComponents.DotNetBar.eNotificationMarkPosition.TopRight;
            this.ConnectSpecifiedWlan_metroTileItem.Symbol = "";
            this.ConnectSpecifiedWlan_metroTileItem.SymbolColor = System.Drawing.Color.Empty;
            this.ConnectSpecifiedWlan_metroTileItem.SymbolSize = 35F;
            this.ConnectSpecifiedWlan_metroTileItem.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Gray;
            this.ConnectSpecifiedWlan_metroTileItem.TileSize = new System.Drawing.Size(120, 70);
            // 
            // 
            // 
            this.ConnectSpecifiedWlan_metroTileItem.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ConnectSpecifiedWlan_metroTileItem.TitleText = "未连接！";
            this.ConnectSpecifiedWlan_metroTileItem.Click += new System.EventHandler(this.ConnectSpecifiedWlan_metroTileItem_Click);
            // 
            // StartCheckStatus_metroTileItem
            // 
            this.StartCheckStatus_metroTileItem.ImageIndent = new System.Drawing.Point(2, 6);
            this.StartCheckStatus_metroTileItem.ImageTextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.StartCheckStatus_metroTileItem.Name = "StartCheckStatus_metroTileItem";
            this.StartCheckStatus_metroTileItem.Symbol = "";
            this.StartCheckStatus_metroTileItem.SymbolColor = System.Drawing.Color.Empty;
            this.StartCheckStatus_metroTileItem.SymbolSize = 65F;
            this.StartCheckStatus_metroTileItem.Text = "开启监控";
            this.StartCheckStatus_metroTileItem.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.DarkGreen;
            this.StartCheckStatus_metroTileItem.TileSize = new System.Drawing.Size(200, 120);
            // 
            // 
            // 
            this.StartCheckStatus_metroTileItem.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.StartCheckStatus_metroTileItem.Click += new System.EventHandler(this.StartCheckStatus_metroTileItem_Click);
            // 
            // StartupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 262);
            this.Controls.Add(this.metroTilePanel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StartupForm";
            this.Padding = new System.Windows.Forms.Padding(14, 16, 14, 16);
            this.Text = "Smart Home";
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Metro.MetroTilePanel metroTilePanel1;
        private DevComponents.DotNetBar.Metro.MetroTileItem ConnectSpecifiedWlan_metroTileItem;
        private DevComponents.DotNetBar.Metro.MetroTileItem StartCheckStatus_metroTileItem;
    }
}