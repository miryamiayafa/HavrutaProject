﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL_Havruta.Interface;
using DTO_Havruta.Model;

namespace BL_Havruta.Objects
{
    internal class UserServices : IUserServices
    {
        public bool AddNew(User newUser)
        {
            throw new NotImplementedException();
        }

        public bool Delete(User deleteUser)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetAll()
        {
            throw new NotImplementedException();
        }

        public User GetById(int id)
        {
            throw new NotImplementedException();
        }

        public User GetByUser(string emaile)
        {
            throw new NotImplementedException();
        }
    }
}
