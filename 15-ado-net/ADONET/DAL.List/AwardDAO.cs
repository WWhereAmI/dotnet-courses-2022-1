using Entities;
using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;


namespace DAL.List
{
    public class AwardDAO : IAwardDAO
    {
        public enum SortDirection
        {
            Asc,
            Desc
        }

        private SortDirection currentSortStep = SortDirection.Asc;

        private List<Award> awardList = new List<Award>();

        public IEnumerable<Award> GetAll()
        {
            return awardList.ToList();
        }

        public Award GetAward(int awardID)
        {
            return awardList.First(e => e.ID == awardID);
        }


        public void UpdateAward(int awardID, string title, string description)
        {
            awardList.Find(e => e.ID == awardID).Title = title;
            awardList.Find(e => e.ID == awardID).Description = description;
        }

        public void AddAward(Award award)
        {
            var maxID = awardList.Count > 0 ? awardList.Max(e => e.ID) : 0;
            award.ID = maxID + 1;

            awardList.Add(award);
        }

        public void RemoveAward(Award award)
        {
            awardList.Remove(award);
        }

        public IEnumerable<Award> OrderAwardByField(int fieldIndex)
        {
            Func<Award, object> sortRule;

            switch (fieldIndex)
            {
                case 0:
                    sortRule = e => e.ID;
                    break;
                case 1:
                    sortRule = e => e.Title;
                    break;
                case 2:
                    sortRule = e => e.Description;
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            if (currentSortStep == SortDirection.Asc)
            {
                awardList = awardList.OrderByDescending(sortRule).ToList();

                currentSortStep = SortDirection.Desc;

                return awardList;
            }
            else
            {
                awardList = awardList.OrderBy(sortRule).ToList();

                currentSortStep = SortDirection.Asc;

                return awardList;
            }
        }

    }
}
