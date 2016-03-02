using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace FUIProject.Class.ObjectClass
{
    public class FileSystemItemObjClass
    {
        private CommonToolsClass.FileDocumentTypeEnum _FileDocumentType = CommonToolsClass.FileDocumentTypeEnum.Document;
        public CommonToolsClass.FileDocumentTypeEnum FileDocumentType
        {
            get
            {
                return _FileDocumentType;
            }
            set
            {
                if (_FileDocumentType != value)
                {
                    _FileDocumentType = value;
                }
            }
        }

        private string _NameStr = "";
        public string NameStr
        {
            get
            {
                return _NameStr;
            }
            set
            {
                if (_NameStr != value)
                {
                    _NameStr = value;
                }
            }
        }

        private string _PathStr = "";
        public string PathStr
        {
            get
            {
                return _PathStr;
            }
            set
            {
                if (_PathStr != value)
                {
                    _PathStr = value;
                }
            }
        }
    }
}
