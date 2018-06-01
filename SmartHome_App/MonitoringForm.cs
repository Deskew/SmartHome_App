using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Net;
using System.Net.Sockets;
using System.IO;

using DevComponents.DotNetBar.Metro;

namespace SmartHome_App
{
    public partial class MonitoringForm : MetroForm
    {
        private TcpClient client;
        public StreamReader str;
        public StreamWriter stw;
        public string recieve;
        public String textToSend;
        private bool isConnectToDevice;
        private bool isStartDetec;
        private System.Timers.Timer timer;
        public MonitoringForm()
        {
            InitializeComponent();
            IPAddress[] localIP = Dns.GetHostAddresses(Dns.GetHostName());      //Get any IP
            foreach (IPAddress address in localIP)
            {
                if (address.AddressFamily == AddressFamily.InterNetwork)
                {
                    IPAdress_textBoxX.Text = address.ToString();
                }
            }
            isConnectToDevice = false;
            isStartDetec = false;
            StartDetect_buttonX.Enabled = false;
        }
        /// <summary>
        /// 开始采集
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartDetect_buttonX_Click(object sender, EventArgs e)
        {
            if (isStartDetec == true)
            {
                timer.Stop();
                timer.Dispose();
                isStartDetec = false;
                StartDetect_buttonX.Text = Helper.sDisconnectToDevice;
                StartDetect_buttonX.BackColor = SystemColors.MenuHighlight;
            }
            else
            {

                timer = new System.Timers.Timer(Interval_trackBar.Value);
                timer.AutoReset = true;
                timer.Elapsed += new System.Timers.ElapsedEventHandler(GetData_FromDevice);
                timer.Start();
                isStartDetec = true;
                StartDetect_buttonX.Text = Helper.sConnectToDevice;
                StartDetect_buttonX.BackColor = SystemColors.Control;
            }
        }
        /// <summary>
        /// 连接到设备
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConnectToDevice_buttonX_Click(object sender, EventArgs e)
        {
            if (isConnectToDevice == false)
            {
                try
                {
                    client = new TcpClient();
                    IPEndPoint ip_End = new IPEndPoint(IPAddress.Parse(IPAdress_textBoxX.Text), int.Parse(Port_textBoxX.Text));
                    client.Connect(ip_End);
                    if (client.Connected)
                    {
                        stw = new StreamWriter(client.GetStream());
                        str = new StreamReader(client.GetStream());
                        stw.AutoFlush = true;
                        ConnectToDevice_buttonX.Image = Properties.Resources.Actions_network_connect_icon;
                        ConnectToDevice_buttonX.Text = Helper.sConnectToDevice;
                        isConnectToDevice = true;
                        StartDetect_buttonX.Enabled = true;
                    }
                }
                catch (Exception x)
                {
                    isConnectToDevice = false;
                    ConnectToDevice_buttonX.Image = Properties.Resources.Actions_network_disconnect_icon;
                    ConnectToDevice_buttonX.Text = Helper.sDisconnectToDevice;
                    MessageBox.Show(x.Message.ToString());
                }
            }
            else
            {
                try
                {
                    client.Close();
                    isConnectToDevice = false;
                    ConnectToDevice_buttonX.Image = Properties.Resources.Actions_network_disconnect_icon;
                    ConnectToDevice_buttonX.Text = Helper.sDisconnectToDevice;
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.Message.ToString());
                }
            }

        }
        private void GetData_FromDevice(object sender, System.Timers.ElapsedEventArgs e)
        {
            timer.Stop();
            stw.WriteLine("GetData");
            Receive_backgroundWorker.RunWorkerAsync();
        }
        /// <summary>
        /// 接收并更新数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Receive_backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            while (client.Connected)
            {
                try
                {
                    bool warning = false;
                    recieve = str.ReadLine();
                    if (recieve.Length == 6)
                    {
                        //气体泄漏否
                        if (recieve.Remove(1,5).Equals("1"))
                        {
                            this.GasValue_labelX.Invoke(new MethodInvoker(delegate ()
                            { GasValue_labelX.Text = Helper.sGasWorning; }));
                            warning = true;
                        }
                        else
                        {
                            this.GasValue_labelX.Invoke(new MethodInvoker(delegate ()
                            { GasValue_labelX.Text = Helper.sGasNormal; }));
                        }
                        //有人否
                        if (recieve.Remove(0, 1).Remove(1,4).Equals("1"))
                        {
                            this.PersonValue_labelX.Invoke(new MethodInvoker(delegate ()
                            { PersonValue_labelX.Text = Helper.sHavePerson; }));
                            warning = true;
                        }
                        else
                        {
                            this.PersonValue_labelX.Invoke(new MethodInvoker(delegate ()
                            { PersonValue_labelX.Text = Helper.sHaveNoPerson; }));                           
                        }
                        if (warning == true)
                        {
                            this.RedBubble_button.Invoke(new MethodInvoker(delegate ()
                            { RedBubble_button.SymbolColor = Color.Red; }));
                        }
                        else
                        {
                            this.RedBubble_button.Invoke(new MethodInvoker(delegate ()
                            { RedBubble_button.SymbolColor = Color.Gray; }));
                        }
                        //温度
                        this.TemperatureValue_labelX.Invoke(new MethodInvoker(delegate ()
                        { TemperatureValue_labelX.Text = recieve.Remove(0, 2).Remove(2, 2); }));
                        //湿度
                        this.HumidityValue_labelX.Invoke(new MethodInvoker(delegate ()
                        { HumidityValue_labelX.Text = recieve.Remove(0, 4); }));
                        break;
                    }
                    else
                    {

                    }
                }
                catch (Exception x)
                {
                    timer.Stop();
                    //StartDetect_buttonX.Text = Helper.sDisconnectToDevice;
                    //StartDetect_buttonX.BackColor = SystemColors.Control;
                    MessageBox.Show(x.Message.ToString());
                }
                //Receive_backgroundWorker.CancelAsync();                
            }
        }

        private void Receive_backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            timer.Start();
        }

        private void Interval_NumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            Interval_trackBar.Value = (int)Interval_NumericUpDown.Value;
        }

        private void Interval_trackBar_ValueChanged(object sender, EventArgs e)
        {
            Interval_NumericUpDown.Value = Interval_trackBar.Value;
        }
    }
}
