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
    /// Interaction logic for SystemInfoPanel.xaml
    /// </summary>
    public partial class SystemInfoPanel : UserControl
    {
        public SystemInfoPanel()
        {
            InitializeComponent();

            _SerialPortClass = SerialPortClass.GetInstance();
            _SerialPortClass.SerialPortOpenTagChangedEvent += new SerialPortClass.SerialPortOpenTagChangedEventHandler(_SerialPortClass_SerialPortOpenTagChangedEvent);
        }


        #region 变量定义

        SerialPortClass _SerialPortClass;

        #endregion


        #region 后台类委托事件

        void _SerialPortClass_SerialPortOpenTagChangedEvent(bool spIsOpen)
        {
            if (spIsOpen)
            {
                ((Storyboard)Resources["SerialPortOpenAction"]).Begin();
            }
            else
            {
                ((Storyboard)Resources["SerialPortCloseAction"]).Begin();
            }
        }

        #endregion

        #region 界面事件


        private void SerialPortOpenCloseButton_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (_SerialPortClass.spIsOpen)
            {
                _SerialPortClass.CloseSerialPort();
            }
            else
            {
                _SerialPortClass.OpenSerialPort(0);
            }
        }

        #endregion

        #region 公共方法

        public void AddSystemInfo(CommonToolsClass.SystemInfoTypeEnum _SystemInfoTypeEnum)
        {
            SystemInfoPanelItem _SystemInfoPanelItem = new SystemInfoPanelItem();
            _SystemInfoPanelItem.Width = 470;
            _SystemInfoPanelItem.Height = 23;
            _SystemInfoPanelItem.SetSystemInfo(_SystemInfoTypeEnum);
            SystemInfoItemStackPanel.Children.Add(_SystemInfoPanelItem);

            if (SystemInfoItemStackPanel.Children.Count > 4)
            {
                ((EasingThicknessKeyFrame)((ThicknessAnimationUsingKeyFrames)(((Storyboard)Resources["SystemInfoItemShowAction"]).Children[0])).KeyFrames[0]).SetValue(EasingThicknessKeyFrame.ValueProperty, new Thickness(0, (4 - SystemInfoItemStackPanel.Children.Count) * 23, 0, 0));
                ((Storyboard)Resources["SystemInfoItemShowAction"]).Begin();
                _SystemInfoPanelItem.ItemLongShowAction();
            }
            else
            {
                _SystemInfoPanelItem.ItemShortShowAction();
            }
        }

        #endregion

    }
}
