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
    public partial class InChannelForm : Form
    {
        private int i_user;
        private int i_channel;
        private DBManager myDBManager;
        private List<messageInfo> messages;
        private List<opponentBubble> searchMsg1;
        private List<myBubble> searchMsg2;

        bool On;
        Point Pos;
        public InChannelForm(int _i_user, int _i_channel, string name, DBManager _myDBManager, List<messageInfo> _messages)
        {
            InitializeComponent();
            canMoveForm();

            this.i_user = _i_user;
            this.i_channel = _i_channel;
            labelChannelName.Text = name;
            myDBManager = _myDBManager;
            this.messages = _messages;

            chat.connectChatPanel.Add(this.i_channel, PanelMsg);

            this.searchMsg1 = new List<opponentBubble>();
            this.searchMsg2 = new List<myBubble>();

            updateMsg();
        }

        private void canMoveForm()
        {
            MouseDown += (o, e) => { if (e.Button == MouseButtons.Left) { On = true; Pos = e.Location; } };
            MouseMove += (o, e) => { if (On) Location = new Point(Location.X + (e.X - Pos.X), Location.Y + (e.Y - Pos.Y)); };
            MouseUp += (o, e) => { if (e.Button == MouseButtons.Left) { On = false; Pos = e.Location; } };
        }

        private void updateMsg()
        {
            foreach(messageInfo messageinfo in messages)
            {
                if (this.i_user != messageinfo.i_user)
                {
                    opponentBubble myBubble = new opponentBubble(i_user, messageinfo.user_name, messageinfo.msg, messageinfo.m_dt);
                    PanelMsg.Controls.Add(myBubble);
                    searchMsg1.Add(myBubble);
                }
                else
                {
                    myBubble myBubble = new myBubble(messageinfo.msg, messageinfo.m_dt);
                    PanelMsg.Controls.Add(myBubble);
                    searchMsg2.Add(myBubble);
                }
            }
            
        }

        private void buttonMsgSend_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxMsgInput.Text) == true)
                return;

            socketIO.client.Emit("chat message", new messageInfo(this.i_user, this.i_channel, chat.myName, textBoxMsgInput.Text, DateTime.Now.ToString("HHmmss")));

            messages.Add(new messageInfo(this.i_user, this.i_channel, chat.myName, textBoxMsgInput.Text, DateTime.Now.ToString("HHmmss")));

            myBubble myBubble = new myBubble(textBoxMsgInput.Text, DateTime.Now.ToString("HHmmss"));
            PanelMsg.Controls.Add(myBubble);
            PanelMsg.ScrollControlIntoView(myBubble);

            textBoxMsgInput.Text = "";
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSearchMsg_Click(object sender, EventArgs e)
        {
            bool success = false;
            foreach(opponentBubble bubble in searchMsg1)
            {
                if (bubble.msg.Contains(textBoxSearchMsgInput.Text) == true)
                {
                    PanelMsg.ScrollControlIntoView(bubble);
                    bubble.BackColor = Color.Beige;
                    success = true;
                    break;
                }
                else
                {
                    bubble.BackColor = Color.Transparent;
                }
            }
            if(success == false)
            {
                foreach (myBubble bubble in searchMsg2)
                {
                    if (bubble.msg.Contains(textBoxSearchMsgInput.Text) == true)
                    {
                        PanelMsg.ScrollControlIntoView(bubble);
                        bubble.BackColor = Color.Beige;
                        break;
                    }
                    else
                    {
                        bubble.BackColor = Color.Transparent;
                    }
                }
            }
        }
    }
}
