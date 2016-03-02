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

using FUIProject_B.Class;
using System.Windows.Media.Animation;

namespace FUIProject_B.Controls.SimpleControls
{
    /// <summary>
    /// Interaction logic for SystemInfoPanelItem.xaml
    /// </summary>
    public partial class SystemInfoPanelItem : UserControl
    {
        public SystemInfoPanelItem()
        {
            InitializeComponent();
        }

        public void SetSystemInfo(CommonToolsClass.SystemInfoTypeEnum _SystemInfoTypeEnum)
        {
            TimeText.Text = DateTime.Now.ToString("HH:mm:ss");

            if (_SystemInfoTypeEnum == CommonToolsClass.SystemInfoTypeEnum.SystemWorked)
            {
                SystemInfoText.Text = "System is working";
            }
            else if (_SystemInfoTypeEnum == CommonToolsClass.SystemInfoTypeEnum.SystemClose)
            {
                SystemInfoText.Text = "System is Closed";
            }
            else if (_SystemInfoTypeEnum == CommonToolsClass.SystemInfoTypeEnum.SerialOpen)
            {
                SystemInfoText.Text = "SerialPort Opened";
            }
            else if (_SystemInfoTypeEnum == CommonToolsClass.SystemInfoTypeEnum.SerialClose)
            {
                SystemInfoText.Text = "SerialPort Closed";
            }
            else if (_SystemInfoTypeEnum == CommonToolsClass.SystemInfoTypeEnum.CommandSend_Normal)
            {
                SystemInfoText.Text = "Command send success";
            }
            else if (_SystemInfoTypeEnum == CommonToolsClass.SystemInfoTypeEnum.CommandSend_SerialNotOpen)
            {
                SystemInfoText.Text = "SerialPort is not open!";
                SetAlarmColor();
            }
            else if (_SystemInfoTypeEnum == CommonToolsClass.SystemInfoTypeEnum.None)
            {
                SystemInfoText.Text = "None";
            }
            else if (_SystemInfoTypeEnum == CommonToolsClass.SystemInfoTypeEnum.ErrorCommand)
            {
                SystemInfoText.Text = "ErrorCommand! Please check";
                SetAlarmColor();
            }
            else if (_SystemInfoTypeEnum == CommonToolsClass.SystemInfoTypeEnum.FileOpenSuccess)
            {
                SystemInfoText.Text = "File Open Success!";
            }
            else if (_SystemInfoTypeEnum == CommonToolsClass.SystemInfoTypeEnum.FileOpenFail)
            {
                SystemInfoText.Text = "File Open Fail!";
                SetAlarmColor();
            }
        }

        private void SetAlarmColor()
        {
            TimeText.Foreground = new SolidColorBrush(Colors.Red);
            SystemInfoText.Foreground = new SolidColorBrush(Colors.Red);
        }

        public void ItemShortShowAction()
        {
            ((Storyboard)Resources["ItemShortShowAction"]).Begin();
        }

        public void ItemLongShowAction()
        {
            ((Storyboard)Resources["ItemLongShowAction"]).Begin();
        }
    }
}
