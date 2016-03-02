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
using FUIProject.Class.ObjectClass;

namespace FUIProject.Controls.SimpleControls
{
    /// <summary>
    /// Interaction logic for ControlPanelCommandButton.xaml
    /// </summary>
    public partial class ControlPanelCommandButton : UserControl
    {
        public ControlPanelCommandButton()
        {
            InitializeComponent();

            _SerialPortClass = SerialPortClass.GetInstance();
        }

        #region 变量标志位

        private string _ButtonTextStr = "Button";
        public string ButtonTextStr
        {
            get
            {
                return _ButtonTextStr;
            }
            set
            {
                if (_ButtonTextStr != value)
                {
                    _ButtonTextStr = value;
                    ButtonText.Text = value;
                }
            }
        }

        #endregion

        #region 变量定义

        CommandObjClass _CommandObjClass;
        SerialPortClass _SerialPortClass;

        #endregion

        #region 自身类委托事件

        public delegate void PressCommandSendEventHandler(byte[] PressCommand);
        public event PressCommandSendEventHandler PressCommandSendEvent;

        public delegate void ReleaseCommandSendEventHandler(byte[] ReleaseCommand);
        public event ReleaseCommandSendEventHandler ReleaseCommandSendEvent;

        #endregion

        private void UserControl_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ((Storyboard)Resources["ButtonDownAction"]).Begin();
            if (_CommandObjClass.PressCommand != null)
            {
                _SerialPortClass.CommandSendAction(_CommandObjClass.PressCommand);
                if (PressCommandSendEvent != null)
                {
                    PressCommandSendEvent(_CommandObjClass.PressCommand);
                }
            }
        }

        private void UserControl_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ((Storyboard)Resources["ButtonUpAction"]).Begin();
            if (_CommandObjClass.ReleaseCommand != null)
            {
                _SerialPortClass.CommandSendAction(_CommandObjClass.ReleaseCommand);
                if (ReleaseCommandSendEvent != null)
                {
                    ReleaseCommandSendEvent(_CommandObjClass.ReleaseCommand);
                }
            }
        }

        private void UserControl_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            ((Storyboard)Resources["ButtonUpAction"]).Begin();
        }

        #region 公共方法

        public void BindingCommandObjClass(CommandObjClass _CommandObjClass)
        {
            this._CommandObjClass = _CommandObjClass;
            ButtonTextStr = _CommandObjClass.CommandName;
        }


        #endregion
    }
}
