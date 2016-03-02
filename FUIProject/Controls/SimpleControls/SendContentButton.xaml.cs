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
    /// Interaction logic for SendContentButton.xaml
    /// </summary>
    public partial class SendContentButton : UserControl
    {
        public SendContentButton()
        {
            InitializeComponent();

            //PressTimer = new System.Timers.Timer();
            //PressTimer.Interval = 50;
            //PressTimer.Elapsed += new System.Timers.ElapsedEventHandler(PressTimer_Elapsed);

            //PressThread = new System.Threading.Thread(PressThreadFunc);
            //PressThread.IsBackground = true;
        }

        #region 变量标志位

        private CommonToolsClass.SendContentTypeEnum _SendContentType = CommonToolsClass.SendContentTypeEnum.Num1;
        public CommonToolsClass.SendContentTypeEnum SendContentType
        {
            get
            {
                return _SendContentType;
            }
            set
            {
                if (_SendContentType != value)
                {
                    _SendContentType = value;

                    Num0Path.Visibility = System.Windows.Visibility.Collapsed;
                    Num1Path.Visibility = System.Windows.Visibility.Collapsed;
                    Num2Path.Visibility = System.Windows.Visibility.Collapsed;
                    Num3Path.Visibility = System.Windows.Visibility.Collapsed;
                    Num4Path.Visibility = System.Windows.Visibility.Collapsed;
                    Num5Path.Visibility = System.Windows.Visibility.Collapsed;
                    Num6Path.Visibility = System.Windows.Visibility.Collapsed;
                    Num7Path.Visibility = System.Windows.Visibility.Collapsed;
                    Num8Path.Visibility = System.Windows.Visibility.Collapsed;
                    Num9Path.Visibility = System.Windows.Visibility.Collapsed;
                    NumAPath.Visibility = System.Windows.Visibility.Collapsed;
                    NumBPath.Visibility = System.Windows.Visibility.Collapsed;
                    NumCPath.Visibility = System.Windows.Visibility.Collapsed;
                    NumDPath.Visibility = System.Windows.Visibility.Collapsed;
                    NumEPath.Visibility = System.Windows.Visibility.Collapsed;
                    NumFPath.Visibility = System.Windows.Visibility.Collapsed;
                    NumXPath.Visibility = System.Windows.Visibility.Collapsed;
                    NumSpacePath.Visibility = System.Windows.Visibility.Collapsed;
                    NumBackSpacePath.Visibility = System.Windows.Visibility.Collapsed;
                    NumEnterPath.Visibility = System.Windows.Visibility.Collapsed;

                    if (_SendContentType == CommonToolsClass.SendContentTypeEnum.Num0)
                    {
                        Num0Path.Visibility = System.Windows.Visibility.Visible;
                    }
                    else if (_SendContentType == CommonToolsClass.SendContentTypeEnum.Num1)
                    {
                        Num1Path.Visibility = System.Windows.Visibility.Visible;
                    }
                    else if (_SendContentType == CommonToolsClass.SendContentTypeEnum.Num2)
                    {
                        Num2Path.Visibility = System.Windows.Visibility.Visible;
                    }
                    else if (_SendContentType == CommonToolsClass.SendContentTypeEnum.Num3)
                    {
                        Num3Path.Visibility = System.Windows.Visibility.Visible;
                    }
                    else if (_SendContentType == CommonToolsClass.SendContentTypeEnum.Num4)
                    {
                        Num4Path.Visibility = System.Windows.Visibility.Visible;
                    }
                    else if (_SendContentType == CommonToolsClass.SendContentTypeEnum.Num5)
                    {
                        Num5Path.Visibility = System.Windows.Visibility.Visible;
                    }
                    else if (_SendContentType == CommonToolsClass.SendContentTypeEnum.Num6)
                    {
                        Num6Path.Visibility = System.Windows.Visibility.Visible;
                    }
                    else if (_SendContentType == CommonToolsClass.SendContentTypeEnum.Num7)
                    {
                        Num7Path.Visibility = System.Windows.Visibility.Visible;
                    }
                    else if (_SendContentType == CommonToolsClass.SendContentTypeEnum.Num8)
                    {
                        Num8Path.Visibility = System.Windows.Visibility.Visible;
                    }
                    else if (_SendContentType == CommonToolsClass.SendContentTypeEnum.Num9)
                    {
                        Num9Path.Visibility = System.Windows.Visibility.Visible;
                    }
                    else if (_SendContentType == CommonToolsClass.SendContentTypeEnum.NumA)
                    {
                        NumAPath.Visibility = System.Windows.Visibility.Visible;
                    }
                    else if (_SendContentType == CommonToolsClass.SendContentTypeEnum.NumB)
                    {
                        NumBPath.Visibility = System.Windows.Visibility.Visible;
                    }
                    else if (_SendContentType == CommonToolsClass.SendContentTypeEnum.NumC)
                    {
                        NumCPath.Visibility = System.Windows.Visibility.Visible;
                    }
                    else if (_SendContentType == CommonToolsClass.SendContentTypeEnum.NumD)
                    {
                        NumDPath.Visibility = System.Windows.Visibility.Visible;
                    }
                    else if (_SendContentType == CommonToolsClass.SendContentTypeEnum.NumE)
                    {
                        NumEPath.Visibility = System.Windows.Visibility.Visible;
                    }
                    else if (_SendContentType == CommonToolsClass.SendContentTypeEnum.NumF)
                    {
                        NumFPath.Visibility = System.Windows.Visibility.Visible;
                    }
                    else if (_SendContentType == CommonToolsClass.SendContentTypeEnum.NumX)
                    {
                        NumXPath.Visibility = System.Windows.Visibility.Visible;
                    }
                    else if (_SendContentType == CommonToolsClass.SendContentTypeEnum.NumSpace)
                    {
                        NumSpacePath.Visibility = System.Windows.Visibility.Visible;
                    }
                    else if (_SendContentType == CommonToolsClass.SendContentTypeEnum.NumBackSpace)
                    {
                        NumBackSpacePath.Visibility = System.Windows.Visibility.Visible;
                    }
                    else if (_SendContentType == CommonToolsClass.SendContentTypeEnum.NumEnter)
                    {
                        NumEnterPath.Visibility = System.Windows.Visibility.Visible;
                    }
                }
            }
        }

        #endregion

        #region 自身委托事件

        public delegate void ClickActionEventHandler(CommonToolsClass.SendContentTypeEnum SendContentType);
        public event ClickActionEventHandler ClickActionEvent;

        #endregion

        #region 变量定义

        //System.Threading.Thread PressThread;
        //System.Timers.Timer PressTimer;

        #endregion

        #region 界面事件

        private void UserControl_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ((Storyboard)Resources["ButtonClickAction"]).Begin();
            if (ClickActionEvent != null)
            {
                ClickActionEvent(SendContentType);
            }

            //PressThread.Start();
        }

        private void UserControl_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            //if (PressThread != null)
            //{
            //    Console.WriteLine("up : " + PressThread.ThreadState.ToString());
            //}
            //if (PressThread != null && (PressThread.ThreadState == System.Threading.ThreadState.Running || PressThread.ThreadState == System.Threading.ThreadState.Background))
            //{
            //    PressThread.Abort();
            //}
            //PressTimer.Stop();
        }

        private void UserControl_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            //Console.WriteLine("Leave : " + PressThread.ThreadState.ToString());
            //if (PressThread != null && (PressThread.ThreadState == System.Threading.ThreadState.Running || PressThread.ThreadState == System.Threading.ThreadState.Background))
            //{
            //    PressThread.Abort();
            //}
            //PressTimer.Stop();
        }

        #endregion

        #region 公共方法

        public void ClickAction()
        {
            ((Storyboard)Resources["ButtonClickAction"]).Begin();
            if (ClickActionEvent != null)
            {
                ClickActionEvent(SendContentType);
            }
        }

        private void PressThreadFunc()
        {
            System.Threading.Thread.Sleep(500);
            //PressTimer.Start();
        }



        void PressTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            Action action = () =>
            {
                ((Storyboard)Resources["ButtonClickAction"]).Begin();
                if (ClickActionEvent != null)
                {
                    ClickActionEvent(SendContentType);
                }
            };
            this.Dispatcher.Invoke(action);
        }

        #endregion

    }
}
