using ChatApp.Data.Entities.Models;
using ChatApp.Domain.Factories;
using ChatApp.Domain.Repositories;
using ChatApp.Domain.Enums;
using ChatApp.Presentation.Views.Menus;
namespace ChatApp.Presentation.Actions
{
    
    public class GroupsActions
    {
        private static GroupsRepository _groupsRepository = RepositoryFactory.Create<GroupsRepository>();
        public static int CreateGroupChat(string groupName)
        {
            var newGroup = new Groups(groupName);
            var responseResult = _groupsRepository.AddGroup(newGroup);
            if (responseResult == ResponseResultType.Success)
                Console.WriteLine($"Group chat {groupName} created successfully!\n");
            else
                Console.WriteLine("Failed to create group chat, no changes saved!\n");
            return newGroup.Id;
        }

        public static List<Groups>? GetUnjoinedGroups(Users user)
        {
            var groups = _groupsRepository.GetAllUnjoinedGroups(user);
            if (groups == null)
            {
                Console.WriteLine("No group chats found!");
                return null;
            }
            return groups!;
        }

        public static void PrintAllUserGroupChats()
        {
            Console.WriteLine("TODO");
        }
    }
}
