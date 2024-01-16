using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace BL_Havruta
{
    public class MappingProfile : AutoMapper.Profile
    {
        public MappingProfile() 
        { 
            CreateMap<DAL_Havruta.Model.Manager, DTO_Havruta.Model.Manager>().ReverseMap();
            CreateMap<DAL_Havruta.Model.Request, DTO_Havruta.Model.Request>().ReverseMap(); 
            CreateMap<DAL_Havruta.Model.Study, DTO_Havruta.Model.Study>().ReverseMap(); 
            CreateMap<DAL_Havruta.Model.StudyCriterion, DTO_Havruta.Model.StudyCriterion>().ReverseMap();
            CreateMap<DAL_Havruta.Model.StudyTime, DTO_Havruta.Model.StudyTime>().ReverseMap();
            CreateMap<DAL_Havruta.Model.StudyType, DTO_Havruta.Model.StudyType>().ReverseMap();    
            CreateMap<DAL_Havruta.Model.Subject, DTO_Havruta.Model.Subject>().ReverseMap();    
            CreateMap<DAL_Havruta.Model.User, DTO_Havruta.Model.User>().ReverseMap();
        
        } 
    }
    
    
}
