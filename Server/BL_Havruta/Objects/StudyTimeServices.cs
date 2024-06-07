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
using Microsoft.EntityFrameworkCore.Migrations;

namespace BL_Havruta.Objects
{
    internal class StudyTimeServices : IStudyTimeServices
    {
        DAL_Havruta.Interface.IDal dal = DAL_Havruta.Objects.DAL.Instance;
        private readonly IMapper mapper;

        public StudyTimeServices(IMapper mapper)
        {
            this.mapper = mapper;
        }
        public bool AddNew(DTO_Havruta.Model.StudyTime newStudyTime)
        {
            return dal.studyTimeDal.AddNew(mapper.Map<DAL_Havruta.Migrations.Model.StudyTime>(newStudyTime));
        }

        public bool Delete(DTO_Havruta.Model.StudyTime deleteStudyTime)
        {
            return dal.studyTimeDal.Delete(mapper.Map<DAL_Havruta.Migrations.Model.StudyTime>(deleteStudyTime));
        }

        public IEnumerable<DTO_Havruta.Model.StudyTime> GetAll()
        {
            try
            {
                IEnumerable<DAL_Havruta.Migrations.Model.StudyTime> studyTimes = dal.studyTimeDal.GetAll();
                MapperConfiguration configuration = new MapperConfiguration(mcfg => mcfg.CreateMap<DTO_Havruta.Model.StudyTime, DAL_Havruta.Migrations.Model.StudyTime>()
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

        public DTO_Havruta.Model.StudyTime GetById(int id)
        {
            DTO_Havruta.Model.StudyTime getByIdStudyTimeBL;
            getByIdStudyTimeBL = mapper.Map<DTO_Havruta.Model.StudyTime>(dal.studyTimeDal.GetById(id));
            return getByIdStudyTimeBL;  

        }

        public int GetTheNuberOfTodayStudyForUser(int userId)
        {
            try
            {
                return dal.studyTimeDal.GetThenumberOfTodayEventForUser(userId);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }

        public bool Update(DTO_Havruta.Model.StudyTime updateStudyTime)
        {
            return dal.studyTimeDal.Update(mapper.Map<DAL_Havruta.Migrations.Model.StudyTime>(updateStudyTime));    
        }
    }
}
