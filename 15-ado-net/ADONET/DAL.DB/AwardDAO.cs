﻿using Entities;
using Interfaces;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAL.DB
{
    public class AwardDAO : IAwardDAO
    {
        SqlConnectionStringBuilder stringBuilder;

        List<Award> awardList;

        private enum SortDirection
        {
            Asc,
            Desc
        }

        private SortDirection currentSortStep = SortDirection.Asc;

        public AwardDAO()
        {
            stringBuilder = new SqlConnectionStringBuilder(DataBaseConfigurator.GetConnectionString());

        }

        public void AddAward(Award award)
        {
            using (var connection = new SqlConnection(stringBuilder.ConnectionString))
            using (var command = new SqlCommand("AddAward", connection))
            {
                connection.Open();

                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("Title", SqlDbType.NVarChar).Value = award.Title;
                command.Parameters.Add("Description", SqlDbType.NVarChar).Value = award.Description;

                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<Award> GetAll()
        {

            using (var connection = new SqlConnection(stringBuilder.ConnectionString))
            using (var command = new SqlCommand("SELECT ID, Title, [Description] FROM dbo.Awards", connection))
            {
                connection.Open();

                var reader = command.ExecuteReader();

                awardList = GetAwardList(reader);
            }

            return awardList;   
        }

        public Award GetAward(int awardID)
        {
            using (var connection = new SqlConnection(stringBuilder.ConnectionString))
            using (var command = new SqlCommand("GetAward", connection))
            {
                connection.Open();

                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("AwardID", SqlDbType.Int).Value = awardID;

                var reader = command.ExecuteReader();

                reader.Read();

                return new Award()
                {
                    ID = (int)reader["ID"],
                    Title = reader["Title"].ToString(),
                    Description = reader["Description"].ToString()
                };
            }
        }

        public IEnumerable<Award> OrderAwardByField(int fieldIndex)
        {
            using (var connection = new SqlConnection(stringBuilder.ConnectionString))
            {
                
                using (var command = new SqlCommand("OrderAwardByField", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("FieldIndex", SqlDbType.Int).Value = fieldIndex;

                    if (currentSortStep == SortDirection.Asc)
                    {
                        command.Parameters.Add("SortStep", SqlDbType.Int).Value = 2;
                        currentSortStep = SortDirection.Desc;
                    }
                    else
                    {
                        command.Parameters.Add("SortStep", SqlDbType.Int).Value = 1;
                        currentSortStep = SortDirection.Asc;
                    }

                    connection.Open();

                    var reader = command.ExecuteReader();

                    awardList = GetAwardList(reader);
                }          
                return awardList;                        
            }
        }

        private List<Award> GetAwardList(SqlDataReader reader)
        {          
            List<Award> awards = new List<Award>();  

            while (reader.Read())
            {
                Award award = new Award()
                {
                    ID = (int)reader["ID"],
                    Title = reader["Title"].ToString(),
                    Description = reader["Description"].ToString()
                };

                awards.Add(award);
            }

            return awards;
        }

        public void RemoveAward(Award award)
        {
            using (var connection = new SqlConnection(stringBuilder.ConnectionString))
            using (var command = new SqlCommand("RemoveAward", connection))
            {
                connection.Open();

                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("AwardID", SqlDbType.Int).Value = award.ID;

                command.ExecuteNonQuery();
            }        
        }

        public void UpdateAward(int awardID, string title, string description)
        {
            using (var connection = new SqlConnection(stringBuilder.ConnectionString))
            using (var command = new SqlCommand("UpdateAward", connection))
            {
                connection.Open();

                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("AwardID", SqlDbType.Int).Value = awardID;
                command.Parameters.Add("Title", SqlDbType.NVarChar).Value = title;
                command.Parameters.Add("Description", SqlDbType.NVarChar).Value = description;

                command.ExecuteNonQuery();
            }
        }
    }
}
