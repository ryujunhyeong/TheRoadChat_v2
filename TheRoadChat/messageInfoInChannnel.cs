using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheRoadChat
{
    public class messageInfoInChannnel
    {
        public int i_channel { get; set; }
        public List<messageInfo> messageInChannel;

        public messageInfoInChannnel(int _i_channel, List<messageInfo> _messageInChannel)
        {
            this.i_channel = _i_channel;
            this.messageInChannel = _messageInChannel;
        }
    }
}
