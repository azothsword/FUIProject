using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using System.Runtime.InteropServices;
using System.Collections;
using System.Collections.Specialized;
using System.Management;
using System.IO;
using FUIProject_A.Class.ObjectClass;

namespace FUIProject_A.Class
{
    class IniFileTreatClass
    {
        static IniFileTreatClass _IniFileTreatClass;

        public static IniFileTreatClass GetInstance()
        {
            if (_IniFileTreatClass == null)
            {
                _IniFileTreatClass = new IniFileTreatClass();
            }
            return _IniFileTreatClass;
        }

        private IniFileTreatClass()
        {
        }

        #region 外部引用函数

        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, byte[] retVal, int size, string filePath);

        #endregion

        #region 变量定义

        StringCollection KeyList = new StringCollection();

        string ButtonDataSection = "ButtonData";
        string ComSetSection = "comm";
        string Default = "Default";

        public List<CommandObjClass> CommandObjList = new List<CommandObjClass>();


        #endregion

        #region 自身类委托事件定义


        public delegate void SerialPortSetChangeEventHandler(int BaudRateIndex, int ParityIndex, int StopBitsIndex, int BytesizeIndex, int SendByHex, string MachineName);
        public event SerialPortSetChangeEventHandler SerialPortSetChangeEvent;

        #endregion

        #region 公共方法

        public void ReadFile(string FileName)
        {
            CommandObjList.Clear();

            if (File.Exists(FileName))
            {
                ReadSection(ButtonDataSection, FileName);
                for (int i = 0; i < KeyList.Count; i++)
                {
                    string Result = ReadString(ButtonDataSection, KeyList[i], Default, FileName);
                    string[] CommandStr = Result.Split('|');
                    CommandObjClass _CommandObjClass = new CommandObjClass();
                    _CommandObjClass.CommandName = CommandStr[0].Trim();
                    _CommandObjClass.SetPressCommand(CommandStr[1].Trim());
                    _CommandObjClass.SetReleaseCommand(CommandStr[2].Trim());
                    CommandObjList.Add(_CommandObjClass);
                }

                int BaudRateIndex = int.Parse(ReadString(ComSetSection, "BaudRate", Default, FileName));
                int ParityIndex = int.Parse(ReadString(ComSetSection, "Parity", Default, FileName));
                int StopBitsIndex = int.Parse(ReadString(ComSetSection, "StopBits", Default, FileName));
                int BytesizeIndex = int.Parse(ReadString(ComSetSection, "Bytesize", Default, FileName));
                int SendByHex = int.Parse(ReadString(ComSetSection, "SendByHex", Default, FileName));
                string MachineName = ReadString(ComSetSection, "Name", Default, FileName);

                if (SerialPortSetChangeEvent != null)
                {
                    SerialPortSetChangeEvent(BaudRateIndex, ParityIndex, StopBitsIndex, BytesizeIndex, SendByHex, MachineName);
                }
            }
        }


        public string ReadString(string Section, string Key, string Default, string FileName)
        {
            byte[] Buffer = new byte[65535];
            int bufLen = GetPrivateProfileString(Section, Key, Default, Buffer, Buffer.GetUpperBound(0), FileName);
            string s = Encoding.GetEncoding(0).GetString(Buffer);
            s = s.Substring(0, bufLen);
            return s.Trim();
        }

        /// <summary>
        /// 获得Section所有Key的值加入到KeyList
        /// </summary>
        /// <param name="Section">Section的名称</param>
        public void ReadSection(string Section, string FileName)
        {
            byte[] Buffer = new byte[16384];

            int bufLen = GetPrivateProfileString(Section, null, null, Buffer, Buffer.GetUpperBound(0), FileName);

            KeyList.Clear();
            if (bufLen != 0)
            {
                int start = 0;
                for (int i = 0; i < bufLen; i++)
                {
                    if ((Buffer[i] == 0) && ((i - start) > 0))
                    {
                        string s = Encoding.GetEncoding(0).GetString(Buffer, start, i - start);
                        KeyList.Add(s);
                        start = i + 1;
                    }
                }
            }
        }



        #endregion
    }
}
