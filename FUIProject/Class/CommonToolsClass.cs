using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FUIProject.Class
{
    public class CommonToolsClass
    {
        /// <summary>
        /// 串口停止位枚举类
        /// </summary>
        public enum StopBitsTypeEnum
        {
            None,
            One,
            OnePointFive,
            Two
        }

        /// <summary>
        /// 串口数据位枚举类
        /// </summary>
        public enum DataBitsTypeEnum
        {
            Five,
            Six,
            Seven,
            Eight
        }

        public enum ParityTypeEnum
        {
            None,
            Odd,
            Even,
            Mark,
            Space
        }

        public static int[] DefaultBaudRate = new int[] { 300, 600, 1200, 2400, 4800, 9600, 19200, 38400, 43000, 56000, 57600, 115200 };

        public enum FileDocumentTypeEnum
        {
            Document,
            File
        }

        public enum SendContentTypeEnum
        {
            Num0,
            Num1,
            Num2,
            Num3,
            Num4,
            Num5,
            Num6,
            Num7,
            Num8,
            Num9,
            NumA,
            NumB,
            NumC,
            NumD,
            NumE,
            NumF,
            NumX,
            NumSpace,
            NumBackSpace,
            NumEnter
        }

        public enum ButtonStateTypeEnum
        {
            Off,
            On,
            Disable
        }

        public enum PortStateTypeEnum
        {
            Active,
            Disable,
            Able,
            None,
        }

        public enum SystemInfoTypeEnum
        {
            SystemWorked,
            SystemClose,
            SerialOpen,
            SerialClose,
            CommandSend_Normal,
            CommandSend_SerialNotOpen,
            None,
            ErrorCommand
        }
    }
}
