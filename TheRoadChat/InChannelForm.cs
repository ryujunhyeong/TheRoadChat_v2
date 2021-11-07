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
                }
                else
                {
                    myBubble myBubble = new myBubble(messageinfo.msg, messageinfo.m_dt);
                    PanelMsg.Controls.Add(myBubble);
                }
            }
            
        }

        private void buttonMsgSend_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxMsgInput.Text) == true)
                return;

            socketIO.client.Emit("chat message", new messageInfo(this.i_user, this.i_channel, chat.myName, textBoxMsgInput.Text, DateTime.Now.ToString("HHmmss")));

            textBoxMsgInput.Text = "";
        }

    }
}
