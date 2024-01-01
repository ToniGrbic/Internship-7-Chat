
using ChatApp.Domain.Factories;
using ChatApp.Domain.Repositories;
using ChatApp.Domain.Enums;
using ChatApp.Data.Entities.Models;
using ChatApp.Presentation.Helpers;

namespace ChatApp.Presentation.Actions
{
    public class GroupMessagesActions
    {
        private static GroupMessagesRepository _groupMessagesRepository = RepositoryFactory.Create<GroupMessagesRepository>();

        public static void CreateAndAddGroupMessage(int userId, int groupId, string messageText)
        {
            var newGroupMessage = new GroupMessages(groupId, userId, messageText);
            var responseResult = _groupMessagesRepository.Add(newGroupMessage);
            if (responseResult == ResponseResultType.Success)
                Console.WriteLine($"Message sent successfully!\n");
            else
            {
                Console.WriteLine("Failed to send message, no changes saved!\n");
                Reader.ReadKeyToContinue();
            }
                
        }

        public static List<GroupMessages>? GetAllGroupMessages(int groupId)
        {
            var groupMessages = _groupMessagesRepository.GetAll(groupId);
            if (groupMessages == null)
            {
                Console.WriteLine("No messages!");
                return null;
            }
            return groupMessages!;
        }
    }
}
