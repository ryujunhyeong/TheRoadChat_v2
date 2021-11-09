﻿using System;
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
        login form;
        private int i_user;
        public static string myName;
        private string ID;
        private int friendOrChannel = 0;
        private bool plusFriendOfFriend = false;
        public socketIO mySocket;

        private List<friendInfo> friendList;
        private List<friendInfo> friendOfFriendList;
        private List<channelInfo> channelList;
        private List<messageInfoInChannnel> messageInfoInChannnelList;
        public static Dictionary<int, FlowLayoutPanel> connectChatPanel;

        private DBManager myDBManager;

        bool On;
        Point Pos;
        public chat(login _form, int _i_user, string _myName, string _ID)
        {
            this.form = _form;
            this.i_user = _i_user;
            chat.myName = _myName;
            this.ID = _ID;
            InitializeComponent();
            canMoveForm();
            initData();
            updateData();
            updateLayout();
            

            Console.WriteLine(this.i_user);
            Console.WriteLine(chat.myName);
            Console.WriteLine(this.ID);

            mySocket = new socketIO(this);
            entranceChannel();

            CheckForIllegalCrossThreadCalls = false;

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
            messageInfoInChannnelList = new List<messageInfoInChannnel>();
            connectChatPanel = new Dictionary<int, FlowLayoutPanel>();

        }

        private void entranceChannel()
        {
            string mychannels = string.Empty;

            foreach(channelInfo mychannel in this.channelList)
            {
                mychannels += mychannel.i_channel + " ";
            }

            socketIO.client.Emit("login", i_user + " " + mychannels);

        }

        public void updateData()
        {
            friendList = myDBManager.selectMyFriendsList(0);
            friendOfFriendList = myDBManager.selectMyFriendsList(1);
            channelList = myDBManager.selectMyChannelsList();
            messageInfoInChannnelList = myDBManager.pullMessage(this.channelList);
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
                    channelForm myChannel = new channelForm(this.i_user, channel.i_channel, channel.channelName, this.myDBManager, this.messageInfoInChannnelList);
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

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.form.Close();

        }
    }
}
