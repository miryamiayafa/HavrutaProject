using System;
using DAL_Havruta.Interfase;
using DAL_Havruta.Model;

namespace DAL_Havruta.Objects
{
   public class StudyTimeDal : IStudyTimeDal
    {
        private readonly DB.HavrutaDbContext context;
        public StudyTimeDal(DB.HavrutaDbContext _context)
        { 
        this.context = _context;
        }

        public bool AddNew(StudyTime studyTime)
        {
            try
            {
                if (studyTime != null)
                {
                    context.StudyTimes.Add(studyTime);
                }

                return true;


            }
            catch (Exception ex)
            {
                throw new Exception();
            }

        }




        public bool Delete(StudyTime studyTime)
        {
            StudyTime studyTimeTry = GetById(studyTime.Idtime);
            try
            {
                if (studyTimeTry != null)
                    context.StudyTimes.Remove(studyTime);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception();
            }



        }

        public bool Update(StudyTime studyTime)
        {
            StudyTime StudyTimeTry = GetById(studyTime.Idtime);
            try
            {
                if (StudyTimeTry != null)
                    context.StudyTimes.Update(studyTime);
                return true;

            }
            catch (Exception ex)
            {
                throw new Exception();
            }



        }

        public IEnumerable<StudyTime> GetAll()
        {
            try
            {
                return context.StudyTimes.ToList();

            }
            catch (Exception ex)
            {
                throw new Exception();
            }
        }


        public StudyTime GetById(int id)
        {

            try
            {
                return (StudyTime) GetAll().Where(x => x.Idtime == id);
            }
            catch (Exception ex)
            {
                throw new Exception();
            }

        }

    }
}