using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheRoadChat
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
            InitautoLoginCheck();
        }
        bool loginChangeCheck = false;
        public void InitautoLoginCheck()
        {
            if (Properties.Settings.Default.autoLoginCheck == true)
            {
                autoLoginCheck.Checked = true;
                Login_textBox_ID.Text = Properties.Settings.Default.autoLoadId;
                Login_textBox_Pw.Text = Properties.Settings.Default.autoLoadPw;
                loginChangeCheck = true;
            }
        }

        string strconn = "Server=210.125.31.247;Database = theroad;Uid=test;Pwd=s1234;Charset=utf8";
        private void Login_button_Login_Click(object sender, EventArgs e)
        {
            string id = Login_textBox_ID.Text;
            string unProtectedPw, protectPw;
            unProtectedPw = Login_textBox_Pw.Text;

            if (loginChangeCheck == true)
            {
                protectPw = Login_textBox_Pw.Text;
            }
            else
            {
                protectPw = join.ProtectedPw.ConvertToSimpleEncoding(unProtectedPw);
            }
            Console.WriteLine(protectPw);
            using (MySqlConnection conn = new MySqlConnection(strconn))
            {
                string query = "SELECT * FROM theroad.userTable";
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                bool loginSuccess = false;
                while (rdr.Read())
                {
                    if (id.Equals((string)rdr["id"]) && protectPw.Equals((string)rdr["pw"]))
                    {
                        loginSuccess = true;
                        int i_user = (int)rdr["i_user"];
                        string name = rdr["user_name"].ToString();
                        string user_id = rdr["id"].ToString();
                        if (Properties.Settings.Default.autoLoginCheck == true)
                        {
                            Properties.Settings.Default.autoLoadId = (string)rdr["id"];
                            Properties.Settings.Default.autoLoadPw = (string)rdr["pw"];
                            Properties.Settings.Default.Save();
                        }
                        else
                        {
                            Properties.Settings.Default.autoLoadId = "";
                            Properties.Settings.Default.autoLoadPw = "";
                            Properties.Settings.Default.Save();
                        }
                        this.Hide();
                        Properties.Settings.Default.i_user = i_user;
                        chat mychat = new chat(this, i_user, name, user_id);

                        mychat.Show();

                        

                    }
                }
                if (loginSuccess == false)
                {
                    MessageBox.Show("아이디 비밀번호를 다시 확인해주세요");
                }
            }
        }

        private void loginID_TextChanged(object sender, EventArgs e)
        {
            loginChangeCheck = false;
        }
        private void Login_textBox_Pw_TextChanged(object sender, EventArgs e)
        {
            loginChangeCheck = false;
        }

        private void Login_button_Join_Click(object sender, EventArgs e)
        {
            using (join frm = new join())
            {
                this.Hide();
                frm.ShowDialog();
            }
        }

        private void autoLoginCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (autoLoginCheck.Checked)
            {
                Properties.Settings.Default.autoLoginCheck = true;
            }
            else
            {
                Properties.Settings.Default.autoLoginCheck = false;
            }
            Properties.Settings.Default.Save();
        }
    }
}
