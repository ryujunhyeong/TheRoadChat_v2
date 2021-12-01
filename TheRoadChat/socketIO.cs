using EngineIOSharp.Common.Enum;
using Newtonsoft.Json.Linq;
using SocketIOSharp.Client;
using SocketIOSharp.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheRoadChat
{
    
    public class socketIO
    {
        public static SocketIOClient client;
        chat mychatForm;
        

        public socketIO(chat chatForm)
        {
            this.mychatForm = chatForm;
       
            socketinit();
            
        }


        public void socketinit()
        {
            client = new SocketIOClient(new SocketIOClientOption(EngineIOScheme.http, "localhost", 3000));
            InitEventHandlers(client);
            client.Connect();

        }

        public void InitEventHandlers(SocketIOClient client)
        {
            //연결 성공시
            client.On(SocketIOEvent.CONNECTION, () =>
            {
                Console.WriteLine("Connected!");
            });


            //연결 끊을시
            client.On(SocketIOEvent.DISCONNECT, () =>
            {
                Console.WriteLine();
                Console.WriteLine("Disconnected!");
            });

            client.On("chat message", (Data) =>
            {

                //string json = Data[0].ToString();
                //var name = JObject.Parse(json)["from"]["name"];
                //var msg = JObject.Parse(json)["msg"];

                string json = Data[0].ToString();
                int i_user = JObject.Parse(json)["i_user"].ToObject<int>();
                int i_channel = JObject.Parse(json)["i_channel"].ToObject<int>();
                string user_name = JObject.Parse(json)["user_name"].ToObject<string>();
                string msg = JObject.Parse(json)["msg"].ToObject<string>();
                string m_dt = JObject.Parse(json)["m_dt"].ToObject<string>();
                int i_file = JObject.Parse(json)["i_file"].ToObject<int>();

                FlowLayoutPanel panel = chat.connectChatPanel[i_channel];

                mychatForm.Invoke(
                    (System.Action)(() =>
                    {
                        if(i_file == 0) //일반 메세지 수신
                        {
                            opponentBubble bubble = new opponentBubble(i_user, user_name, msg, m_dt);
                            panel.Controls.Add(bubble);
                            panel.ScrollControlIntoView(bubble);
                        }
                        else if(i_file == -1)
                        {
                            string realPath = System.Windows.Forms.Application.StartupPath + "\\emoticon\\" + msg;
                            opponentImgBubble bubble = new opponentImgBubble(realPath, user_name, msg, m_dt);
                            panel.Controls.Add(bubble);
                            panel.ScrollControlIntoView(bubble);
                        }
                        else
                        {
                            if (msg.CompareTo("img") == 0) //이미지 파일 수신
                            {
                                string path = DBManager.thisDBManager.pullFile(i_file);
                                opponentImgBubble bubble = new opponentImgBubble(path, user_name, msg, m_dt);
                                panel.Controls.Add(bubble);
                                panel.ScrollControlIntoView(bubble);
                            }
                            else //파일 수신
                            {
                                opponentFileBubble bubble = new opponentFileBubble(i_file, user_name, m_dt);
                                panel.Controls.Add(bubble);
                                panel.ScrollControlIntoView(bubble);
                            }
                        }
                        


                        foreach (messageInfoInChannnel messages in this.mychatForm.messageInfoInChannnelList)
                        {
                            if(messages.i_channel == i_channel)
                            {
                                messages.messageInChannel.Add(new messageInfo(i_user, i_channel, user_name, msg, m_dt, i_file));
                            }
                        }

                        if(chat.thisForm.alarm == true)
                        {
                            MessageBox.Show(user_name + " : " + msg);
                        }
                    }));

            });

            client.On("checkFriend", (Data) =>
            {
                string json = Data[0].ToString();
                int idx = 0;
                if(idx.ToString().CompareTo(json) == 0)
                {
                    mychatForm.Invoke(
                    (System.Action)(() =>
                    {
                        chat.thisForm.updateData();
                        chat.thisForm.updateLayout();
                    }));
                }
                else if(chat.thisForm.i_user.ToString().CompareTo(json) == 0)
                {
                    mychatForm.Invoke(
                    (System.Action)(() =>
                    {
                        chat.thisForm.updateData();
                        chat.thisForm.updateLayout();
                    }));
                }
                else if (chat.thisForm.ID.CompareTo(json) == 0)
                {
                    mychatForm.Invoke(
                    (System.Action)(() =>
                    {
                        chat.thisForm.updateData();
                        chat.thisForm.updateLayout();
                    }));
                }
                else if (chat.myName.CompareTo(json) == 0)
                {
                    mychatForm.Invoke(
                    (System.Action)(() =>
                    {
                        chat.thisForm.updateData();
                        chat.thisForm.updateLayout();
                    }));
                }
            });
        }
    }
}
