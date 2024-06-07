using System;
using DAL_Havruta.Migrations.Model;

namespace DAL_Havruta.Interfase
{
    public interface IStudyTypeDal
    {
        IEnumerable<StudyType> GetAll();
        StudyType GetById(int id);
        bool Update(StudyType studyType);   
        bool Delete(StudyType studyType);
        bool AddNew(StudyType studyType);   
    }
}

