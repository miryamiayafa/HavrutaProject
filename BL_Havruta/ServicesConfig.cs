using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace BL_Havruta
{
    public static class ServicesConfig
    {
        public static void AddBLServices(this IServiceCollection collection)
        {
            collection.AddScoped(typeof(BL_Havruta.Interface.IUserServices), typeof(BL_Havruta.Objects.UserServices));
            collection.AddScoped(typeof(BL_Havruta.Interface.IManagerServices), typeof(BL_Havruta.Objects.ManagerServices));
            collection.AddScoped(typeof(BL_Havruta.Interface.IRequestServices) ,typeof(BL_Havruta.Objects.RequestServices));
            collection.AddScoped(typeof(BL_Havruta.Interface.IStudyCriteriaServices) ,typeof(BL_Havruta.Objects.StudyCriteriaServices));
            collection.AddScoped(typeof(BL_Havruta.Interface.IStudyServices), typeof(BL_Havruta.Objects.StudyServices));
            collection.AddScoped(typeof(BL_Havruta.Interface.IStudyTimeServices), typeof(BL_Havruta.Objects.StudyTimeServices));
            collection.AddScoped(typeof(BL_Havruta.Interface.IStudyTypeServices), typeof(BL_Havruta.Objects.StudyTypeServices));
            collection.AddScoped(typeof(BL_Havruta.Interface.ISubjectServices), typeof(BL_Havruta.Objects.SubjectServices));
            //collection.AddScoped(typeof(BL_Havruta.Interface.ICommentsServices), typeof(BL_Havruta.Objects.)

            collection.AddDbContext<DAL_Havruta.DB.HavrutaDbContext>();
            var mapping = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfile());
            });
            
            IMapper mapper = mapping.CreateMapper();
            collection.AddSingleton(mapper);    
        
        }
    }
}
