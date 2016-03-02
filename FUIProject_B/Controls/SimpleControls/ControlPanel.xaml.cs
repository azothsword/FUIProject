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

using FUIProject_B.Class;
using System.Windows.Media.Animation;

namespace FUIProject_B.Controls.SimpleControls
{
    /// <summary>
    /// Interaction logic for ControlPanel.xaml
    /// </summary>
    public partial class ControlPanel : UserControl
    {
        public ControlPanel()
        {
            InitializeComponent();

            _FileDocumentTreatClass = new FileDocumentTreatClass();
            _FileDocumentTreatClass.DirectoryChangedEvent += new FileDocumentTreatClass.DirectoryChangedEventHandler(_FileDocumentTreatClass_DirectoryChangedEvent);



            _FileDocumentTreatClass.CurrentDirectory = AppDomain.CurrentDomain.BaseDirectory;
        }


        #region 变量标志位

        private int _CurrentPage = 1;
        public int CurrentPage
        {
            get
            {
                return _CurrentPage;
            }
            set
            {
                if (_CurrentPage != value)
                {
                    _CurrentPage = value;

                    ((EasingThicknessKeyFrame)((ThicknessAnimationUsingKeyFrames)(((Storyboard)Resources["CommandButtonPageChangeAction"]).Children[0])).KeyFrames[0]).SetValue(EasingThicknessKeyFrame.ValueProperty, new Thickness((_CurrentPage - 1) * -650, 0, 0, 0));
                    ((Storyboard)Resources["CommandButtonPageChangeAction"]).Begin();
                }
            }
        }

        #endregion


        #region 后台类委托事件

        void _FileDocumentTreatClass_DirectoryChangedEvent()
        {
            RefreshDocumentFileItem();

            //DirectoryPathComboBox.CurrentDirectory = _FileDocumentTreatClass.CurrentDirectory;

        }

        #region 界面事件


        private void GoUpButton_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            ((Storyboard)Resources["GoUpBackMouseEnterAction"]).SetValue(Storyboard.TargetNameProperty, "GoUpButtonPath");
            ((Storyboard)Resources["GoUpBackMouseEnterAction"]).Begin();
        }

        private void GoUpButton_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            ((Storyboard)Resources["GoUpBackMouseLeaveAction"]).SetValue(Storyboard.TargetNameProperty, "GoUpButtonPath");
            ((Storyboard)Resources["GoUpBackMouseLeaveAction"]).Begin();
        }

        private void GoUpButton_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ((Storyboard)Resources["GoUpBackMouseLeftButtonDownAction"]).SetValue(Storyboard.TargetNameProperty, "GoUpButtonPath");
            ((Storyboard)Resources["GoUpBackMouseLeftButtonDownAction"]).Begin();
        }

        private void GoUpButton_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ((Storyboard)Resources["GoUpBackMouseEnterAction"]).SetValue(Storyboard.TargetNameProperty, "GoUpButtonPath");
            ((Storyboard)Resources["GoUpBackMouseEnterAction"]).Begin();

            if (_FileDocumentTreatClass.CurrentDirectory.LastIndexOf('\\') != -1)
            {
                string tempStr = _FileDocumentTreatClass.CurrentDirectory.Substring(0, _FileDocumentTreatClass.CurrentDirectory.LastIndexOf('\\'));
                if (tempStr.LastIndexOf('\\') != -1)
                {
                    _FileDocumentTreatClass.PathStrStack.Push(_FileDocumentTreatClass.CurrentDirectory);
                    _FileDocumentTreatClass.CurrentDirectory = tempStr.Substring(0, tempStr.LastIndexOf('\\')) + "\\";
                }
                else
                {
                    _FileDocumentTreatClass.PathStrStack.Push(_FileDocumentTreatClass.CurrentDirectory);
                    _FileDocumentTreatClass.CurrentDirectory = "";
                }
            }
        }



        private void GoBackButton_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            ((Storyboard)Resources["GoUpBackMouseEnterAction"]).SetValue(Storyboard.TargetNameProperty, "GoBackButtonPath");
            ((Storyboard)Resources["GoUpBackMouseEnterAction"]).Begin();
        }

        private void GoBackButton_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            ((Storyboard)Resources["GoUpBackMouseLeaveAction"]).SetValue(Storyboard.TargetNameProperty, "GoBackButtonPath");
            ((Storyboard)Resources["GoUpBackMouseLeaveAction"]).Begin();
        }

        private void GoBackButton_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ((Storyboard)Resources["GoUpBackMouseLeftButtonDownAction"]).SetValue(Storyboard.TargetNameProperty, "GoBackButtonPath");
            ((Storyboard)Resources["GoUpBackMouseLeftButtonDownAction"]).Begin();
        }

        private void GoBackButton_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ((Storyboard)Resources["GoUpBackMouseEnterAction"]).SetValue(Storyboard.TargetNameProperty, "GoBackButtonPath");
            ((Storyboard)Resources["GoUpBackMouseEnterAction"]).Begin();

            if (_FileDocumentTreatClass.PathStrStack.Count > 0)
            {
                string BeforePath = _FileDocumentTreatClass.PathStrStack.Pop();
                _FileDocumentTreatClass.CurrentDirectory = BeforePath;
            }
        }



        private void FileContentScrollBar_ValueChanged(object sender, System.Windows.RoutedPropertyChangedEventArgs<double> e)
        {
            FileDocumentItemWrapPanel.Margin = new Thickness(-648 * e.NewValue, 0, 0, 0);
        }




        private void ButtonToFileButton_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ((Storyboard)Resources["ButtonToFileAction"]).Begin();
        }

        private void ButtonItemNextButton_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (CurrentPage + 1 <= TotalPage)
            {
                CurrentPage++;
            }
        }

        private void ButtonItemBeforeButton_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (CurrentPage - 1 >= 1)
            {
                CurrentPage--;
            }
        }


        #endregion

        #endregion

        #region 变量定义

        private FileDocumentTreatClass _FileDocumentTreatClass;

        public ControlPanelFileItem CurrentControlPanelFileItem;

        int TotalPage = 0;

        #endregion

        #region 自身委托事件

        public delegate void SystemInfoArrivedEventHandler(CommonToolsClass.SystemInfoTypeEnum _SystemInfoTypeEnum);
        public event SystemInfoArrivedEventHandler SystemInfoArrivedEvent;

        #endregion

        #region 公共方法

        private void RefreshDocumentFileItem()
        {
            FileDocumentItemWrapPanel.Children.Clear();
            for (int i = 0; i < _FileDocumentTreatClass.FileSystemItemList.Count; i++)
            {
                ControlPanelFileItem _ControlPanelFileItem = new ControlPanelFileItem();
                _ControlPanelFileItem.Width = 216;
                _ControlPanelFileItem.Height = 25;
                _ControlPanelFileItem.BindingItem(_FileDocumentTreatClass.FileSystemItemList[i]);
                _ControlPanelFileItem.MouseLeftButtonUp += new MouseButtonEventHandler(_FileDocumentItemType1_MouseLeftButtonUp);
                _ControlPanelFileItem.MouseDoubleClick += new MouseButtonEventHandler(_FileDocumentItemType1_MouseDoubleClick);
                FileDocumentItemWrapPanel.Children.Add(_ControlPanelFileItem);
            }

            //FileDocumentItemWrapPanel.Margin = new Thickness(0);

            int TotalSize = FileDocumentItemWrapPanel.Children.Count / 27;
            if (FileDocumentItemWrapPanel.Children.Count % 27 != 0)
            {
                TotalSize++;
            }
            FileContentScrollBar.Maximum = TotalSize - 1;
            FileContentScrollBar.Value = 0;
        }

        void _FileDocumentItemType1_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            ControlPanelFileItem _ControlPanelFileItem = (ControlPanelFileItem)sender;

            if (_ControlPanelFileItem._FileSystemItemObjClass.FileDocumentType == CommonToolsClass.FileDocumentTypeEnum.File)
            {
                if (_FileDocumentTreatClass.ReadFile(_ControlPanelFileItem._FileSystemItemObjClass.PathStr))
                {
                    RefreshButtonItem();
                    CurrentPage = 1;
                    TotalPage = _FileDocumentTreatClass.CommandObjList.Count / 20 + 1;
                    ((Storyboard)Resources["FileToButtonAction"]).Begin();

                    if (SystemInfoArrivedEvent != null)
                    {
                        SystemInfoArrivedEvent(CommonToolsClass.SystemInfoTypeEnum.FileOpenSuccess);
                    }
                }
                else
                {
                    if (SystemInfoArrivedEvent != null)
                    {
                        SystemInfoArrivedEvent(CommonToolsClass.SystemInfoTypeEnum.FileOpenFail);
                    }
                }
            }
            else
            {
                _FileDocumentTreatClass.PathStrStack.Push(_FileDocumentTreatClass.CurrentDirectory);
                _FileDocumentTreatClass.CurrentDirectory = _ControlPanelFileItem._FileSystemItemObjClass.PathStr;
                CurrentControlPanelFileItem = null;
            }

        }

        void _FileDocumentItemType1_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            ControlPanelFileItem _ControlPanelFileItem = (ControlPanelFileItem)sender;
            if (CurrentControlPanelFileItem != null && CurrentControlPanelFileItem != _ControlPanelFileItem)
            {
                CurrentControlPanelFileItem.IsCheckedTag = false;
            }
            _ControlPanelFileItem.IsCheckedTag = true;
            CurrentControlPanelFileItem = _ControlPanelFileItem;
        }

        private void RefreshButtonItem()
        {
            ButtonItemContentGrid.Children.Clear();
            for (int i = 0; i < _FileDocumentTreatClass.CommandObjList.Count; i++)
            {
                ButtonType1 _ButtonType1 = new ButtonType1();
                _ButtonType1.HorizontalAlignment = System.Windows.HorizontalAlignment.Left;
                _ButtonType1.VerticalAlignment = System.Windows.VerticalAlignment.Top;
                _ButtonType1.Height = 40;
                _ButtonType1.Width = 125;
                _ButtonType1.Margin = new Thickness(i % 5 * 130 + i / 20 * 650, i % 20 / 5 * 50, 0, 0);
                _ButtonType1.BindingCommandObj(_FileDocumentTreatClass.CommandObjList[i]);
                ButtonItemContentGrid.Children.Add(_ButtonType1);
            }
        }

        #endregion
    }
}
