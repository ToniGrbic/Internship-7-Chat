using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatApp.Data.Entities.Models
{
    public class GroupMessages
    {
        public GroupMessages(int groupID, int senderUserID, string messageText)
        {
            GroupID = groupID;
            SenderUserID = senderUserID;
            MessageText = messageText;
            MessageDate = DateTime.Now;
        }
        
        public int Id { get; set; }

        public int GroupID { get; set; }

        public Groups Group { get; set; } = null!;

        public int SenderUserID { get; set; }

        public Users SenderUser { get; set; } = null!;

        public string MessageText { get; set; }

        public DateTime MessageDate { get; set; }
    }
}