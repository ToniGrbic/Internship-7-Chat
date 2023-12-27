using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatApp.Data.Entities.Models
{
    public class Users
    {
        public Users(string email, string password)
        {
            Email = email;
            Password = password;
        }

        public Users(string email, string password, string username)
        {
            Email = email;
            Password = password;
            UserName = username;
        }

        public int Id { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public string? UserName { get; set; }

        public bool isAdmin { get; set; }

        public bool isLogged { get; set; }

        public ICollection<PrivateMessages> PrivateMessagesSent { get; set; } = new List<PrivateMessages>();

        public ICollection<PrivateMessages> PrivateMessagesReceived { get; set; } = new List<PrivateMessages>();

        public ICollection<GroupUsers> GroupUsers { get; set; } = new List<GroupUsers>();

        public ICollection<GroupMessages> GroupMessages { get; set; } = new List<GroupMessages>();
    }
}