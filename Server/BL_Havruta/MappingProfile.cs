using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using DAL_Havruta.Migrations.Model;

namespace BL_Havruta;

public class MappingProfile : AutoMapper.Profile
{
    public MappingProfile() 
    { 
        CreateMap<Manager, DTO_Havruta.Model.Manager>().ReverseMap();
        CreateMap<Request, DTO_Havruta.Model.Request>().ReverseMap(); 
        CreateMap<Study, DTO_Havruta.Model.Study>().ReverseMap(); 
        CreateMap<StudyCriterion, DTO_Havruta.Model.StudyCriterion>().ReverseMap();
        CreateMap<StudyTime, DTO_Havruta.Model.StudyTime>().ReverseMap();
        CreateMap<StudyType, DTO_Havruta.Model.StudyType>().ReverseMap();    
        CreateMap<Subject, DTO_Havruta.Model.Subject>().ReverseMap();    
        CreateMap<User, DTO_Havruta.Model.User>().ReverseMap();
    
    } 
}


