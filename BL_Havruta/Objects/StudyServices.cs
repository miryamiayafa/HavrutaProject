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
    public class StudyServices : IStudyServices
    {
        private readonly DAL_Havruta.Interfase.IStudyDal dal;
        private readonly IMapper mapper;
        public StudyServices(IStudyDal dal, IMapper mapper)
        {
            this.dal = dal;
            this.mapper = mapper;
        }
        public bool AddNew(Study newStudy)
        {
            return dal.AddNew(mapper.Map<DAL_Havruta.Model.Study>(newStudy));
        }

        public bool Delete(Study deleteStudy)
        {
            return dal.Delete(mapper.Map<DAL_Havruta.Model.Study>(deleteStudy));
        }

        public IEnumerable<DTO_Havruta.Model.Study> GetAll()
        {
            try
            {
                IEnumerable<DAL_Havruta.Model.Study> studies = dal.GetAll();
                MapperConfiguration configuration = new MapperConfiguration(mcfg => mcfg.CreateMap<DTO_Havruta.Model.Study, DAL_Havruta.Model.Study>()
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

        public Study GetById(int id)
        {
            Study getByIdStudyBL;
            getByIdStudyBL = mapper.Map<DTO_Havruta.Model.Study>(dal.GetById(id));
            return getByIdStudyBL;
        }

        public bool Update(Study updateStudy)
        {
            return dal.Update(mapper.Map<DAL_Havruta.Model.Study>(updateStudy));
        }
    }
}
