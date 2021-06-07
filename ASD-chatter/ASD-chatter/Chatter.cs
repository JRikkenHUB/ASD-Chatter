using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ASD_chatter.Connection;
using WebSocketSharp;

namespace ASD_chatter
{
    public partial class Chatter : Form
    {
        WebSocketConnection connection;
        BindingList<string> chatLog;
        public Chatter()
        {
            InitializeComponent();
            chatLog = new BindingList<string>();
            ltbChatLog.DataSource = chatLog;
            connection = new WebSocketConnection(chatLog);
        }

        private void send_Click(object sender, EventArgs e)
        {
            AddToChatLog(txtMessageBox.Text);
            connection.SendMessage(txtMessageBox.Text);

            txtMessageBox.Clear();
        }

        private void connect_Click(object sender, EventArgs e)
        {
            var message = connection.Connect();
            AddToChatLog(message);

        }

        public void AddToChatLog(string message) 
        {
            chatLog.Add(message);
        }
    }
}
