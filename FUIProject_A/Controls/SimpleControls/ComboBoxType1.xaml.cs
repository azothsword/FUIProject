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

namespace FUIProject_A.Controls.SimpleControls
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

        private string _ContentStr = "";
        public string ContentStr
        {
            get
            {
                return _ContentStr;
            }
            set
            {
                if (_ContentStr != value && value != "")
                {
                    _ContentStr = value;
                    RefreshContent();
                }
            }
        }

        private string _SelectStr = "";
        public string SelectStr
        {
            get
            {
                return _SelectStr;
            }
            set
            {
                if (_SelectStr != value)
                {
                    _SelectStr = value;
                    SelectText.Text = value;
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
                if (_SelectIndex != value && value >=0 && value < ContentStackPanel.Children.Count)
                {
                    _SelectIndex = value;
                    TextBlock tempText = (TextBlock)((Grid)ContentStackPanel.Children[value]).Children[0];
                    SelectStr = tempText.Text;
                }
            }
        }

        private HorizontalAlignment _TextHA = HorizontalAlignment.Center;
        public HorizontalAlignment TextHA
        {
            get
            {
                return _TextHA;
            }
            set
            {
                if (_TextHA != value)
                {
                    _TextHA = value;
                    RefreshTextHA();
                }
            }

        }

        private bool _OpenTag = false;
        public bool OpenTag
        {
            get
            {
                return _OpenTag;
            }
            set
            {
                if (_OpenTag != value)
                {
                    _OpenTag = value;
                    if (_OpenTag)
                    {
                        ClosePath.Visibility = System.Windows.Visibility.Visible;
                        OpenPath.Visibility = System.Windows.Visibility.Collapsed;
                        ((EasingDoubleKeyFrame)((DoubleAnimationUsingKeyFrames)((Storyboard)Resources["ComboOpenAction"]).Children[0]).KeyFrames[0]).SetValue(EasingDoubleKeyFrame.ValueProperty, 29.0 + ContentStackPanel.Children.Count * 20.0);
                        ((Storyboard)Resources["ComboOpenAction"]).Begin();
                    }
                    else
                    {
                        ClosePath.Visibility = System.Windows.Visibility.Collapsed;
                        OpenPath.Visibility = System.Windows.Visibility.Visible;
                        ((Storyboard)Resources["ComboCloseAction"]).Begin();
                    }
                }
            }
        }

        private void RefreshContent()
        {
            ContentStackPanel.Children.Clear();
            string[] ContentStrs = ContentStr.Split('|');
            for (int i = 0; i < ContentStrs.Length; i++)
            {
                Grid tempGrid = new Grid();
                tempGrid.Height = 20;
                tempGrid.Background = new SolidColorBrush(Color.FromArgb(0, 0, 0, 0));
                tempGrid.MouseLeftButtonDown += new MouseButtonEventHandler(tempGrid_MouseLeftButtonDown);
                tempGrid.MouseEnter += new MouseEventHandler(tempGrid_MouseEnter);
                tempGrid.MouseLeave += new MouseEventHandler(tempGrid_MouseLeave);
                tempGrid.Tag = i;

                TextBlock tempText = new TextBlock();
                tempText.HorizontalAlignment = TextHA;
                tempText.VerticalAlignment = System.Windows.VerticalAlignment.Center;
                tempText.TextWrapping = TextWrapping.Wrap;
                tempText.Foreground = new SolidColorBrush(Colors.White);
                tempText.FontSize = 14.667;
                tempText.FontFamily = new FontFamily("Microsoft Sans Serif");
                tempText.Text = ContentStrs[i];

                tempGrid.Children.Add(tempText);
                ContentStackPanel.Children.Add(tempGrid);
            }
        }

        private void RefreshTextHA()
        {
            SelectText.HorizontalAlignment = TextHA;
            for (int i = 0; i < ContentStackPanel.Children.Count; i++)
            {
                Grid tempGrid = (Grid)ContentStackPanel.Children[i];
                TextBlock tempText = (TextBlock)tempGrid.Children[0];
                tempText.HorizontalAlignment = TextHA;
            }
        }

        void tempGrid_MouseLeave(object sender, MouseEventArgs e)
        {
            ((Grid)sender).Background = new SolidColorBrush(Color.FromArgb(0, 0, 0, 0));
        }

        void tempGrid_MouseEnter(object sender, MouseEventArgs e)
        {
            ((Grid)sender).Background = new SolidColorBrush(Color.FromArgb(255, 0, 146, 186));
        }

        void tempGrid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            TextBlock tempText = (TextBlock)((Grid)sender).Children[0];
            SelectStr = tempText.Text;
            SelectIndex = (int)((Grid)sender).Tag;
            OpenTag = false;
        }

        private void OpenOrCloseGrid_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ((Storyboard)Resources["MouseLeftButtonDownAction"]).Begin();
            OpenTag = !OpenTag;
            e.Handled = true;
        }

        private void OpenOrCloseGrid_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            ((Storyboard)Resources["MouseEnterAction"]).Begin();
        }

        private void OpenOrCloseGrid_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            ((Storyboard)Resources["MouseLeaveAction"]).Begin();
        }

        private void OpenOrCloseGrid_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ((Storyboard)Resources["MouseEnterAction"]).Begin();
        }
    }
}
