using DAL_Havruta.Interfase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL_Havruta.Interface;

public interface IBL
{
    ICommentsServices CommentsServices { get; }
    IManagerServices ManagerServices { get; }
    IRequestServices RequestServices { get; }
    IStudyCriteriaServices StudyCriteriaServices { get; }
    IStudyServices StudyServices { get; }
    IStudyTimeServices StudyTimeServices { get; }
    IStudyTypeServices studyTypeServices { get; }
    IUserServices userServices { get; }
    IUserStudyTypeDal userStudyTypeDal { get; }
    IUserSubjectDal subjectDal { get; }


}
