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
    public partial class friendForm : UserControl
    {
        public int i_user;
        public friendForm(int i_user, string name)
        {
            InitializeComponent();

            this.i_user = i_user;
            labelFriend.Text = name;
        }

        private void buttonDelFriend_Click(object sender, EventArgs e)
        {
            chat.thisForm.myDBManager.delFriend(this.i_user);
            chat.thisForm.updateData();
            chat.thisForm.updateLayout();
        }
    }
}
