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

namespace FUIProject_B.Controls.SimpleControls
{
    /// <summary>
    /// Interaction logic for ComboBoxType1.xaml
    /// </summary>
    public partial class ComboBoxType1 : UserControl
    {
        public ComboBoxType1()
        {
            InitializeComponent();
        }

        private string _TitleStr = "Combo Box";
        public string TitleStr
        {
            get
            {
                return _TitleStr;
            }
            set
            {
                if (_TitleStr != value)
                {
                    _TitleStr = value;
                    TitleText.Text = value;
                }
            }
        }

        private int _SelectIndex = -1;
        public int SelectIndex
        {
            get
            {
                return _SelectIndex;
            }
            set
            {
                if (_SelectIndex != value)
                {
                    try
                    {
                        SelectText.Text = ComboItem[value];
                        _SelectIndex = value;
                    }
                    catch
                    {
                    }
                }
            }
        }

        private string _ComboItemStr = "";
        public string ComboItemStr
        {
            get
            {
                return _ComboItemStr;
            }
            set
            {
                if (_ComboItemStr != value)
                {
                    _ComboItemStr = value;
                    ComboItem = _ComboItemStr.Split('|');
                    if (ComboItem.Length > 0)
                    {
                        SelectIndex = 0;
                    }
                }
            }
        }

        private bool _IsUnable = false;
        public bool IsUnable
        {
            get
            {
                return _IsUnable;
            }
            set
            {
                if (_IsUnable != value)
                {
                    _IsUnable = value;
                    if (_IsUnable)
                    {
                        ((Storyboard)Resources["UnableAction"]).Begin();
                    }
                    else
                    {
                        ((Storyboard)Resources["AbleAction"]).Begin();
                    }
                }
            }
        }

        private string[] ComboItem;

        #region 界面事件

        private void BeforeButton_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            ((Storyboard)Resources["MouseEnterAction"]).SetValue(Storyboard.TargetNameProperty, "BeforeButtonPath");
            ((Storyboard)Resources["MouseEnterAction"]).Begin();
        }

        private void BeforeButton_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            ((Storyboard)Resources["MouseLeaveAction"]).SetValue(Storyboard.TargetNameProperty, "BeforeButtonPath");
            ((Storyboard)Resources["MouseLeaveAction"]).Begin();
        }

        private void BeforeButton_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ((Storyboard)Resources["MouseLeftButtonDownAction"]).SetValue(Storyboard.TargetNameProperty, "BeforeButtonPath");
            ((Storyboard)Resources["MouseLeftButtonDownAction"]).Begin();
        }

        private void BeforeButton_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ((Storyboard)Resources["MouseEnterAction"]).SetValue(Storyboard.TargetNameProperty, "BeforeButtonPath");
            ((Storyboard)Resources["MouseEnterAction"]).Begin();
            SelectIndex--;
        }

        private void NextButton_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            ((Storyboard)Resources["MouseEnterAction"]).SetValue(Storyboard.TargetNameProperty, "NextButtonPath");
            ((Storyboard)Resources["MouseEnterAction"]).Begin();
        }

        private void NextButton_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            ((Storyboard)Resources["MouseLeaveAction"]).SetValue(Storyboard.TargetNameProperty, "NextButtonPath");
            ((Storyboard)Resources["MouseLeaveAction"]).Begin();
        }

        private void NextButton_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ((Storyboard)Resources["MouseLeftButtonDownAction"]).SetValue(Storyboard.TargetNameProperty, "NextButtonPath");
            ((Storyboard)Resources["MouseLeftButtonDownAction"]).Begin();
        }

        private void NextButton_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ((Storyboard)Resources["MouseEnterAction"]).SetValue(Storyboard.TargetNameProperty, "NextButtonPath");
            ((Storyboard)Resources["MouseEnterAction"]).Begin();
            SelectIndex++;
        }

        #endregion
    }
}
