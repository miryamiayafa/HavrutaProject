using DAL_Havruta.Model;
using System;

namespace BL_Havruta.Interface
{
    public interface ISubjectServices
    {
        IEnumerable<DTO_Havruta.Model.Subject> GetAll();
        bool AddNew(DTO_Havruta.Model.Subject newSubject);
        DTO_Havruta.Model.Subject GetById(int id);
        bool Delete(DTO_Havruta.Model.Subject deleteSubject);
        bool Update(DTO_Havruta.Model.Subject updateSubject);

    }

}
