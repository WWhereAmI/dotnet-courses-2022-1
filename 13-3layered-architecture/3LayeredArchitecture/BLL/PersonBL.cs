using System;
using Entities;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace BLL.Main
{
    public class PersonBL
    {
        private BindingList<User> userList = new BindingList<User>();

        public BindingList<User> GetAll()
        {
            return userList;
        }

        public User GetUser(int userID)
        {
            return userList.First(e => e.ID == userID);
        }

        public void AddUser(User user)
        {
            userList.Add(user);
        }

        public void RemoveUser(User user)
        {
            userList.Remove(user);
        }

        public IEnumerable<Award> GetUserAwards(int userID)
        {
            var currentUser = GetUser(userID);

            foreach (var award in currentUser.UserAwards)
            {
                yield return award;
            }
        }

    }
}
