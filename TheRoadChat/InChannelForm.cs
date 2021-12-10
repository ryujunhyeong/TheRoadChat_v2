using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        public string channel_name;
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
            channel_name = name;
            myDBManager = _myDBManager;
            this.messages = _messages;

            chat.connectChatPanel.Add(this.i_channel, PanelMsg);

            this.searchMsg1 = new List<opponentBubble>();
            this.searchMsg2 = new List<myBubble>();

            updateMsg();

            chat.thisForm.entranceChannel();
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
                if(messageinfo.i_file == 0) //일반 메세지
                {
                    if (this.i_user != messageinfo.i_user)
                    {
                        opponentBubble Bubble = new opponentBubble(messageinfo.i_user, messageinfo.user_name, messageinfo.msg, messageinfo.m_dt);
                        PanelMsg.Controls.Add(Bubble);
                        searchMsg1.Add(Bubble);
                    }
                    else
                    {
                        myBubble Bubble = new myBubble(messageinfo.msg, messageinfo.m_dt);
                        PanelMsg.Controls.Add(Bubble);
                        searchMsg2.Add(Bubble);
                    }
                }
                else if(messageinfo.i_file == -1)
                {
                    if (this.i_user != messageinfo.i_user)
                    {
                        string realPath = System.Windows.Forms.Application.StartupPath + "\\emoticon\\" + messageinfo.msg;
                        opponentImgBubble Bubble = new opponentImgBubble(realPath, messageinfo.user_name, messageinfo.msg, messageinfo.m_dt);
                        PanelMsg.Controls.Add(Bubble);
                    }
                    else
                    {
                        string realPath = System.Windows.Forms.Application.StartupPath + "\\emoticon\\" + messageinfo.msg;
                        myImgBubble Bubble = new myImgBubble(realPath, messageinfo.msg, messageinfo.m_dt);
                        PanelMsg.Controls.Add(Bubble);
                    }
                }
                else //파일 메세지
                {
                    if (messageinfo.msg.CompareTo("img") == 0) //이미지 
                    {
                        if (this.i_user != messageinfo.i_user)
                        {
                            string path = DBManager.thisDBManager.pullFile(messageinfo.i_file);
                            opponentImgBubble Bubble = new opponentImgBubble(path, messageinfo.user_name, messageinfo.msg, messageinfo.m_dt);
                            PanelMsg.Controls.Add(Bubble);
                        }
                        else
                        {
                            string path = DBManager.thisDBManager.pullFile(messageinfo.i_file);
                            myImgBubble Bubble = new myImgBubble(path, messageinfo.msg, messageinfo.m_dt);
                            PanelMsg.Controls.Add(Bubble);
                        }
                    }
                    else
                    {
                        if (this.i_user != messageinfo.i_user) //이미지 제외 파일
                        {
                            opponentFileBubble Bubble = new opponentFileBubble(messageinfo.i_file, messageinfo.user_name, messageinfo.m_dt);
                            PanelMsg.Controls.Add(Bubble);
                        }
                        else
                        {
                            myFileBubble Bubble = new myFileBubble(messageinfo.i_file, messageinfo.m_dt);
                            PanelMsg.Controls.Add(Bubble);
                        }
                    }
                }

            }
            
        }

        private void buttonMsgSend_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxMsgInput.Text) == true)
                return;

            if(textBoxMsgInput.Text[0]== '@')
            {
                if(textBoxMsgInput.Text.Length == 4)
                {
                    foreach (friendInfo friend in chat.thisForm.friendList)
                    {
                        if (friend.name.CompareTo(textBoxMsgInput.Text.Substring(1,3)) == 0)
                        {
                            socketIO.client.Emit("tag", friend.name);
                            textBoxMsgInput.Text = "";
                            return;
                        }
                    }
                }
                
                
            }

            socketIO.client.Emit("chat message", new messageInfo(this.i_user, this.i_channel, chat.myName, textBoxMsgInput.Text, DateTime.Now.ToString("HHmmss"),0));

            messages.Add(new messageInfo(this.i_user, this.i_channel, chat.myName, textBoxMsgInput.Text, DateTime.Now.ToString("HHmmss"),0));

            myBubble myBubble = new myBubble(textBoxMsgInput.Text, DateTime.Now.ToString("HHmmss"));
            PanelMsg.Controls.Add(myBubble);
            PanelMsg.ScrollControlIntoView(myBubble);

            textBoxMsgInput.Text = "";
            this.searchMsg2.Add(myBubble);
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSearchMsg_Click(object sender, EventArgs e)
        {
            foreach(opponentBubble bubble in searchMsg1)
            {
                if (bubble.msg.Contains(textBoxSearchMsgInput.Text) == true)
                {
                    PanelMsg.ScrollControlIntoView(bubble);
                    bubble.BackColor = Color.Beige;
                }
                else
                {
                    bubble.BackColor = Color.Transparent;
                }
            }
            foreach (myBubble bubble in searchMsg2)
            {
                if (bubble.msg.Contains(textBoxSearchMsgInput.Text) == true)
                {
                    PanelMsg.ScrollControlIntoView(bubble);
                    bubble.BackColor = Color.Beige;
                }
                else
                {
                    bubble.BackColor = Color.Transparent;
                }
            }
        }

        private void InChannelForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            chat.connectChatPanel.Remove(this.i_channel);
        }

        private void buttonInvite_Click(object sender, EventArgs e)
        {
            InviteChannelForm inviteForm = new InviteChannelForm(this.i_channel, this.channel_name);

            inviteForm.Show();
        }

        private void buttonImgOrFileSend_Click(object sender, EventArgs e)
        {
            string filePath = string.Empty;
            string fileName = string.Empty;
            string fileExtension = string.Empty;
            string fileType = string.Empty;

            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.InitialDirectory = "c:\\";
                    openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                    openFileDialog.FilterIndex = 2;
                    openFileDialog.RestoreDirectory = true;

                    if (openFileDialog.ShowDialog() == DialogResult.OK) //경로 선택하는 창띄우기
                    {
                        //Get the path of specified file
                        filePath = openFileDialog.FileName; //파일 경로 저장
                        fileName = openFileDialog.SafeFileName; //파일 이름 저장
                                                                //Console.WriteLine(filePath);
                                                                //Console.WriteLine(openFileDialog.SafeFileName);
                    }
                }

                fileExtension = System.IO.Path.GetExtension(filePath);

                switch (fileExtension.ToLower())
                {
                    case ".bmp":
                    case ".exif":
                    case ".gif":
                    case ".jpg":
                    case ".jpeg":
                    case ".png":
                    case ".tif":
                    case ".tiff":
                        fileType = "img";
                        break;
                    default:
                        fileType = "not img";
                        break;
                }

                UInt32 FileSize; //이미지 파일 사이즈
                byte[] rawData; //이미지 파일 바이트 배열
                FileStream fs; //파일스트림


                fs = new FileStream(@filePath, FileMode.Open, FileAccess.Read); //파일 열기
                FileSize = (UInt32)fs.Length; //파일 크기 받기

                rawData = new byte[FileSize]; //파일 크기만큼의 바이트 배열 생성
                fs.Read(rawData, 0, (int)FileSize); //파일 읽기
                fs.Close(); //파일 스트림 종료

                //db에 메뉴 정보 삽입 후 결과 받기
                int my_i_file = DBManager.thisDBManager.pushFile(this.i_user, this.i_channel, fileName, FileSize, rawData);

                socketIO.client.Emit("chat message", new messageInfo(this.i_user, this.i_channel, chat.myName, fileType, DateTime.Now.ToString("HHmmss"), my_i_file));

                messages.Add(new messageInfo(this.i_user, this.i_channel, chat.myName, fileType, DateTime.Now.ToString("HHmmss"), my_i_file));

                if (fileType.CompareTo("img") == 0)
                {
                    myImgBubble Bubble = new myImgBubble(filePath, fileType, DateTime.Now.ToString("HHmmss"));
                    PanelMsg.Controls.Add(Bubble);
                    PanelMsg.ScrollControlIntoView(Bubble);
                }
                else
                {
                    myFileBubble Bubble = new myFileBubble(my_i_file, DateTime.Now.ToString("HHmmss"));
                    PanelMsg.Controls.Add(Bubble);
                    PanelMsg.ScrollControlIntoView(Bubble);
                }
            }
            catch { }

            

        }

        private void buttonEmoticon_Click(object sender, EventArgs e)
        {
            emoticonForm emoticon = new emoticonForm(this);

            emoticon.Show();
        }

        public void emoticonSend(string path)
        {
            //Console.WriteLine(path);
            string realPath = System.Windows.Forms.Application.StartupPath + "\\emoticon\\" + path;
            Console.WriteLine(realPath);
            myImgBubble Bubble = new myImgBubble(realPath, "emo", DateTime.Now.ToString("HHmmss"));
            PanelMsg.Controls.Add(Bubble);
            PanelMsg.ScrollControlIntoView(Bubble);

            socketIO.client.Emit("chat message", new messageInfo(this.i_user, this.i_channel, chat.myName, path, DateTime.Now.ToString("HHmmss"), -1));
            messages.Add(new messageInfo(this.i_user, this.i_channel, chat.myName, path, DateTime.Now.ToString("HHmmss"), -1));
        }

        private void PanelMsg_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox_theme_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_theme.SelectedIndex == 0)
            {
                PanelMsg.BackColor = Color.Blue;
            }
            else if (comboBox_theme.SelectedIndex == 1)
            {
                PanelMsg.BackColor = Color.Beige;
            }
            else if (comboBox_theme.SelectedIndex == 2)
            {
                PanelMsg.BackColor = Color.Red;
            }
        }
    }
}
