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

using FUIProject.Class;
using System.Windows.Media.Animation;

namespace FUIProject.Controls.SimpleControls
{
    /// <summary>
    /// Interaction logic for StopBitsSetButton.xaml
    /// </summary>
    public partial class StopBitsSetButton : UserControl
    {
        public StopBitsSetButton()
        {
            InitializeComponent();
        }


        #region 变量标志位

        private CommonToolsClass.StopBitsTypeEnum _StopBitsType = CommonToolsClass.StopBitsTypeEnum.None;
        public CommonToolsClass.StopBitsTypeEnum StopBitsType
        {
            get
            {
                return _StopBitsType;
            }
            set
            {
                if (_StopBitsType != value)
                {
                    _StopBitsType = value;
                    StopBitsScreener.StopBitsType = _StopBitsType;
                    if (_StopBitsType == CommonToolsClass.StopBitsTypeEnum.None)
                    {
                        ((Storyboard)Resources["StopBitsNoneAction"]).Begin();
                    }
                    else if (_StopBitsType == CommonToolsClass.StopBitsTypeEnum.One)
                    {
                        ((Storyboard)Resources["StopBitsOneAction"]).Begin();
                    }
                    else if (_StopBitsType == CommonToolsClass.StopBitsTypeEnum.OnePointFive)
                    {
                        ((Storyboard)Resources["StopBitsOnePointFiveAction"]).Begin();
                    }
                    else if (_StopBitsType == CommonToolsClass.StopBitsTypeEnum.Two)
                    {
                        ((Storyboard)Resources["StopBitsTwoAction"]).Begin();
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
            
            if (StopBitsType + 1 <= CommonToolsClass.StopBitsTypeEnum.Two)
            {
                StopBitsType++;
            }
        }

        private void ReduceButton_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ((Storyboard)Resources["ReduceClickAction"]).Begin();
            if (StopBitsType - 1 >= CommonToolsClass.StopBitsTypeEnum.None)
            {
                StopBitsType--;
            }
        }

        #endregion
    }
}
