using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TheRoadChat
{
    public partial class join : Form
    {
        public join()
        {
            InitializeComponent();
        }

        string strconn = "Server=210.125.31.247;Database = theroad;Uid=test;Pwd=s1234;Charset=utf8";
        string query = "";

        public class userDTO
        {
            public int i_user;
            public string id;
            public string pw;
            public string name;
            public string nick;
            public string roadAddr;
            public string detailAddr;
        }

        public class ProtectedPw
        {
            // 현재 이 암호화 방식을 사용
            public static string ConvertToSimpleEncoding(string original)
            {
                byte[] byt = System.Text.Encoding.UTF8.GetBytes(original);
                return System.Convert.ToBase64String(byt);       //암호화
            }

            public static string ConvertToSimpleDecoding(string modified)
            {
                byte[] byt = System.Convert.FromBase64String(modified);
                return System.Text.Encoding.UTF8.GetString(byt); //복호화
            }

        }

        private void insertUser(userDTO user)
        {
            using (MySqlConnection conn = new MySqlConnection(strconn))
            {
                conn.Open();

                // 암호화
                //user.pw = ProtectedPw.Protect(user.pw);
                Console.WriteLine(user.name);

                user.pw = ProtectedPw.ConvertToSimpleEncoding(user.pw);

                query = "insert into userTable (id, pw, nick, user_name, roadAddr, detailAddr) values ('" + user.id + "', '" + user.pw + "', '" + user.nick + "', '" + user.name + "', '" + user.roadAddr + "', '" + user.detailAddr + "')";

                // 복호화, 나중에 로그인 시 비밀번호 복호화 후 비교하여 로그인
                //user.pw = ProtectedPw.Unprotect(user.pw);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();

                MessageBox.Show("회원가입에 성공하였습니다.");

            }
        }

        private void selectUser(userDTO user)
        {
            using (MySqlConnection conn = new MySqlConnection(strconn))
            {
                conn.Open();

                query = "select * from userTable";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    if (user.id.Equals((string)rdr["id"]))
                    { // 아이디가 존재한다면
                        MessageBox.Show("이미 아이디가 존재합니다");
                        rdr.Close();
                        return;
                    }
                    // 존재 하지 않는다면
                    else if (user.nick.Equals((string)rdr["nick"]))
                    { // 별명이 존재한다면
                        MessageBox.Show("이미 별명이 존재합니다");
                        rdr.Close();
                        return;
                    }
                }
                insertUser(user);
                rdr.Close();
            }
        }

        private void Join_button_Join_Click(object sender, EventArgs e)
        {
            userDTO user = new userDTO();

            user.id = Join_textBox_Id.Text;
            user.pw = Join_textBox_Pw.Text;
            user.name = Join_textBox_Name.Text;
            user.nick = Join_textBox_Nick.Text;
            user.detailAddr = Join_textBox_DetailAddr.Text;
            user.roadAddr = Join_textBox_Address.Text;

            if (user.id.Equals(""))
            {
                MessageBox.Show("아이디를 입력하여 주십시오");
                return;
            }
            else if (user.pw.Equals(""))
            {
                MessageBox.Show("비밀번호를 입력하여 주십시오");
                return;
            }
            else if (user.nick.Equals(""))
            {
                MessageBox.Show("닉네임을 입력하여 주십시오");
                return;
            }
            else if (user.name.Equals(""))
            {
                MessageBox.Show("이름을 입력하여 주십시오");
                return;
            }
            else if (user.roadAddr.Equals(""))
            {
                MessageBox.Show("주소를 입력하여 주십시오");
                return;
            }
            selectUser(user);
            DBManager_.GetInstance().button_save(textBox_Path.Text, Join_textBox_Id.Text);
            using (login frm = new login())
            {
                this.Hide();
                frm.ShowDialog();
            }
        }

        private void Join_button_AddrSearch_Click(object sender, EventArgs e)
        {
            Address addr = new Address();
            string adress = addr.search(Join_textBox_Address.Text);
            if (adress.Equals("error"))
            {
                MessageBox.Show("주소를 입력해주세요");
                return;
            }
            Join_textBox_Address.Text = adress;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Join_button_picture_pull_Click(object sender, EventArgs e)
        {
            textBox_Path.Text = DBManager_.GetInstance().picture_open();
            pictureBox_main.Load(@textBox_Path.Text);
            pictureBox_main.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void Join_textBox_DetailAddr_TextChanged(object sender, EventArgs e)
        {

        }

        private void Join_textBox_Id_TextChanged(object sender, EventArgs e)
        {

        }
    }
}