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

            personBL.RemoveAward(award);

        }
        public IEnumerable<Award> OrderAwardByField(int fieldIndex)
        {
            return awardDAO.OrderAwardByField(fieldIndex);
        }

        public void UpdateAward(int awardID, string title, string description)
        {
            awardDAO.UpdateAward(awardID, title, description);
        }
    }
}
