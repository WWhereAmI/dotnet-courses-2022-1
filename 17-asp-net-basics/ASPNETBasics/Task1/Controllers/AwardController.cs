using Entities;
using Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Task1.Controllers
{
    public class AwardController : Controller
    {
        IPersonBL personBL;
        IAwardBL awardBL;

        public AwardController(IPersonBL personBL, IAwardBL awardBL)
        {
            this.personBL = personBL;
            this.awardBL = awardBL;
        }

        [HttpGet]
        public IActionResult AwardIndex()
        {
            var awards = awardBL.GetAll();

            return View(awards);
        }

        [HttpPost]
        public IActionResult AwardDelete(int awardID)
        {
            var award = awardBL.GetAward(awardID);

            awardBL.RemoveAward(award, personBL);

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

            var rewardToAdd = new Award(award.Title, award?.Description);
 

            awardBL.AddAward(rewardToAdd);

            return RedirectToAction("AwardIndex");
        }

        [HttpGet]
        public IActionResult AwardUpdate(int awardID)
        {
            var award = awardBL.GetAward(awardID);

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

            awardBL.UpdateAward(award.ID, award.Title, award.Description);

            return RedirectToAction("AwardIndex");
        }

        [HttpGet]
        public IActionResult AwardOrder(int fieldIndex, SortDirection sortDirection = SortDirection.Desc)
        {
            awardBL.GetAll();

            ViewBag.SortOrder = sortDirection == SortDirection.Asc ? SortDirection.Desc : SortDirection.Asc;

            var awards = awardBL.OrderAwardByField(fieldIndex, sortDirection);

            return View("AwardIndex", awards);
        }


    }
}
