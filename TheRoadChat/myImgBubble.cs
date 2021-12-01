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
    public partial class myImgBubble : UserControl
    {
        public string msg;
        public myImgBubble(string filePath, string msg, string time)
        {
            InitializeComponent();

            this.msg = msg;
            labelTime.Text = time;
            Console.WriteLine(filePath);
            pictureBoxImg.Load(filePath);

        }
    }
}
