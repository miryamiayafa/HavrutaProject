using System;
using DAL_Havruta.Interfase;
using System.Runtime.CompilerServices;
using DAL_Havruta.Migrations.Model;

namespace DAL_Havruta.Objects
{
    public class StudyDal : IStudyDal
    {
        private readonly DB.HavrutaDbContext context;

        public StudyDal(DB.HavrutaDbContext _context)
        {
            this.context = _context;
        }

        public bool AddNew(Study study)
        {
            try
            {
                if (study != null)
                {
                    context.Studies.Add(study);
                }

                return true;


            }
            catch (Exception ex)
            {
                throw new Exception();
            }

        }




        public bool Delete(Study study)
        {
            Study studyTry = GetById (study.Idstudy);
            try
            {
                if (studyTry != null)
                    context.Studies.Remove(study);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception();
            }



        }

        public bool Update(Study study)
        {
            Study StudyTry = GetById(study.Idstudy);
            try
            {
                if (StudyTry != null)
                    context.Studies.Update(study);
                return true;

            }
            catch (Exception ex)
            {
                throw new Exception();
            }



        }

        public IEnumerable<Study> GetAll()
        {
            try
            {
                return context.Studies.ToList();

            }
            catch (Exception ex)
            {
                throw new Exception();
            }
        }


        public Study GetById(int id)
        {

            try
            {
                return (Study)GetAll().Where(x => x.Idstudy == id);
            }
            catch (Exception ex)
            {
                throw new Exception();
            }

        }

    }
}




