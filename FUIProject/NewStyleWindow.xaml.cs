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
using System.Windows.Shapes;

using FUIProject.Class;

namespace FUIProject
{
    /// <summary>
    /// Interaction logic for NewStyleWindow.xaml
    /// </summary>
    public partial class NewStyleWindow : Window
    {
        public NewStyleWindow()
        {
            InitializeComponent();

            _SerialPortClass = SerialPortClass.GetInstance();


            PortNameSetButtoner.PortIndexChangedEvent += new Controls.SimpleControls.PortNameSetButton.PortIndexChangedEventHandler(PortNameSetButtoner_PortIndexChangedEvent);
            ControlPaneler.PressCommandSendEvent += new Controls.SimpleControls.ControlPanel.PressCommandSendEventHandler(ControlPaneler_PressCommandSendEvent);
            ControlPaneler.ReleaseCommandSendEvent += new Controls.SimpleControls.ControlPanel.ReleaseCommandSendEventHandler(ControlPaneler_ReleaseCommandSendEvent);

            _SystemInfoTreatClass = SystemInfoTreatClass.GetInstance();
            _SystemInfoTreatClass.GetMessage(CommonToolsClass.SystemInfoTypeEnum.SystemWorked);
        }



        #region 变量定义

        SerialPortClass _SerialPortClass;
        List<byte> CommandList = new List<byte>();
        SystemInfoTreatClass _SystemInfoTreatClass;

        #endregion

        #region 界面委托事件


        void ControlPaneler_ReleaseCommandSendEvent(byte[] ReleaseCommand)
        {
            SendContentTextBoxer.GetInputCommand(ReleaseCommand);
        }

        void ControlPaneler_PressCommandSendEvent(byte[] PressCommand)
        {
            SendContentTextBoxer.GetInputCommand(PressCommand);
        }

        private void CloseButtoner_ClickEvent()
        {
            this.Close();
        }

        private void MinButtoner_ClickEvent()
        {
            this.WindowState = System.Windows.WindowState.Minimized;
        }

        void PortNameSetButtoner_PortIndexChangedEvent(int PortIndex)
        {
            CommonToolsClass.PortStateTypeEnum CurrentPortState = _SerialPortClass.GetPortStateByIndex(PortIndex);

            if (CurrentPortState == CommonToolsClass.PortStateTypeEnum.Disable)
            {
                SerialPortOpenCloseButtoner.ButtonStateType = CommonToolsClass.ButtonStateTypeEnum.Disable;
            }
            else
            {
                SerialPortOpenCloseButtoner.ButtonStateType = CommonToolsClass.ButtonStateTypeEnum.Off;
            }
        }

        #endregion

        #region 界面事件


        private void Window_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            GetKeyInput(e);
        }

        private void SerialPortOpenCloseButtoner_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            //判断是打开串口还是关闭串口
            if (_SerialPortClass.spIsOpen)
            {
                _SerialPortClass.CloseSerialPort();
            }
            else
            {
                _SerialPortClass.OpenSerialPort(PortNameSetButtoner.PortIndex);
            }

            //根据结果设置按钮状态
            if (_SerialPortClass.spIsOpen)
            {
                SerialPortOpenCloseButtoner.ButtonStateType = CommonToolsClass.ButtonStateTypeEnum.On;
            }
            else
            {
                SerialPortOpenCloseButtoner.ButtonStateType = CommonToolsClass.ButtonStateTypeEnum.Off;
            }


            if (SerialPortOpenCloseButtoner.ButtonStateType == CommonToolsClass.ButtonStateTypeEnum.On)
            {
                BaudRateSetButtoner.DisableTag = true;
                DataBitsSetButtoner.DisableTag = true;
                ParitySetButtoner.DisableTag = true;
                StopBitsSetButtoner.DisableTag = true;
                PortNameSetButtoner.DisableTag = true;

                PortStatePaneler.SetPortNameText(PortNameSetButtoner.PortIndex);

            }
            else if (SerialPortOpenCloseButtoner.ButtonStateType == CommonToolsClass.ButtonStateTypeEnum.Off)
            {
                BaudRateSetButtoner.DisableTag = false;
                DataBitsSetButtoner.DisableTag = false;
                ParitySetButtoner.DisableTag = false;
                StopBitsSetButtoner.DisableTag = false;
                PortNameSetButtoner.DisableTag = false;

                PortStatePaneler.SetPortNameText(-1);
            }

            PortStateButtoner.RefreshTitlePortStateScreener();
        }

        private void SendNumButton_ClickActionEvent(FUIProject.Class.CommonToolsClass.SendContentTypeEnum SendContentType)
        {
            SendContentTextBoxer.GetInputContent(SendContentType);
            if (SendContentType == CommonToolsClass.SendContentTypeEnum.NumEnter)
            {
                //判断串口是否打开

                string[] CommandStr = SendContentTextBoxer.SendContentStr.Trim().Split(' ');

                try
                {
                    for (int i = 0; i < CommandStr.Length; i++)
                    {
                        if (!string.IsNullOrEmpty(CommandStr[i]))
                        {
                            if (CommandStr[i].IndexOf("0x") == 0)
                            {
                                CommandList.Add(byte.Parse(CommandStr[i].Substring(2, CommandStr[i].Length - 2), System.Globalization.NumberStyles.HexNumber));
                            }
                            else
                            {
                                CommandList.Add(byte.Parse(CommandStr[i]));
                            }
                        }
                    }

                    //判断命令是否为空
                    if (CommandList.Count == 0)
                    {
                        throw new Exception();
                    }

                    //复制命令数据
                    byte[] Command = new byte[CommandList.Count];
                    for (int i = 0; i < CommandList.Count; i++)
                    {
                        Command[i] = CommandList[i];
                    }
                    //发送命令
                    _SerialPortClass.CommandSendAction(Command);
                    CommandList.Clear();
                }
                catch
                {
                    _SystemInfoTreatClass.GetMessage(CommonToolsClass.SystemInfoTypeEnum.ErrorCommand);
                    CommandList.Clear();
                }
            }
        }



        private void TitleDragMoveGrid_MouseMove(object sender, System.Windows.Input.MouseEventArgs e)
        {
            if (e.MouseDevice.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }


        #endregion

        #region 公共方法

        public void GetKeyInput(System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == Key.NumPad0 || e.Key == Key.D0 && e.KeyboardDevice.Modifiers == ModifierKeys.None)
            {
                SendNum0Button.ClickAction();
            }
            else if (e.Key == Key.NumPad1 || e.Key == Key.D1 && e.KeyboardDevice.Modifiers == ModifierKeys.None)
            {
                SendNum1Button.ClickAction();
            }
            else if (e.Key == Key.NumPad2 || e.Key == Key.D2 && e.KeyboardDevice.Modifiers == ModifierKeys.None)
            {
                SendNum2Button.ClickAction();
            }
            else if (e.Key == Key.NumPad3 || e.Key == Key.D3 && e.KeyboardDevice.Modifiers == ModifierKeys.None)
            {
                SendNum3Button.ClickAction();
            }
            else if (e.Key == Key.NumPad4 || e.Key == Key.D4 && e.KeyboardDevice.Modifiers == ModifierKeys.None)
            {
                SendNum4Button.ClickAction();
            }
            else if (e.Key == Key.NumPad5 || e.Key == Key.D5 && e.KeyboardDevice.Modifiers == ModifierKeys.None)
            {
                SendNum5Button.ClickAction();
            }
            else if (e.Key == Key.NumPad6 || e.Key == Key.D6 && e.KeyboardDevice.Modifiers == ModifierKeys.None)
            {
                SendNum6Button.ClickAction();
            }
            else if (e.Key == Key.NumPad7 || e.Key == Key.D7 && e.KeyboardDevice.Modifiers == ModifierKeys.None)
            {
                SendNum7Button.ClickAction();
            }
            else if (e.Key == Key.NumPad8 || e.Key == Key.D8 && e.KeyboardDevice.Modifiers == ModifierKeys.None)
            {
                SendNum8Button.ClickAction();
            }
            else if (e.Key == Key.NumPad9 || e.Key == Key.D9 && e.KeyboardDevice.Modifiers == ModifierKeys.None)
            {
                SendNum9Button.ClickAction();
            }
            else if (e.Key == Key.A && e.KeyboardDevice.Modifiers == ModifierKeys.None)
            {
                SendNumAButton.ClickAction();
            }
            else if (e.Key == Key.B && e.KeyboardDevice.Modifiers == ModifierKeys.None)
            {
                SendNumBButton.ClickAction();
            }
            else if (e.Key == Key.C && e.KeyboardDevice.Modifiers == ModifierKeys.None)
            {
                SendNumCButton.ClickAction();
            }
            else if (e.Key == Key.D && e.KeyboardDevice.Modifiers == ModifierKeys.None)
            {
                SendNumDButton.ClickAction();
            }
            else if (e.Key == Key.E && e.KeyboardDevice.Modifiers == ModifierKeys.None)
            {
                SendNumEButton.ClickAction();
            }
            else if (e.Key == Key.F && e.KeyboardDevice.Modifiers == ModifierKeys.None)
            {
                SendNumFButton.ClickAction();
            }
            else if (e.Key == Key.X && e.KeyboardDevice.Modifiers == ModifierKeys.None)
            {
                SendNumXButton.ClickAction();
            }
            else if (e.Key == Key.Space && e.KeyboardDevice.Modifiers == ModifierKeys.None)
            {
                SendNumSpaceButton.ClickAction();
            }
            else if (e.Key == Key.Back && e.KeyboardDevice.Modifiers == ModifierKeys.None)
            {
                SendNumBackSpaceButton.ClickAction();
            }
            else if (e.Key == Key.Enter && e.KeyboardDevice.Modifiers == ModifierKeys.None)
            {
                SendNumEnterButton.ClickAction();
            }
            else if (e.Key == Key.F1 && e.KeyboardDevice.Modifiers == ModifierKeys.None)
            {
                _SerialPortClass.TestReceiveData();
            }
        }



        #endregion
    }
}
