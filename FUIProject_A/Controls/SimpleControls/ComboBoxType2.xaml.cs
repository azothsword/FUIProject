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

using FUIProject_A.Class;

namespace FUIProject_A.Controls.SimpleControls
{
    /// <summary>
    /// Interaction logic for ComboBoxType2.xaml
    /// </summary>
    public partial class ComboBoxType2 : UserControl
    {
        public ComboBoxType2()
        {
            InitializeComponent();
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

        private string _CurrentDirectory = "";
        public string CurrentDirectory
        {
            get
            {
                return _CurrentDirectory;
            }
            set
            {
                if (_CurrentDirectory != value)
                {
                    _CurrentDirectory = value;
                    RefreshContent();
                }
            }
        }


        #region 自身类委托事件

        public delegate void CurrentDirectoryChangedEventHandler(string CurrentDirectory);
        public event CurrentDirectoryChangedEventHandler CurrentDirectoryChangedEvent;

        #endregion


        #region 界面事件



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
            Grid tempGrid = (Grid)sender;
            if (tempGrid.Tag.ToString() == "-1")
            {
                CurrentDirectory = "";
            }
            else if (tempGrid.Tag.ToString() == "0")
            {
                TextBlock tempText = (TextBlock)tempGrid.Children[0];
                CurrentDirectory = tempText.Text + "\\";
            }
            else
            {
                string tempStr = CurrentDirectory;
                if (tempStr.LastIndexOf('\\') != -1 && tempStr.LastIndexOf('\\') == tempStr.Length - 1)
                {
                    tempStr = tempStr.Remove(tempStr.Length - 1);
                }
                string[] DirectoryStrs = tempStr.Split('\\');
                int EndPosition = int.Parse(tempGrid.Tag.ToString());
                string tempPath = "";
                for (int i = 0; i <= EndPosition; i++)
                {
                    tempPath += DirectoryStrs[i] + "\\";
                }
                CurrentDirectory = tempPath;
            }

            if (CurrentDirectoryChangedEvent != null)
            {
                CurrentDirectoryChangedEvent(CurrentDirectory);
            }

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


        #endregion

        #region 公共方法

        private void RefreshContent()
        {
            ContentStackPanel.Children.Clear();

            string[] DiskStrs = FileDocumentTreatClass.GetAllDiskStrs().Split('|');
            string tempStr = CurrentDirectory;
            if (tempStr.LastIndexOf('\\') != -1 && tempStr.LastIndexOf('\\') == tempStr.Length - 1)
            {
                tempStr = tempStr.Remove(tempStr.Length - 1);
            }
            string[] DirectoryStrs = tempStr.Split('\\');

            Grid tempGrid2 = new Grid();
            tempGrid2.Height = 20;
            tempGrid2.Background = new SolidColorBrush(Color.FromArgb(0, 0, 0, 0));
            tempGrid2.MouseLeftButtonDown += new MouseButtonEventHandler(tempGrid_MouseLeftButtonDown);
            tempGrid2.MouseEnter += new MouseEventHandler(tempGrid_MouseEnter);
            tempGrid2.MouseLeave += new MouseEventHandler(tempGrid_MouseLeave);
            tempGrid2.Tag = "-1";

            Path tempPath2 = new Path();
            tempPath2.Data = Geometry.Parse("M0,4.4999999L13.5,4.4999999 15.895863,12 2.3958631,12z M2.3949315,0L7.3949316,0 7.3949316,1.9999999 17.394932,1.9999999 17.394932,12 17.394587,12 14.679275,3.4999999 2.3949315,3.4999999 2.3949315,1.9999999z");
            tempPath2.Fill = new SolidColorBrush(Colors.White);
            tempPath2.Width = 17;
            tempPath2.Height = 12;
            tempPath2.HorizontalAlignment = System.Windows.HorizontalAlignment.Left;
            tempPath2.VerticalAlignment = System.Windows.VerticalAlignment.Center;
            tempPath2.Margin = new Thickness(4, 0, 0, 0);

            TextBlock tempText2 = new TextBlock();
            tempText2.HorizontalAlignment = System.Windows.HorizontalAlignment.Left;
            tempText2.VerticalAlignment = System.Windows.VerticalAlignment.Center;
            tempText2.TextWrapping = TextWrapping.Wrap;
            tempText2.Foreground = new SolidColorBrush(Colors.White);
            tempText2.FontSize = 12;
            tempText2.FontFamily = new FontFamily("Microsoft Sans Serif");
            tempText2.Text = "我的电脑";
            tempText2.Margin = new Thickness(25, 0, 0, 0);

            tempGrid2.Children.Add(tempText2);
            tempGrid2.Children.Add(tempPath2);
            ContentStackPanel.Children.Add(tempGrid2);


            for (int i = 0; i < DiskStrs.Length; i++)
            {
                Grid tempGrid = new Grid();
                tempGrid.Height = 20;
                tempGrid.Background = new SolidColorBrush(Color.FromArgb(0, 0, 0, 0));
                tempGrid.MouseLeftButtonDown += new MouseButtonEventHandler(tempGrid_MouseLeftButtonDown);
                tempGrid.MouseEnter += new MouseEventHandler(tempGrid_MouseEnter);
                tempGrid.MouseLeave += new MouseEventHandler(tempGrid_MouseLeave);
                tempGrid.Tag = "0";

                Path tempPath = new Path();
                tempPath.Data = Geometry.Parse("M0,4.4999999L13.5,4.4999999 15.895863,12 2.3958631,12z M2.3949315,0L7.3949316,0 7.3949316,1.9999999 17.394932,1.9999999 17.394932,12 17.394587,12 14.679275,3.4999999 2.3949315,3.4999999 2.3949315,1.9999999z");
                tempPath.Fill = new SolidColorBrush(Colors.White);
                tempPath.Width = 17;
                tempPath.Height = 12;
                tempPath.HorizontalAlignment = System.Windows.HorizontalAlignment.Left;
                tempPath.VerticalAlignment = System.Windows.VerticalAlignment.Center;
                tempPath.Margin = new Thickness(24, 0, 0, 0);

                TextBlock tempText = new TextBlock();
                tempText.HorizontalAlignment = System.Windows.HorizontalAlignment.Left;
                tempText.VerticalAlignment = System.Windows.VerticalAlignment.Center;
                tempText.TextWrapping = TextWrapping.Wrap;
                tempText.Foreground = new SolidColorBrush(Colors.White);
                tempText.FontSize = 12;
                tempText.FontFamily = new FontFamily("Microsoft Sans Serif");
                tempText.Text = DiskStrs[i];
                tempText.Margin = new Thickness(45, 0, 0, 0);

                tempGrid.Children.Add(tempText);
                tempGrid.Children.Add(tempPath);
                ContentStackPanel.Children.Add(tempGrid);

                if (DiskStrs[i] == DirectoryStrs[0])
                {
                    if (DirectoryStrs.Length > 1)
                    {
                        for (int j = 1; j < DirectoryStrs.Length; j++)
                        {
                            Grid tempGrid1 = new Grid();
                            tempGrid1.Height = 20;
                            tempGrid1.Background = new SolidColorBrush(Color.FromArgb(0, 0, 0, 0));
                            tempGrid1.MouseLeftButtonDown += new MouseButtonEventHandler(tempGrid_MouseLeftButtonDown);
                            tempGrid1.MouseEnter += new MouseEventHandler(tempGrid_MouseEnter);
                            tempGrid1.MouseLeave += new MouseEventHandler(tempGrid_MouseLeave);
                            tempGrid1.Tag = j.ToString();

                            Path tempPath1 = new Path();
                            tempPath1.Data = Geometry.Parse("M0,4.4999999L13.5,4.4999999 15.895863,12 2.3958631,12z M2.3949315,0L7.3949316,0 7.3949316,1.9999999 17.394932,1.9999999 17.394932,12 17.394587,12 14.679275,3.4999999 2.3949315,3.4999999 2.3949315,1.9999999z");
                            tempPath1.Fill = new SolidColorBrush(Colors.White);
                            tempPath1.Width = 17;
                            tempPath1.Height = 12;
                            tempPath1.HorizontalAlignment = System.Windows.HorizontalAlignment.Left;
                            tempPath1.VerticalAlignment = System.Windows.VerticalAlignment.Center;
                            tempPath1.Margin = new Thickness(24 + j * 20, 0, 0, 0);

                            TextBlock tempText1 = new TextBlock();
                            tempText1.HorizontalAlignment = System.Windows.HorizontalAlignment.Left;
                            tempText1.VerticalAlignment = System.Windows.VerticalAlignment.Center;
                            tempText1.TextWrapping = TextWrapping.Wrap;
                            tempText1.Foreground = new SolidColorBrush(Colors.White);
                            tempText1.FontSize = 12;
                            tempText1.FontFamily = new FontFamily("Microsoft Sans Serif");
                            tempText1.Text = DirectoryStrs[j];
                            tempText1.Margin = new Thickness(45 + j * 20, 0, 0, 0);

                            tempGrid1.Children.Add(tempText1);
                            tempGrid1.Children.Add(tempPath1);
                            ContentStackPanel.Children.Add(tempGrid1);

                            if (j == DirectoryStrs.Length - 1)
                            {
                                SelectText.Text = DirectoryStrs[j];
                            }
                        }
                    }
                    else
                    {
                        SelectText.Text = DirectoryStrs[0];
                    }
                }
            }

            if (tempStr == "")
            {
                SelectText.Text = "我的电脑";
            }
        }

        #endregion
    }
}
