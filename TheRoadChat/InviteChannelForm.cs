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
    public partial class InviteChannelForm : Form
    {
        public List<string> friends;
        public int i_channel;
        public string channel_name;
        public InviteChannelForm(int i_channel, string channel_name)
        {
            InitializeComponent();

            this.i_channel = i_channel;
            this.channel_name = channel_name;

            friends = new List<string>();

            pullFriendList();
        }

        public void pullFriendList()
        {
            foreach(friendInfo friend in chat.thisForm.friendList)
            {
                listBoxFriend.Items.Add(friend.name);
            }
        }
        
        
        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBoxFriend_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxFriend.SelectedItem != null)
            {
                bool InlistboxInvite = false;
                foreach (string friend in friends)
                {
                    if (friend.CompareTo(listBoxFriend.SelectedItem.ToString()) == 0)
                    {
                        InlistboxInvite = true;
                        break;
                    }
                }
                if(InlistboxInvite == false)
                {
                    listBoxInvite.Items.Add(listBoxFriend.SelectedItem.ToString());
                    friends.Add(listBoxFriend.SelectedItem.ToString());
                }
                    
            }
        }

        private void buttonInvite_Click(object sender, EventArgs e)
        {
            foreach (string friend in friends)
            {
                DBManager.thisDBManager.inviteChannel(friend, this.i_channel, this.channel_name);
                socketIO.client.Emit("checkFriend", friend);
            }
        }
    }
}
