using DAL.DB;
using Entities;
using Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Task1.Controllers
{
    public class AwardController : Controller
    {
        IAwardDAO awardDAO = new AwardDAO();

        [HttpGet]
        public IActionResult AwardIndex()
        {
            var awards = awardDAO.GetAll();

            return View(awards);
        }

        [HttpPost]
        public IActionResult AwardDelete(int awardID)
        {
            var award = awardDAO.GetAward(awardID);

            awardDAO.RemoveAward(award);

            return RedirectToAction("AwardIndex");
        }

        [HttpGet]
        public IActionResult AwardAdd()
        {
            return View(new AwardViewModel());
        }

        [HttpPost]
        public IActionResult AwardAdd(AwardViewModel award)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var rewardToAdd = new Award
            {
                ID = award.ID,
                Title = award.Title,
                Description = award.Description,
            };

            awardDAO.AddAward(rewardToAdd);

            return RedirectToAction("AwardIndex");
        }

        [HttpGet]
        public IActionResult AwardUpdate(int awardID)
        {
            var award = awardDAO.GetAward(awardID);

            var rewardToUpdate = new AwardViewModel(award);

            return View(rewardToUpdate);
        }

        [HttpPost]
        public IActionResult AwardUpdate(AwardViewModel award)
        {
            if (!ModelState.IsValid)
            {
                return View(award);
            }

            awardDAO.UpdateAward(award.ID, award.Title, award.Description);

            return RedirectToAction("AwardIndex");
        }

        [HttpGet]
        public IActionResult AwardOrder(int fieldIndex, SortDirection sortDirection = SortDirection.Desc)
        {
            awardDAO.GetAll();

            ViewBag.SortOrder = sortDirection == SortDirection.Asc ? SortDirection.Desc : SortDirection.Asc;

            var awards = awardDAO.OrderAwardByField(fieldIndex, sortDirection);

            return View("AwardIndex", awards);
        }


    }
}
