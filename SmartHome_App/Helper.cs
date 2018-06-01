using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHome_App
{
    public class Helper
    {
        public const string sConnectWifi = "已连接至Wifi";
        public const string sDisconnectWifi = "未连接至Wifi";

        public const string sConnectToDevice = "已连接至设备";
        public const string sDisconnectToDevice = "未连接至设备";

        public const string sStartDetect = "开始采集";
        public const string sStopDetect = "停止采集";

        public const string sHavePerson = "有人";
        public const string sHaveNoPerson = "无人";

        public const string sGasNormal = "正常";
        public const string sGasWorning = "气体泄漏";
    }
    public class WlanData
    {
        private int _Id;
        public int Id
        {
            get { return _Id; }
            set
            {
                _Id = value;
            }
        }

        private string _Name;
        public string Name
        {
            get { return _Name; }
            set
            {
                _Name = value;
            }
        }

        public WlanData(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
