using System;
using DAL_Havruta.Model;
namespace DAL_Havruta.Interfase
{
    public interface IUserSubjectDal
    {
        IEnumerable<UserSubject> GetAll();
        UserSubject GetById(int id);    
        bool Update(UserSubject userSubject);   
        bool Delete(UserSubject userSubject);    
        bool AddNew(UserSubject userSubject);   
    }
}

