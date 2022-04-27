using System;
using Entities;
using System.Collections.Generic;
using System.ComponentModel;

namespace BLL.Main
{
    public class PersonBL
    {
        private BindingList<User> userList = new BindingList<User>();

        public BindingList<User> GetAll()
        {
            return userList;
        }

    }
}
