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
    /// Interaction logic for SystemInfo.xaml
    /// </summary>
    public partial class SystemInfo : UserControl
    {
        public SystemInfo()
        {
            InitializeComponent();

            _SystemInfoTreatClass = SystemInfoTreatClass.GetInstance();
            _SystemInfoTreatClass.MessageArrivedEvent += new SystemInfoTreatClass.MessageArrivedEventHandler(_SystemInfoTreatClass_MessageArrivedEvent);
        }


        //private string _Parameter1 = "";
        //public string Parameter1
        //{
        //    get
        //    {
        //        return _Parameter1;
        //    }
        //    set
        //    {
        //        if (_Parameter1 != value)
        //        {
        //            _Parameter1 = value;
        //        }
        //    }
        //}

        private CommonToolsClass.SystemInfoTypeEnum _SystemInfoType = CommonToolsClass.SystemInfoTypeEnum.None;
        public CommonToolsClass.SystemInfoTypeEnum SystemInfoType
        {
            get
            {
                return _SystemInfoType;
            }
            set
            {
                if (_SystemInfoType != value)
                {
                    _SystemInfoType = value;
                }
            }
        }

        #region 变量定义

        SystemInfoTreatClass _SystemInfoTreatClass;

        #endregion

        #region 后台类委托事件


        void _SystemInfoTreatClass_MessageArrivedEvent(CommonToolsClass.SystemInfoTypeEnum _SystemInfoType)
        {
            AddSystemInfo(_SystemInfoType);
        }

        #endregion

        #region 公共方法

        private void AddContent()
        {
            Grid tempGrid = new Grid();
            tempGrid.Height = 15;
            TextBlock tempTextBlock = new TextBlock();
            tempTextBlock.HorizontalAlignment = System.Windows.HorizontalAlignment.Left;
            tempTextBlock.VerticalAlignment = System.Windows.VerticalAlignment.Center;
            tempTextBlock.TextWrapping = TextWrapping.Wrap;
            tempTextBlock.FontFamily = new FontFamily("OCR A Extended");
            tempTextBlock.Foreground = new SolidColorBrush(Colors.White);

            if (_SystemInfoType == CommonToolsClass.SystemInfoTypeEnum.SystemWorked)
            {
                tempTextBlock.Text = DateTime.Now.ToString("HH:mm:ss") + " " + "System is working";
            }
            else if (_SystemInfoType == CommonToolsClass.SystemInfoTypeEnum.CommandSend_Normal)
            {
                tempTextBlock.Text = DateTime.Now.ToString("HH:mm:ss") + " " + "Command send success";
            }
            else if (_SystemInfoType == CommonToolsClass.SystemInfoTypeEnum.SerialOpen)
            {
                tempTextBlock.Text = DateTime.Now.ToString("HH:mm:ss") + " " + "SerialPort Opened";
            }
            else if (_SystemInfoType == CommonToolsClass.SystemInfoTypeEnum.SerialClose)
            {
                tempTextBlock.Text = DateTime.Now.ToString("HH:mm:ss") + " " + "SerialPort Closed";
            }
            else if (_SystemInfoType == CommonToolsClass.SystemInfoTypeEnum.ErrorCommand)
            {
                tempTextBlock.Foreground = new SolidColorBrush(Colors.Orange);
                tempTextBlock.Text = DateTime.Now.ToString("HH:mm:ss") + " " + "ErrorCommand! Please check";
            }
            else if (_SystemInfoType == CommonToolsClass.SystemInfoTypeEnum.CommandSend_SerialNotOpen)
            {
                tempTextBlock.Foreground = new SolidColorBrush(Colors.Orange);
                tempTextBlock.Text = DateTime.Now.ToString("HH:mm:ss") + " " + "SerialPort is not open!";
            }

            tempGrid.Children.Add(tempTextBlock);
            ContentStackPanel.Children.Add(tempGrid);

            if (ContentStackPanel.Children.Count > 4)
            {
                ((EasingThicknessKeyFrame)((ThicknessAnimationUsingKeyFrames)(((Storyboard)Resources["ContentShowAction"]).Children[0])).KeyFrames[0]).SetValue(EasingThicknessKeyFrame.ValueProperty, new Thickness(0, (4 - ContentStackPanel.Children.Count) * 15, 0, 0));
                ((Storyboard)Resources["ContentShowAction"]).Begin();
            }
        }

        public void AddSystemInfo(CommonToolsClass.SystemInfoTypeEnum SystemInfoType)
        {
            this.SystemInfoType = SystemInfoType;
            AddContent();
        }

        //public void AddSystemInfo(CommonToolsClass.SystemInfoTypeEnum SystemInfoType, string Parameter1)
        //{
        //    this.SystemInfoType = SystemInfoType;
        //    this.Parameter1 = Parameter1;
        //    AddContent();
        //}

        #endregion
    }
}
