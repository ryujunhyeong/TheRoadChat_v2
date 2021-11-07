using EngineIOSharp.Common.Enum;
using Newtonsoft.Json.Linq;
using SocketIOSharp.Client;
using SocketIOSharp.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

                string json = Data[0].ToString();
                var name = JObject.Parse(json)["from"]["name"];
                var msg = JObject.Parse(json)["msg"];


            });

        }
    }
}
