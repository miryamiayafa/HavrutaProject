using System;
using System.Data.SqlTypes;
using DAL_Havruta.Migrations.Model;

namespace DAL_Havruta.Interfase;

public interface IUserDal
{
    IEnumerable<User> GetAll();
    User GetById(int id);

    User GetByEmail(string email);
    int AddNew(User NewUser); 

    bool Delete(User DeleteUser);
    bool IsUserExsit(int id);
    int Login(string userName, string password);
    IEnumerable<DTO_Havruta.Model.UserInformation> GetUserSubjectInfo();
}

