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
    public partial class opponentImgBubble : UserControl
    {
        public string msg;
        public opponentImgBubble(string filePath, string name, string msg, string time)
        {
            InitializeComponent();

            this.msg = msg;
            labelFriendName.Text = name;
            labelTime.Text = time;
            Console.WriteLine(filePath);
            pictureBoxImg.Load(filePath);
        }
    }
}
