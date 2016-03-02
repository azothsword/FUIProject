using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FUIProject.Class.ObjectClass
{
    public class CommandObjClass
    {

        #region 变量标志位

        private string _CommandName = "";
        public string CommandName
        {
            get
            {
                return _CommandName;
            }
            set
            {
                if (_CommandName != value)
                {
                    _CommandName = value;
                }
            }
        }


        public byte[] PressCommand;

        public byte[] ReleaseCommand;

        #endregion

        #region 变量定义

        private List<byte> PressCommandList = new List<byte>();
        private List<byte> ReleaseCommandList = new List<byte>();

        #endregion

        public bool SetPressCommand(string CommandStr)
        {
            PressCommandList.Clear();
            string[] CommandStrArray = CommandStr.Split(',');
            for (int i = 0; i < CommandStrArray.Length; i++)
            {
                if (!string.IsNullOrEmpty(CommandStrArray[i]))
                {
                    try
                    {
                        PressCommandList.Add(byte.Parse(CommandStrArray[i], System.Globalization.NumberStyles.HexNumber));
                    }
                    catch
                    {
                        return false;
                    }
                }
            }

            if (PressCommandList.Count > 0)
            {
                PressCommand = PressCommandList.ToArray();
                return true;
            }
            else
            {
                return false;
            }
        }


        public bool SetReleaseCommand(string CommandStr)
        {
            ReleaseCommandList.Clear();
            string[] CommandStrArray = CommandStr.Split(',');
            for (int i = 0; i < CommandStrArray.Length; i++)
            {
                if (!string.IsNullOrEmpty(CommandStrArray[i]))
                {
                    try
                    {
                        ReleaseCommandList.Add(byte.Parse(CommandStrArray[i], System.Globalization.NumberStyles.HexNumber));
                    }
                    catch
                    {
                        return false;
                    }
                }
            }

            if (ReleaseCommandList.Count > 0)
            {
                ReleaseCommand = ReleaseCommandList.ToArray();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
