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
    public partial class opponentBubble : UserControl
    {
        public string msg;
        public int i_user;
        public opponentBubble(int i_user, string name, string msg, string time)
        {
            InitializeComponent();

            this.msg = msg;
            this.i_user = i_user;
            labelFriendName.Text = name;
            labelMsg.Text = msg;
            labelTime.Text = time;
            showProfile();
        }

        public void showProfile()
        {
            string FileName = this.i_user + ".png";
            string FilePath = @System.IO.Directory.GetCurrentDirectory() + "\\profile\\" + FileName;

            FileInfo fileInfo = new FileInfo(FilePath); //해당 경로 파일 확인

            if (fileInfo.Exists == false) //파일이 없는 경우
            {
                DBManager.thisDBManager.pullProfile(this.i_user);
            }

            FriendImg.Load(FilePath);
        }
    }
}
