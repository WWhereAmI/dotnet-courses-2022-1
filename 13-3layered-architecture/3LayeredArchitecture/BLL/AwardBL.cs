using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Linq;

namespace BLL.Main
{
    public class AwardBL
    {
        private BindingList<Award> awardList = new BindingList<Award>();

        public BindingList<Award> GetAll()
        {
            return awardList;
        }

        public Award GetAward(int awardID)
        {
            return awardList.First(e => e.ID == awardID);
        }

        public void AddAward(Award award)
        {
            awardList.Add(award);
        }

        public void RemoveAward(Award award)
        {
            awardList.Remove(award);
        }
    }
}
