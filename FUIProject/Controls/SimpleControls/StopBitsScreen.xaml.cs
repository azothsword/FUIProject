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
    /// Interaction logic for StopBitsScreen.xaml
    /// </summary>
    public partial class StopBitsScreen : UserControl
    {
        public StopBitsScreen()
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

        #endregion
    }
}
