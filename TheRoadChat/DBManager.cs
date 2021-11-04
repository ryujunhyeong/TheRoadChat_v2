using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheRoadChat
{
    public class DBManager
    {
        private int i_user;
        private string strconn = "Server=27.96.130.41;Port=3306;Database=s5469775;Uid=s5469775;Pwd=s5469775;Charset=utf8";

        public DBManager(int _i_user)
        {
            this.i_user = _i_user;
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

        public void pullMessage(FlowLayoutPanel PanelMsg, string channel_name)
        {
            using (MySqlConnection conn = new MySqlConnection(strconn))
            {
                conn.Open();
                string query = "CALL pullMessage(\"" + channel_name + "\")";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();


                while (rdr.Read())
                {
                    //필요한 정보들 가져오기
                    int i_user = int.Parse(rdr["i_user"].ToString());
                    string user_name = rdr["user_name"].ToString();
                    string msg = rdr["msg"].ToString();
                    string m_dt = rdr["m_dt"].ToString().Substring(11);
                    m_dt = m_dt.Substring(0, 8); //아니 이거 왜이러냐 한번에 왜 안돼 ㅅㅂ

                    Console.WriteLine(m_dt.Length);

                    if (this.i_user != i_user)
                    {
                        opponentBubble myBubble = new opponentBubble(i_user, user_name, msg, m_dt);
                        PanelMsg.Controls.Add(myBubble);
                    }
                    else
                    {
                        myBubble myBubble = new myBubble(msg, m_dt);
                        PanelMsg.Controls.Add(myBubble);
                    }
                    
                }

                rdr.Close();
            }
        }

        public bool plusFriend(string ID)
        {


            return true;
        }


    }
}
