using System;
using System.Data.SqlTypes;
using DAL_Havruta.Model;

namespace DAL_Havruta.Interfase
{
    public interface IUserDal
    {

        IEnumerable<DAL_Havruta.Model.User> GetAll();
        Model.User GetById(int id);

        Model.User Get(string email);
        bool AddNew(Model.User NewUser); 

        bool Delete(User DeleteUser);    

    }
}

