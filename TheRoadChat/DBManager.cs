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
    public class DBManager
    {
        public int i_user;
        private string strconn = "Server=27.96.130.41;Port=3306;Database=s5469775;Uid=s5469775;Pwd=s5469775;Charset=utf8";
        public static DBManager thisDBManager;

        public DBManager(int _i_user)
        {
            this.i_user = _i_user;
            thisDBManager = this;
        }

        public List<friendInfo> selectMyFriendsList(int plusFriendOfFriend)
        {
            List<friendInfo> myFriends;

            using (MySqlConnection conn = new MySqlConnection(strconn))
            {
                conn.Open();
                string query = "";

                if (plusFriendOfFriend == 0)
                {
                    query = "CALL myFriends(" + i_user + ")";
                }

                else if(plusFriendOfFriend == 1)
                {
                    query = "CALL friendOfMyFriend(" + i_user + ")";
                }

                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                myFriends = new List<friendInfo>();

                while (rdr.Read())
                {
                    //필요한 정보들 가져오기
                    int friend_i_user = int.Parse(rdr["i_user"].ToString());
                    string name = rdr["user_name"].ToString();

                    friendInfo myFriend = new friendInfo(friend_i_user, name);
                    myFriends.Add(myFriend);
                }

                rdr.Close();

                
            }
            return myFriends;
        }

      

        public List<channelInfo> selectMyChannelsList()
        {
            List<channelInfo> myChannels;

            using (MySqlConnection conn = new MySqlConnection(strconn))
            {
                conn.Open();
                string query = "CALL myChannels(" + i_user + ")";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                myChannels = new List<channelInfo>();

                while (rdr.Read())
                {
                    //필요한 정보들 가져오기
                    int i_channel = int.Parse(rdr["i_channel"].ToString());
                    string channel_name = rdr["channel_name"].ToString();

                    channelInfo myChannel = new channelInfo(i_channel, channel_name);
                    myChannels.Add(myChannel);
                }

                rdr.Close();
            }
            return myChannels;
        }

        public List<messageInfoInChannnel> pullMessage(List<channelInfo> channelList)
        {
            List<messageInfoInChannnel> result = new List<messageInfoInChannnel>();

            foreach (channelInfo channel in channelList)
            {
                using (MySqlConnection conn = new MySqlConnection(strconn))
                {
                    conn.Open();
                    string query = "CALL pullMessage(" + channel.i_channel + ")";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader rdr = cmd.ExecuteReader();

                    List<messageInfo> messages = new List<messageInfo>();

                    while (rdr.Read())
                    {
                        //필요한 정보들 가져오기
                        int i_user = int.Parse(rdr["i_user"].ToString());
                        string user_name = rdr["user_name"].ToString();
                        string msg = rdr["msg"].ToString();
                        string m_dt = rdr["m_dt"].ToString().Substring(11);
                        m_dt = m_dt.Substring(0, 8); //아니 이거 왜이러냐 한번에 왜 안돼 ㅅㅂ
                        int i_file = int.Parse(rdr["i_file"].ToString());

                        messages.Add(new messageInfo(i_user, channel.i_channel, user_name, msg, m_dt, i_file));

                    }

                    result.Add(new messageInfoInChannnel(channel.i_channel, messages));

                    rdr.Close();
                }
            }
            return result;
            
        }

        public bool plusFriend(string ID)
        {
            using (MySqlConnection conn = new MySqlConnection(strconn))
            {
                conn.Open();
                string query = "CALL plusFriend(" + this.i_user + ", " + "\"" + ID + "\"" + ")";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();


                while (rdr.Read())
                {
                    //필요한 정보들 가져오기
                    int exist = int.Parse(rdr["exist"].ToString());

                    if (exist == -1)
                        MessageBox.Show("존재하지 않는 아이디입니다.");
                    else if (exist == 0)
                    {
                        MessageBox.Show("친구 등록 성공");
                        socketIO.client.Emit("checkFriend", 0);
                    }
                        
                    else
                        MessageBox.Show("이미 존재하는 친구 입니다.");

                }

                rdr.Close();
            }

            return true;
        }

        public void delFriend(int friends_i_user)
        {
            using (MySqlConnection conn = new MySqlConnection(strconn))
            {
                conn.Open();
                string query = "CALL delFriend(" + this.i_user + ", " + friends_i_user + ")";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteReader();

            }
            socketIO.client.Emit("checkFriend", 0);
        }

        public void plusChannel(string channel_name)
        {
            using (MySqlConnection conn = new MySqlConnection(strconn))
            {
                conn.Open();
                string query = "CALL plusChannel(" + this.i_user + ", \"" + channel_name + "\")";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteReader();

            }
        }

        public void inviteChannel(string friendName, int i_channel, string channel_name)
        {
            using (MySqlConnection conn = new MySqlConnection(strconn))
            {
                conn.Open();
                string query = "CALL inviteChannel(\"" + friendName + "\", " + i_channel + ", \"" + channel_name + "\")";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteReader();

            }
        }

        public int pushFile(int i_user, int i_channel, string fileName, UInt32 fileSize, byte[] fileRawData)
        {
            int i_file = 0;
            using (MySqlConnection conn = new MySqlConnection(strconn))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();

                string query = "call pushFileAndGet_i_file(@i_user, @i_channel, @FileName, @FileSize, @fileRawData)";

                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@i_user", i_user);
                cmd.Parameters.AddWithValue("@i_channel", i_channel);
                cmd.Parameters.AddWithValue("@fileName", fileName);
                cmd.Parameters.AddWithValue("@fileSize", fileSize);
                cmd.Parameters.AddWithValue("@fileRawData", fileRawData);
                MySqlDataReader rdr = cmd.ExecuteReader();


                while (rdr.Read())
                {
                    //필요한 정보들 가져오기
                    i_file = int.Parse(rdr["i_file"].ToString());

                }

                rdr.Close();
            }
            return i_file;
        }
        public string pullFile(int i_file)
        {
            string SQL;
            string FileName;
            UInt32 FileSize;
            string FilePath = string.Empty;
            byte[] rawData;
            FileStream fs;

            MySqlConnection con = new MySqlConnection(strconn);
            MySqlCommand cmd = new MySqlCommand();

            string query = "SELECT * from fileTable where i_file = " + i_file;

            try
            {
                con.Open();

                cmd.Connection = con;
                cmd.CommandText = query;

                MySqlDataReader myData = cmd.ExecuteReader();

                if (!myData.HasRows)
                    throw new Exception("There are no BLOBs to save");

                myData.Read();

                FileName = myData["fileName"].ToString();

                FilePath = @System.IO.Directory.GetCurrentDirectory() + "\\file\\" + FileName;

                Console.WriteLine(FilePath);

                FileInfo fileInfo = new FileInfo(FilePath); //해당 경로 파일 확인

                if (fileInfo.Exists == false) //파일이 없는 경우
                {
                    FileSize = myData.GetUInt32(myData.GetOrdinal("fileLength"));
                    rawData = new byte[FileSize];

                    myData.GetBytes(myData.GetOrdinal("fileData"), 0, rawData, 0, (int)FileSize);

                    fs = new FileStream(FilePath, FileMode.OpenOrCreate, FileAccess.Write);
                    fs.Write(rawData, 0, (int)FileSize);
                    fs.Close();
                }

                myData.Close();
                con.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show("Error " + ex.Number + " has occurred: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return FilePath;
        }

        public string pullFileWantedPath(int i_file, string path)
        {
            string SQL;
            string FileName;
            UInt32 FileSize;
            string FilePath = string.Empty;
            byte[] rawData;
            FileStream fs;

            MySqlConnection con = new MySqlConnection(strconn);
            MySqlCommand cmd = new MySqlCommand();

            string query = "SELECT * from fileTable where i_file = " + i_file;

            try
            {
                con.Open();

                cmd.Connection = con;
                cmd.CommandText = query;

                MySqlDataReader myData = cmd.ExecuteReader();

                if (!myData.HasRows)
                    throw new Exception("There are no BLOBs to save");

                myData.Read();

                FileName = myData["fileName"].ToString();

                FilePath = path + "\\" + FileName;

                Console.WriteLine(FilePath);

                FileInfo fileInfo = new FileInfo(FilePath); //해당 경로 파일 확인

                if (fileInfo.Exists == false) //파일이 없는 경우
                {
                    FileSize = myData.GetUInt32(myData.GetOrdinal("fileLength"));
                    rawData = new byte[FileSize];

                    myData.GetBytes(myData.GetOrdinal("fileData"), 0, rawData, 0, (int)FileSize);

                    fs = new FileStream(FilePath, FileMode.OpenOrCreate, FileAccess.Write);
                    fs.Write(rawData, 0, (int)FileSize);
                    fs.Close();
                }

                myData.Close();
                con.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show("Error " + ex.Number + " has occurred: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return FilePath;

        }
    }
}
