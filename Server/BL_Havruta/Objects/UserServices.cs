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
        DAL_Havruta.Interface.IDal dal = DAL_Havruta.Objects.DAL.Instance;
        private readonly IMapper mapper;

        public UserServices(IMapper mapper)
        {

            this.mapper = mapper;
        }   
        public int AddNew( User newUser)
        {
            try
            {
                return dal.UserDal.AddNew(mapper.Map<DAL_Havruta.Model.User>(newUser));
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }

        }

        public IEnumerable<User> GetAll()
        {
            try
            {
                IEnumerable<DAL_Havruta.Model.User> users = dal.UserDal.GetAll();

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
           GetByIdUserBL = mapper.Map<DTO_Havruta.Model.User>(dal.UserDal.GetById(id));
           return GetByIdUserBL;    
        }

        public User GetByEmail(string email)
        {
            User GetByEmailUserBL;
            GetByEmailUserBL = mapper.Map<DTO_Havruta.Model.User>(dal.UserDal.GetByEmail(email));
            return GetByEmailUserBL;

        }

        public bool Delete(User deleteUser)
        {
            return dal.UserDal.Delete(mapper.Map<DAL_Havruta.Model.User>(deleteUser));
        }

        public bool IsExist(int id)
        {
            try
            {
                return dal.UserDal.IsUserExsit(id);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public int Login(LoginUser loginUser)
        {
            try
            {
                return dal.UserDal.Login(loginUser.UserName, loginUser.Password);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
