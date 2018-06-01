using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SimpleWifi;
using SimpleWifi.Win32;
using DevComponents.DotNetBar.Metro;

namespace SmartHome_App
{
    public partial class ConnectSpecifiedWlanForm : MetroForm
    {
        private static Wifi wifi;
        public ConnectSpecifiedWlanForm()
        {
            InitializeComponent();
            wifi = new Wifi();
            List_Wlan();
        }

        #region Wifi Operation
        private static void Disconnect()
        {
            wifi.Disconnect();
        }

        private static IEnumerable<AccessPoint> List()
        {
            IEnumerable<AccessPoint> accessPoints = wifi.GetAccessPoints().OrderByDescending(ap => ap.SignalStrength);

            int i = 0;
            foreach (AccessPoint ap in accessPoints)
                Console.WriteLine("{0}. {1} {2}% Connected: {3}", i++, ap.Name, ap.SignalStrength, ap.IsConnected);

            return accessPoints;
        }

        private void List_Wlan()
        {
            IEnumerable<AccessPoint> accessPoints = List();
            int i = 0;
            foreach (AccessPoint ap in accessPoints)
                WlanList_listBoxAdv.Items.Add(string.Format("{0}     信号强度：{1}%     是否连接：{2}", ap.Name, ap.SignalStrength,ap.IsConnected));
        }
        
        private static void Connect()
        {
            var accessPoints = List();

            Console.Write("\r\nEnter the index of the network you wish to connect to: ");

            int selectedIndex = int.Parse(Console.ReadLine());
            if (selectedIndex > accessPoints.ToArray().Length || accessPoints.ToArray().Length == 0)
            {
                Console.Write("\r\nIndex out of bounds");
                return;
            }
            AccessPoint selectedAP = accessPoints.ToList()[selectedIndex];

            // Auth
            AuthRequest authRequest = new AuthRequest(selectedAP);
            bool overwrite = true;

            if (authRequest.IsPasswordRequired)
            {
                if (selectedAP.HasProfile)
                // If there already is a stored profile for the network, we can either use it or overwrite it with a new password.
                {
                    Console.Write("\r\nA network profile already exist, do you want to use it (y/n)? ");
                    if (Console.ReadLine().ToLower() == "y")
                    {
                        overwrite = false;
                    }
                }

                if (overwrite)
                {
                    if (authRequest.IsUsernameRequired)
                    {
                        Console.Write("\r\nPlease enter a username: ");
                        authRequest.Username = Console.ReadLine();
                    }

                    authRequest.Password = PasswordPrompt(selectedAP);

                    if (authRequest.IsDomainSupported)
                    {
                        Console.Write("\r\nPlease enter a domain: ");
                        authRequest.Domain = Console.ReadLine();
                    }
                }
            }

            selectedAP.ConnectAsync(authRequest, overwrite, OnConnectedComplete);
        }

        private static string PasswordPrompt(AccessPoint selectedAP)
        {
            string password = string.Empty;

            bool validPassFormat = false;

            while (!validPassFormat)
            {
                Console.Write("\r\nPlease enter the wifi password: ");
                password = Console.ReadLine();

                validPassFormat = selectedAP.IsValidPassword(password);

                if (!validPassFormat)
                    Console.WriteLine("\r\nPassword is not valid for this network type.");
            }

            return password;
        }
        private static void Status()
        {
            if (wifi.ConnectionStatus == WifiStatus.Connected)
                Console.WriteLine("You are connected to a wifi");
            else
                Console.WriteLine("You are not connected to a wifi");
        }

        private static void OnConnectedComplete(bool success)
        {
            Console.WriteLine("\nOnConnectedComplete, success: {0}", success);
        }
        #endregion
    }
}
