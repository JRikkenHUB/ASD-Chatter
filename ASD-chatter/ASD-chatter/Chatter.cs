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
using ASD_chatter.DTO;
using WebSocketSharp;

namespace ASD_chatter
{
    public partial class Chatter : Form
    {
        WebSocketConnection connection;
        BindingList<string> chatLog;
        string Username;
        public Chatter()
        {
            InitializeComponent();
            GetUsername();
            chatLog = new BindingList<string>();
            ltbChatLog.DataSource = chatLog;
            connection = new WebSocketConnection(chatLog);
        }

        public void GetUsername() 
        {
            UsernameDialog usernameDialog = new UsernameDialog();

            if (usernameDialog.ShowDialog(this) == DialogResult.OK) 
            {
                Username = usernameDialog.UsernameText;

            }
            usernameDialog.Dispose();
        }

        private void send_Click(object sender, EventArgs e)
        {
            AddToChatLog($"{Username}: {txtMessageBox.Text}");
            connection.SendMessage(new MessageDTO(Username, txtMessageBox.Text));

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
