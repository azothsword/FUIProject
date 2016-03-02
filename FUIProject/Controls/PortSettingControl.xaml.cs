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

using FUIProject.Class;
using FUIProject.Controls.SimpleControls;

namespace FUIProject.Controls
{
    /// <summary>
    /// Interaction logic for PortSettingControl.xaml
    /// </summary>
    public partial class PortSettingControl : UserControl
    {
        public PortSettingControl()
        {
            InitializeComponent();
        }


        #region 界面事件

        private void SerialPortOpenCloseButtoner_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (SerialPortOpenCloseButtoner.ButtonStateType == CommonToolsClass.ButtonStateTypeEnum.Off)
            {
                SerialPortOpenCloseButtoner.ButtonStateType = CommonToolsClass.ButtonStateTypeEnum.On;
                BaudRateSetButtoner.DisableTag = true;
                DataBitsSetButtoner.DisableTag = true;
                ParitySetButtoner.DisableTag = true;
                StopBitsSetButtoner.DisableTag = true;
                PortNameSetButtoner.DisableTag = true;
            }
            else if (SerialPortOpenCloseButtoner.ButtonStateType == CommonToolsClass.ButtonStateTypeEnum.On)
            {
                SerialPortOpenCloseButtoner.ButtonStateType = CommonToolsClass.ButtonStateTypeEnum.Off;
                BaudRateSetButtoner.DisableTag = false;
                DataBitsSetButtoner.DisableTag = false;
                ParitySetButtoner.DisableTag = false;
                StopBitsSetButtoner.DisableTag = false;
                PortNameSetButtoner.DisableTag = false;
            }
        }

        private void SendNumButton_ClickActionEvent(FUIProject.Class.CommonToolsClass.SendContentTypeEnum SendContentType)
        {
            SnedContentTextBoxer.GetInputContent(SendContentType);
        }


        #endregion

        #region 公共方法

        public void GetKeyInput(System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == Key.NumPad0 || e.Key == Key.D0)
            {
                SendNum0Button.ClickAction();
            }
            else if (e.Key == Key.NumPad1 || e.Key == Key.D1)
            {
                SendNum1Button.ClickAction();
            }
            else if (e.Key == Key.NumPad2 || e.Key == Key.D2)
            {
                SendNum2Button.ClickAction();
            }
            else if (e.Key == Key.NumPad3 || e.Key == Key.D3)
            {
                SendNum3Button.ClickAction();
            }
            else if (e.Key == Key.NumPad4 || e.Key == Key.D4)
            {
                SendNum4Button.ClickAction();
            }
            else if (e.Key == Key.NumPad5 || e.Key == Key.D5)
            {
                SendNum5Button.ClickAction();
            }
            else if (e.Key == Key.NumPad6 || e.Key == Key.D6)
            {
                SendNum6Button.ClickAction();
            }
            else if (e.Key == Key.NumPad7 || e.Key == Key.D7)
            {
                SendNum7Button.ClickAction();
            }
            else if (e.Key == Key.NumPad8 || e.Key == Key.D8)
            {
                SendNum8Button.ClickAction();
            }
            else if (e.Key == Key.NumPad9 || e.Key == Key.D9)
            {
                SendNum9Button.ClickAction();
            }
            else if (e.Key == Key.A)
            {
                SendNumAButton.ClickAction();
            }
            else if (e.Key == Key.B)
            {
                SendNumBButton.ClickAction();
            }
            else if (e.Key == Key.C)
            {
                SendNumCButton.ClickAction();
            }
            else if (e.Key == Key.D)
            {
                SendNumDButton.ClickAction();
            }
            else if (e.Key == Key.E)
            {
                SendNumEButton.ClickAction();
            }
            else if (e.Key == Key.F)
            {
                SendNumFButton.ClickAction();
            }
            else if (e.Key == Key.X)
            {
                SendNumXButton.ClickAction();
            }
            else if (e.Key == Key.Space)
            {
                SendNumSpaceButton.ClickAction();
            }
            else if (e.Key == Key.Back)
            {
                SendNumBackSpaceButton.ClickAction();
            }
            else if (e.Key == Key.Enter)
            {
                SendNumEnterButton.ClickAction();
            }
        }

        #endregion
    }
}
