using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BL_Havruta.Interface;
using DAL_Havruta.Interfase;
using DTO_Havruta.Model;
using Microsoft.EntityFrameworkCore.Update.Internal;

namespace BL_Havruta.Objects
{
    public class RequestServices : IRequestServices
    {
        private readonly DAL_Havruta.Interfase.IRequestDal dal;
        private readonly IMapper mapper;

        public RequestServices(IMapper mapper, IRequestDal dal )
        {
            this.mapper = mapper;   
            this.dal = dal;
        }

         public bool AddNew(Request request)
        {
            return dal.AddNew(mapper.Map<DAL_Havruta.Model.Request>(request));  

        }

        public IEnumerable<DTO_Havruta.Model.Request> GetAll() 
        { 
            try
            {
                IEnumerable<DAL_Havruta.Model.Request> requests = dal.GetAll();
                MapperConfiguration configuration = new MapperConfiguration(mcfg => mcfg.CreateMap<DAL_Havruta.Model.Request, DTO_Havruta.Model.Request>()
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

        public Request GetById(int id)
        {
            Request requestByIdBL;
            requestByIdBL = mapper.Map<DTO_Havruta.Model.Request>(dal.GetById(id));
            return requestByIdBL;
        }
        public bool Delete(Request deleteRequest)
        {
            return dal.Delete( mapper.Map<DAL_Havruta.Model.Request>(deleteRequest));
        }

        public bool Update(Request updateRequest)
        {
            return dal.Update( mapper.Map<DAL_Havruta.Model.Request>(updateRequest));
        }

    }
}
