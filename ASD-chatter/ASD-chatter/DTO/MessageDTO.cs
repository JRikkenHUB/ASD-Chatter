using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASD_chatter.DTO
{
    public class MessageDTO
    {
        private string Sender;
        private string Message;
        public string SenderInfo { get => Sender; set => Sender = value; }
        public string MessageInfo { get => Message; set => Message = value; }

        public MessageDTO(string sender, string message)
        {
            Sender = sender;
            Message = message;
        }
    }
}
