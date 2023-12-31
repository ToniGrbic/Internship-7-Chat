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
using ChatApp.Presentation.Views.Menus;

namespace ChatApp.Presentation.Actions
{
    public class GroupUsersActions
    {
        private static GroupUsersRepository _groupUsersRepository = RepositoryFactory.Create<GroupUsersRepository>();
        public static void AddUser(int userID, int groupID)
        {
            var response = _groupUsersRepository.AddUser(userID, groupID);
            if (response == ResponseResultType.Success)
                Console.WriteLine("User added to group");
            else
                Console.WriteLine("User not added to group");
        }

    }
}
