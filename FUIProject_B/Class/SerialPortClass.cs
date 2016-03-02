using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FUIProject_B.Class
{
    class SerialPortClass
    {
        static SerialPortClass _SerialPortClass;

        public static SerialPortClass GetInstance()
        {
            if (_SerialPortClass == null)
            {
                _SerialPortClass = new SerialPortClass();
            }
            return _SerialPortClass;
        }

        private SerialPortClass()
        {
        }

        #region 变量标志位

        private int _PortIndex = -1;
        public int PortIndex
        {
            get
            {
                return _PortIndex;
            }
            set
            {
                if (_PortIndex != value)
                {
                    _PortIndex = value;
                }
            }
        }

        private bool _spIsOpen = false;
        public bool spIsOpen
        {
            get
            {
                return _spIsOpen;
            }
            set
            {
                if (_spIsOpen != value)
                {
                    _spIsOpen = value;
                    if (SerialPortOpenTagChangedEvent != null)
                    {
                        SerialPortOpenTagChangedEvent(_spIsOpen);
                    }
                }
            }
        }

        private int _ReceiveCount = 0;
        public int ReceiveCount
        {
            get
            {
                return _ReceiveCount;
            }
            set
            {
                if (_ReceiveCount != value)
                {
                    _ReceiveCount = value;
                    if (ReceiveCountChangedEvent != null)
                    {
                        ReceiveCountChangedEvent(_ReceiveCount);
                    }
                }
            }
        }

        private int _SendCount = 0;
        public int SendCount
        {
            get
            {
                return _SendCount;
            }
            set
            {
                if (_SendCount != value)
                {
                    _SendCount = value;
                    if (SendCountChangedEvent != null)
                    {
                        SendCountChangedEvent(SendCount);
                    }
                }
            }
        }

        #endregion


        #region 变量定义


        #endregion

        #region 自身类委托事件

        public delegate void ReceiveDataArrivedEventHandler(byte[] ReceiveData);
        public event ReceiveDataArrivedEventHandler ReceiveDataArrivedEvent;

        public delegate void ReceiveCountChangedEventHandler(int ReceiveCount);
        public event ReceiveCountChangedEventHandler ReceiveCountChangedEvent;

        public delegate void SendDataArrivedEventHandler(byte[] SendData);
        public event SendDataArrivedEventHandler SendDataArrivedEvent;

        public delegate void SendCountChangedEventHandler(int SendCount);
        public event SendCountChangedEventHandler SendCountChangedEvent;

        public delegate void SerialPortNotOpenEventHandler();
        public event SerialPortNotOpenEventHandler SerialPortNotOpenEvent;

        public delegate void SerialPortOpenTagChangedEventHandler(bool spIsOpen);
        public event SerialPortOpenTagChangedEventHandler SerialPortOpenTagChangedEvent;


        #endregion

        #region 公共方法

        public void OpenSerialPort(int PortIndex)
        {
            this.PortIndex = PortIndex;
            spIsOpen = true;
        }

        public void CloseSerialPort()
        {
            PortIndex = -1;
            spIsOpen = false;
        }

        public string GetPortNameByIndex(int PortIndex)
        {
            if (PortIndex >= 0)
            {
                return "COM" + (PortIndex + 1).ToString();
            }
            else
            {
                return "N/A";
            }
        }

        public void CommandSendAction(byte[] Command)
        {
            if (spIsOpen)
            {
                SendCount += Command.Length;
                if (SendDataArrivedEvent != null)
                {
                    SendDataArrivedEvent(Command);
                }
            }
            else
            {
                if (SerialPortNotOpenEvent != null)
                {
                    SerialPortNotOpenEvent();
                }
            }
        }

        #endregion


        #region 测试方法

        byte[] TestData = new byte[] { 0x55, 0xaa, 0x02, 0x12, 0x45, 0x00, 0x27, 0x00, 0x57, 0xf0 };
        public void TestReceiveData()
        {
            ReceiveCount += TestData.Length;
            if (ReceiveDataArrivedEvent != null)
            {
                ReceiveDataArrivedEvent(TestData);
            }
        }

        #endregion
    }
}
