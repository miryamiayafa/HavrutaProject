using DAL_Havruta.Interface;
using DAL_Havruta.Interfase;
using DAL_Havruta.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Havruta.Objects;

public class DAL : IDal
{
    private readonly DB.HavrutaDbContext context = new DB.HavrutaDbContext();

    private DAL(){ }

    public static readonly IDal Instance = new DAL(); 


    public ICommentsDal CommentsDal => new CommentsDal(context);

    public IManagerDal ManagerDal => new ManagerDal(context);

    public IRequestDal RequestDal => new RequestDal(context);
    public IStudyDal studyDal => new StudyDal(context);

    public IStudyCriteriaDal studyCriteriaDal => new StudyCriteria(context);

    public IStudyTimeDal studyTimeDal => new StudyTimeDal(context);

    public IStudyTypeDal studyTypeDal => new StudyTypeDal(context);

    public IUserDal UserDal => new UserDal(context);

    public IUserStudyTypeDal UserStudyType => throw new NotImplementedException();

    public IUserSubjectDal UserSubjectDal => throw new NotImplementedException();

    public ISubjectDal SubjectDal => new SubjectDal(context);

    //public IUserStudyTypeDal UserStudyType => new UserStudyTypeDal(context);

    //public IUserSubjectDal UserSubjectDal => new UserSubjectDal (context);
}
