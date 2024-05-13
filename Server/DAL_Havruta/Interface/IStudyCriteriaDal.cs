using System;
using DAL_Havruta.Model;

namespace DAL_Havruta.Interfase
{
    public interface IStudyCriteriaDal
    {
        IEnumerable<StudyCriterion> GetAll();
        StudyCriterion GetById(int id);
        bool AddNew(StudyCriterion addStudyCriterion); 
        bool Delete(StudyCriterion deleteStudyCriterion);   
        bool Update(StudyCriterion updateStudyCriterion);   





    }
}


