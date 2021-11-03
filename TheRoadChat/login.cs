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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        string strconn = "Server=27.96.130.41;Database=s5727844;Uid=s5727844;Pwd=s5727844;Charset=utf8";
        //using (MySqlConnection conn = new MySqlConnection(strconn));
    }
}
