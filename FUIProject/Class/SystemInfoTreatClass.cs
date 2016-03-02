using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace FUIProject.Class
{
    public class SystemInfoTreatClass
    {

        static SystemInfoTreatClass _SystemInfoTreatClass;

        public static SystemInfoTreatClass GetInstance()
        {
            if (_SystemInfoTreatClass == null)
            {
                _SystemInfoTreatClass = new SystemInfoTreatClass();
            }
            return _SystemInfoTreatClass;
        }

        private SystemInfoTreatClass()
        {
        }

        #region 自身类委托事件

        public delegate void MessageArrivedEventHandler(CommonToolsClass.SystemInfoTypeEnum _SystemInfoType);
        public event MessageArrivedEventHandler MessageArrivedEvent;

        #endregion

        #region 公共方法

        public void GetMessage(CommonToolsClass.SystemInfoTypeEnum _SystemInfoType)
        {
            if (MessageArrivedEvent != null)
            {
                MessageArrivedEvent(_SystemInfoType);
            }
        }

        #endregion
    }
}
