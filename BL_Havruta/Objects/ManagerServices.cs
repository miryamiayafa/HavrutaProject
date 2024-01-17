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
    public class ManagerServices : IManagerServices
    {
        private readonly DAL_Havruta.Interfase.IManagerDal dal;
        private readonly IMapper mapper;

        public ManagerServices(IMapper mapper, IManagerDal managerDal)
        {
            this.mapper = mapper;   
            this.dal = managerDal;
        }
        public bool AddNew(Manager newManager)
        {
            return dal.AddNew(mapper.Map<DAL_Havruta.Model.Manager>(newManager));   
        }
        public IEnumerable<Manager> GetAll() 
        {
            try 
            { 
              IEnumerable<DAL_Havruta.Model.Manager> managers = dal.GetAll();
              MapperConfiguration configuration = new MapperConfiguration(mcfg => mcfg.CreateMap<DAL_Havruta.Model.Manager, DTO_Havruta.Model.Manager>()
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
        public Manager GetById(int id)
        {
            Manager getByIdManagerBL;
            getByIdManagerBL = mapper.Map < DTO_Havruta.Model.Manager > (dal.GetById(id));
            return getByIdManagerBL;

        }
        public Manager GetByEmail(string email)
        {
            Manager getByEmailBL;
            getByEmailBL = mapper.Map<DTO_Havruta.Model.Manager>(dal.GetByEmail(email));
            return getByEmailBL;

        }
        public bool Delete(Manager  deleteManager)
        {
            return dal.Delete(mapper.Map<DAL_Havruta.Model.Manager>(deleteManager));
        }
        
    }
}
