using DAL.DB;
using Entities;
using Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Task1.Controllers
{

    public class UserController : Controller
    {
        IPersonDAO personDAO = new PersonDAO();
        IAwardDAO awardDAO = new AwardDAO();

        IEnumerable<User> users;

        [HttpGet]

        public IActionResult UserIndex()
        {
            var users = personDAO.GetAll();

            return View(users);
        }

        [HttpPost]
        public IActionResult UserDelete(int userID)
        {
            var user = personDAO.GetUser(userID);

            personDAO.RemoveUser(user);

            return RedirectToAction("UserIndex");
        }

        [HttpGet]
        public IActionResult UserAdd()
        {
            return View(new UserViewModel());
        }

        [HttpPost]
        public IActionResult UserAdd(UserViewModel user, int[] awardIDList)
        {
            if (!ModelState.IsValid)
            {
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

            int userID = personDAO.AddUser(userToAdd);

            userToAdd = personDAO.GetUser(userID);

            foreach (var award in awardDAO.GetAll())
            {
                if (awardIDList.Contains(award.ID))
                {
                    personDAO.AddUserAward(userToAdd, award);
                }
            }

            return RedirectToAction("UserIndex");
        }

        [HttpGet]
        public IActionResult UserUpdate(int userID)
        {
            var user = personDAO.GetUser(userID);

            var userToUpdate = new UserViewModel(user);

            return View(userToUpdate);
        }

        [HttpPost]
        public IActionResult UserUpdate(UserViewModel user, int[] awardIDList)
        {
            if (!ModelState.IsValid)
            {
                var newUser = personDAO.GetUser(user.ID);

                user = new UserViewModel(newUser);

                return View(user);

            }

            personDAO.UpdateUser(user.ID, user.FirstName, user.LastName, user.BirthDate);

            var userToUpdate = new User
            {
                ID = user.ID,
                FirstName = user.FirstName,
                LastName = user.LastName,
                BirthDate = user.BirthDate,
                UserAwards = user.UserAwards
            };

            userToUpdate = personDAO.GetUser(userToUpdate.ID);

            foreach (var award in awardDAO.GetAll())
            {
                if (awardIDList.Contains(award.ID) && !userToUpdate.UserAwards.Contains(award))
                {
                    personDAO.AddUserAward(userToUpdate, award);
                }
                else if (userToUpdate.UserAwards.Contains(award) && !awardIDList.Contains(award.ID))
                {
                    personDAO.RemoveAward(userToUpdate.ID, award);
                }

            }

            return RedirectToAction("UserIndex");
        }

        [HttpGet]
        public IActionResult UserOrder(int fieldIndex, SortDirection sortDirection = SortDirection.Desc)
        {
            personDAO.GetAll();

            ViewBag.SortDirection = sortDirection == SortDirection.Asc ? SortDirection.Desc : SortDirection.Asc;    

            users = personDAO.OrderUserByField(fieldIndex, sortDirection);

            return View("UserIndex", users);
        }
    }
}
