using System;
using DAL_Havruta.Model;

namespace DAL_Havruta.Interfase
{
    public interface IUserStudyTypeDal
    {
        IEnumerable<UserStudyType> GetAll();
        UserStudyType GetById(int id);  
        bool Update(UserStudyType userStudyType);   
        bool Delete(UserStudyType userStudyType);
        bool AddNew(UserStudyType userStudyType);   

    }
}

