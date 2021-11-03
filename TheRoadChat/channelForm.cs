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
    public partial class channelForm : UserControl
    {
        public channelForm(int i_channel, string channel_name)
        {
            InitializeComponent();

            labelChannelName.Text = channel_name;
        }
    }
}
