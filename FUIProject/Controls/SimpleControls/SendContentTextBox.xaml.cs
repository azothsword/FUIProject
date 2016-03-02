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
    /// Interaction logic for SendContentTextBox.xaml
    /// </summary>
    public partial class SendContentTextBox : UserControl
    {
        public SendContentTextBox()
        {
            InitializeComponent();

            CursorTimer.Interval = 500;
            CursorTimer.Elapsed += new System.Timers.ElapsedEventHandler(CursorTimer_Elapsed);
            CursorTimer.Start();
        }

        void CursorTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            Action action = () =>
            {
                if (CursorShowTag)
                {
                    SendContentTextStr = SendContentStr;
                }
                else
                {
                    SendContentTextStr = SendContentStr + "_";
                }
                CursorShowTag = !CursorShowTag;
            };
            this.Dispatcher.Invoke(action);
        }

        #region 变量标志位

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
                    SendContentText.Text = value;
                }
            }
        }


        private string _SendContentTextStr = "";
        public string SendContentTextStr
        {
            get
            {
                return _SendContentTextStr;
            }
            set
            {
                if (_SendContentTextStr != value)
                {
                    _SendContentTextStr = value;
                    SendContentText.Text = value;
                }
            }
        }

        #endregion

        #region 变量定义

        System.Timers.Timer CursorTimer = new System.Timers.Timer();
        bool CursorShowTag = false;

        #endregion

        #region 公共方法

        public void GetInputCommand(byte[] Command)
        {
            SendContentStr = "";
            for (int i = 0; i < Command.Length; i++)
            {
                if (i != Command.Length - 1)
                {
                    SendContentStr += "0x" + Command[i].ToString("X2") + " ";
                }
                else
                {
                    SendContentStr += "0x" + Command[i].ToString("X2");
                }
            }
        }

        public void GetInputContent(CommonToolsClass.SendContentTypeEnum SendContentType)
        {
            if (SendContentType == CommonToolsClass.SendContentTypeEnum.Num0)
            {
                SendContentStr += "0";
            }
            else if (SendContentType == CommonToolsClass.SendContentTypeEnum.Num1)
            {
                SendContentStr += "1";
            }
            else if (SendContentType == CommonToolsClass.SendContentTypeEnum.Num2)
            {
                SendContentStr += "2";
            }
            else if (SendContentType == CommonToolsClass.SendContentTypeEnum.Num3)
            {
                SendContentStr += "3";
            }
            else if (SendContentType == CommonToolsClass.SendContentTypeEnum.Num4)
            {
                SendContentStr += "4";
            }
            else if (SendContentType == CommonToolsClass.SendContentTypeEnum.Num5)
            {
                SendContentStr += "5";
            }
            else if (SendContentType == CommonToolsClass.SendContentTypeEnum.Num6)
            {
                SendContentStr += "6";
            }
            else if (SendContentType == CommonToolsClass.SendContentTypeEnum.Num7)
            {
                SendContentStr += "7";
            }
            else if (SendContentType == CommonToolsClass.SendContentTypeEnum.Num8)
            {
                SendContentStr += "8";
            }
            else if (SendContentType == CommonToolsClass.SendContentTypeEnum.Num9)
            {
                SendContentStr += "9";
            }
            else if (SendContentType == CommonToolsClass.SendContentTypeEnum.NumA)
            {
                SendContentStr += "A";
            }
            else if (SendContentType == CommonToolsClass.SendContentTypeEnum.NumB)
            {
                SendContentStr += "B";
            }
            else if (SendContentType == CommonToolsClass.SendContentTypeEnum.NumC)
            {
                SendContentStr += "C";
            }
            else if (SendContentType == CommonToolsClass.SendContentTypeEnum.NumD)
            {
                SendContentStr += "D";
            }
            else if (SendContentType == CommonToolsClass.SendContentTypeEnum.NumE)
            {
                SendContentStr += "E";
            }
            else if (SendContentType == CommonToolsClass.SendContentTypeEnum.NumF)
            {
                SendContentStr += "F";
            }
            else if (SendContentType == CommonToolsClass.SendContentTypeEnum.NumX)
            {
                SendContentStr += "x";
            }
            else if (SendContentType == CommonToolsClass.SendContentTypeEnum.NumSpace)
            {
                SendContentStr += " ";
            }
            else if (SendContentType == CommonToolsClass.SendContentTypeEnum.NumBackSpace)
            {
                if (SendContentStr.Length >= 1)
                {
                    SendContentStr = SendContentStr.Substring(0, SendContentStr.Length - 1);
                }
            }
            else if (SendContentType == CommonToolsClass.SendContentTypeEnum.NumEnter)
            {
            }
        }

        #endregion
    }
}
