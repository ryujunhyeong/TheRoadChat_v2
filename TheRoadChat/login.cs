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


        private void btn_login_Click(object sender, EventArgs e)
        {
            chat mychat = new chat(this, int.Parse(textBox1.Text), id_login.Text, pw_login.Text);

            mychat.Show();

            this.Hide();

        }
    }
}
