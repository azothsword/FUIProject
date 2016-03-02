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
using FUIProject_B.Class.ObjectClass;
using System.Windows.Media.Animation;


namespace FUIProject_B.Controls.SimpleControls
{
    /// <summary>
    /// Interaction logic for ControlPanelFileItem.xaml
    /// </summary>
    public partial class ControlPanelFileItem : UserControl
    {
        public ControlPanelFileItem()
        {
            InitializeComponent();
        }



        #region 变量控制标志位

        private CommonToolsClass.FileDocumentTypeEnum _FileDocumentType = CommonToolsClass.FileDocumentTypeEnum.File;
        public CommonToolsClass.FileDocumentTypeEnum FileDocumentType
        {
            get
            {
                return _FileDocumentType;
            }
            set
            {
                if (_FileDocumentType != value)
                {
                    _FileDocumentType = value;
                    if (_FileDocumentType == CommonToolsClass.FileDocumentTypeEnum.Document)
                    {
                        DocumentPath.Visibility = System.Windows.Visibility.Visible;
                        FilePath.Visibility = System.Windows.Visibility.Collapsed;
                    }
                    else if (_FileDocumentType == CommonToolsClass.FileDocumentTypeEnum.File)
                    {
                        DocumentPath.Visibility = System.Windows.Visibility.Collapsed;
                        FilePath.Visibility = System.Windows.Visibility.Visible;
                    }
                }
            }
        }

        private string _ItemTextStr = "FileName";
        public string ItemTextStr
        {
            get
            {
                return _ItemTextStr;
            }
            set
            {
                if (_ItemTextStr != value)
                {
                    _ItemTextStr = value;
                    ItemText.Text = value;
                }
            }
        }

        private bool _IsCheckedTag = false;
        public bool IsCheckedTag
        {
            get
            {
                return _IsCheckedTag;
            }
            set
            {
                if (_IsCheckedTag != value)
                {
                    _IsCheckedTag = value;
                    if (_IsCheckedTag)
                    {
                        ((Storyboard)Resources["IsCheckAction"]).Begin();
                    }
                    else
                    {
                        ((Storyboard)Resources["UnCheckAction"]).Begin();
                    }
                }
            }
        }

        #endregion

        #region 变量定义

        public FileSystemItemObjClass _FileSystemItemObjClass;


        #endregion

        #region 界面事件

        private void UserControl_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
        }

        private void UserControl_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
        }

        #endregion

        #region 公共方法

        public void BindingItem(FileSystemItemObjClass _FileSystemItemObjClass)
        {
            this._FileSystemItemObjClass = _FileSystemItemObjClass;
            ItemTextStr = _FileSystemItemObjClass.NameStr;
            FileDocumentType = _FileSystemItemObjClass.FileDocumentType;
        }

        #endregion
    }
}
