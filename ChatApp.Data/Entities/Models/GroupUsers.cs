

namespace ChatApp.Data.Entities.Models
{
    public class GroupUsers
    {
        public int GroupId { get; set; }

        public Groups Group { get; set; } = null!;

        public int UserId { get; set; }

        public Users User { get; set; } = null!;
    }
}