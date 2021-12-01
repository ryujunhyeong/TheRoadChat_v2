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
    public partial class emoticonForm : Form
    {
        public string pictureBoxEmo1Path = System.Windows.Forms.Application.StartupPath + "\\emoticon\\" + "emo1.gif";
        public string pictureBoxEmo2Path = System.Windows.Forms.Application.StartupPath + "\\emoticon\\" + "emo2.gif";
        public InChannelForm inChannelForm;
        public emoticonForm(InChannelForm inChannelForm)
        {
            InitializeComponent();

            this.inChannelForm = inChannelForm;

            pictureBoxEmo1.Load(pictureBoxEmo1Path);
            pictureBoxEmo2.Load(pictureBoxEmo2Path);
        }

        private void pictureBoxEmo1_Click(object sender, EventArgs e)
        {
            inChannelForm.emoticonSend("emo1.gif");
        }

        private void pictureBoxEmo2_Click(object sender, EventArgs e)
        {
            inChannelForm.emoticonSend("emo2.gif");
        }
    }
}
