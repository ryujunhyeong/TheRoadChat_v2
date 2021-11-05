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
    public partial class plusFriendForm : Form
    {
        private chat mychat;
        private string ID;
        private DBManager myDBManager;
        bool On;
        Point Pos;
        
        public plusFriendForm(chat _mychat, string _ID, DBManager _myDBManager)
        {
            InitializeComponent();
            canMoveForm();

            this.ID = _ID;
            this.myDBManager = _myDBManager;
            this.mychat = _mychat;
        }

        private void canMoveForm()
        {
            MouseDown += (o, e) => { if (e.Button == MouseButtons.Left) { On = true; Pos = e.Location; } };
            MouseMove += (o, e) => { if (On) Location = new Point(Location.X + (e.X - Pos.X), Location.Y + (e.Y - Pos.Y)); };
            MouseUp += (o, e) => { if (e.Button == MouseButtons.Left) { On = false; Pos = e.Location; } };
        }

        private void buttonPlusFriend_Click(object sender, EventArgs e)
        {
            if(textBoxIDInput.Text.CompareTo(this.ID) == 0)
            {
                MessageBox.Show("자신의 아이디와 같습니다.");
                return;
            }

            this.myDBManager.plusFriend(textBoxIDInput.Text);

            mychat.updateData();
            mychat.updateLayout();
        }
    }
}
