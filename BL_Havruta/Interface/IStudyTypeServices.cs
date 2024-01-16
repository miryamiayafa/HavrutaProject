using DAL_Havruta.Model;
using System;

namespace BL_Havruta.Interface
{
    public interface IStudyTypeServices
    {
        IEnumerable<DTO_Havruta.Model.StudyType> GetAll();
        bool AddNew(DTO_Havruta.Model.StudyType newStudyType);
        DTO_Havruta.Model.StudyType GetById(int id);
        bool Delete(DTO_Havruta.Model.StudyType deleteStudyType);
        bool Update(DTO_Havruta.Model.StudyType updateStudyType);

    }

}

