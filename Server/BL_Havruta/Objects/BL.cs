using AutoMapper;
using BL_Havruta.Interface;
using DAL_Havruta.Interfase;
using DAL_Havruta.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL_Havruta.Objects;

public class BL : IBL
{
    private readonly IMapper mapper;

    public static readonly IBL Instance = new BL();
    private BL()
    {
        var mapping = new MapperConfiguration(mc =>
        {
            mc.AddProfile(new MappingProfile());
        });
        mapper = mapping.CreateMapper();
    }

    public ICommentsServices CommentsServices => throw new NotImplementedException();

    public IManagerServices ManagerServices => new ManagerServices(mapper);

    public IRequestServices RequestServices => new RequestServices(mapper);

    public IStudyCriteriaServices StudyCriteriaServices => new StudyCriteriaServices(mapper);

    public IStudyServices StudyServices => new StudyServices(mapper);

    public IStudyTimeServices StudyTimeServices => new StudyTimeServices(mapper);

    public IStudyTypeServices studyTypeServices => new StudyTypeServices(mapper);

    public IUserServices userServices => new UserServices(mapper);

    public IUserStudyTypeDal userStudyTypeDal => throw new NotImplementedException();

    public IUserSubjectDal subjectDal => throw new NotImplementedException();
}
