using DAL_Havruta.Model;
using System;

namespace BL_Havruta.Interface
{
    public interface IStudyCriteriaServices
    {
        IEnumerable<DTO_Havruta.Model.StudyCriterion> GetAll();
        bool AddNew(DTO_Havruta.Model.StudyCriterion newStudyCriterion);
        DTO_Havruta.Model.StudyCriterion GetById(int id);
        bool Delete(DTO_Havruta.Model.StudyCriterion deleteStudyCriterion);
        bool Update(DTO_Havruta.Model.StudyCriterion updateStudyCriterion);

    }

}
