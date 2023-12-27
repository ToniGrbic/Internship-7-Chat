using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatApp.Data.Entities.Models
{
    public class PrivateMessages
    {
        public PrivateMessages(int senderUserID, int receiverUserID, string messageText)
        {
            SenderUserID = senderUserID;
            ReceiverUserID = receiverUserID;
            MessageText = messageText;
            MessageDate = DateTime.Now;
        }

        public int Id { get; set; }

        public int SenderUserID { get; set; }

        public Users SenderUser { get; set; } = null!;

        public int ReceiverUserID { get; set; }

        public Users ReceiverUser { get; set; } = null!;

        public string MessageText { get; set; }

        public DateTime MessageDate { get; set; }

    }
}