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

namespace FUIProject.Controls.SimpleControls
{
    /// <summary>
    /// Interaction logic for ControlPanelCommandToolsButton.xaml
    /// </summary>
    public partial class ControlPanelCommandToolsButton : UserControl
    {
        public ControlPanelCommandToolsButton()
        {
            InitializeComponent();
        }

        private string _ButtonTextStr = "";
        public string ButtonTextStr
        {
            get
            {
                return _ButtonTextStr;
            }
            set
            {
                if (_ButtonTextStr != value)
                {
                    _ButtonTextStr = value;
                    ButtonText.Text = value;
                }
            }
        }

        private void UserControl_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ((Storyboard)Resources["ButtonClickAction"]).Begin();
        }
    }
}
