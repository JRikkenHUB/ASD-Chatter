using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSocketSharp;
using Newtonsoft.Json;
using System.Windows.Forms;
using System.ComponentModel;

namespace ASD_chatter.Connection
{
    public class WebSocketConnection
    {
        private WebSocket socket;
        private BindingList<string> adapterRef;
        public WebSocketConnection(BindingList<string> adapter)
        {
            adapterRef = adapter;
            //Configure websocket
            socket = new WebSocket("ws://127.0.0.1:8080");

            //Set events
            socket.OnMessage += Socket_OnMessage;
        }

        public void Socket_OnMessage(object sender, MessageEventArgs e)
        {
            string message = JsonConvert.DeserializeObject<string>(e.Data);
            adapterRef.Add(message);
        }

        public string Connect() 
        {
            try
            {
                socket.Connect();
                return "Succes";
            }
            catch (Exception e)
            {
                return e.Message;                
            }
        }

        public void SendMessage(string message) 
        {
            try
            {
                var jsonMessage = JsonConvert.SerializeObject(message);
                socket.Send(jsonMessage);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
