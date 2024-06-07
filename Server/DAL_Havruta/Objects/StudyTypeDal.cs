using System;
using DAL_Havruta.Interfase;
using DAL_Havruta.Migrations.Model;

namespace DAL_Havruta.Objects
{
    public class StudyTypeDal : IStudyTypeDal
    {
        private readonly DB.HavrutaDbContext context;
        public StudyTypeDal(DB.HavrutaDbContext _context) 
         { 
            this.context = _context;    
        }

        public bool AddNew(StudyType studyType)
        {
            try
            {
                if (studyType != null)
                {
                    context.StudyTypes.Add(studyType);
                }

                return true;


            }
            catch (Exception ex)
            {
                throw new Exception();
            }

        }




        public bool Delete(StudyType studyType)
        {
            StudyType studyTypeTry = GetById(studyType.Idstudy);
            try
            {
                if (studyTypeTry != null)
                    context.StudyTypes.Remove(studyType);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception();
            }



        }

        public bool Update(StudyType studyType)
        {
            StudyType StudyTypeTry = GetById(studyType.Idstudy);
            try
            {
                if (StudyTypeTry != null)
                    context.StudyTypes.Update(studyType);
                return true;

            }
            catch (Exception ex)
            {
                throw new Exception();
            }



        }

        public IEnumerable<StudyType> GetAll()
        {
            try
            {
                return context.StudyTypes.ToList();

            }
            catch (Exception ex)
            {
                throw new Exception();
            }
        }


        public StudyType GetById(int id)
        {

            try
            {
                return (StudyType)GetAll().Where(x => x.Idstudy == id);
            }
            catch (Exception ex)
            {
                throw new Exception();
            }

        }

    }
}