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
using FUIProject.Class.ObjectClass;

namespace FUIProject.Controls.SimpleControls
{
    /// <summary>
    /// Interaction logic for ControlPanel.xaml
    /// </summary>
    public partial class ControlPanel : UserControl
    {
        public ControlPanel()
        {
            InitializeComponent();

            _IniFileTreatClass = IniFileTreatClass.GetInstance();
            _IniFileTreatClass.DirectoryChangedEvent += new IniFileTreatClass.DirectoryChangedEventHandler(_IniFileTreatClass_DirectoryChangedEvent);


            _IniFileTreatClass.CurrentDirectory = AppDomain.CurrentDomain.BaseDirectory;
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

                    ((EasingThicknessKeyFrame)((ThicknessAnimationUsingKeyFrames)(((Storyboard)Resources["CommandButtonPageChangeAction"]).Children[0])).KeyFrames[0]).SetValue(EasingThicknessKeyFrame.ValueProperty, new Thickness((_CurrentPage - 1) * -214, 0, 0, 0));
                    ((Storyboard)Resources["CommandButtonPageChangeAction"]).Begin();
                }
            }
        }

        #endregion

        #region 变量定义

        IniFileTreatClass _IniFileTreatClass;
        int TotalPage = 0;
        int MoveSpeed = 10;

        #endregion

        #region 自身类委托事件

        public delegate void PressCommandSendEventHandler(byte[] PressCommand);
        public event PressCommandSendEventHandler PressCommandSendEvent;

        public delegate void ReleaseCommandSendEventHandler(byte[] ReleaseCommand);
        public event ReleaseCommandSendEventHandler ReleaseCommandSendEvent;

        #endregion

        #region 后台类委托事件

        void _IniFileTreatClass_DirectoryChangedEvent()
        {
            RefreshFileSystemItem();
        }

        #endregion

        #region 界面事件

        private void ButtonPanelToFileSystemButton_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ((Storyboard)Resources["ButtonPanelToFileSystem"]).Begin();
        }

        private void ButtonPanelBeforeButton_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (CurrentPage - 1 >= 1)
            {
                CurrentPage--;
            }
        }

        private void ButtonPanelNextButton_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (CurrentPage + 1 <= TotalPage)
            {
                CurrentPage++;
            }
        }

        private void FileSystemGrid_MouseWheel(object sender, System.Windows.Input.MouseWheelEventArgs e)
        {
            if (FileSystemStackPanel.ActualHeight > FileSystemGrid.ActualHeight)
            {
                if (e.Delta < 0)
                {
                    MoveSpeed = -Math.Abs(MoveSpeed);
                }
                else
                {
                    MoveSpeed = Math.Abs(MoveSpeed);
                }

                double MarginY = 0;
                if (FileSystemStackPanel.Margin.Top + MoveSpeed > 0)
                {
                    MarginY = -FileSystemStackPanel.Margin.Top;
                }
                else if (-FileSystemStackPanel.Margin.Top - MoveSpeed + FileSystemGrid.ActualHeight > FileSystemStackPanel.ActualHeight)
                {
                    MarginY = FileSystemGrid.ActualHeight - FileSystemStackPanel.ActualHeight - FileSystemStackPanel.Margin.Top;
                }
                else
                {
                    MarginY = MoveSpeed;
                }

                FileSystemStackPanel.Margin = new Thickness(0, FileSystemStackPanel.Margin.Top + MarginY, 0, 0);
            }
        }

        #endregion

        #region 公共方法

        private void RefreshFileSystemItem()
        {
            FileSystemStackPanel.Children.Clear();

            if (!_IniFileTreatClass.RootTag)
            {
                ControlPanelFileItem _ControlPanelFileItem_Back = new ControlPanelFileItem();
                FileSystemItemObjClass _FileSystemItemObjClass = new FileSystemItemObjClass();
                _FileSystemItemObjClass.FileDocumentType = CommonToolsClass.FileDocumentTypeEnum.Document;
                _FileSystemItemObjClass.NameStr = "<...>Go back";
                _FileSystemItemObjClass.PathStr = _IniFileTreatClass.ParentPathStr;
                _ControlPanelFileItem_Back.BindingItem(_FileSystemItemObjClass);
                _ControlPanelFileItem_Back.MouseLeftButtonUp += new MouseButtonEventHandler(ControlPanelFileItem_MouseLeftButtonUp);
                FileSystemStackPanel.Children.Add(_ControlPanelFileItem_Back);
            }

            for (int i = 0; i < _IniFileTreatClass.FileSystemItemList.Count; i++)
            {
                ControlPanelFileItem _ControlPanelFileItem = new ControlPanelFileItem();
                _ControlPanelFileItem.BindingItem(_IniFileTreatClass.FileSystemItemList[i]);
                _ControlPanelFileItem.MouseLeftButtonUp += new MouseButtonEventHandler(ControlPanelFileItem_MouseLeftButtonUp);
                FileSystemStackPanel.Children.Add(_ControlPanelFileItem);
            }

            FileSystemStackPanel.Margin = new Thickness(0);
        }

        void ControlPanelFileItem_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            ControlPanelFileItem _ControlPanelFileItem = (ControlPanelFileItem)sender;
            if (_ControlPanelFileItem.FileDocumentType == CommonToolsClass.FileDocumentTypeEnum.File)
            {
                _IniFileTreatClass.ReadFile(_ControlPanelFileItem._FileSystemItemObjClass.PathStr);
                RefreshCommandButton();
                CurrentPage = 1;
                TotalPage = _IniFileTreatClass.CommandObjList.Count / 15 + 1;
                ((Storyboard)Resources["FileSystemToButtonPanel"]).Begin();
            }
            else
            {
                _IniFileTreatClass.CurrentDirectory = _ControlPanelFileItem._FileSystemItemObjClass.PathStr;
            }
        }

        private void RefreshCommandButton()
        {
            CommandButtonGrid.Children.Clear();
            for (int i = 0; i < _IniFileTreatClass.CommandObjList.Count; i++)
            {
                ControlPanelCommandButton _ControlPanelCommandButton = new ControlPanelCommandButton();
                _ControlPanelCommandButton.Width = 70;
                _ControlPanelCommandButton.Height = 30;
                _ControlPanelCommandButton.HorizontalAlignment = System.Windows.HorizontalAlignment.Left;
                _ControlPanelCommandButton.VerticalAlignment = System.Windows.VerticalAlignment.Top;
                _ControlPanelCommandButton.Margin = new Thickness(i / 15 * 214 + i % 3 * 72, i % 15 / 3 * 35, 0, 0);
                _ControlPanelCommandButton.BindingCommandObjClass(_IniFileTreatClass.CommandObjList[i]);
                _ControlPanelCommandButton.PressCommandSendEvent += new ControlPanelCommandButton.PressCommandSendEventHandler(_ControlPanelCommandButton_PressCommandSendEvent);
                _ControlPanelCommandButton.ReleaseCommandSendEvent += new ControlPanelCommandButton.ReleaseCommandSendEventHandler(_ControlPanelCommandButton_ReleaseCommandSendEvent);

                CommandButtonGrid.Children.Add(_ControlPanelCommandButton);
            }
        }

        void _ControlPanelCommandButton_ReleaseCommandSendEvent(byte[] ReleaseCommand)
        {
            if (PressCommandSendEvent != null)
            {
                PressCommandSendEvent(ReleaseCommand);
            }
        }

        void _ControlPanelCommandButton_PressCommandSendEvent(byte[] PressCommand)
        {
            if (ReleaseCommandSendEvent != null)
            {
                ReleaseCommandSendEvent(PressCommand);
            }
        }

        #endregion
    }
}
