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
    /// Interaction logic for ParityScreen.xaml
    /// </summary>
    public partial class ParityScreen : UserControl
    {
        public ParityScreen()
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

        #endregion
    }
}
