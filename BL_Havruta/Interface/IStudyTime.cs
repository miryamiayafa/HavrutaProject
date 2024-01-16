﻿using DAL_Havruta.Model;
using System;

namespace BL_Havruta.Interface
{
    public interface IStudyTime
    {
        IEnumerable<DTO_Havruta.Model.StudyTime> GetAll();
        bool AddNew(DTO_Havruta.Model.StudyTime newStudyTime);
        DTO_Havruta.Model.StudyTime GetById(int id);
        bool Delete(DTO_Havruta.Model.StudyTime deleteStudyTime);
        bool Update(DTO_Havruta.Model.StudyTime updateStudyTime);

    }

}
