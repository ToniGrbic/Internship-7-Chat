using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatApp.Data.Entities.Models
{
    public class GroupUsers
    {
        public int Id { get; set; }

        public Groups Group { get; set; } = null!;

        public int UserId { get; set; }

        public Users User { get; set; } = null!;
    }
}