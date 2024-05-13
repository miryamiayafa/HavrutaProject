using DAL_Havruta.Interfase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Havruta.Interface;

public interface IDal
{
    
    ICommentsDal CommentsDal { get; }
    IManagerDal ManagerDal { get; }
    IRequestDal RequestDal { get; }
    IStudyDal studyDal { get; }
    IStudyCriteriaDal studyCriteriaDal { get; }
    IStudyTimeDal studyTimeDal { get; }
    IStudyTypeDal studyTypeDal { get; }
    IUserDal UserDal { get; }
    IUserStudyTypeDal UserStudyType { get; }
    IUserSubjectDal UserSubjectDal { get; }
    ISubjectDal SubjectDal { get; }


}
