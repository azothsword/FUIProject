using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Runtime.InteropServices;
using System.Collections;
using System.Collections.Specialized;
using System.Management;
using System.IO;

using FUIProject_B.Class.ObjectClass;

namespace FUIProject_B.Class
{
    class FileDocumentTreatClass
    {

        public FileDocumentTreatClass()
        {
        }

        #region 外部引用函数

        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, byte[] retVal, int size, string filePath);

        #endregion


        #region 变量标志位

        private string _CurrentDirectory = "";
        public string CurrentDirectory
        {
            get
            {
                return _CurrentDirectory;
            }
            set
            {
                if (_CurrentDirectory != value)
                {
                    _CurrentDirectory = value;
                    GetCurrentFileAndDirectory();
                    if (DirectoryChangedEvent != null)
                    {
                        DirectoryChangedEvent();
                    }
                }
            }
        }

        #endregion

        #region 自身类委托事件定义

        public delegate void DirectoryChangedEventHandler();
        public event DirectoryChangedEventHandler DirectoryChangedEvent;

        #endregion

        #region 变量定义


        StringCollection KeyList = new StringCollection();

        string ButtonDataSection = "ButtonData";
        string Default = "Default";

        public List<CommandObjClass> CommandObjList = new List<CommandObjClass>();

        public List<FileSystemItemObjClass> FileSystemItemList = new List<FileSystemItemObjClass>();
        public bool RootTag = true;            //标志当前是否已经到了顶层，判断依据为CurrentDirectory是否为空
        public string ParentPathStr = "";
        public Stack<string> PathStrStack = new Stack<string>();

        #endregion

        #region 公共方法


        public bool ReadFile(string FileName)
        {
            CommandObjList.Clear();

            if (File.Exists(FileName))
            {
                try
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
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            else
            {
                return false;
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


        public static string GetAllDiskStrs()
        {
            SelectQuery selectQuery = new SelectQuery("select * from win32_logicaldisk");
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(selectQuery);
            string DiskStr = "";
            foreach (ManagementObject disk in searcher.Get())
            {
                //DriveType等于3时可识别的盘符，4为光驱
                if (disk["DriveType"].ToString() == "3")
                {
                    DiskStr += disk["Name"].ToString() + "|";
                }
            }
            if (DiskStr.LastIndexOf('|') == DiskStr.Length - 1)
            {
                DiskStr = DiskStr.Remove(DiskStr.Length - 1);
            }
            return DiskStr;
        }

        private void GetAllDisk()
        {
            SelectQuery selectQuery = new SelectQuery("select * from win32_logicaldisk");
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(selectQuery);
            foreach (ManagementObject disk in searcher.Get())
            {
                //DriveType等于3时可识别的盘符，4为光驱
                if (disk["DriveType"].ToString() == "3")
                {
                    //DiskNameList.Add(disk["Name"].ToString());
                    FileSystemItemObjClass _FileSystemItemObjClass = new FileSystemItemObjClass();
                    _FileSystemItemObjClass.FileDocumentType = CommonToolsClass.FileDocumentTypeEnum.Document;
                    _FileSystemItemObjClass.NameStr = disk["Name"].ToString();
                    _FileSystemItemObjClass.PathStr = disk["Name"].ToString();
                    FileSystemItemList.Add(_FileSystemItemObjClass);
                }
            }
        }

        public void GetCurrentFileAndDirectory()
        {
            //若当前未到顶层目录结构
            if (CurrentDirectory != "")
            {
                DirectoryInfo tempDirectory = new DirectoryInfo(CurrentDirectory);

                FileInfo[] tempFileList = tempDirectory.GetFiles();
                DirectoryInfo[] tempDirectoryList = tempDirectory.GetDirectories();

                FileSystemItemList.Clear();

                //添加文件夹部分
                for (int i = 0; i < tempDirectoryList.Length; i++)
                {
                    if (tempDirectoryList[i].Attributes.ToString().IndexOf("Hidden") != -1 || tempDirectoryList[i].Attributes.ToString().IndexOf("System") != -1)
                    {
                        continue;
                    }

                    FileSystemItemObjClass _FileSystemItemObjClass = new FileSystemItemObjClass();
                    _FileSystemItemObjClass.FileDocumentType = CommonToolsClass.FileDocumentTypeEnum.Document;
                    _FileSystemItemObjClass.NameStr = tempDirectoryList[i].Name;
                    _FileSystemItemObjClass.PathStr = CurrentDirectory + tempDirectoryList[i].Name + "\\";
                    FileSystemItemList.Add(_FileSystemItemObjClass);

                }
                //添加文件部分
                for (int i = 0; i < tempFileList.Length; i++)
                {
                    if (tempFileList[i].Name.ToLower().IndexOf(".ini") == tempFileList[i].Name.Length - 4)
                    {
                        FileSystemItemObjClass _FileSystemItemObjClass = new FileSystemItemObjClass();
                        _FileSystemItemObjClass.FileDocumentType = CommonToolsClass.FileDocumentTypeEnum.File;
                        _FileSystemItemObjClass.NameStr = tempFileList[i].Name;
                        _FileSystemItemObjClass.PathStr = CurrentDirectory + tempFileList[i].Name;
                        FileSystemItemList.Add(_FileSystemItemObjClass);
                    }
                }

                if (tempDirectory.Parent == null)
                {
                    ParentPathStr = "";
                }
                else
                {
                    ParentPathStr = tempDirectory.Parent.FullName + "\\";
                }

                RootTag = false;
            }
            else
            {
                //若当前已到顶层目录结构
                FileSystemItemList.Clear();

                SelectQuery selectQuery = new SelectQuery("select * from win32_logicaldisk");
                ManagementObjectSearcher searcher = new ManagementObjectSearcher(selectQuery);
                foreach (ManagementObject disk in searcher.Get())
                {
                    //DriveType等于3时可识别的盘符，4为光驱
                    if (disk["DriveType"].ToString() == "3")
                    {
                        FileSystemItemObjClass _FileSystemItemObjClass = new FileSystemItemObjClass();
                        _FileSystemItemObjClass.FileDocumentType = CommonToolsClass.FileDocumentTypeEnum.Document;
                        _FileSystemItemObjClass.NameStr = disk["Name"].ToString();
                        _FileSystemItemObjClass.PathStr = disk["Name"].ToString() + "\\";
                        FileSystemItemList.Add(_FileSystemItemObjClass);
                    }
                }

                RootTag = true;
            }
        }

        #endregion
    }
}
