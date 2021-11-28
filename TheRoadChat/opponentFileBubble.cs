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
    public partial class opponentFileBubble : UserControl
    {
        public int i_file;
        public string filePath;
        public opponentFileBubble(int i_file, string name, string time)
        {
            InitializeComponent();

            this.i_file = i_file;
            labelFriendName.Text = name;
            labelTime.Text = time;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                this.filePath = DBManager.thisDBManager.pullFileWantedPath(i_file, folderBrowserDialog.SelectedPath);
            }
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(filePath) == true)
            {
                MessageBox.Show("저장이 필요합니다.");
                return;
            }

            FileInfo fileInfo = new FileInfo(filePath); //해당 경로 파일 확인

            if (fileInfo.Exists == false) //파일이 없는 경우
            {
                MessageBox.Show("파일이 없습니다.");
                return;
            }

            System.Diagnostics.Process.Start(this.filePath);
        }
    }
}
