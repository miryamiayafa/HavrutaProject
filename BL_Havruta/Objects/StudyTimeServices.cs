using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BL_Havruta.Interface;
using DAL_Havruta.Interfase;
using DTO_Havruta.Model;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BL_Havruta.Objects
{
    internal class StudyTimeServices : IStudyTimeServices
    {
        private readonly DAL_Havruta.Interfase.IStudyTimeDal dal;
        private readonly IMapper mapper;

        public StudyTimeServices(IStudyTimeDal dal, IMapper mapper)
        {
            this.dal = dal;
            this.mapper = mapper;
        }
        public bool AddNew(StudyTime newStudyTime)
        {
            return dal.AddNew(mapper.Map<DAL_Havruta.Model.StudyTime>(newStudyTime));
        }

        public bool Delete(StudyTime deleteStudyTime)
        {
            return dal.Delete(mapper.Map<DAL_Havruta.Model.StudyTime>(deleteStudyTime));
        }

        public IEnumerable<DTO_Havruta.Model.StudyTime> GetAll()
        {
            try
            {
                IEnumerable<DAL_Havruta.Model.StudyTime> studyTimes = dal.GetAll();
                MapperConfiguration configuration = new MapperConfiguration(mcfg => mcfg.CreateMap<DTO_Havruta.Model.StudyTime, DAL_Havruta.Model.StudyTime>()
                .ReverseMap());
                var mapper = configuration.CreateMapper();
                IEnumerable<DTO_Havruta.Model.StudyTime> studyTimesList = studyTimes.Select(x => mapper.Map<DTO_Havruta.Model.StudyTime>(x));
                return studyTimesList;
            }
            catch (Exception ex)
            {
                throw new NotImplementedException();
            }
        }

        public StudyTime GetById(int id)
        {
            StudyTime getByIdStudyTimeBL;
            getByIdStudyTimeBL = mapper.Map<DTO_Havruta.Model.StudyTime>(dal.GetById(id));
            return getByIdStudyTimeBL;  

        }

        public bool Update(StudyTime updateStudyTime)
        {
            return dal.Update(mapper.Map<DAL_Havruta.Model.StudyTime>(updateStudyTime));    
        }
    }
}
