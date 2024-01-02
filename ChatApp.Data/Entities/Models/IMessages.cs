using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatApp.Data.Entities.Models
{
    public interface IMessages
    {
        public int Id { get; set; }
        public int SenderUserID { get; set; }

        public string MessageText { get; set; }

        public Users SenderUser { get; set; }
        public DateTime SentDate { get; set; }
    }
}