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

namespace FUIProject.Controls.SimpleControls
{
    /// <summary>
    /// Interaction logic for DataBitsSetButton.xaml
    /// </summary>
    public partial class DataBitsSetButton : UserControl
    {
        public DataBitsSetButton()
        {
            InitializeComponent();
        }

        #region 变量标志位

        private CommonToolsClass.DataBitsTypeEnum _DataBitsType = CommonToolsClass.DataBitsTypeEnum.Eight;
        public CommonToolsClass.DataBitsTypeEnum DataBitsType
        {
            get
            {
                return _DataBitsType;
            }
            set
            {
                if (_DataBitsType != value)
                {
                    _DataBitsType = value;
                    DataBitsScreener.DataBitsType = _DataBitsType;
                    if (_DataBitsType == CommonToolsClass.DataBitsTypeEnum.Eight)
                    {
                        ((Storyboard)Resources["DataBitsEightAction"]).Begin();
                    }
                    else if (_DataBitsType == CommonToolsClass.DataBitsTypeEnum.Seven)
                    {
                        ((Storyboard)Resources["DataBitsSevenAction"]).Begin();
                    }
                    else if (_DataBitsType == CommonToolsClass.DataBitsTypeEnum.Six)
                    {
                        ((Storyboard)Resources["DataBitsSixAction"]).Begin();
                    }
                    else if (_DataBitsType == CommonToolsClass.DataBitsTypeEnum.Five)
                    {
                        ((Storyboard)Resources["DataBitsFiveAction"]).Begin();
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

        #region 界面事件部分

        private void AddButton_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ((Storyboard)Resources["AddClickAction"]).Begin();

            if (DataBitsType + 1 <= CommonToolsClass.DataBitsTypeEnum.Eight)
            {
                DataBitsType++;
            }
        }

        private void ReduceButton_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ((Storyboard)Resources["ReduceClickAction"]).Begin();
            if (DataBitsType - 1 >= CommonToolsClass.DataBitsTypeEnum.Five)
            {
                DataBitsType--;
            }
        }

        #endregion
    }
}
