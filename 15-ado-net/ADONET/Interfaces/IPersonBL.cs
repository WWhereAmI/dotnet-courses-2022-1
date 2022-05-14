using Entities;
using System;
using System.Collections.Generic;

namespace Interfaces
{
    public interface IPersonBL
    {
        public IEnumerable<User> GetAll();

        public User GetUser(int userID);

        public int AddUser(User user);

        public void UpdateUser(int userID, string firstName, string lastName, DateTime dateTime);

        public void RemoveUser(User user);

        /// <summary>
        /// Deleting award from all users
        /// </summary>
        /// <param name="award"></param>
        public void RemoveAward(Award award);

        public void AddUserAward(User user, Award award);

        public IEnumerable<Award> GetUserAwards(User user);

        public IEnumerable<User> OrderUserByField(int fieldIndex);

    }
}
