using DAL_Havruta.Interfase;
using DAL_Havruta.Migrations.Model;


namespace DAL_Havruta.Objects
{
    public class SubjectDal : ISubjectDal
    {

        private readonly DB.HavrutaDbContext context;
        public SubjectDal(DB.HavrutaDbContext _context)
        {
            this.context = _context;
        }

        public bool AddNew(Subject subject)
        {
            try
            {
                if (subject != null)
                {
                    context.Subjects.Add(subject);
                }

                return true;


            }
            catch (Exception ex)
            {
                throw new Exception();
            }

        }




        public bool Delete(Subject subject)
        {
            Subject subjectTry = GetById(subject.Idsubject);
            try
            {
                if (subjectTry != null)
                    context.Subjects.Remove(subject);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception();
            }



        }

        public bool Update(Subject subject)
        {
            Subject subjectTry = GetById(subject.Idsubject);
            try
            {
                if (subjectTry != null)
                    context.Subjects.Update(subject);
                return true;

            }
            catch (Exception ex)
            {
                throw new Exception();
            }



        }

        public IEnumerable<Subject> GetAll()
        {
            try
            {
                return context.Subjects.ToList();

            }
            catch (Exception ex)
            {
                throw new Exception();
            }
        }


        public Subject GetById(int id)
        {

            try
            {
                return (Subject)GetAll().Where(x => x.Idsubject == id);
            }
            catch (Exception ex)
            {
                throw new Exception();
            }

        }






    }


}



