using System;
using DAL_Havruta.Migrations.Model;

namespace DAL_Havruta.Interfase
{
    public interface ISubjectDal
    {
        IEnumerable<Subject> GetAll();
        Subject GetById(int id); 
        bool Update(Subject subject);   
        bool Delete(Subject subject);   
        bool AddNew(Subject subject);
    }
}

