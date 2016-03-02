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
    /// Interaction logic for ParitySetButton.xaml
    /// </summary>
    public partial class ParitySetButton : UserControl
    {
        public ParitySetButton()
        {
            InitializeComponent();
        }

        #region 变量标志位

        private CommonToolsClass.ParityTypeEnum _ParityType = CommonToolsClass.ParityTypeEnum.None;
        public CommonToolsClass.ParityTypeEnum ParityType
        {
            get
            {
                return _ParityType;
            }
            set
            {
                if (_ParityType != value)
                {
                    _ParityType = value;
                    ParityScreener.ParityType = _ParityType;
                    if (_ParityType == CommonToolsClass.ParityTypeEnum.None)
                    {
                        ((Storyboard)Resources["ParityNoneAction"]).Begin();
                    }
                    else if (_ParityType == CommonToolsClass.ParityTypeEnum.Odd)
                    {
                        ((Storyboard)Resources["ParityOddAction"]).Begin();
                    }
                    else if (_ParityType == CommonToolsClass.ParityTypeEnum.Even)
                    {
                        ((Storyboard)Resources["ParityEvenAction"]).Begin();
                    }
                    else if (_ParityType == CommonToolsClass.ParityTypeEnum.Mark)
                    {
                        ((Storyboard)Resources["ParityMarkAction"]).Begin();
                    }
                    else if (_ParityType == CommonToolsClass.ParityTypeEnum.Space)
                    {
                        ((Storyboard)Resources["ParitySpaceAction"]).Begin();
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

            if (ParityType + 1 <= CommonToolsClass.ParityTypeEnum.Space)
            {
                ParityType++;
            }
        }

        private void ReduceButton_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ((Storyboard)Resources["ReduceClickAction"]).Begin();
            if (ParityType - 1 >= CommonToolsClass.ParityTypeEnum.None)
            {
                ParityType--;
            }
        }

        #endregion
    }
}
