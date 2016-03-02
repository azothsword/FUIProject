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
using FUIProject_A.Controls.SimpleControls;
using FUIProject_A.Class;

namespace FUIProject_A
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            _IniFileTreatClass = IniFileTreatClass.GetInstance();
            _IniFileTreatClass.SerialPortSetChangeEvent += new IniFileTreatClass.SerialPortSetChangeEventHandler(_IniFileTreatClass_SerialPortSetChangeEvent);

            _SerialPortClass = SerialPortClass.GetInstance();
            _SerialPortClass.SendDataArrivedEvent += new SerialPortClass.SendDataArrivedEventHandler(_SerialPortClass_SendDataArrivedEvent);
            _SerialPortClass.ReceiveDataArrivedEvent += new SerialPortClass.ReceiveDataArrivedEventHandler(_SerialPortClass_ReceiveDataArrivedEvent);
            _SerialPortClass.SerialPortNotOpenEvent += new SerialPortClass.SerialPortNotOpenEventHandler(_SerialPortClass_SerialPortNotOpenEvent);

            CommandItemShowTimer.Tick += new EventHandler(CommandItemShowTimer_Tick);
        }


        #region 后台委托事件


        void _IniFileTreatClass_SerialPortSetChangeEvent(int BaudRateIndex, int ParityIndex, int StopBitsIndex, int BytesizeIndex, int SendByHex, string MachineName)
        {
            BaudRateCombo.SelectIndex = BaudRateIndex - 4;
            ParityCombo.SelectIndex = ParityIndex - 1;
            StopBitsCombo.SelectIndex = StopBitsIndex - 1;
            BytesizeCombox.SelectIndex = BytesizeIndex - 1;
            if (SendByHex == 1)
            {
                SendByHexCheckBox.CheckTag = true;
            }
            else
            {
                SendByHexCheckBox.CheckTag = false;
            }
            MachineNameText.Text = MachineName;
        }

        void _SerialPortClass_SerialPortNotOpenEvent()
        {
            SendDataText.Foreground = new SolidColorBrush(Colors.Red);
            SendDataText.Text = "请先打开串口!";
        }

        void _SerialPortClass_ReceiveDataArrivedEvent(byte[] ReceiveData)
        {
            ReceiveDataText.Foreground = new SolidColorBrush(Colors.White);
            ReceiveDataText.Text = "";
            for (int i = 0; i < ReceiveData.Length; i++)
            {
                ReceiveDataText.Text += "0x" + ReceiveData[i].ToString("X2") + " ";
            }
        }

        void _SerialPortClass_SendDataArrivedEvent(byte[] SendData)
        {
            SendDataText.Foreground = new SolidColorBrush(Colors.White);
            SendDataText.Text = "";
            for (int i = 0; i < SendData.Length; i++)
            {
                SendDataText.Text += "0x" + SendData[i].ToString("X2") + " ";
            }
        }

        #endregion

        #region 变量定义

        IniFileTreatClass _IniFileTreatClass;
        SerialPortClass _SerialPortClass;

        System.Windows.Threading.DispatcherTimer CommandItemShowTimer = new System.Windows.Threading.DispatcherTimer();
        int CommandItemShowCount = 0;
        #endregion

        #region 界面事件

        private void Window_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == Key.F1)
            {
                _SerialPortClass.TestReceiveData();
            }
            else if (e.Key == Key.Escape)
            {
            }
        }

        private void SerialPortOpenCloseButton_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (_SerialPortClass.spIsOpen)
            {
                _SerialPortClass.CloseSerialPort();
            }
            else
            {
                if (PortIndexCombo.SelectIndex != -1)
                {
                    _SerialPortClass.OpenSerialPort(PortIndexCombo.SelectIndex);
                }
            }

            if (_SerialPortClass.spIsOpen)
            {
                SerialPortOpenCloseButton.ButtonStr = "关闭";
            }
            else
            {
                SerialPortOpenCloseButton.ButtonStr = "连接";
            }
        }


        private void MinGrid_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            ((Storyboard)Resources["CloseMinButtonMouseEnterAction"]).SetValue(Storyboard.TargetNameProperty, "MinPath");
            ((Storyboard)Resources["CloseMinButtonMouseEnterAction"]).Begin();
        }

        private void MinGrid_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            ((Storyboard)Resources["CloseMinButtonMouseLeaveAction"]).SetValue(Storyboard.TargetNameProperty, "MinPath");
            ((Storyboard)Resources["CloseMinButtonMouseLeaveAction"]).Begin();
        }

        private void MinGrid_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ((Storyboard)Resources["CloseMinButtonMouseLeftButtonDownAction"]).SetValue(Storyboard.TargetNameProperty, "MinPath");
            ((Storyboard)Resources["CloseMinButtonMouseLeftButtonDownAction"]).Begin();
        }

        private void MinGrid_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ((Storyboard)Resources["CloseMinButtonMouseEnterAction"]).SetValue(Storyboard.TargetNameProperty, "MinPath");
            ((Storyboard)Resources["CloseMinButtonMouseEnterAction"]).Begin();
            this.WindowState = System.Windows.WindowState.Minimized;
        }


        private void CloseGrid_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            ((Storyboard)Resources["CloseMinButtonMouseEnterAction"]).SetValue(Storyboard.TargetNameProperty, "ClosePath");
            ((Storyboard)Resources["CloseMinButtonMouseEnterAction"]).Begin();
        }

        private void CloseGrid_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            ((Storyboard)Resources["CloseMinButtonMouseLeaveAction"]).SetValue(Storyboard.TargetNameProperty, "ClosePath");
            ((Storyboard)Resources["CloseMinButtonMouseLeaveAction"]).Begin();
        }

        private void CloseGrid_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ((Storyboard)Resources["CloseMinButtonMouseLeftButtonDownAction"]).SetValue(Storyboard.TargetNameProperty, "ClosePath");
            ((Storyboard)Resources["CloseMinButtonMouseLeftButtonDownAction"]).Begin();
        }

        private void CloseGrid_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ((Storyboard)Resources["CloseMinButtonMouseEnterAction"]).SetValue(Storyboard.TargetNameProperty, "ClosePath");
            ((Storyboard)Resources["CloseMinButtonMouseEnterAction"]).Begin();
            this.Close();
        }

        private void TitleGrid_MouseMove(object sender, System.Windows.Input.MouseEventArgs e)
        {
            if (e.MouseDevice.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }

        private void ContentGrid_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            for (int i = 0; i < ComboBoxGrid1.Children.Count; i++)
            {
                ComboBoxType1 temp = (ComboBoxType1)ComboBoxGrid1.Children[i];
                if (temp.OpenTag)
                {
                    temp.OpenTag = false;
                }
            }


            for (int i = 0; i < ComboBoxGrid2.Children.Count; i++)
            {
                ComboBoxType1 temp = (ComboBoxType1)ComboBoxGrid2.Children[i];
                if (temp.OpenTag)
                {
                    temp.OpenTag = false;
                }
            }
        }


        private void CommandExecuteButton_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ((Storyboard)Resources["ButtonShowAction"]).Begin();
            RefreshCommandButton();
        }

        private void LoadIniButton_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            //System.Windows.Forms.OpenFileDialog ofd = new System.Windows.Forms.OpenFileDialog();
            //ofd.Filter = "ini文件(*.ini)|*.ini";
            //if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            //{
            //    _IniFileTreatClass.ReadFile(ofd.FileName);
            //    RefreshCommandContent();
            //}


            OpenFileWindow ofw = new OpenFileWindow();
            if ((bool)ofw.ShowDialog())
            {
                _IniFileTreatClass.ReadFile(ofw.CurrentFileDocumentItem._FileSystemItemObjClass.PathStr);
                RefreshCommandContent();
            }
            else
            {

            }
        }

        private void RemoveAllButton_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            for (int i = 0; i < CommandContentStackPanel.Children.Count; i++)
            {
                CommandContentItem _CommandContentItem = (CommandContentItem)CommandContentStackPanel.Children[i];
                _CommandContentItem.ItemHideAction();
            }
        }

        private void SaveIniButton_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            System.Windows.Forms.SaveFileDialog sfd = new System.Windows.Forms.SaveFileDialog();
            sfd.Filter = "ini文件(*.ini)|*.ini";
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
            }

            //OpenFileWindow ofw = new OpenFileWindow();
            //if ((bool)ofw.ShowDialog())
            //{
            //    _IniFileTreatClass.ReadFile(ofw.CurrentFileDocumentItem._FileSystemItemObjClass.PathStr);
            //    RefreshCommandContent();
            //}
            //else
            //{

            //}
        }

        private void GoBackButton_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ((Storyboard)Resources["ButtonHideAction"]).Begin();
        }

        #endregion

        #region 公共方法

        private void RefreshCommandButton()
        {
            CommandButtonGrid.Children.Clear();
            for (int i = 0; i < _IniFileTreatClass.CommandObjList.Count; i++)
            {
                ButtonType1 _ButtonType1 = new ButtonType1();
                _ButtonType1.HorizontalAlignment = System.Windows.HorizontalAlignment.Left;
                _ButtonType1.VerticalAlignment = System.Windows.VerticalAlignment.Top;
                _ButtonType1.Width = 120;
                _ButtonType1.Height = 30;
                _ButtonType1.Margin = new Thickness(i % 4 * 140, i / 4 * 45, 0, 0);
                _ButtonType1.BindingCommandObj(_IniFileTreatClass.CommandObjList[i]);

                CommandButtonGrid.Children.Add(_ButtonType1);
            }
        }

        private void RefreshCommandContent()
        {
            CommandContentStackPanel.Children.Clear();
            for (int i = 0; i < _IniFileTreatClass.CommandObjList.Count; i++)
            {
                CommandContentItem _CommandContentItem = new CommandContentItem();
                _CommandContentItem.Height = 20;
                if (i == 0)
                {
                    _CommandContentItem.Margin = new Thickness(0, 0, 0, 0);
                }
                else
                {
                    _CommandContentItem.Margin = new Thickness(0, -1, 0, 0);
                }
                _CommandContentItem.BindingCommandObj(_IniFileTreatClass.CommandObjList[i]);
                _CommandContentItem.CommandContentItemDeleteEvent += new CommandContentItem.CommandContentItemDeleteEventHandler(_CommandContentItem_CommandContentItemDeleteEvent);

                CommandContentStackPanel.Children.Add(_CommandContentItem);
            }
            if (CommandItemShowTimer.IsEnabled)
            {
                CommandItemShowTimer.Stop();
            }
            CommandItemShowCount = 0;
            CommandItemShowTimer.Interval = new TimeSpan(0, 0, 0, 0, 50);
            CommandItemShowTimer.Start();

        }

        void _CommandContentItem_CommandContentItemDeleteEvent(Class.ObjectClass.CommandObjClass _CommandObjClass)
        {
            _IniFileTreatClass.CommandObjList.Remove(_CommandObjClass);
        }

        void CommandItemShowTimer_Tick(object sender, EventArgs e)
        {
            if (CommandContentStackPanel.Children.Count > 0)
            {
                CommandContentItem _CommandContentItem = (CommandContentItem)CommandContentStackPanel.Children[CommandItemShowCount];
                _CommandContentItem.ItemShowAction();
                CommandItemShowCount++;
                if (CommandItemShowCount == CommandContentStackPanel.Children.Count)
                {
                    CommandItemShowTimer.Stop();
                }
            }
            else
            {
                CommandItemShowTimer.Stop();
            }
        }


        #endregion
    }
}
