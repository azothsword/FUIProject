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
using FUIProject_B.Class;

namespace FUIProject_B
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            ((Storyboard)Resources["StartUpEffectAction"]).Completed += new EventHandler(StartUpEffectAction_Completed);

            ControlPaneler.SystemInfoArrivedEvent += new Controls.SimpleControls.ControlPanel.SystemInfoArrivedEventHandler(ControlPaneler_SystemInfoArrivedEvent);

            _SerialPortClass = SerialPortClass.GetInstance();
            _SerialPortClass.SendDataArrivedEvent += new SerialPortClass.SendDataArrivedEventHandler(_SerialPortClass_SendDataArrivedEvent);
            _SerialPortClass.SerialPortNotOpenEvent += new SerialPortClass.SerialPortNotOpenEventHandler(_SerialPortClass_SerialPortNotOpenEvent);
            _SerialPortClass.SerialPortOpenTagChangedEvent += new SerialPortClass.SerialPortOpenTagChangedEventHandler(_SerialPortClass_SerialPortOpenTagChangedEvent);
        }



        void StartUpEffectAction_Completed(object sender, EventArgs e)
        {
            SystemInfoPaneler.AddSystemInfo(Class.CommonToolsClass.SystemInfoTypeEnum.SystemWorked);
        }

        #region 变量定义

        SerialPortClass _SerialPortClass;

        #endregion

        #region 界面委托事件


        void ControlPaneler_SystemInfoArrivedEvent(Class.CommonToolsClass.SystemInfoTypeEnum _SystemInfoTypeEnum)
        {
            SystemInfoPaneler.AddSystemInfo(_SystemInfoTypeEnum);
        }

        #endregion

        #region 后台类委托事件


        void _SerialPortClass_SerialPortOpenTagChangedEvent(bool spIsOpen)
        {
            if (spIsOpen)
            {
                comboBoxType1.IsUnable = true;
                comboBoxType2.IsUnable = true;
                comboBoxType3.IsUnable = true;
                comboBoxType4.IsUnable = true;
            }
            else
            {
                comboBoxType1.IsUnable = false;
                comboBoxType2.IsUnable = false;
                comboBoxType3.IsUnable = false;
                comboBoxType4.IsUnable = false;
            }
        }

        void _SerialPortClass_SerialPortNotOpenEvent()
        {
            SystemInfoPaneler.AddSystemInfo(CommonToolsClass.SystemInfoTypeEnum.CommandSend_SerialNotOpen);
        }

        void _SerialPortClass_SendDataArrivedEvent(byte[] SendData)
        {
            SystemInfoPaneler.AddSystemInfo(CommonToolsClass.SystemInfoTypeEnum.CommandSend_Normal);
        }

        #endregion

        #region 界面事件

        private void Window_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == Key.F1)
            {
                SystemInfoPaneler.AddSystemInfo(Class.CommonToolsClass.SystemInfoTypeEnum.SystemWorked);
            }
        }


        private void CloseButton_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            ((Storyboard)Resources["CloseMinMouseEnterAction"]).SetValue(Storyboard.TargetNameProperty, "ClosePath");
            ((Storyboard)Resources["CloseMinMouseEnterAction"]).Begin();
        }

        private void CloseButton_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            ((Storyboard)Resources["CloseMinMouseLeaveAction"]).SetValue(Storyboard.TargetNameProperty, "ClosePath");
            ((Storyboard)Resources["CloseMinMouseLeaveAction"]).Begin();
        }

        private void CloseButton_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ((Storyboard)Resources["CloseMinMouseLeftButtonDownAction"]).SetValue(Storyboard.TargetNameProperty, "ClosePath");
            ((Storyboard)Resources["CloseMinMouseLeftButtonDownAction"]).Begin();
        }

        private void CloseButton_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ((Storyboard)Resources["CloseMinMouseEnterAction"]).SetValue(Storyboard.TargetNameProperty, "ClosePath");
            ((Storyboard)Resources["CloseMinMouseEnterAction"]).Begin();
            this.Close();
        }

        private void MinButton_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            ((Storyboard)Resources["CloseMinMouseEnterAction"]).SetValue(Storyboard.TargetNameProperty, "MinPath");
            ((Storyboard)Resources["CloseMinMouseEnterAction"]).Begin();
        }

        private void MinButton_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            ((Storyboard)Resources["CloseMinMouseLeaveAction"]).SetValue(Storyboard.TargetNameProperty, "MinPath");
            ((Storyboard)Resources["CloseMinMouseLeaveAction"]).Begin();
        }

        private void MinButton_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ((Storyboard)Resources["CloseMinMouseLeftButtonDownAction"]).SetValue(Storyboard.TargetNameProperty, "MinPath");
            ((Storyboard)Resources["CloseMinMouseLeftButtonDownAction"]).Begin();
        }

        private void MinButton_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ((Storyboard)Resources["CloseMinMouseEnterAction"]).SetValue(Storyboard.TargetNameProperty, "MinPath");
            ((Storyboard)Resources["CloseMinMouseEnterAction"]).Begin();
            this.WindowState = System.Windows.WindowState.Minimized;
        }

        private void TitleGrid_MouseMove(object sender, System.Windows.Input.MouseEventArgs e)
        {
            if (e.MouseDevice.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }

        #endregion

    }
}
