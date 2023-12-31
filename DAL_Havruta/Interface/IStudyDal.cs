using System;
using DAL_Havruta.Model;

namespace DAL_Havruta.Interfase
{
    public interface IStudyDal
    {
        IEnumerable<Study> GetAll();
        Study GetById(int id);  
        bool Update(Study study);   
        bool Delete(Study study);   
        bool AddNew(Study study);   

    }
}

