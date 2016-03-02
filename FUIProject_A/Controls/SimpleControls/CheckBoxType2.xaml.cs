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

namespace FUIProject_A.Controls.SimpleControls
{
    /// <summary>
    /// Interaction logic for CheckBoxType2.xaml
    /// </summary>
    public partial class CheckBoxType2 : UserControl
    {
        public CheckBoxType2()
        {
            InitializeComponent();
        }

        private bool _CheckTag = false;
        public bool CheckTag
        {
            get
            {
                return _CheckTag;
            }
            set
            {
                if (_CheckTag != value)
                {
                    _CheckTag = value;

                    if (_CheckTag)
                    {
                        ((Storyboard)Resources["CheckAction"]).Begin();
                    }
                    else
                    {
                        ((Storyboard)Resources["UncheckAction"]).Begin();
                    }
                }
            }
        }

        private void UserControl_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            CheckTag = !CheckTag;
        }
    }
}
