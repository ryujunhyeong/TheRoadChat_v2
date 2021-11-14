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
    public partial class plusChannelForm : Form
    {
        bool On;
        Point Pos;
        public plusChannelForm()
        {
            InitializeComponent();
            canMoveForm();
        }

        private void canMoveForm()
        {
            MouseDown += (o, e) => { if (e.Button == MouseButtons.Left) { On = true; Pos = e.Location; } };
            MouseMove += (o, e) => { if (On) Location = new Point(Location.X + (e.X - Pos.X), Location.Y + (e.Y - Pos.Y)); };
            MouseUp += (o, e) => { if (e.Button == MouseButtons.Left) { On = false; Pos = e.Location; } };
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonPlusChannel_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textBoxChannelNameInput.Text) == true)
            {
                MessageBox.Show("추가할 채팅방 이름을 입력하세요.");
                return;
            }

            chat.thisForm.myDBManager.plusChannel(textBoxChannelNameInput.Text);
            MessageBox.Show("채팅방을 추가하였습니다.");

            textBoxChannelNameInput.Text = "";

            chat.thisForm.updateData();
            chat.thisForm.updateLayout();
        }
    }
}
