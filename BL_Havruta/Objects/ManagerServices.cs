using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL_Havruta.Interface;
using DTO_Havruta.Model;

namespace BL_Havruta.Objects
{
    public class ManagerServices : IManagerServices
    {
        public bool AddNew(Manager manager)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Manager deleteManager)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Manager> getAll()
        {
            throw new NotImplementedException();
        }

        public Manager GetByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public Manager GetById(int id)
        {
            throw new NotImplementedException();
        } 
    }
}
