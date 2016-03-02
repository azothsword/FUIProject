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


namespace FUIProject.Controls.SimpleControls
{
    /// <summary>
    /// Interaction logic for PortNameSetButton.xaml
    /// </summary>
    public partial class PortNameSetButton : UserControl
    {
        public PortNameSetButton()
        {
            InitializeComponent();
        }

        #region 变量标志位

        private int _PortIndex = 0;
        public int PortIndex
        {
            get
            {
                return _PortIndex;
            }
            set
            {
                if (_PortIndex != value)
                {
                    _PortIndex = value;

                    ((EasingThicknessKeyFrame)((ThicknessAnimationUsingKeyFrames)(((Storyboard)Resources["PortNameChangeAction"]).Children[0])).KeyFrames[0]).SetValue(EasingThicknessKeyFrame.ValueProperty, new Thickness(0, PortIndex * -20, 0, 0));
                    ((Storyboard)Resources["PortNameChangeAction"]).Begin();

                    if (PortIndexChangedEvent != null)
                    {
                        PortIndexChangedEvent(_PortIndex);
                    }
                }
            }
        }

        private bool _IsSetTag = true;
        public bool IsSetTag
        {
            get
            {
                return _IsSetTag;
            }
            set
            {
                if (_IsSetTag != value)
                {
                    _IsSetTag = value;
                    if (_IsSetTag)
                    {
                        AddButton.Visibility = System.Windows.Visibility.Visible;
                        ReduceButton.Visibility = System.Windows.Visibility.Visible;
                    }
                    else
                    {
                        AddButton.Visibility = System.Windows.Visibility.Collapsed;
                        ReduceButton.Visibility = System.Windows.Visibility.Collapsed;
                    }
                }
            }
        }



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

        #region 自身类委托事件

        public delegate void PortIndexChangedEventHandler(int PortIndex);
        public event PortIndexChangedEventHandler PortIndexChangedEvent;

        #endregion

        #region 界面事件

        private void AddButton_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ((Storyboard)Resources["AddClickAction"]).Begin();
            if (PortIndex + 1 < PortNameStackPanel.Children.Count)
            {
                PortIndex++;
            }
        }

        private void ReduceButton_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ((Storyboard)Resources["ReduceClickAction"]).Begin();
            if (PortIndex - 1 >= 0)
            {
                PortIndex--;
            }
        }

        #endregion

        #region 公共方法

        public void AddAction()
        {
            ((Storyboard)Resources["AddClickAction"]).Begin();
            if (PortIndex + 1 < PortNameStackPanel.Children.Count)
            {
                PortIndex++;
            }
        }

        public void ReduceAction()
        {
            ((Storyboard)Resources["ReduceClickAction"]).Begin();
            if (PortIndex - 1 >= 0)
            {
                PortIndex--;
            }
        }


        #endregion
    }
}
