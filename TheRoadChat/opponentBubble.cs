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
    public partial class opponentBubble : UserControl
    {
        public string msg;
        public opponentBubble(int i_user, string name, string msg, string time)
        {
            InitializeComponent();

            this.msg = msg;
            labelFriendName.Text = name;
            labelMsg.Text = msg;
            labelTime.Text = time;
        }
    }
}
