using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ChatApp.Data.Entities.Models;
using ChatApp.Domain.Enums;
using ChatApp.Domain.Factories;
using ChatApp.Domain.Repositories;

namespace ChatApp.Presentation.Actions
{
    public class GroupUsersActions
    {
        private static GroupUsersRepository _groupUsersRepository = RepositoryFactory.Create<GroupUsersRepository>();
        public static void AddUserToGroup(int userID, int groupID)
        {
            var groupUser = new GroupUsers { UserId = userID, GroupId = groupID };
            var response = _groupUsersRepository.Add(groupID, userID);
            if (response == ResponseResultType.Success)
                Console.WriteLine("User added to group");
            else
                Console.WriteLine("User not added to group");
        }
    }
}
