using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Azure.Core;
using BL_Havruta.Interface;
using DAL_Havruta.Interfase;
using DAL_Havruta.Migrations.Model;
using DTO_Havruta.Model;
using Microsoft.EntityFrameworkCore.Update.Internal;

namespace BL_Havruta.Objects
{
    public class RequestServices : IRequestServices
    {
        DAL_Havruta.Interface.IDal dal = DAL_Havruta.Objects.DAL.Instance;
        private readonly IMapper mapper;

        public RequestServices(IMapper mapper)
        {
            this.mapper = mapper;   
        }

         public bool AddNew(DTO_Havruta.Model.Request request)
        {
            return dal.RequestDal.AddNew(mapper.Map<DAL_Havruta.Migrations.Model.Request>(request));  

        }

        public IEnumerable<DTO_Havruta.Model.Request> GetAll() 
        { 
            try
            {
                IEnumerable<DAL_Havruta.Migrations.Model.Request> requests = dal.RequestDal.GetAll();
                MapperConfiguration configuration = new MapperConfiguration(mcfg => mcfg.CreateMap<DAL_Havruta.Migrations.Model.Request, DTO_Havruta.Model.Request>()
                .ReverseMap());
                var mapper = configuration.CreateMapper();
                IEnumerable<DTO_Havruta.Model.Request> requestsList = requests.Select(x => mapper.Map<DTO_Havruta.Model.Request>(x));
                return requestsList;    
            }
            catch (Exception ex) 
            {
                throw new Exception();
            }
        }

        public DTO_Havruta.Model.Request GetById(int id)
        {
            DTO_Havruta.Model.Request requestByIdBL;
            requestByIdBL = mapper.Map<DTO_Havruta.Model.Request>(dal.RequestDal.GetById(id));
            return requestByIdBL;
        }
        public bool Delete(DTO_Havruta.Model.Request deleteRequest)
        {
            return dal.RequestDal.Delete( mapper.Map<DAL_Havruta.Migrations.Model.Request>(deleteRequest));
        }

        public bool Update(DTO_Havruta.Model.Request updateRequest)
        {
            return dal.RequestDal.Update( mapper.Map<DAL_Havruta.Migrations.Model.Request>(updateRequest));
        }

        public int GetNumberOfRequestForUser(int userId)
        {
            try
            {
               return dal.RequestDal.GetNumberOfRequestForUser( userId );
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message );
                throw ex;
            }
        
        }

        public IEnumerable<DTO_Havruta.Model.Request> GetRequestsForIdAcceptingRequest(int IdAcceptingRequest)
        {
            try
            {
                var requests = dal.RequestDal.RequestsForIdAcceptingRequest(IdAcceptingRequest);
                MapperConfiguration configuration = new MapperConfiguration(mcfg => mcfg.CreateMap<DAL_Havruta.Migrations.Model.Request, DTO_Havruta.Model.Request>()
                .ReverseMap());
                var mapper = configuration.CreateMapper();
                IEnumerable<DTO_Havruta.Model.Request> requestsList = requests.Select(x => mapper.Map<DTO_Havruta.Model.Request>(x));
                return requestsList;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }
    }
}
