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

namespace FUIProject.Controls.SimpleControls
{
    /// <summary>
    /// Interaction logic for CloseMinButton.xaml
    /// </summary>
    public partial class CloseMinButton : UserControl
    {
        public CloseMinButton()
        {
            InitializeComponent();
        }

        private bool _CloseMinTag = true;
        public bool CloseMinTag
        {
            get
            {
                return _CloseMinTag;
            }
            set
            {
                if (_CloseMinTag != value)
                {
                    _CloseMinTag = value;
                    if (_CloseMinTag)
                    {
                        ClosePath.Visibility = System.Windows.Visibility.Visible;
                        MinPath.Visibility = System.Windows.Visibility.Collapsed;
                    }
                    else
                    {
                        ClosePath.Visibility = System.Windows.Visibility.Collapsed;
                        MinPath.Visibility = System.Windows.Visibility.Visible;
                    }
                }
            }
        }

        #region 自身类委托事件
        public delegate void ClickEventHandler();
        public event ClickEventHandler ClickEvent;
        #endregion

        private void UserControl_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ContentGrid.Margin = new Thickness(4, 4.5, 0, 0);
        }

        private void UserControl_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ContentGrid.Margin = new Thickness(3.5, 3.5, 0, 0);
            if (ClickEvent != null)
            {
                ClickEvent();
            }
        }

        private void UserControl_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            ContentGrid.Margin = new Thickness(3.5, 3.5, 0, 0);
        }
    }
}
