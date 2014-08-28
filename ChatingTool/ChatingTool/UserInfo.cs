using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace ChatingTool
{
    [Serializable]
    public class UserInfo
    {
        public string NickName { get; set; }
        public int HeadImageIndex { get; set; }
        public string shuoshuo { get; set; }

        public UserInfo()
        {
            NickName = "您未设置用户名";
            HeadImageIndex = 0;
            shuoshuo = "您还没有留下任何说说,写一点吧！";
        }
    }
}
