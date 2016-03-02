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
    /// Interaction logic for BaudRateSetButton.xaml
    /// </summary>
    public partial class BaudRateSetButton : UserControl
    {
        public BaudRateSetButton()
        {
            InitializeComponent();
        }

        #region 变量控制标志位

        private bool _DisableTag = false;
        public bool DisableTag
        {
            get
            {
                return _DisableTag;
            }
            set
            {
                if (_DisableTag != value)
                {
                    _DisableTag = value;
                    if (_DisableTag)
                    {
                        ((Storyboard)Resources["DisableAction"]).Begin();
                    }
                    else
                    {
                        ((Storyboard)Resources["AbleAction"]).Begin();
                    }
                }
            }
        }

        #endregion

        #region 界面事件

        private void BaudRateAddButton1_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ((Storyboard)Resources["BaudRateAddButton1ClickAction"]).Begin();
            BaudRateNum1.Num++;
        }

        private void BaudRateAddButton2_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ((Storyboard)Resources["BaudRateAddButton2ClickAction"]).Begin();
            BaudRateNum2.Num++;
        }

        private void BaudRateAddButton3_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ((Storyboard)Resources["BaudRateAddButton3ClickAction"]).Begin();
            BaudRateNum3.Num++;
        }

        private void BaudRateAddButton4_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ((Storyboard)Resources["BaudRateAddButton4ClickAction"]).Begin();
            BaudRateNum4.Num++;
        }

        private void BaudRateAddButton5_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ((Storyboard)Resources["BaudRateAddButton5ClickAction"]).Begin();
            BaudRateNum5.Num++;
        }

        private void BaudRateAddButton6_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ((Storyboard)Resources["BaudRateAddButton6ClickAction"]).Begin();
            BaudRateNum6.Num++;
        }

        private void BaudRateReduceButton1_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ((Storyboard)Resources["BaudRateReduceButton1ClickAction"]).Begin();
            BaudRateNum1.Num--;
        }

        private void BaudRateReduceButton2_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ((Storyboard)Resources["BaudRateReduceButton2ClickAction"]).Begin();
            BaudRateNum2.Num--;
        }

        private void BaudRateReduceButton3_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ((Storyboard)Resources["BaudRateReduceButton3ClickAction"]).Begin();
            BaudRateNum3.Num--;
        }

        private void BaudRateReduceButton4_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ((Storyboard)Resources["BaudRateReduceButton4ClickAction"]).Begin();
            BaudRateNum4.Num--;
        }

        private void BaudRateReduceButton5_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ((Storyboard)Resources["BaudRateReduceButton5ClickAction"]).Begin();
            BaudRateNum5.Num--;
        }

        private void BaudRateReduceButton6_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ((Storyboard)Resources["BaudRateReduceButton6ClickAction"]).Begin();
            BaudRateNum6.Num--;
        }

        private void BaudRateAddButton_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ((Storyboard)Resources["BaudRateAddButtonClickAction"]).Begin();
            int Position = 0;
            int CurrentBaudRate = GetCurrentShowBaudRate();
            for (int i = 0; i < CommonToolsClass.DefaultBaudRate.Length; i++)
            {
                if (CurrentBaudRate < CommonToolsClass.DefaultBaudRate[i])
                {
                    Position = i;
                    break;
                }
                else
                {
                    Position = i + 1;
                }
            }
            SetCurrentShowBaudRate(CommonToolsClass.DefaultBaudRate[Position % CommonToolsClass.DefaultBaudRate.Length]);
        }

        private void BaudRateReduceButton_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ((Storyboard)Resources["BaudRateReduceButtonClickAction"]).Begin();
            int Position = 0;
            int CurrentBaudRate = GetCurrentShowBaudRate();
            for (int i = 0; i < CommonToolsClass.DefaultBaudRate.Length; i++)
            {
                if (CurrentBaudRate <= CommonToolsClass.DefaultBaudRate[i])
                {
                    Position = i;
                    break;
                }
                else
                {
                    Position = i + 1;
                }
            }
            SetCurrentShowBaudRate(CommonToolsClass.DefaultBaudRate[(Position - 1 + CommonToolsClass.DefaultBaudRate.Length) % CommonToolsClass.DefaultBaudRate.Length]);
        }

        #endregion

        #region 公共方法

        private int GetCurrentShowBaudRate()
        {
            return BaudRateNum1.Num + BaudRateNum2.Num * 10 + BaudRateNum3.Num * 100 + BaudRateNum4.Num * 1000 + BaudRateNum5.Num * 10000 + BaudRateNum6.Num * 100000;
        }

        private void SetCurrentShowBaudRate(int BaudRate)
        {
            BaudRateNum1.Num = BaudRate % 10;
            BaudRateNum2.Num = BaudRate / 10 % 10;
            BaudRateNum3.Num = BaudRate / 100 % 10;
            BaudRateNum4.Num = BaudRate / 1000 % 10;
            BaudRateNum5.Num = BaudRate / 10000 % 10;
            BaudRateNum6.Num = BaudRate / 100000 % 10;
        }

        #endregion
    }
}
