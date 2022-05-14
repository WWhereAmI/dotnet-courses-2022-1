using Entities;
using System;
using System.Collections.Generic;

namespace Interfaces
{
    public interface IAwardDAO
    {
        public IEnumerable<Award> GetAll();

        public Award GetAward(int awardID);

        public void AddAward(Award award);

        public void RemoveAward(Award award);

        public IEnumerable<Award> OrderAwardByField(int fieldIndex);

        public void UpdateAward(int awardID, string title, string description);
    }
}
