using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheRoadChat
{
    class DBManager_
    {

        private static DBManager_ instance_ = new DBManager_();
        private string connection_string = "Server=210.125.31.247;Database = theroad;Uid=test;Pwd=s1234;Charset=utf8"; // DB정보 저장하는 스트링
        public static DBManager_ GetInstance() //singleton방식으로 구현
        {
            return instance_;
        }
        public string picture_open() // 사진파일 열기 버튼 클릭
        {

            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog(); // 파일 탐색기 열림
                openFileDialog1.Filter = "Image files(*.jpg) | *.jpg |" + // jpg와 png만 선택가능
                                         "이미지 파일(*.png) | *.png";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    return openFileDialog1.FileName; // 선택한 파일명 텍스트박스에 저장
                }
            }
            catch (Exception ex)
            {
            }
            return "";
        }

        public void button_save(string textBox_picture, string Join_textBox_Id)
        {
            string SQL;
            UInt32 FileSize;
            byte[] rawData;
            FileStream fs;
            MySqlConnection con = new MySqlConnection(connection_string);
            MySqlCommand cmd = new MySqlCommand();
            BinaryReader br;
            try
            {
                fs = new FileStream(textBox_picture, FileMode.Open, FileAccess.Read);
                FileSize = (UInt32)fs.Length;

                rawData = new byte[FileSize];
                fs.Read(rawData, 0, (int)FileSize);
                fs.Close();

                con.Open();

                //SQL = "UPDATE s5469499.Menu_List_DBP SET filename ='" + textBox_picture.Text + "', filesize = '" + FileSize + "', file ='" + rawData. + "' WHERE Menu ='" + textBox_picturename.Text + "'";
                SQL = "UPDATE theroad.usertable SET pictureName = @FileName, pictureSize = @FileSize, picture = @File WHERE id ='" + Join_textBox_Id + "'";
                // SQL = "insert into theroad.usertable (i_user,pictureName, pictureSize, picture) values (,'@FileName', '@FileSize', '@File'))";
                cmd.Connection = con;
                cmd.CommandText = SQL;
                cmd.Parameters.AddWithValue("@FileName", textBox_picture); // 사진 파일의 이름이 저장되는 부분
                cmd.Parameters.AddWithValue("@FileSize", FileSize); // 사진 파일의 사이즈가 저장되는 부분
                cmd.Parameters.AddWithValue("@File", rawData); // 사진파일의 데이터가 저장되는 부분
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex) { }
        }
    }
}
