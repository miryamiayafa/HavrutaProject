using BL_Havruta.Interface;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HavrutaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubjectController : ControllerBase
    {
        private readonly BL_Havruta.Interface.ISubjectServices _services;
        public SubjectController(ISubjectServices services)
        {
            _services = services;
        }


        [HttpGet]
        [EnableCors("AllowAllOrigins")]
        public IEnumerable<DTO_Havruta.Model.Subject> Get()
        {
            return _services.GetAll();
        }

        [HttpGet("{id}")]
        [EnableCors("AllowAllOrigins")]
        public DTO_Havruta.Model.Subject GetSubject(int id)
        {
            return _services.GetById(id);
        }
        [HttpGet("byMail/{mail}")]
        [EnableCors("AllowAllOrigins")]

        public void Post(DTO_Havruta.Model.Subject subject)
        {
            _services.AddNew(subject);
        }
        [HttpPut("Edit")]
        public void Edit(int id, [FromBody] DTO_Havruta.Model.Subject subject)
        {
            _services.AddNew(subject);
            _services.Delete(subject);
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _services.Delete(GetSubject(id));
        }
        public DTO_Havruta.Model.Subject UpdateStudyTime(int id, [FromBody] DTO_Havruta.Model.Subject subject)
        {
            try
            {

                DTO_Havruta.Model.Subject OldSubject = _services.GetById(id);
                if (OldSubject != subject)
                {
                    OldSubject = subject;
                }
                return OldSubject;
            }
            catch (Exception e)
            {
                throw new Exception();
            }
        }


    }
}
