using Entities;
using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL.List
{
    public class PersonDAO : IPersonDAO
    {
        private enum SortDirection
        {
            Asc,
            Desc
        }

        private SortDirection currentSortStep = SortDirection.Asc;

        private List<User> userList = new List<User>();

        public IEnumerable<User> GetAll()
        {
            return userList.ToList();
        }

        public User GetUser(int userID)
        {
            return userList.First(e => e.ID == userID);
        }

        public void AddUser(User user)
        {
            var maxID = userList.Count > 0 ? userList.Max(e => e.ID) : 0;
            user.ID = maxID + 1;

            userList.Add(user);
        }

        public void RemoveUser(User user)
        {
            userList.Remove(user);
        }

        /// <summary>
        /// Deleting award from all users
        /// </summary>
        /// <param name="award"></param>
        public void RemoveAward(Award award)
        {
            foreach (var user in userList)
            {
                foreach (var userAward in user.UserAwards)
                {
                    if (userAward == award)
                    {
                        user.UserAwards.Remove(userAward);
                        break;
                    }
                }
            }
        }

        public void AddUserAward(User user, Award award)
        {
            user.UserAwards.Add(award);
        }

        public IEnumerable<Award> GetUserAwards(User user)
        {
            return user.UserAwards;
        }

        public void OrderUserByField(int fieldIndex)
        {
            Func<User, object> sortRule;

            switch (fieldIndex)
            {
                case 0:
                    sortRule = e => e.ID;
                    break;
                case 1:
                    sortRule = e => e.FirstName;
                    break;
                case 2:
                    sortRule = e => e.LastName;
                    break;
                case 3:
                    sortRule = e => e.BirthDate;
                    break;
                case 4:
                    sortRule = e => e.Age;
                    break;
                case 5:
                    sortRule = e => e.UserAwardsList;
                    break;
                default:
                    throw new ArgumentOutOfRangeException();            
            }

            if (currentSortStep == SortDirection.Asc)
            {
                userList = userList.OrderByDescending(sortRule).ToList();
                currentSortStep = SortDirection.Desc;
            }
            else
            {
                userList = userList.OrderBy(sortRule).ToList();
                currentSortStep = SortDirection.Asc;
            }

        }
    }
}
