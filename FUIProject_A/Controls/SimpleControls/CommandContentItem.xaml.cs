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

using FUIProject_A.Class.ObjectClass;
using System.Windows.Media.Animation;

namespace FUIProject_A.Controls.SimpleControls
{
    /// <summary>
    /// Interaction logic for CommandContentItem.xaml
    /// </summary>
    public partial class CommandContentItem : UserControl
    {
        public CommandContentItem()
        {
            InitializeComponent();
        }

        private string _CommandNameStr = "";
        public string CommandNameStr
        {
            get
            {
                return _CommandNameStr;
            }
            set
            {
                if (_CommandNameStr != value)
                {
                    _CommandNameStr = value;
                    CommandNameText.Text = value;
                }
            }
        }

        private string _PressCommandStr = "";
        public string PressCommandStr
        {
            get
            {
                return _PressCommandStr;
            }
            set
            {
                if (_PressCommandStr != value)
                {
                    _PressCommandStr = value;
                    PressCommandText.Text = value;
                }
            }
        }

        private string _ReleaseCommandStr = "";
        public string ReleaseCommandStr
        {
            get
            {
                return _ReleaseCommandStr;
            }
            set
            {
                if (_ReleaseCommandStr != value)
                {
                    _ReleaseCommandStr = value;
                    ReleaseCommandText.Text = value;
                }
            }
        }

        #region 变量定义

        CommandObjClass _CommandObjClass;

        #endregion

        #region 自定义委托事件

        public delegate void CommandContentItemDeleteEventHandler(CommandObjClass _CommandObjClass);
        public event CommandContentItemDeleteEventHandler CommandContentItemDeleteEvent;

        #endregion

        #region 界面事件

        private void DeleteButton_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ((Storyboard)Resources["ItemHideAction"]).Begin();
            if (this._CommandObjClass != null)
            {
                if (CommandContentItemDeleteEvent != null)
                {
                    CommandContentItemDeleteEvent(this._CommandObjClass);
                }
            }
        }

        private void userControl_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            BackgroundRect.Visibility = System.Windows.Visibility.Visible;
        }

        private void userControl_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            BackgroundRect.Visibility = System.Windows.Visibility.Collapsed;
        }


        #endregion

        #region 公共方法

        public void BindingCommandObj(CommandObjClass _CommandObjClass)
        {
            this._CommandObjClass = _CommandObjClass;
            CommandNameStr = _CommandObjClass.CommandName;

            string temp = "";
            if (_CommandObjClass.PressCommand != null)
            {
                for (int i = 0; i < _CommandObjClass.PressCommand.Length; i++)
                {
                    if (i != _CommandObjClass.PressCommand.Length - 1)
                    {
                        temp += _CommandObjClass.PressCommand[i].ToString("X2") + ",";
                    }
                    else
                    {
                        temp += _CommandObjClass.PressCommand[i].ToString("X2");
                    }
                }
            }
            PressCommandStr = temp;

            temp = "";
            if (_CommandObjClass.ReleaseCommand != null)
            {
                for (int i = 0; i < _CommandObjClass.ReleaseCommand.Length; i++)
                {
                    if (i != _CommandObjClass.ReleaseCommand.Length - 1)
                    {
                        temp += _CommandObjClass.ReleaseCommand[i].ToString("X2") + ",";
                    }
                    else
                    {
                        temp += _CommandObjClass.ReleaseCommand[i].ToString("X2");
                    }
                }
            }
            ReleaseCommandStr = temp;
        }

        public void ItemShowAction()
        {
            ((Storyboard)Resources["ItemShowAction"]).Begin();
        }

        public void ItemHideAction()
        {
            ((Storyboard)Resources["AllItemHideAction"]).Begin();
            if (this._CommandObjClass != null)
            {
                if (CommandContentItemDeleteEvent != null)
                {
                    CommandContentItemDeleteEvent(this._CommandObjClass);
                }
            }
        }

        #endregion
    }
}
