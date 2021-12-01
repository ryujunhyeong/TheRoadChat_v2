using MySql.Data.MySqlClient;
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
    public partial class changeInfo : Form
    {
        public login loginForm;
        public chat chatForm;
        public int i_user;
        public string ID;
        public changeInfo(login loginForm, chat chatForm, int i_user, string ID)
        {
            InitializeComponent();

            this.loginForm = loginForm;
            this.chatForm = chatForm;
            this.i_user = i_user;
            this.ID = ID;
            selectUserInfo();
        }
        string query = "";
        string strconn = "Server=210.125.31.247;Database = theroad;Uid=test;Pwd=s1234;Charset=utf8";



        class UserInfo
        {
            public string pw;
            public string name;
            public string nick;
            public string addr;
            public string detailAddr;
        }



        UserInfo user = new UserInfo();
        void selectUserInfo()
        {
            using (MySqlConnection conn = new MySqlConnection(strconn))
            {
                conn.Open();

                query = "select * from theroad.userTable where i_user = " + Properties.Settings.Default.i_user;

                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    user.name = (string)rdr["user_name"];
                    user.pw = (string)rdr["pw"];
                    user.nick = (string)rdr["nick"];
                    user.addr = (string)rdr["roadAddr"];
                    user.detailAddr = (string)rdr["detailAddr"];
                }
                rdr.Close();

            }
            changePw.Text = join.ProtectedPw.ConvertToSimpleDecoding(user.pw);
            changeName.Text = user.name;
            changeNick.Text = user.nick;
            changeAddr.Text = user.addr;
            changeDetailAddr.Text = user.detailAddr;
        }



        private void changeInfoBtn_Click(object sender, EventArgs e)
        {
            string protectedPw = join.ProtectedPw.ConvertToSimpleEncoding(changePw.Text);


            using (MySqlConnection conn = new MySqlConnection(strconn))
            {
                conn.Open();
                query = "update userTable set pw = '" + protectedPw + "', nick = '" + changeNick.Text + "', user_name = '" + changeName.Text + "', roadAddr = '" + changeAddr.Text + "', detailAddr = '" + changeDetailAddr.Text + "' where i_user = " + Properties.Settings.Default.i_user;

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();

            }

            this.chatForm.Close();

            chat mychat = new chat(this.loginForm, this.i_user, changeName.Text, this.ID);

            mychat.Show();

            this.Close();
        }
    }
}