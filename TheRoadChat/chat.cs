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
    public partial class chat : Form
    {
        private int i_user = 1;
        private string myName = "이상철";
        private string ID = "zktm9903";
        private int friendOrChannel = 0;
        private bool plusFriendOfFriend = false;

        private List<friendInfo> friendList;
        private List<friendInfo> friendOfFriendList;
        private List<channelInfo> channelList;

        private DBManager myDBManager;

        bool On;
        Point Pos;
        public chat()
        {
            InitializeComponent();
            canMoveForm();
            initData();
            updateData();
            updateLayout();
        }

        private void canMoveForm()
        {
            MouseDown += (o, e) => { if (e.Button == MouseButtons.Left) { On = true; Pos = e.Location; } };
            MouseMove += (o, e) => { if (On) Location = new Point(Location.X + (e.X - Pos.X), Location.Y + (e.Y - Pos.Y)); };
            MouseUp += (o, e) => { if (e.Button == MouseButtons.Left) { On = false; Pos = e.Location; } };
        }
        private void initData()
        {
            labelMyName.Text = myName;

            myDBManager = new DBManager(i_user);
            friendList = new List<friendInfo>();
            friendOfFriendList = new List<friendInfo>();
            channelList = new List<channelInfo>();


        }

        public void updateData()
        {
            friendList = myDBManager.selectMyFriendsList(0);
            friendOfFriendList = myDBManager.selectMyFriendsList(1);
            channelList = myDBManager.selectMyChannelsList();
        }

        public void updateLayout()
        {
            layout.Controls.Clear();

            if (friendOrChannel == 0) //친구 목록
            {
                labelFriendOrChannel.Text = "친구";
                buttonFriendOfFriend.Visible = true;

                

                foreach (friendInfo friend in friendList)
                {
                    friendForm myFriend = new friendForm(friend.i_user, friend.name);
                    layout.Controls.Add(myFriend);
                }

                if(plusFriendOfFriend == true)
                {
                    foreach (friendInfo friend in friendOfFriendList)
                    {
                        friendForm myFriend = new friendForm(friend.i_user, friend.name);
                        myFriend.BackColor = Color.Coral;
                        layout.Controls.Add(myFriend);
                    }
                }

            }
            else if (friendOrChannel == 1) //채널 목록
            {
                labelFriendOrChannel.Text = "채팅방";
                buttonFriendOfFriend.Visible = false;

                

                foreach (channelInfo channel in channelList)
                {
                    channelForm myChannel = new channelForm(channel.i_channel, channel.channelName, this.myDBManager);
                    layout.Controls.Add(myChannel);
                }

            }

        }


        private void buttonFriendList_Click(object sender, EventArgs e)
        {
            friendOrChannel = 0;
            updateLayout();
        }

        private void buttonChannelList_Click(object sender, EventArgs e)
        {
            friendOrChannel = 1;
            updateLayout();
        }

        private void buttonFriendOfFriend_Click(object sender, EventArgs e)
        {
            if (plusFriendOfFriend == false)
                plusFriendOfFriend = true;
            else
                plusFriendOfFriend = false;
            updateLayout();
        }

        private void buttonPlusFriend_Click(object sender, EventArgs e)
        {
            plusFriendForm myPlusFriendForm = new plusFriendForm(this, this.ID, this.myDBManager);

            myPlusFriendForm.Show();
        }
    }
}
