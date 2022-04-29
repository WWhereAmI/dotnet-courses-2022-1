using Entities;
using Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.DB
{
    public class PersonDAO : IPersonDAO
    {
        public void AddUser(User user)
        {
            throw new NotImplementedException();
        }

        public void AddUserAward(User user, Award award)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetAll()
        {
            throw new NotImplementedException();
        }

        public User GetUser(int userID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Award> GetUserAwards(User user)
        {
            throw new NotImplementedException();
        }

        public void OrderUserByField(int fieldIndex)
        {
            throw new NotImplementedException();
        }

        public void RemoveAward(Award award)
        {
            throw new NotImplementedException();
        }

        public void RemoveUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
