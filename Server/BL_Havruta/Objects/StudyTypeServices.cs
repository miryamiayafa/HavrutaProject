using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BL_Havruta.Interface;
using DAL_Havruta.Interfase;
using DAL_Havruta.Migrations.Model;
using DTO_Havruta.Model;

namespace BL_Havruta.Objects
{
    internal class StudyTypeServices : IStudyTypeServices
    {
        DAL_Havruta.Interface.IDal dal = DAL_Havruta.Objects.DAL.Instance;
        private readonly IMapper mapper;
        public StudyTypeServices(IMapper mapper)
        {
            
            this.mapper = mapper;
        }
        public bool AddNew(DTO_Havruta.Model.StudyType newStudyType)
        {
            return dal.studyTypeDal.AddNew(mapper.Map<DAL_Havruta.Migrations.Model.StudyType>(newStudyType));
        }

        public bool Delete(DTO_Havruta.Model.StudyType deleteStudyType)
        {
            return dal.studyTypeDal.Delete(mapper.Map<DAL_Havruta.Migrations.Model.StudyType>(deleteStudyType));
        }

        public IEnumerable<DTO_Havruta.Model.StudyType> GetAll()
        {
            try
            {
                IEnumerable<DAL_Havruta.Migrations.Model.StudyType> studyTypes = dal.studyTypeDal.GetAll();
                MapperConfiguration configuration = new MapperConfiguration(mcfg => mcfg.CreateMap<DTO_Havruta.Model.StudyType, DAL_Havruta.Migrations.Model.StudyType>()
                .ReverseMap());
                var mapper = configuration.CreateMapper();
                IEnumerable<DTO_Havruta.Model.StudyType> studyTypesList = studyTypes.Select(x => mapper.Map<DTO_Havruta.Model.StudyType>(x));
                return studyTypesList;
            }
            catch (Exception ex)
            {
                throw new NotImplementedException();
            }
        }

        public DTO_Havruta.Model.StudyType GetById(int id)
        {
            DTO_Havruta.Model.StudyType getByIdStudyTypeBL;
            getByIdStudyTypeBL = mapper.Map<DTO_Havruta.Model.StudyType>(dal.studyTypeDal.GetById(id));
            return getByIdStudyTypeBL;  
        }

        public bool Update(DTO_Havruta.Model.StudyType updateStudyType)
        {
            return dal.studyTypeDal.Update(mapper.Map<DAL_Havruta.Migrations.Model.StudyType>(updateStudyType));    
        }
    }
}
