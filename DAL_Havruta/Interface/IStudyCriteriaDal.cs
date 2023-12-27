using System;
using DAL_Havruta.Model;

namespace DAL_Havruta.Interfase
{
    public interface IStudyCriteriaDal
    {
        IEnumerable<StudyCriterion> GetAll();
        StudyCriterion GetById(int id);
        bool AddNew(StudyCriterion AddStudyCriterion); 
        bool Delete(StudyCriterion DeleteStudyCriterion);   
        bool Update(StudyCriterion UpdateStudyCriterion);   





    }
}


