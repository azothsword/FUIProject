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
    /// Interaction logic for DataBitsScreen.xaml
    /// </summary>
    public partial class DataBitsScreen : UserControl
    {
        public DataBitsScreen()
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

        #endregion
    }
}
