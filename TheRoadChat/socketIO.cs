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

                FlowLayoutPanel panel = chat.connectChatPanel[i_channel];

                mychatForm.Invoke(
                    (System.Action)(() =>
                    {
                        opponentBubble bubble = new opponentBubble(i_user, user_name, msg, m_dt);
                        panel.Controls.Add(bubble);
                        panel.ScrollControlIntoView(bubble);
                    }));
                

            });

        }
    }
}
