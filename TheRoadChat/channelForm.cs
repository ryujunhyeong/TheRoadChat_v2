using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheRoadChat
{
    public partial class channelForm : UserControl
    {
        private int i_user;
        private int i_channel;
        public DBManager myDBManager;
        public List<messageInfoInChannnel> messageInChannel;
        public channelForm(int _i_user, int _i_channel, string channel_name, DBManager _myDBManager, List<messageInfoInChannnel> _messageInfoInChannnelList)
        {
            InitializeComponent();

            this.i_user = _i_user;
            this.i_channel = _i_channel;
            labelChannelName.Text = channel_name;

            this.myDBManager = _myDBManager;
            this.messageInChannel = _messageInfoInChannnelList;
        }

        private void channelForm_Click(object sender, EventArgs e)
        {
            foreach(messageInfoInChannnel messages in messageInChannel)
            {
                if(this.i_channel == messages.i_channel)
                {
                    if (chat.connectChatPanel.ContainsKey(this.i_channel) == false)
                    {
                        InChannelForm myInChannelForm = new InChannelForm(this.i_user, this.i_channel, labelChannelName.Text, this.myDBManager, messages.messageInChannel);

                        myInChannelForm.Show();
                        break;
                    }
                    

                }
            }
            
        }

    }
}
