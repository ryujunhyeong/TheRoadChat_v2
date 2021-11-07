using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheRoadChat
{
    public class messageInfo
    {
        public int i_user { get; set; }

        public int i_channel { get; set; }
        public string user_name { get; set; }
        public string msg { get; set; }
        public string m_dt { get; set; }

        public messageInfo(int _i_user, int _i_channel, string _user_name, string _msg, string _m_dt)
        {
            this.i_user = _i_user;
            this.i_channel = _i_channel;
            this.user_name = _user_name;
            this.msg = _msg;
            this.m_dt = _m_dt;
        }
    }
}
