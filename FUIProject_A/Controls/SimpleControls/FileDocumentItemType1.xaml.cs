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

using FUIProject_A.Class;
using System.Windows.Media.Animation;
using FUIProject_A.Class.ObjectClass;

namespace FUIProject_A.Controls.SimpleControls
{
    /// <summary>
    /// Interaction logic for FileDocumentItemType1.xaml
    /// </summary>
    public partial class FileDocumentItemType1 : UserControl
    {
        public FileDocumentItemType1()
        {
            InitializeComponent();
        }


        #region 变量控制标志位

        private CommonToolsClass.FileDocumentTypeEnum _FileDocumentType = CommonToolsClass.FileDocumentTypeEnum.Document;
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
                        DocumentGrid.Visibility = System.Windows.Visibility.Visible;
                        FileGrid.Visibility = System.Windows.Visibility.Collapsed;
                    }
                    else if (_FileDocumentType == CommonToolsClass.FileDocumentTypeEnum.File)
                    {
                        DocumentGrid.Visibility = System.Windows.Visibility.Collapsed;
                        FileGrid.Visibility = System.Windows.Visibility.Visible;
                    }
                }
            }
        }

        private string _ItemTextStr = "Document_1";
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
