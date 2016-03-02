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
    /// Interaction logic for PortStateButton.xaml
    /// </summary>
    public partial class PortStateButton : UserControl
    {
        public PortStateButton()
        {
            InitializeComponent();

            _SerialPortClass = SerialPortClass.GetInstance();
        }

        #region 变量定义

        SerialPortClass _SerialPortClass;

        #endregion

        private void AddButton_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ((Storyboard)Resources["AddClickAction"]).Begin();

            PortNameSetButtoner.AddAction();

            CommonToolsClass.PortStateTypeEnum CurrentPortState = _SerialPortClass.GetPortStateByIndex(PortNameSetButtoner.PortIndex);

            if (_SerialPortClass.PortIndex != -1 && _SerialPortClass.PortIndex == PortNameSetButtoner.PortIndex && _SerialPortClass.spIsOpen)
            {
                CurrentPortState = CommonToolsClass.PortStateTypeEnum.Active;
            }

            TitlePortStateScreener.PortStateType = CurrentPortState;
        }

        private void ReduceButton_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ((Storyboard)Resources["ReduceClickAction"]).Begin();

            PortNameSetButtoner.ReduceAction();

            CommonToolsClass.PortStateTypeEnum CurrentPortState = _SerialPortClass.GetPortStateByIndex(PortNameSetButtoner.PortIndex);

            if (_SerialPortClass.PortIndex != -1 && _SerialPortClass.PortIndex == PortNameSetButtoner.PortIndex && _SerialPortClass.spIsOpen)
            {
                CurrentPortState = CommonToolsClass.PortStateTypeEnum.Active;
            }

            TitlePortStateScreener.PortStateType = CurrentPortState;
        }

        #region 公共方法

        public void RefreshTitlePortStateScreener()
        {
            CommonToolsClass.PortStateTypeEnum CurrentPortState = _SerialPortClass.GetPortStateByIndex(PortNameSetButtoner.PortIndex);

            if (_SerialPortClass.PortIndex != -1 && _SerialPortClass.PortIndex == PortNameSetButtoner.PortIndex && _SerialPortClass.spIsOpen)
            {
                CurrentPortState = CommonToolsClass.PortStateTypeEnum.Active;
            }

            TitlePortStateScreener.PortStateType = CurrentPortState;
        }

        #endregion
    }
}
