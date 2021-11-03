using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheRoadChat
{

    class channelInfo
    {
        public int i_channel { get; set; }
        public string channelName { get; set; }

        public channelInfo(int _i_channel, string _channelName)
        {
            this.i_channel = _i_channel;
            this.channelName = _channelName;
        }

    }
}
