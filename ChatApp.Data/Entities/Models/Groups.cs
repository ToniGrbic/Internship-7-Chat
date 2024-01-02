

namespace ChatApp.Data.Entities.Models
{
    public class Groups
    {
        public Groups(string groupName)
        {
            GroupName = groupName;
        }

        public int Id { get; set; }

        public string GroupName { get; set; }

        public ICollection<GroupUsers> GroupUsers { get; set; } = new List<GroupUsers>();

        public ICollection<GroupMessages> GroupMessages { get; set; } = new List<GroupMessages>();
    }
}