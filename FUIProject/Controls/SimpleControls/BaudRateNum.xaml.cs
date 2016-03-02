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
    /// Interaction logic for BaudRateNum.xaml
    /// </summary>
    public partial class BaudRateNum : UserControl
    {
        public BaudRateNum()
        {
            InitializeComponent();
        }

        private int _Num = 0;
        public int Num
        {
            get
            {
                return _Num;
            }
            set
            {
                if (_Num != value)
                {
                    if (value < 0)
                    {
                        _Num = 9;
                    }
                    else if (value > 9)
                    {
                        _Num = 0;
                    }
                    else
                    {
                        _Num = value;
                    }
                    ((Storyboard)Resources["Num" + _Num.ToString() + "Action"]).Begin();
                }
            }
        }
    }
}
