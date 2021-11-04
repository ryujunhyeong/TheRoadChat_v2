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
        public opponentBubble(int i_user, string name)
        {
            InitializeComponent();

            labelFriendName.Text = name;
        }
    }
}
