using BL_Havruta.Interface;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HavrutaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudyTypeController : ControllerBase
    {
        private readonly BL_Havruta.Interface.IStudyTypeServices _services;
        public StudyTypeController(IStudyTypeServices services)
        {
            _services = services;
        }


        [HttpGet]
        [EnableCors("AllowAllOrigins")]
        public IEnumerable<DTO_Havruta.Model.StudyType> Get()
        {
            return _services.GetAll();
        }

        [HttpGet("{id}")]
        [EnableCors("AllowAllOrigins")]
        public DTO_Havruta.Model.StudyType GetStudyType(int id)
        {
            return _services.GetById(id);
        }
        [HttpGet("byMail/{mail}")]
        [EnableCors("AllowAllOrigins")]

        public void Post(DTO_Havruta.Model.StudyType studyType)
        {
            _services.AddNew(studyType);
        }
        [HttpPut("Edit")]
        public void Edit(int id, [FromBody] DTO_Havruta.Model.StudyType studyType)
        {
            _services.AddNew(studyType);
            _services.Delete(studyType);
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _services.Delete(GetStudyType(id));
        }
        public DTO_Havruta.Model.StudyType UpdateStudyType(int id, [FromBody] DTO_Havruta.Model.StudyType studyType)
        {
            try
            {

                DTO_Havruta.Model.StudyType OldStudyType = _services.GetById(id);
                if (OldStudyType != studyType)
                {
                    OldStudyType = studyType;
                }
                return OldStudyType;
            }
            catch (Exception e)
            {
                throw new Exception()   ;
            }
        }
    }
}
