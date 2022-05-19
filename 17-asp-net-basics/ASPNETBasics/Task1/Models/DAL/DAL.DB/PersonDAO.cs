using Entities;
using Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace DAL.DB
{
    public class PersonDAO : IPersonDAO
    {
        SqlConnectionStringBuilder stringBuilder;

        List<User> userList;

        public PersonDAO()
        {
            stringBuilder = new SqlConnectionStringBuilder(DataBaseConfigurator.GetConnectionString());
        }

        public int AddUser(User user)
        {
            SqlParameter idParam;

            using (var connection = new SqlConnection(stringBuilder.ConnectionString))
            using (var command = new SqlCommand("AddUser", connection))
            {
                connection.Open();

                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("FirstName", SqlDbType.NVarChar).Value = user.FirstName;
                command.Parameters.Add("LastName", SqlDbType.NVarChar).Value = user.LastName;
                command.Parameters.Add("BirthDate", SqlDbType.DateTime).Value = user.BirthDate;

                idParam = new SqlParameter
                {
                    ParameterName = "@NewID",
                    SqlDbType = SqlDbType.Int,
                    Direction = ParameterDirection.Output
                };

                command.Parameters.Add(idParam);

                command.ExecuteNonQuery();
            }

            return (int)idParam.Value;
        }

        public void AddUserAward(User user, Award award)
        {
            using (var connection = new SqlConnection(stringBuilder.ConnectionString))
            using (var command = new SqlCommand("AddUserAward", connection))
            {
                connection.Open();

                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("UserID", SqlDbType.Int).Value = user.ID;
                command.Parameters.Add("AwardID", SqlDbType.Int).Value = award.ID;

                command.ExecuteNonQuery();
            }

        }
        public IEnumerable<User> GetAll()
        {
            using (var connection = new SqlConnection(stringBuilder.ConnectionString))
            using (var command = new SqlCommand("SELECT * FROM Users", connection))
            {
                User user = new User();

                userList = new List<User>();

                connection.Open();

                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    user = new User()
                    {
                        ID = (int)reader[0],
                        FirstName = reader[1].ToString(),
                        LastName = reader[2].ToString(),
                        BirthDate = reader.GetDateTime(3),
                    };

                    userList.Add(user);
                 
                    user.UserAwards = GetUserAwards(user).ToList();
                }
            }

            return userList;
        }

        public User GetUser(int userID)
        {
            using (var connection = new SqlConnection(stringBuilder.ConnectionString))
            using (var command = new SqlCommand("GetUser", connection))
            {
                User user = new User();
                Award award = new Award();

                connection.Open();

                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("UserID", SqlDbType.Int).Value = userID;

                var reader = command.ExecuteReader();

                reader.Read();

                user = new User()
                {
                    ID = (int)reader[0],
                    FirstName = reader[1].ToString(),
                    LastName = reader[2].ToString(),
                    BirthDate = reader.GetDateTime(3)
                };

                user.UserAwards = GetUserAwards(user).ToList();

                return user;
            }
        }

        public IEnumerable<Award> GetUserAwards(User user)
        {
            using (var connection = new SqlConnection(stringBuilder.ConnectionString))
            using (var command = new SqlCommand("GetUserAwards", connection))
            {
                var awardList = new List<Award>();

                connection.Open();

                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("UserID", SqlDbType.Int).Value = user.ID;

                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Award award = new Award()
                    {
                        ID = (int)reader["ID"],
                        Title = reader["Title"].ToString(),
                        Description = reader["Description"].ToString()
                    };

                    awardList.Add(award);
                }

                return awardList;
            }
        }

        public IEnumerable<User> OrderUserByField(int fieldIndex, SortDirection sortDirection)
        {
            #region AdoNet vesion
            //using (var connection = new SqlConnection(stringBuilder.ConnectionString))
            //{
            //    if (currentSortStep == SortDirection.Asc)
            //    {
            //        using (var command = new SqlCommand("OrderUserByFieldDESC", connection))
            //        {
            //            userList = new List<User>();

            //            command.CommandType = CommandType.StoredProcedure;
            //            command.Parameters.Add("FieldIndex", SqlDbType.Int).Value = fieldIndex;

            //            connection.Open();

            //            var reader = command.ExecuteReader();

            //            while (reader.Read())
            //            {
            //                User user = new User()
            //                {
            //                    ID = (int)reader[0],
            //                    FirstName = reader[1].ToString(),
            //                    LastName = reader[2].ToString(),
            //                    BirthDate = reader.GetDateTime(3),
            //                };

            //                userList.Add(user);
            //            }
            //        }

            //        currentSortStep = SortDirection.Desc;
            //    }
            //    else if (currentSortStep == SortDirection.Desc)
            //    {
            //        using (var command = new SqlCommand("OrderUserByFieldASC", connection))
            //        {
            //            userList = new List<User>();

            //            command.CommandType = CommandType.StoredProcedure;
            //            command.Parameters.Add("FieldIndex", SqlDbType.Int).Value = fieldIndex;

            //            connection.Open();

            //            var reader = command.ExecuteReader();

            //            while (reader.Read())
            //            {
            //                User user = new User()
            //                {
            //                    ID = (int)reader[0],
            //                    FirstName = reader[1].ToString(),
            //                    LastName = reader[2].ToString(),
            //                    BirthDate = reader.GetDateTime(3),
            //                };

            //                userList.Add(user);
            //            }
            //        }
            //        currentSortStep = SortDirection.Asc;
            //    }
            //}
            #endregion

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

            if (sortDirection == SortDirection.Desc)
            {
                userList = userList.OrderByDescending(sortRule).ToList();
                
                return userList;
            }
            else
            {
                userList = userList.OrderBy(sortRule).ToList();

                return userList;
            }

        }

        public void RemoveAward(int userID, Award award)
        {
            using (var connection = new SqlConnection(stringBuilder.ConnectionString))
            using (var command = new SqlCommand("RemoveUserAward", connection))
            {
                connection.Open();

                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("AwardID", SqlDbType.Int).Value = award.ID;
                command.Parameters.Add("UserID", SqlDbType.Int).Value = userID;

                command.ExecuteNonQuery();
            }

        }

        public void RemoveUser(User user)
        {
            using (var connection = new SqlConnection(stringBuilder.ConnectionString))
            using (var command = new SqlCommand("RemoveUser", connection))
            {
                connection.Open();

                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("UserID", SqlDbType.Int).Value = user.ID;

                command.ExecuteNonQuery();
            }

        }

        public void UpdateUser(int userID, string firstName, string lastName, DateTime dateTime)
        {
            using (var connection = new SqlConnection(stringBuilder.ConnectionString))
            using (var command = new SqlCommand("UpdateUser", connection))
            {
                connection.Open();

                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("UserID", SqlDbType.Int).Value = userID;
                command.Parameters.Add("FirstName", SqlDbType.NVarChar).Value = firstName;
                command.Parameters.Add("LastName", SqlDbType.NVarChar).Value = lastName;
                command.Parameters.Add("BirthDate", SqlDbType.DateTime).Value = dateTime;

                command.ExecuteNonQuery();
            }
        }
    }
}
