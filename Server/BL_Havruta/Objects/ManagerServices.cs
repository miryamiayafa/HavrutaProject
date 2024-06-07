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
    public class ManagerServices : IManagerServices
    {
        DAL_Havruta.Interface.IDal dal = DAL_Havruta.Objects.DAL.Instance;
        private readonly IMapper mapper;

        public ManagerServices(IMapper mapper)
        {
            this.mapper = mapper;   
         
        }
        public bool AddNew(DTO_Havruta.Model.Manager newManager)
        {
            return dal.ManagerDal.AddNew(mapper.Map<DAL_Havruta.Migrations.Model.Manager>(newManager));   
        }
        public IEnumerable<DTO_Havruta.Model.Manager> GetAll() 
        {
            try 
            { 
              IEnumerable<DAL_Havruta.Migrations.Model.Manager> managers = dal.ManagerDal.GetAll();
              MapperConfiguration configuration = new MapperConfiguration(mcfg => mcfg.CreateMap<DAL_Havruta.Migrations.Model.Manager, DTO_Havruta.Model.Manager>()
              .ReverseMap());
              var mapper = configuration.CreateMapper();
              IEnumerable<DTO_Havruta.Model.Manager> managerList = managers.Select(x => mapper.Map<DTO_Havruta.Model.Manager>(x));
              return managerList;
            }
            catch (Exception ex) 
            {
                throw new Exception("   " + ex);
            }
        }
        public DTO_Havruta.Model.Manager GetById(int id)
        {
            DTO_Havruta.Model.Manager getByIdManagerBL;
            getByIdManagerBL = mapper.Map < DTO_Havruta.Model.Manager > (dal.ManagerDal.GetById(id));
            return getByIdManagerBL;

        }
        public DTO_Havruta.Model.Manager GetByEmail(string email)
        {
            DTO_Havruta.Model.Manager getByEmailBL;
            getByEmailBL = mapper.Map<DTO_Havruta.Model.Manager>(dal.ManagerDal.GetByEmail(email));
            return getByEmailBL;

        }
        public bool Delete(DTO_Havruta.Model.Manager  deleteManager)
        {
            return dal.ManagerDal.Delete(mapper.Map<DAL_Havruta.Migrations.Model.Manager>(deleteManager));
        }
        
    }
}
