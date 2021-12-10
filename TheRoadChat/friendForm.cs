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
    public partial class friendForm : UserControl
    {
        public int i_user;
        public friendForm(int i_user, string name)
        {
            InitializeComponent();

            this.i_user = i_user;
            labelFriend.Text = name;

            string FileName = this.i_user + ".png";
            string FilePath = @System.IO.Directory.GetCurrentDirectory() + "\\profile\\" + FileName;

            FileInfo fileInfo = new FileInfo(FilePath); //해당 경로 파일 확인

            if (fileInfo.Exists == false) //파일이 없는 경우
            {
                DBManager.thisDBManager.pullProfile(this.i_user);
            }

            ImgFriend.Load(FilePath);
        }

        private void buttonDelFriend_Click(object sender, EventArgs e)
        {
            chat.thisForm.myDBManager.delFriend(this.i_user);
            chat.thisForm.updateData();
            chat.thisForm.updateLayout();

            
        }
    }
}
