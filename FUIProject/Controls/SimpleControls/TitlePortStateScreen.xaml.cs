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
    /// Interaction logic for TitlePortStateScreen.xaml
    /// </summary>
    public partial class TitlePortStateScreen : UserControl
    {
        public TitlePortStateScreen()
        {
            InitializeComponent();
        }

        private CommonToolsClass.PortStateTypeEnum _PortStateType = CommonToolsClass.PortStateTypeEnum.None;
        public CommonToolsClass.PortStateTypeEnum PortStateType
        {
            get
            {
                return _PortStateType;
            }
            set
            {
                if (_PortStateType != value)
                {
                    _PortStateType = value;

                    if (_PortStateType == CommonToolsClass.PortStateTypeEnum.Active)
                    {
                        for (int i = 0; i < StateGrid.Children.Count; i++)
                        {
                            Rectangle temp = (Rectangle)StateGrid.Children[i];
                            temp.Fill = new SolidColorBrush(Colors.Lime);
                        }
                        ((Storyboard)Resources["EffectAction"]).Begin();
                    }
                    else if (_PortStateType == CommonToolsClass.PortStateTypeEnum.Able)
                    {
                        for (int i = 0; i < StateGrid.Children.Count; i++)
                        {
                            Rectangle temp = (Rectangle)StateGrid.Children[i];
                            temp.Fill = new SolidColorBrush(Colors.Yellow);
                        }
                        ((Storyboard)Resources["EffectAction"]).Begin();
                    }
                    else if (_PortStateType == CommonToolsClass.PortStateTypeEnum.Disable)
                    {
                        for (int i = 0; i < StateGrid.Children.Count; i++)
                        {
                            Rectangle temp = (Rectangle)StateGrid.Children[i];
                            temp.Fill = new SolidColorBrush(Colors.Red);
                        }
                        ((Storyboard)Resources["EffectAction"]).Begin();
                    }
                    else if (_PortStateType == CommonToolsClass.PortStateTypeEnum.None)
                    {
                        for (int i = 0; i < StateGrid.Children.Count; i++)
                        {
                            Rectangle temp = (Rectangle)StateGrid.Children[i];
                            temp.Fill = new SolidColorBrush(Colors.Gray);
                        }
                        ((Storyboard)Resources["EffectAction"]).Stop();
                    }
                }
            }
        }
    }
}
