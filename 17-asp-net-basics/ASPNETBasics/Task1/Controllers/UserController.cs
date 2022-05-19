using Entities;
using Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Task1.Controllers
{

    public class UserController : Controller
    {
        IPersonBL personBL;
        IAwardBL awardBL;

        public UserController(IPersonBL personBL, IAwardBL awardBL)
        {
            this.personBL = personBL;
            this.awardBL = awardBL;
        }

        [HttpGet]

        public IActionResult UserIndex()
        {
            var users = personBL.GetAll();

            return View(users);
        }

        [HttpPost]
        public IActionResult UserDelete(int userID)
        {
            var user = personBL.GetUser(userID);

            personBL.RemoveUser(user);

            return RedirectToAction("UserIndex");
        }

        [HttpGet]
        public IActionResult UserAdd()
        {
            ViewBag.AllAwards = awardBL.GetAll();

            return View(new UserViewModel());
        }

        [HttpPost]
        public IActionResult UserAdd(UserViewModel user, int[] awardIDList)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.AllAwards = awardBL.GetAll();

                return View();
            }


            var userToAdd = new User
            {
                ID = user.ID,
                FirstName = user.FirstName,
                LastName = user.LastName,
                BirthDate = user.BirthDate,
                UserAwards = user.UserAwards
            };

            int userID = personBL.AddUser(userToAdd);

            userToAdd = personBL.GetUser(userID);

            foreach (var award in awardBL.GetAll())
            {
                if (awardIDList.Contains(award.ID))
                {
                    personBL.AddUserAward(userToAdd, award);
                }
            }

            return RedirectToAction("UserIndex");
        }

        [HttpGet]
        public IActionResult UserUpdate(int userID)
        {
            ViewBag.AllAwards = awardBL.GetAll();

            var user = personBL.GetUser(userID);

            var userToUpdate = new UserViewModel(user);

            return View(userToUpdate);
        }

        [HttpPost]
        public IActionResult UserUpdate(UserViewModel user, int[] awardIDList)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.AllAwards = awardBL.GetAll();

                var newUser = personBL.GetUser(user.ID);

                user = new UserViewModel(newUser);

                return View(user);

            }

            personBL.UpdateUser(user.ID, user.FirstName, user.LastName, user.BirthDate);

            var userToUpdate = new User
            {
                ID = user.ID,
                FirstName = user.FirstName,
                LastName = user.LastName,
                BirthDate = user.BirthDate,
                UserAwards = user.UserAwards
            };

            userToUpdate = personBL.GetUser(userToUpdate.ID);

            foreach (var award in awardBL.GetAll())
            {
                if (awardIDList.Contains(award.ID) && !userToUpdate.UserAwards.Contains(award))
                {
                    personBL.AddUserAward(userToUpdate, award);
                }
                else if (userToUpdate.UserAwards.Contains(award) && !awardIDList.Contains(award.ID))
                {
                    personBL.RemoveAward(userToUpdate.ID, award);
                }

            }

            return RedirectToAction("UserIndex");
        }

        [HttpGet]
        public IActionResult UserOrder(int fieldIndex, SortDirection sortDirection = SortDirection.Desc)
        {
            personBL.GetAll();

            ViewBag.SortDirection = sortDirection == SortDirection.Asc ? SortDirection.Desc : SortDirection.Asc;

            var users = personBL.OrderUserByField(fieldIndex, sortDirection);

            return View("UserIndex", users);
        }
    }
}
