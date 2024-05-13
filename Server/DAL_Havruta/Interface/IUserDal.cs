using System;
using System.Data.SqlTypes;
using DAL_Havruta.Model;

namespace DAL_Havruta.Interfase
{
    public interface IUserDal
    {
        IEnumerable<DAL_Havruta.Model.User> GetAll();
        Model.User GetById(int id);

        Model.User GetByEmail(string email);
        int AddNew(Model.User NewUser); 

        bool Delete(Model.User DeleteUser);
        bool IsUserExsit(int id);
        int Login(string userName, string password);
    }
}

