using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BL_Havruta.Interface;
using DAL_Havruta.Interfase;
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
        public bool AddNew(StudyType newStudyType)
        {
            return dal.studyTypeDal.AddNew(mapper.Map<DAL_Havruta.Model.StudyType>(newStudyType));
        }

        public bool Delete(StudyType deleteStudyType)
        {
            return dal.studyTypeDal.Delete(mapper.Map<DAL_Havruta.Model.StudyType>(deleteStudyType));
        }

        public IEnumerable<DTO_Havruta.Model.StudyType> GetAll()
        {
            try
            {
                IEnumerable<DAL_Havruta.Model.StudyType> studyTypes = dal.studyTypeDal.GetAll();
                MapperConfiguration configuration = new MapperConfiguration(mcfg => mcfg.CreateMap<DTO_Havruta.Model.StudyType, DAL_Havruta.Model.StudyType>()
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

        public StudyType GetById(int id)
        {
            StudyType getByIdStudyTypeBL;
            getByIdStudyTypeBL = mapper.Map<DTO_Havruta.Model.StudyType>(dal.studyTypeDal.GetById(id));
            return getByIdStudyTypeBL;  
        }

        public bool Update(StudyType updateStudyType)
        {
            return dal.studyTypeDal.Update(mapper.Map<DAL_Havruta.Model.StudyType>(updateStudyType));    
        }
    }
}
