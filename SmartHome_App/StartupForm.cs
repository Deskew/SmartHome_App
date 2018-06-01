using System;

using SimpleWifi;
using DevComponents.DotNetBar.Metro;


namespace SmartHome_App
{
    public partial class StartupForm : MetroForm
    {
        public static bool IsConnectTo_Wlan;
        private Wifi wifi;
        //private System.Timers.Timer timer;
        public StartupForm()
        {
            wifi = new Wifi();
            IsConnectTo_Wlan = false;
            InitializeComponent();
            //timer = new System.Timers.Timer(300);
            //timer.AutoReset = true;
            //timer.Elapsed += new System.Timers.ElapsedEventHandler(GetData_FromDevice);        
            wifi.ConnectionStatusChanged += wifi_ConnectionStatusChanged;
            IsConnectTo_Wlan = wifi.ConnectionStatus == 0 ? false : true;
            if (IsConnectTo_Wlan == true)
            {
                ConnectSpecifiedWlan_metroTileItem.TileColor = eMetroTileColor.DarkBlue;
                ConnectSpecifiedWlan_metroTileItem.TitleText = Helper.sConnectWifi;
                StartCheckStatus_metroTileItem.Enabled = true;
            }
            else
            {
                ConnectSpecifiedWlan_metroTileItem.TileColor = eMetroTileColor.Gray;
                ConnectSpecifiedWlan_metroTileItem.TitleText = Helper.sDisconnectWifi;
                StartCheckStatus_metroTileItem.Enabled = false;
            }
            //timer.Start();
        }

        private void ConnectSpecifiedWlan_metroTileItem_Click(object sender, EventArgs e)
        {
            //ConnectSpecifiedWlanForm connectSpecifiedWlanForm = new ConnectSpecifiedWlanForm();
            //connectSpecifiedWlanForm.ShowDialog();
        }

        private void StartCheckStatus_metroTileItem_Click(object sender, EventArgs e)
        {
            MonitoringForm monitoringForm = new MonitoringForm();
            monitoringForm.ShowDialog();
        }


        private void wifi_ConnectionStatusChanged(object sender, WifiStatusEventArgs e)
        {
            IsConnectTo_Wlan = e.NewStatus == 0 ? false : true;
            if (InvokeRequired)
            {
                this.Invoke(new EventHandler(delegate
                {
                    if (IsConnectTo_Wlan == true)
                    {
                        ConnectSpecifiedWlan_metroTileItem.TileColor = eMetroTileColor.DarkBlue;
                        ConnectSpecifiedWlan_metroTileItem.TitleText = Helper.sConnectWifi;
                        StartCheckStatus_metroTileItem.Enabled = true;
                    }
                    else
                    {
                        ConnectSpecifiedWlan_metroTileItem.TileColor = eMetroTileColor.Gray;
                        ConnectSpecifiedWlan_metroTileItem.TitleText = Helper.sDisconnectWifi;
                        StartCheckStatus_metroTileItem.Enabled = false;
                    }
                }));
            }
            else
            {
                if (IsConnectTo_Wlan == true)
                {
                    ConnectSpecifiedWlan_metroTileItem.TileColor = eMetroTileColor.DarkBlue;
                    ConnectSpecifiedWlan_metroTileItem.TitleText = Helper.sConnectWifi;
                    StartCheckStatus_metroTileItem.Enabled = true;
                }
                else
                {
                    ConnectSpecifiedWlan_metroTileItem.TileColor = eMetroTileColor.Gray;
                    ConnectSpecifiedWlan_metroTileItem.TitleText = Helper.sDisconnectWifi;
                    StartCheckStatus_metroTileItem.Enabled = false;
                }
            }
        }
        //private void GetData_FromDevice(object sender, System.Timers.ElapsedEventArgs e)
        //{
        //    if (InvokeRequired)
        //    {
        //        this.Invoke(new EventHandler(delegate
        //        {
        //            if (IsConnectTo_Wlan == true)
        //            {
        //                ConnectSpecifiedWlan_metroTileItem.TileColor = eMetroTileColor.DarkBlue;
        //                ConnectSpecifiedWlan_metroTileItem.TitleText = Helper.sConnect;
        //                StartCheckStatus_metroTileItem.Enabled = true;
        //            }
        //            else
        //            {
        //                ConnectSpecifiedWlan_metroTileItem.TileColor = eMetroTileColor.Gray;
        //                ConnectSpecifiedWlan_metroTileItem.TitleText = Helper.sDisconnectWifi;
        //                StartCheckStatus_metroTileItem.Enabled = false;
        //            }
        //        }));
        //    }
        //    else
        //    {
        //        if (IsConnectTo_Wlan == true)
        //        {
        //            ConnectSpecifiedWlan_metroTileItem.TileColor = eMetroTileColor.DarkBlue;
        //            ConnectSpecifiedWlan_metroTileItem.TitleText = Helper.sConnect;
        //            StartCheckStatus_metroTileItem.Enabled = true;
        //        }
        //        else
        //        {
        //            ConnectSpecifiedWlan_metroTileItem.TileColor = eMetroTileColor.Gray;
        //            ConnectSpecifiedWlan_metroTileItem.TitleText = Helper.sDisconnectWifi;
        //            StartCheckStatus_metroTileItem.Enabled = false;
        //        }
        //    }
        //}
    }
}
