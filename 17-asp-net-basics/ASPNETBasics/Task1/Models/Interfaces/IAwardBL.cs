using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public interface IAwardBL
    {
        public IEnumerable<Award> GetAll();

        public Award GetAward(int awardID);

        public void AddAward(Award award);

        public void RemoveAward(Award award, IPersonBL personBL);

        public IEnumerable<Award> OrderAwardByField(int fieldIndex, SortDirection sortDirection);

        public void UpdateAward(int awardID, string title, string description);

    }
}
