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
    public partial class myBubble : UserControl
    {
        public string msg;
        public myBubble(string msg, string time)
        {
            InitializeComponent();

            this.msg = msg;
            labelMsg.Text = msg;
            labelTime.Text = time;
        }
    }
}
