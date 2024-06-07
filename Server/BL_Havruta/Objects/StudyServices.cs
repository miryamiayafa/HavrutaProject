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
    public class StudyServices : IStudyServices
    {
        DAL_Havruta.Interface.IDal dal = DAL_Havruta.Objects.DAL.Instance;
        private readonly IMapper mapper;
        public StudyServices(IMapper mapper)
        {
   
            this.mapper = mapper;
        }
        public bool AddNew(DTO_Havruta.Model.Study newStudy)
        {
            return dal.studyDal.AddNew(mapper.Map<DAL_Havruta.Migrations.Model.Study>(newStudy));
        }

        public bool Delete(DTO_Havruta.Model.Study deleteStudy)
        {
            return dal.studyDal.Delete(mapper.Map<DAL_Havruta.Migrations.Model.Study>(deleteStudy));
        }

        public IEnumerable<DTO_Havruta.Model.Study> GetAll()
        {
            try
            {
                IEnumerable<DAL_Havruta.Migrations.Model.Study> studies = dal.studyDal.GetAll();
                MapperConfiguration configuration = new MapperConfiguration(mcfg => mcfg.CreateMap<DTO_Havruta.Model.Study, DAL_Havruta.Migrations.Model.Study>()
                .ReverseMap());
                var mapper = configuration.CreateMapper();
                IEnumerable<DTO_Havruta.Model.Study> studiesList = studies.Select(x => mapper.Map<DTO_Havruta.Model.Study>(x));
                return studiesList;
            }
            catch (Exception ex) 
            { 
            throw new NotImplementedException();
            }
        }

        public DTO_Havruta.Model.Study GetById(int id)
        {
            DTO_Havruta.Model.Study getByIdStudyBL;
            getByIdStudyBL = mapper.Map<DTO_Havruta.Model.Study>(dal.studyDal.GetById(id));
            return getByIdStudyBL;
        }

        public bool Update(DTO_Havruta.Model.Study updateStudy)
        {
            return dal.studyDal.Update(mapper.Map<DAL_Havruta.Migrations.Model.Study>(updateStudy));
        }
    }
}
