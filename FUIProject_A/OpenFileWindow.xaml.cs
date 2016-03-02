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
using System.Windows.Shapes;

using FUIProject_A.Class;
using FUIProject_A.Controls.SimpleControls;
using System.Windows.Media.Animation;

namespace FUIProject_A
{
    /// <summary>
    /// Interaction logic for OpenFileWindow.xaml
    /// </summary>
    public partial class OpenFileWindow : Window
    {
        public OpenFileWindow()
        {
            InitializeComponent();

            _FileDocumentTreatClass = new FileDocumentTreatClass();
            _FileDocumentTreatClass.DirectoryChangedEvent += new FileDocumentTreatClass.DirectoryChangedEventHandler(_FileDocumentTreatClass_DirectoryChangedEvent);

            DirectoryPathComboBox.CurrentDirectoryChangedEvent += new ComboBoxType2.CurrentDirectoryChangedEventHandler(DirectoryPathComboBox_CurrentDirectoryChangedEvent);


            _FileDocumentTreatClass.CurrentDirectory = AppDomain.CurrentDomain.BaseDirectory;
        }



        #region 变量定义

        private bool WindowMoveTag = false;

        private FileDocumentTreatClass _FileDocumentTreatClass;

        public FileDocumentItemType1 CurrentFileDocumentItem;

        #endregion

        #region 界面委托事件定义


        void DirectoryPathComboBox_CurrentDirectoryChangedEvent(string CurrentDirectory)
        {
            _FileDocumentTreatClass.PathStrStack.Push(_FileDocumentTreatClass.CurrentDirectory);
            _FileDocumentTreatClass.CurrentDirectory = CurrentDirectory;
        }

        #endregion


        #region 后台类委托事件

        void _FileDocumentTreatClass_DirectoryChangedEvent()
        {
            RefreshDocumentFileItem();

            DirectoryPathComboBox.CurrentDirectory = _FileDocumentTreatClass.CurrentDirectory;

        }

        #endregion

        #region 界面委托事件



        #endregion


        #region 界面事件

        private void OpenFileButton_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (CurrentFileDocumentItem != null)
            {
                if (CurrentFileDocumentItem._FileSystemItemObjClass.FileDocumentType == CommonToolsClass.FileDocumentTypeEnum.File)
                {
                    this.DialogResult = true;
                }
                else
                {
                    _FileDocumentTreatClass.PathStrStack.Push(_FileDocumentTreatClass.CurrentDirectory);
                    _FileDocumentTreatClass.CurrentDirectory = CurrentFileDocumentItem._FileSystemItemObjClass.PathStr;
                }
            }
        }

        private void CloseButton_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            this.DialogResult = false;
        }

        private void TitleGrid_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            WindowMoveTag = true;
        }

        private void TitleGrid_MouseMove(object sender, System.Windows.Input.MouseEventArgs e)
        {
            if (e.MouseDevice.LeftButton == MouseButtonState.Pressed && WindowMoveTag)
            {
                this.DragMove();
            }
        }



        private void GoBackButton_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            ((Storyboard)Resources["ButtonEnterAction"]).SetValue(Storyboard.TargetNameProperty, "GoBackButtonPath");
            ((Storyboard)Resources["ButtonEnterAction"]).Begin();
        }

        private void GoBackButton_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            ((Storyboard)Resources["ButtonLeaveAction"]).SetValue(Storyboard.TargetNameProperty, "GoBackButtonPath");
            ((Storyboard)Resources["ButtonLeaveAction"]).Begin();
        }

        private void GoBackButton_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ((Storyboard)Resources["ButtonClickAction"]).SetValue(Storyboard.TargetNameProperty, "GoBackButtonPath");
            ((Storyboard)Resources["ButtonClickAction"]).Begin();
            WindowMoveTag = false;
        }

        private void GoBackButton_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ((Storyboard)Resources["ButtonEnterAction"]).SetValue(Storyboard.TargetNameProperty, "GoBackButtonPath");
            ((Storyboard)Resources["ButtonEnterAction"]).Begin();
            if (_FileDocumentTreatClass.PathStrStack.Count > 0)
            {
                string BeforePath = _FileDocumentTreatClass.PathStrStack.Pop();
                _FileDocumentTreatClass.CurrentDirectory = BeforePath;
            }
        }

        private void GoUpButton_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            ((Storyboard)Resources["ButtonEnterAction"]).SetValue(Storyboard.TargetNameProperty, "GoUpButtonPath");
            ((Storyboard)Resources["ButtonEnterAction"]).Begin();
        }

        private void GoUpButton_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            ((Storyboard)Resources["ButtonLeaveAction"]).SetValue(Storyboard.TargetNameProperty, "GoUpButtonPath");
            ((Storyboard)Resources["ButtonLeaveAction"]).Begin();
        }

        private void GoUpButton_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ((Storyboard)Resources["ButtonClickAction"]).SetValue(Storyboard.TargetNameProperty, "GoUpButtonPath");
            ((Storyboard)Resources["ButtonClickAction"]).Begin();
            WindowMoveTag = false;
        }

        private void GoUpButton_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ((Storyboard)Resources["ButtonEnterAction"]).SetValue(Storyboard.TargetNameProperty, "GoUpButtonPath");
            ((Storyboard)Resources["ButtonEnterAction"]).Begin();
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



        private void FileContentScrollBar_ValueChanged(object sender, System.Windows.RoutedPropertyChangedEventArgs<double> e)
        {
            FileDocumentItemWrapPanel.Margin = new Thickness(-480 * e.NewValue, 0, 0, 0);
        }



        private void FileContentGrid_MouseWheel(object sender, System.Windows.Input.MouseWheelEventArgs e)
        {
            if (e.Delta < 0)
            {
                if ((int)(FileContentScrollBar.Value + 1) <= (int)(FileContentScrollBar.Maximum))
                {
                    FileContentScrollBar.Value = (int)(FileContentScrollBar.Value + 1);
                }
            }
            else
            {
                if ((int)(FileContentScrollBar.Value - 1) >= 0)
                {
                    FileContentScrollBar.Value = (int)(FileContentScrollBar.Value - 1);
                }
            }
        }


        #endregion

        #region 公共方法

        private void RefreshDocumentFileItem()
        {
            FileDocumentItemWrapPanel.Children.Clear();
            for (int i = 0; i < _FileDocumentTreatClass.FileSystemItemList.Count; i++)
            {
                FileDocumentItemType1 _FileDocumentItemType1 = new FileDocumentItemType1();
                _FileDocumentItemType1.Width = 160;
                _FileDocumentItemType1.Height = 20;
                _FileDocumentItemType1.BindingItem(_FileDocumentTreatClass.FileSystemItemList[i]);
                _FileDocumentItemType1.MouseLeftButtonUp += new MouseButtonEventHandler(_FileDocumentItemType1_MouseLeftButtonUp);
                _FileDocumentItemType1.MouseDoubleClick += new MouseButtonEventHandler(_FileDocumentItemType1_MouseDoubleClick);
                FileDocumentItemWrapPanel.Children.Add(_FileDocumentItemType1);
            }

            //FileDocumentItemWrapPanel.Margin = new Thickness(0);

            int TotalSize = FileDocumentItemWrapPanel.Children.Count  / 27;
            if (FileDocumentItemWrapPanel.Children.Count % 27 != 0)
            {
                TotalSize++;
            }
            FileContentScrollBar.Maximum = TotalSize - 1;
            FileContentScrollBar.Value = 0;
        }

        void _FileDocumentItemType1_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            FileDocumentItemType1 _FileDocumentItemType1 = (FileDocumentItemType1)sender;
            
            if (_FileDocumentItemType1._FileSystemItemObjClass.FileDocumentType == CommonToolsClass.FileDocumentTypeEnum.File)
            {
                this.DialogResult = true;
            }
            else
            {
                _FileDocumentTreatClass.PathStrStack.Push(_FileDocumentTreatClass.CurrentDirectory);
                _FileDocumentTreatClass.CurrentDirectory = _FileDocumentItemType1._FileSystemItemObjClass.PathStr;
                CurrentFileDocumentItem = null;
            }

        }

        void _FileDocumentItemType1_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            FileDocumentItemType1 _FileDocumentItemType1 = (FileDocumentItemType1)sender;
            if (CurrentFileDocumentItem != null && CurrentFileDocumentItem != _FileDocumentItemType1)
            {
                CurrentFileDocumentItem.IsCheckedTag = false;
            }
            _FileDocumentItemType1.IsCheckedTag = true;
            CurrentFileDocumentItem = _FileDocumentItemType1;

            if (_FileDocumentItemType1._FileSystemItemObjClass.FileDocumentType == CommonToolsClass.FileDocumentTypeEnum.File)
            {
                FileNameText.Text = _FileDocumentItemType1._FileSystemItemObjClass.NameStr;
            }
            else
            {
                FileNameText.Text = "";
            }
        }

        #endregion

    }
}
