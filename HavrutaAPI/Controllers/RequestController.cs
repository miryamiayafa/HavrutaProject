using BL_Havruta.Interface;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HavrutaAPI.Controllers;

    [Route("api/[controller]")]
    [ApiController]
    public class RequestController : ControllerBase
    {
        private readonly BL_Havruta.Interface.IRequestServices _services;
        public RequestController(IRequestServices services)
        {
            _services = services;
        }


        [HttpGet]
        [EnableCors("AllowAllOrigins")]
        public IEnumerable<DTO_Havruta.Model.Request> Get()
        {
            return _services.GetAll();
        }

        [HttpGet("{id}")]
        [EnableCors("AllowAllOrigins")]
        public DTO_Havruta.Model.Request GetRequest(int id)
        {
            return _services.GetById(id);
        }
        [HttpGet("byMail/{mail}")]
        [EnableCors("AllowAllOrigins")]

        public void Post(DTO_Havruta.Model.Request request)
        {
            _services.AddNew(request);
        }
        [HttpPut("Edit")]
        public void Edit(int id, [FromBody] DTO_Havruta.Model.Request request)
        {
            _services.AddNew(request);
            _services.Delete(request);
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _services.Delete(GetRequest(id));
        }
        public DTO_Havruta.Model.Request UpdateRequest(int id, [FromBody] DTO_Havruta.Model.Request request)
        {
            try
            {

                DTO_Havruta.Model.Request OldRequest = _services.GetById(id);
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

