using AutoMapper;
using BL_Havruta.Interface;
using DAL_Havruta.Interfase;
using DTO_Havruta.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL_Havruta.Objects
{
    public class UserServices : IUserServices
    {
        private readonly DAL_Havruta.Interfase.IUserDal dal;
        private readonly IMapper mapper;

        public UserServices(IUserDal dal, IMapper mapper)
        {
            this.dal = dal;
            this.mapper = mapper;
        }   
        public bool AddNew( User newUser)
        {
            return dal.AddNew(mapper.Map<DAL_Havruta.Model.User>(newUser));

        }

        public IEnumerable<User> GetAll()
        {
            try
            {
                IEnumerable<DAL_Havruta.Model.User> users = dal.GetAll();

                MapperConfiguration configuration = new MapperConfiguration(mcfg => mcfg.CreateMap<DTO_Havruta.Model.User, DAL_Havruta.Model.User>()
                .ReverseMap());
                var mapper = configuration.CreateMapper();
                IEnumerable<DTO_Havruta.Model.User> userList = users.Select(x => mapper.Map<DTO_Havruta.Model.User>(x));
                return userList;
            }
            catch (Exception ex) 
            {
                throw new Exception("sory,can`t loat the users" + ex  );
            }
        }

        public User GetById(int id)
        {
           User GetByIdUserBL;
           GetByIdUserBL = mapper.Map<DTO_Havruta.Model.User>(dal.GetById(id));
           return GetByIdUserBL;    
        }

        public User GetByEmail(string email)
        {
            User GetByEmailUserBL;
            GetByEmailUserBL = mapper.Map<DTO_Havruta.Model.User>(dal.GetByEmail(email));
            return GetByEmailUserBL;

        }

        public bool Delete(User deleteUser)
        {
            return dal.Delete(mapper.Map<DAL_Havruta.Model.User>(deleteUser));
        }
    }
}
