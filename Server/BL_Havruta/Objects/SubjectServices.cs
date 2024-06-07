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
    internal class SubjectServices : ISubjectServices
    {
        DAL_Havruta.Interface.IDal dal = DAL_Havruta.Objects.DAL.Instance;
        private readonly IMapper mapper;
        public SubjectServices(IMapper mapper)
        { 
       
            this.mapper = mapper;
        }
        public bool AddNew(DTO_Havruta.Model.Subject newSubject)
        {
            return dal.SubjectDal.AddNew(mapper.Map<DAL_Havruta.Migrations.Model.Subject>(newSubject));
        }

        public bool Delete(DTO_Havruta.Model.Subject deleteSubject)
        {
            return dal.SubjectDal.Delete(mapper.Map<DAL_Havruta.Migrations.Model.Subject>(deleteSubject));
        }

        public IEnumerable<DTO_Havruta.Model.Subject> GetAll()
        {
            try 
            {
                IEnumerable<DAL_Havruta.Migrations.Model.Subject> subjects = dal.SubjectDal.GetAll();
                MapperConfiguration configuration = new MapperConfiguration(mcfg => mcfg.CreateMap<DTO_Havruta.Model.Subject, DAL_Havruta.Migrations.Model.Subject>()
                .ReverseMap());
                var mapper = configuration.CreateMapper();
                IEnumerable<DTO_Havruta.Model.Subject> subjectsList = subjects.Select(x => mapper.Map<DTO_Havruta.Model.Subject>(x));
                return subjectsList;    
            }
            catch (Exception ex) 
            { 
            throw new NotImplementedException();
            }
        }

        public DTO_Havruta.Model.Subject GetById(int id)
        {
            DTO_Havruta.Model.Subject getByIdSubject;
            getByIdSubject = mapper.Map<DTO_Havruta.Model.Subject>(id); 
            return getByIdSubject;
        }

        public bool Update(DTO_Havruta.Model.Subject updateSubject)
        {
            return dal.SubjectDal.Update(mapper.Map<DAL_Havruta.Migrations.Model.Subject>(updateSubject));
        }
    }
}
