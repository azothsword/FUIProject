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

using FUIProject_A.Class;
using FUIProject_A.Class.ObjectClass;

namespace FUIProject_A.Controls.SimpleControls
{
    /// <summary>
    /// Interaction logic for ButtonType1.xaml
    /// </summary>
    public partial class ButtonType1 : UserControl
    {
        public ButtonType1()
        {
            InitializeComponent();

            _SerialPortClass = SerialPortClass.GetInstance();
        }

        private string _ButtonStr = "";
        public string ButtonStr
        {
            get
            {
                return _ButtonStr;
            }
            set
            {
                if (_ButtonStr != value)
                {
                    _ButtonStr = value;
                    ButtonText.Text = value;
                }
            }
        }

        #region 变量定义

        CommandObjClass _CommandObjClass;

        SerialPortClass _SerialPortClass;

        #endregion

        #region 界面事件

        private void UserControl_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            ((Storyboard)Resources["MouseEnterAction"]).Begin();
        }

        private void UserControl_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            ((Storyboard)Resources["MouseLeaveAction"]).Begin();
        }

        private void UserControl_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ((Storyboard)Resources["MouseLeftButtonDownAction"]).Begin();
            if (_CommandObjClass != null && _CommandObjClass.PressCommand != null)
            {
                _SerialPortClass.CommandSendAction(_CommandObjClass.PressCommand);
            }
        }

        private void UserControl_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ((Storyboard)Resources["MouseEnterAction"]).Begin();
            if (_CommandObjClass != null && _CommandObjClass.ReleaseCommand != null)
            {
                _SerialPortClass.CommandSendAction(_CommandObjClass.ReleaseCommand);
            }
        }

        #endregion


        #region 公共方法

        public void BindingCommandObj(CommandObjClass _CommandObjClass)
        {
            this._CommandObjClass = _CommandObjClass;
            ButtonStr = _CommandObjClass.CommandName;
        }

        #endregion
    }
}
