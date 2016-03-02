using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using System.Windows.Media.Animation;
using FUIProject.Class;

namespace FUIProject.Controls.SimpleControls
{
    /// <summary>
    /// Interaction logic for PortStatePanel.xaml
    /// </summary>
    public partial class PortStatePanel : UserControl
    {
        public PortStatePanel()
        {
            InitializeComponent();


            _SerialPortClass = SerialPortClass.GetInstance();
            _SerialPortClass.ReceiveCountChangedEvent += new SerialPortClass.ReceiveCountChangedEventHandler(_SerialPortClass_ReceiveCountChangedEvent);
            _SerialPortClass.ReceiveDataArrivedEvent += new SerialPortClass.ReceiveDataArrivedEventHandler(_SerialPortClass_ReceiveDataArrivedEvent);
            _SerialPortClass.SendCountChangedEvent += new SerialPortClass.SendCountChangedEventHandler(_SerialPortClass_SendCountChangedEvent);
            _SerialPortClass.SendDataArrivedEvent += new SerialPortClass.SendDataArrivedEventHandler(_SerialPortClass_SendDataArrivedEvent);
        }

        #region 变量标志位

        private string _ReceiveContentStr = "";
        public string ReceiveContentStr
        {
            get
            {
                return _ReceiveContentStr;
            }
            set
            {
                if (_ReceiveContentStr != value)
                {
                    _ReceiveContentStr = value;
                    ReceiveDataText.Text = value;
                    if (ReceiveDataText.ActualHeight > ReceiveDataGrid.ActualHeight)
                    {
                        ReceiveDataText.VerticalAlignment = System.Windows.VerticalAlignment.Bottom;
                    }
                    else
                    {
                        ReceiveDataText.VerticalAlignment = System.Windows.VerticalAlignment.Top;
                    }
                }
            }
        }

        private string _SendContentStr = "";
        public string SendContentStr
        {
            get
            {
                return _SendContentStr;
            }
            set
            {
                if (_SendContentStr != value)
                {
                    _SendContentStr = value;
                    SendDataText.Text = value;
                    if (SendDataText.ActualHeight > SendDataGrid.ActualHeight)
                    {
                        SendDataText.VerticalAlignment = System.Windows.VerticalAlignment.Bottom;
                    }
                    else
                    {
                        SendDataText.VerticalAlignment = System.Windows.VerticalAlignment.Top;
                    }
                }
            }
        }


        #endregion

        #region 变量定义


        SerialPortClass _SerialPortClass;

        #endregion

        #region 界面委托事件

        void _SerialPortClass_SendDataArrivedEvent(byte[] SendData)
        {
            for (int i = 0; i < SendData.Length; i++)
            {
                SendContentStr += "0x" + SendData[i].ToString("X2") + " ";
            }
        }

        void _SerialPortClass_SendCountChangedEvent(int SendCount)
        {
            SendBytesCountText.Text = SendCount.ToString();
        }

        void _SerialPortClass_ReceiveDataArrivedEvent(byte[] ReceiveData)
        {
            for (int i = 0; i < ReceiveData.Length; i++)
            {
                ReceiveContentStr += "0x" + ReceiveData[i].ToString("X2") + " ";
            }
        }

        void _SerialPortClass_ReceiveCountChangedEvent(int ReceiveCount)
        {
            ReceivedBytesCountText.Text = ReceiveCount.ToString();
        }


        #endregion


        #region 公共方法

        public void SetPortNameText(int PortIndex)
        {
            PortNameText.Text = _SerialPortClass.GetPortNameByIndex(PortIndex);
        }

        #endregion
    }
}
