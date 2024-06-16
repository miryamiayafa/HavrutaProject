using BL_Havruta.Interface;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HavrutaAPI.Controllers;

    [Route("api/[controller]")]
    [ApiController]
    public class RequestController : ControllerBase
    {
        //private readonly BL_Havruta.Interface.IRequestServices _services ;
    private readonly BL_Havruta.Interface.IBL _services = BL_Havruta.Objects.BL.Instance;
    
    //private readonly BL_Havruta.Interface.IBL _services = BL_Havruta.Objects.BL.Instance;
    public RequestController()
        {
           // _services = services;
        }


        [HttpGet]
        [EnableCors("AllowAllOrigins")]
        public IEnumerable<DTO_Havruta.Model.Request> Get()
        {
            return _services.RequestServices.GetAll();
        }

        [HttpGet("{id}")]
        [EnableCors("AllowAllOrigins")]
        public DTO_Havruta.Model.Request GetRequest(int id)
        {
            return _services.RequestServices.GetById(id);
        }

    [HttpGet("IdAcceptingRequest/{IdAcceptingRequest}")]
    public IEnumerable<DTO_Havruta.Model.Request> GetRequestsForIdAcceptingRequest(int IdAcceptingRequest)
    {
       return _services.RequestServices.GetRequestsForIdAcceptingRequest(IdAcceptingRequest);
    }


    // POST api/<StudyController>
    [HttpPost("AddNewRequest")]
        public void AddNewRequest(DTO_Havruta.Model.Request request)
        {
            _services.RequestServices.AddNew(request);
        }

        [HttpPut("Edit")]
        public void Edit(int id, [FromBody] DTO_Havruta.Model.Request request)
        {
            _services.RequestServices.AddNew(request);
            _services.RequestServices.Delete(request);
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _services.RequestServices.Delete(GetRequest(id));
        }
        [HttpPut("UpdateRequest")]
        public DTO_Havruta.Model.Request UpdateRequest(int id, [FromBody] DTO_Havruta.Model.Request request)
        {
            try
            {

                DTO_Havruta.Model.Request OldRequest = _services.RequestServices.GetById(id);
                if (OldRequest != request)
                {
                    OldRequest = request;
                }
                return OldRequest;
            }
            catch (Exception e)
            {
                throw new Exception();
            }
        }


    }

