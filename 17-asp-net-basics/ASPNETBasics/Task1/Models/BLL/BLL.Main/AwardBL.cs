using DAL.List;
using Entities;
using Interfaces;
using System.Collections.Generic;

namespace BLL.Main
{
    public class AwardBL : IAwardBL
    {

        private IAwardDAO awardDAO;

        public AwardBL(IAwardDAO awardDAO)
        {
            this.awardDAO = awardDAO;
        }

        public IEnumerable<Award> GetAll()
        {
            return awardDAO.GetAll();
        }

        public Award GetAward(int awardID)
        {
            return awardDAO.GetAward(awardID);
        }

        public void AddAward(Award award)
        {
            awardDAO.AddAward(award);
        }

        public void RemoveAward(Award award, IPersonBL personBL)
        {
            awardDAO.RemoveAward(award);

            personBL.RemoveAward(default, award);

        }
        public IEnumerable<Award> OrderAwardByField(int fieldIndex, SortDirection sortDirection)
        {
            return awardDAO.OrderAwardByField(fieldIndex, sortDirection);
        }

        public void UpdateAward(int awardID, string title, string description)
        {
            awardDAO.UpdateAward(awardID, title, description);
        }
    }
}
