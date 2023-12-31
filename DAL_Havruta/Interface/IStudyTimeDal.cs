﻿using System;
using DAL_Havruta.Model;

namespace DAL_Havruta.Interfase
{
    public interface IStudyTimeDal
    {
        IEnumerable<StudyTime> GetAll();
        StudyTime GetById(int id);
        bool Update(StudyTime studyTime);   
        bool Delete(StudyTime studyTime);
        bool AddNew(StudyTime studyTime);   


    }
}

