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
        private int i_channel;
        public DBManager myDBManager;
        public channelForm(int _i_channel, string channel_name, DBManager _myDBManager)
        {
            InitializeComponent();

            this.i_channel = _i_channel;
            labelChannelName.Text = channel_name;

            this.myDBManager = _myDBManager;
        }

        private void channelForm_Click(object sender, EventArgs e)
        {
            InChannelForm myInChannelForm = new InChannelForm(this.i_channel, labelChannelName.Text, this.myDBManager);

            myInChannelForm.Show();
        }

    }
}
