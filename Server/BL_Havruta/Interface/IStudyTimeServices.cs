using DAL_Havruta.Migrations.Model;
using System;

namespace BL_Havruta.Interface;

public interface IStudyTimeServices
{
    IEnumerable<DTO_Havruta.Model.StudyTime> GetAll();
    bool AddNew(DTO_Havruta.Model.StudyTime newStudyTime);
    DTO_Havruta.Model.StudyTime GetById(int id);
    bool Delete(DTO_Havruta.Model.StudyTime deleteStudyTime);
    bool Update(DTO_Havruta.Model.StudyTime updateStudyTime);

    int GetTheNuberOfTodayStudyForUser(int userId);
}
