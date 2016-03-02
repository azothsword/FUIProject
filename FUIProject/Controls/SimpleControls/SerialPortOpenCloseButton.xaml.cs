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
    /// Interaction logic for SerialPortOpenCloseButton.xaml
    /// </summary>
    public partial class SerialPortOpenCloseButton : UserControl
    {
        public SerialPortOpenCloseButton()
        {
            InitializeComponent();
        }

        private CommonToolsClass.ButtonStateTypeEnum _ButtonStateType = CommonToolsClass.ButtonStateTypeEnum.Off;
        public CommonToolsClass.ButtonStateTypeEnum ButtonStateType
        {
            get
            {
                return _ButtonStateType;
            }
            set
            {
                if (_ButtonStateType != value)
                {
                    _ButtonStateType = value;
                    if (_ButtonStateType == CommonToolsClass.ButtonStateTypeEnum.Off)
                    {
                        ((Storyboard)Resources["ButtonCloseAction"]).Begin();
                    }
                    else if (_ButtonStateType == CommonToolsClass.ButtonStateTypeEnum.On)
                    {
                        ((Storyboard)Resources["ButtonOpenAction"]).Begin();
                    }
                    else if (_ButtonStateType == CommonToolsClass.ButtonStateTypeEnum.Disable)
                    {
                        ((Storyboard)Resources["ButtonDisableAction"]).Begin();
                    }
                }
            }
        }
    }
}
