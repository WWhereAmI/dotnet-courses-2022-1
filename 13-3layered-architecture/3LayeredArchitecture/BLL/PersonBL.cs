using DAL.List;
using Entities;
using Interfaces;
using System.Collections.Generic;

namespace BLL.Main
{
    public class PersonBL : IPersonBL
    {

        private IPersonDAO personDAO;

        public PersonBL(IPersonDAO personDAO)
        {
            this.personDAO = personDAO;
        }

        public IEnumerable<User> GetAll()
        {
            return personDAO.GetAll();
        }

        public User GetUser(int userID)
        {
            return personDAO.GetUser(userID);
        }

        public void AddUser(User user)
        {
            personDAO.AddUser(user);
        }

        public void RemoveUser(User user)
        {
            personDAO.RemoveUser(user);
        }

        /// <summary>
        /// Deleting award from all users
        /// </summary>
        /// <param name="award"></param>
        public void RemoveAward(Award award)
        {
            personDAO.RemoveAward(award);
        }


        public void AddUserAward(User user, Award award)
        {
            personDAO.AddUserAward(user, award);
        }

        public IEnumerable<Award> GetUserAwards(User user)
        {
            return personDAO.GetUserAwards(user);
        }

        public void OrderUserByField(int fieldIndex)
        {
            personDAO.OrderUserByField(fieldIndex);
        }

    }
}
